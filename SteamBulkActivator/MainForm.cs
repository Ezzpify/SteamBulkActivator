using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using Steam4NET;

namespace SteamBulkActivator
{
    public partial class MainForm : Form
    {
        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int _eM_SETCUEBANNER = 0x1501;

        private int _user, _pipe;
        private bool _enableRegexChecking = true;
        private bool _waitingForActivationResp = false;

        private ISteam006 _steam006;
        private IClientEngine _clientEngine;
        private IClientBilling _clientBilling;
        private ISteamClient012 _steamClient012;

        private Result _result;
        private List<string> _cdKeyList;
        private BackgroundWorker _callbackBwg;
        private BackgroundWorker _purchaseBwg;

        protected override CreateParams CreateParams
        {
            get
            {
                const int CS_DROPSHADOW = 0x20000;
                CreateParams cp = base.CreateParams;
                cp.ClassStyle |= CS_DROPSHADOW;
                return cp;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (connectToSteam())
            {
                panelMain.Visible = true;
                panelLoading.Visible = false;
                _cdKeyList = new List<string>();
                this.ActiveControl = lblKeyCount;
                NativeMethods.SendMessage(txtKeys.Handle, _eM_SETCUEBANNER, IntPtr.Zero, "6EZ77-35QQY-9BTT8");

                _callbackBwg = new BackgroundWorker() { WorkerSupportsCancellation = true };
                _callbackBwg.DoWork += _callbacks_DoWork;
                _callbackBwg.RunWorkerCompleted += _callbacks_RunWorkerCompleted;
                _callbackBwg.RunWorkerAsync();

                _purchaseBwg = new BackgroundWorker();
                _purchaseBwg.DoWork += _purchaseBwg_DoWork;
            }
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void linkGithub_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ezzpify");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (_callbackBwg.IsBusy)
                _callbackBwg.CancelAsync();

            Environment.Exit(1);
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (_cdKeyList.Count == 0)
            {
                if (_enableRegexChecking && !string.IsNullOrWhiteSpace(txtKeys.Text))
                {
                    string chk = "No keys passed the validity check. If you are certain that the keys you have inputted"
                        + " are valid, then you can disable the validity check for cd-keys by pressing Yes.";

                    var diagRes = MessageBox.Show(chk, "No valid keys", MessageBoxButtons.YesNo);
                    if (diagRes == DialogResult.Yes)
                    {
                        _enableRegexChecking = false;
                        addKeysToList();
                    }
                }
                else
                {
                    MessageBox.Show("No keys added.", "Error");
                }
            }
            else
            {
                _result = new Result(_cdKeyList);
                _result.Show();

                _purchaseBwg.RunWorkerAsync(_cdKeyList);
            }
        }

        private void txtKeys_Enter(object sender, EventArgs e)
        {
            txtKeys.Multiline = true;
        }

        private void btnClose_MouseEnter(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void btnMinimize_MouseEnter(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.ForeColor = Color.FromArgb(224, 224, 224);
        }

        private void _purchaseBwg_DoWork(object sender, DoWorkEventArgs e)
        {
            var cdkeys = (List<string>)e.Argument;
            foreach (var pchActivationCode in cdkeys)
            {
                _clientBilling.PurchaseWithActivationCode(pchActivationCode);
                Thread.Sleep(2000);

                while (_waitingForActivationResp)
                    Thread.Sleep(100);
            }
        }

        private void _callbacks_DoWork(object sender, DoWorkEventArgs e)
        {
            CallbackMsg_t callbackMsg = new CallbackMsg_t();
            while (!_callbackBwg.CancellationPending)
            {
                while (Steamworks.GetCallback(_pipe, ref callbackMsg) && !_callbackBwg.CancellationPending)
                {
                    switch (callbackMsg.m_iCallback)
                    {
                        case PurchaseResponse_t.k_iCallback:
                            onPurchaseResponse((PurchaseResponse_t)Marshal.PtrToStructure(callbackMsg.m_pubParam, typeof(PurchaseResponse_t)));
                            break;
                    }

                    Steamworks.FreeLastCallback(_pipe);
                }

                Thread.Sleep(100);
            }
        }

        private void _callbacks_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
                MessageBox.Show($"Uhhh...\n\n{e.Error}", "Callback error");
        }

        private void onPurchaseResponse(PurchaseResponse_t callback)
        {
            if (callback.m_EResult == EResult.k_EResultOK)
            {
                _result.AddResult(Utils.GetFriendlyEPurchaseResultDetailMsg(callback.m_EPurchaseResultDetail));
            }
            else
            {
                _result.AddResult(callback.m_EResult.ToString());
            }

            _waitingForActivationResp = false;
        }

        private void txtKeys_TextChanged(object sender, EventArgs e)
        {
            addKeysToList();
        }

        private void addKeysToList()
        {
            var tempList = new List<string>();
            string[] lines = txtKeys.Text.Split('\n');
            foreach (var line in lines)
            {
                string key = line.Replace("\r", "");

                if (string.IsNullOrWhiteSpace(key))
                    continue;

                if (_enableRegexChecking && !Utils.ValidateCDKey(key))
                    continue;

                if (tempList.Contains(key))
                    continue;

                tempList.Add(key.Trim());
            }

            _cdKeyList = tempList;
            lblKeyCount.Text = $"Valid keys: {_cdKeyList.Count}";
        }

        private bool connectToSteam()
        {
            var steamError = new TSteamError();

            if (!Steamworks.Load(true))
            {
                lblError.Text = "Steamworks failed to load.";
                return false;
            }

            _steam006 = Steamworks.CreateSteamInterface<ISteam006>();
            if (_steam006.Startup(0, ref steamError) == 0)
            {
                lblError.Text = "Steam startup failed.";
                return false;
            }

            _steamClient012 = Steamworks.CreateInterface<ISteamClient012>();
            _clientEngine = Steamworks.CreateInterface<IClientEngine>();

            _pipe = _steamClient012.CreateSteamPipe();
            if (_pipe == 0)
            {
                lblError.Text = "Failed to create a pipe.";
                return false;
            }

            _user = _steamClient012.ConnectToGlobalUser(_pipe);
            if (_user == 0 || _user == -1)
            {
                lblError.Text = "Failed to connect to global user.";
                return false;
            }
            
            _clientBilling = _clientEngine.GetIClientBilling<IClientBilling>(_user, _pipe);
            return true;
        }
    }

    public static class NativeMethods
    {
        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, [MarshalAs(UnmanagedType.LPWStr)]string lParam);


        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);


        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
    }
}
