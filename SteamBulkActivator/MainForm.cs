using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Steam4NET;

namespace SteamBulkActivator
{
    public partial class MainForm : Form
    {
        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int _eM_SETCUEBANNER = 0x1501;

        private int _user, _pipe;
        private int _registerDelay;
        private bool _waitingForActivationResp = false;
        private bool _txtKeysCleared = false;

        private ISteam006 _steam006;
        private IClientUser _clientUser;
        private IClientEngine _clientEngine;
        private IClientBilling _clientBilling;
        private ISteamClient012 _steamClient012;

        private ResultForm _result;
        private List<string> _cdKeyList;
        private BackgroundWorker _callbackBwg;
        private BackgroundWorker _purchaseBwg;

        private Color _buttonBackgroundNormal = Color.FromArgb(36, 41, 45);
        private Color _buttonBackgroundHover = Color.FromArgb(15, 174, 220);

        private BrowserForm _browserForm;

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

        private void tmr_Update_Tick(object sender, EventArgs e)
        {
            tmr_Update.Stop();

            var uc = new UpdateCheck();
            var data = uc.GetVersionData(Const.UPDATE_URL);

            if (data != null && data.UpdateAvailable)
            {
                var diagRes = MessageBox.Show($"Release notes:\n----------------\n{data.Info}\n\nWould you like to check it out?",
                    "Update available", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (diagRes == DialogResult.Yes)
                {
                    Process.Start(Const.RELEASE_URL);
                }
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            if (connectToSteam())
            {
                while (!_clientUser.BLoggedOn())
                {
                    var diagRes = MessageBox.Show("Not logged on Steam.", "Steam Bulk Activator", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                    if (diagRes == DialogResult.Cancel)
                    {
                        Environment.Exit(1);
                    }
                    else
                    {
                        if (!connectToSteam())
                        {
                            MessageBox.Show("Unable to connect to Steam.", "Fatal error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Environment.Exit(1);
                        }
                    }
                }

                panelMain.Visible = true;
                panelLoading.Visible = false;

                _cdKeyList = new List<string>();
                ActiveControl = lbl_KeyCount;
                txtKeys.Text = $"Enter your keys here\n\n{Utils.GetRandomCDKey()}\n{Utils.GetRandomCDKey()}\n{Utils.GetRandomCDKey()}\n{Utils.GetRandomCDKey()}";

                _callbackBwg = new BackgroundWorker() { WorkerSupportsCancellation = true };
                _callbackBwg.DoWork += _callbacks_DoWork;
                _callbackBwg.RunWorkerCompleted += _callbacks_RunWorkerCompleted;

                _purchaseBwg = new BackgroundWorker() { WorkerSupportsCancellation = true };
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

        private void topSpacer_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void pic_MoveForm_MouseDown(object sender, MouseEventArgs e)
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

        private void btn_Github_Click(object sender, EventArgs e)
        {
            Process.Start("https://github.com/Ezzpify");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Scrape_Click(object sender, EventArgs e)
        {
            if (_browserForm == null)
                _browserForm = new BrowserForm();

            _browserForm.ShowDialog();
        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if (!_txtKeysCleared || string.IsNullOrWhiteSpace(txtKeys.Text))
            {
                MessageBox.Show("No keys have been entered.", "No keys", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (_cdKeyList.Count == 0)
            {
                string msg = "No valid keys were detected. Do you wish to attempt to register them anyways?";
                var diagRes = MessageBox.Show(msg, "Information", MessageBoxButtons.YesNo);
                if (diagRes == DialogResult.Yes)
                {
                    addKeysToList(false);
                    registerKeys();
                }
            }
            else
            {
                registerKeys();
            }
        }

        private void txtKeys_Enter(object sender, EventArgs e)
        {
            if (!_txtKeysCleared)
            {
                _txtKeysCleared = true;
                txtKeys.Text = string.Empty;
                txtKeys.ForeColor = Color.FromArgb(223, 233, 233);
            }
        }

        private void txtKeys_TextChanged(object sender, EventArgs e)
        {
            addKeysToList();
        }

        private void MainForm_Deactivate(object sender, EventArgs e)
        {
            txtKeys.Text = txtKeys.Text.Trim();
            txtKeys.Text += "\n";
            txtKeys.DeselectAll();
            txtKeys.SelectionStart = txtKeys.Text.Length;

            ActiveControl = panelHeader;
        }

        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (_txtKeysCleared)
            {
                ActiveControl = txtKeys;
            }
        }

        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.close_bg_hover;
        }

        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.close_bg;
        }

        private void btn_Min_MouseEnter(object sender, EventArgs e)
        {
            btn_Min.Image = Properties.Resources.min_bg_hover;
        }

        private void btn_Min_MouseLeave(object sender, EventArgs e)
        {
            btn_Min.Image = Properties.Resources.min_bg;
        }

        private void btn_Github_MouseEnter(object sender, EventArgs e)
        {
            btn_Github.BackColor = _buttonBackgroundHover;
        }

        private void btn_Github_MouseLeave(object sender, EventArgs e)
        {
            btn_Github.BackColor = _buttonBackgroundNormal;
        }

        private void btn_Donate_MouseEnter(object sender, EventArgs e)
        {
            btn_Donate.BackColor = _buttonBackgroundHover;
            panelDonate.Visible = true;
        }

        private void btn_Donate_MouseLeave(object sender, EventArgs e)
        {
            btn_Donate.BackColor = _buttonBackgroundNormal;

            if (!panelContainsMouse(panelDonate))
                panelDonate.Visible = false;
        }

        private void panelDonate_MouseLeave(object sender, EventArgs e)
        {
            panelDonate.Visible = false;
        }

        private void btn_Paypal_MouseEnter(object sender, EventArgs e)
        {
            btn_Paypal.BackColor = _buttonBackgroundHover;
        }

        private void btn_Paypal_MouseLeave(object sender, EventArgs e)
        {
            btn_Paypal.BackColor = _buttonBackgroundNormal;

            if (!panelContainsMouse(panelDonate))
                panelDonate.Visible = false;
        }

        private void btn_Bitcoin_MouseEnter(object sender, EventArgs e)
        {
            btn_Bitcoin.BackColor = _buttonBackgroundHover;
        }

        private void btn_Bitcoin_MouseLeave(object sender, EventArgs e)
        {
            btn_Bitcoin.BackColor = _buttonBackgroundNormal;

            if (!panelContainsMouse(panelDonate))
                panelDonate.Visible = false;
        }

        private void panelDonateBottomSpacer_MouseLeave(object sender, EventArgs e)
        {
            if (!panelContainsMouse(panelDonate))
                panelDonate.Visible = false;
        }

        private void panelDonateTopSpacer_MouseLeave(object sender, EventArgs e)
        {
            if (!panelContainsMouse(panelDonate))
                panelDonate.Visible = false;
        }

        private void _purchaseBwg_DoWork(object sender, DoWorkEventArgs e)
        {
            while (_result != null && !_result.Visible)
                Thread.Sleep(100);

            var cdkeys = (List<string>)e.Argument;
            for (int i = 0; i < cdkeys.Count; i++)
            {
                if (_purchaseBwg.CancellationPending)
                    break;

                _waitingForActivationResp = true;
                string pchActivationCode = cdkeys[i];
                _clientBilling.PurchaseWithActivationCode(pchActivationCode);

                if (i + 1 < cdkeys.Count)
                {
                    if (_registerDelay != 0)
                        Thread.Sleep(_registerDelay);
                }

                while (_waitingForActivationResp)
                    Thread.Sleep(50);
            }

            completedRegistration();
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
            EPurchaseResultDetail result = (EPurchaseResultDetail)callback.m_EPurchaseResultDetail;
            switch (result)
            {
                case EPurchaseResultDetail.k_EPurchaseResultTooManyActivationAttempts:
                    _purchaseBwg.CancelAsync();
                    completedRegistration();
                    break;
            }

            _result.AddResult(Utils.GetFriendlyEPurchaseResultDetailMsg(result));
            _waitingForActivationResp = false;
        }

        private void registerKeys()
        {
            _registerDelay = (int)num_RegDelay.Value;

            _purchaseBwg.RunWorkerAsync(_cdKeyList);
            _callbackBwg.RunWorkerAsync();

            _result = new ResultForm(_cdKeyList, _registerDelay);
            _result.ShowDialog();
            txtKeys.Text = string.Empty;
        }

        private void completedRegistration()
        {
            _callbackBwg.CancelAsync();
            _result.Completed = true;
        }

        private void addKeysToList(bool regexCheck = true)
        {
            if (!_txtKeysCleared)
                return;

            var tempList = new List<string>();
            string cdKeyPattern = @"([A-Za-z0-9]+)(-([A-Za-z0-9]+)){2,}";
            foreach (Match m in Regex.Matches(txtKeys.Text, cdKeyPattern))
            {
                if (tempList.Contains(m.Value))
                    continue;

                tempList.Add(m.Value);
            }
            _cdKeyList = tempList;
            lbl_KeyCount.Text = $"Valid keys: {_cdKeyList.Count}";
        }

        private bool panelContainsMouse(Panel panel)
        {
            return panelDonate.ClientRectangle.Contains(panelDonate.PointToClient(Cursor.Position));
        }

        private void btn_Paypal_Click(object sender, EventArgs e)
        {
            Process.Start("http://www.paypal.me/ezzpify");
            panelDonate.Visible = false;
            ShowLoveGif();
        }

        private void ShowLoveGif()
        {
            pic_MoveForm.Image = Properties.Resources.heart_animation_ps;
            tmr_LoveAnimation.Stop();
            tmr_LoveAnimation.Start();
        }

        private void tmr_LoveAnimation_Tick(object sender, EventArgs e)
        {
            tmr_LoveAnimation.Stop();
            pic_MoveForm.Image = null;
        }

        private void btn_Bitcoin_Click(object sender, EventArgs e)
        {
            panelBitcoin.Visible = true;
            panelDonate.Visible = false;

            txt_BitcoinAddress.SelectAll();
            txt_BitcoinAddress.Focus();
            ShowLoveGif();
        }

        private void panelBitcoin_MouseLeave(object sender, EventArgs e)
        {
            if (!panelBitcoin.ClientRectangle.Contains(panelBitcoin.PointToClient(Cursor.Position)))
                panelBitcoin.Visible = false;
        }

        private void panelBitcoinBottomSpacer_MouseLeave(object sender, EventArgs e)
        {
            panelBitcoin.Visible = false;
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
                lblError.Text = "Steam startup failed. Is Steam running?";
                return false;
            }

            _steamClient012 = Steamworks.CreateInterface<ISteamClient012>();
            _clientEngine = Steamworks.CreateInterface<IClientEngine>();

            _pipe = _steamClient012.CreateSteamPipe();
            if (_pipe == 0)
            {
                lblError.Text = "Failed to create user pipe.";
                return false;
            }

            _user = _steamClient012.ConnectToGlobalUser(_pipe);
            if (_user == 0 || _user == -1)
            {
                lblError.Text = "Failed to connect to global user.";
                return false;
            }
            
            _clientBilling = _clientEngine.GetIClientBilling<IClientBilling>(_user, _pipe);
            _clientUser = _clientEngine.GetIClientUser<IClientUser>(_user, _pipe);
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
