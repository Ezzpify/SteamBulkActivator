using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SteamBulkActivator
{
    public partial class ResultForm : Form
    {
        class KeyResponse
        {
            public string Key { get; set; }

            public string Response { get; set; }

            public bool Added { get; set; }
        }

        public bool Completed;

        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;

        private List<string> _cdKeyList;
        private List<KeyResponse> _cdKeyResponses = new List<KeyResponse>();

        private int _registerDelay;
        private int _registerDelayFull;

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

        public ResultForm(List<string> keys, int registerDelay)
        {
            InitializeComponent();

            _registerDelayFull = registerDelay;
            _registerDelay = registerDelay;
            _cdKeyList = keys;

            tmr_NextResult.Start();
        }

        public void AddResult(string result)
        {
            _registerDelay = _registerDelayFull;

            if (_cdKeyList.Count() < _cdKeyResponses.Count() + 1)
                return;

            _cdKeyResponses.Add(new KeyResponse()
            {
                Response = result,
                Added = false
            });
        }

        private void Result_Load(object sender, EventArgs e)
        {
            _cdKeyList.ForEach(o => keyListView.Items.Add(o));
            keyListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            keyListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            /*If we reached too many activation attempts then it will stop
             trying to register keys. We'll find those keys without a response
             in the original cdKeyList and add them to the save list with a custom
             message to make it easier for users to see which keys did not get activated.*/
            foreach (var key in _cdKeyList)
            {
                if (_cdKeyResponses.Any(o => o.Key == key))
                    continue;

                _cdKeyResponses.Add(new KeyResponse()
                {
                    Key = key,
                    Response = "Not attempted"
                });
            }

            /*We'll add all keys to a dictionary for easier formatting
             We start with the responses as keys, and keys as the value list*/
            var keyDic = new Dictionary<string, List<string>>();
            foreach (var response in _cdKeyResponses.GroupBy(o => o.Response).Select(o => o.First()))
                keyDic.Add(response.Response, new List<string>());

            /*Add all the keys to the right reponse type*/
            foreach (var key in _cdKeyResponses)
                keyDic[key.Response].Add(key.Key);

            /*Format the final string to write to file*/
            string finalStr = string.Empty;
            foreach (var resp in keyDic)
            {
                finalStr += resp.Key;
                foreach (var key in resp.Value)
                    finalStr += $"\n{key}";

                finalStr += "\n\n";
            }

            string location = Path.Combine(Application.StartupPath, $"Results {Utils.GetTimestamp()}.txt");
            File.WriteAllText(location, finalStr.Trim());

            Process.Start(location);
            Close();
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panelControlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void responseTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < _cdKeyResponses.Count; i++)
            {
                string resp = _cdKeyResponses[i].Response;
                if (!string.IsNullOrWhiteSpace(resp) && !_cdKeyResponses[i].Added)
                {
                    if (keyListView.Items.Count < i)
                        continue;

                    _cdKeyResponses[i].Key = keyListView.Items[i].Text;
                    _cdKeyResponses[i].Added = true;

                    keyListView.Items[i].SubItems.Add(resp);
                    keyListView.EnsureVisible(i);
                }
            }

            if (Completed)
            {
                btn_Save.Visible = true;
                lbl_NextResult.Visible = false;
                tmr_NextResult.Stop();
                responseTimer.Stop();
            }
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Min_MouseEnter(object sender, EventArgs e)
        {
            btn_Min.Image = Properties.Resources.min_bg_hover;
        }

        private void btn_Min_MouseLeave(object sender, EventArgs e)
        {
            btn_Min.Image = Properties.Resources.min_bg;
        }

        private void tmr_NextResult_Tick(object sender, EventArgs e)
        {
            _registerDelay = _registerDelay - tmr_NextResult.Interval;
            if (_registerDelay > 0)
            {
                var ts = TimeSpan.FromMilliseconds(_registerDelay);
                lbl_NextResult.Text = $"Next result in {new DateTime(ts.Ticks).ToString("HH:mm:ss.f")}";
            }
        }
    }
}
