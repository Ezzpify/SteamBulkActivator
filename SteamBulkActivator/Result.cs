using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.IO;
using System.Diagnostics;
using System.Windows.Forms;

namespace SteamBulkActivator
{
    public partial class Result : Form
    {
        class KeyResponse
        {
            public string key { get; set; }

            public string response { get; set; }

            public bool added { get; set; }
        }

        public bool Completed;

        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;

        private List<string> _cdKeyList;
        private List<KeyResponse> _cdKeyResponses = new List<KeyResponse>();

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

        public Result(List<string> keys)
        {
            InitializeComponent();
            _cdKeyList = keys;
        }

        public void AddResult(string result)
        {
            if (_cdKeyList.Count() < _cdKeyResponses.Count() + 1)
                return;

            _cdKeyResponses.Add(new KeyResponse()
            {
                response = result,
                added = false
            });
        }

        private void Result_Load(object sender, EventArgs e)
        {
            _cdKeyList.ForEach(o => keyListView.Items.Add(o));
            keyListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            keyListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            /*If we reached too many activation attempts then it will stop
             trying to register keys. We'll find those keys without a response
             in the original cdKeyList and add them to the save list with a custom
             message to make it easier for users to see which keys did not get activated.*/
            foreach (var key in _cdKeyList)
            {
                if (_cdKeyResponses.Any(o => o.key == key))
                    continue;

                _cdKeyResponses.Add(new KeyResponse()
                {
                    key = key,
                    response = "Not attempted"
                });
            }
            
            string formattedStr = string.Empty;
            foreach (var item in _cdKeyResponses.OrderBy(o => o.response))
                formattedStr += $"{item.key} - {item.response}\n";

            string location = Path.Combine(Application.StartupPath, $"Results {Utils.GetTimestamp()}.txt");
            File.WriteAllText(location, formattedStr.Trim());

            /*This will open the saved text file with the default text editor.*/
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

        private void topSpacer_MouseDown(object sender, MouseEventArgs e)
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
                string resp = _cdKeyResponses[i].response;
                if (!string.IsNullOrWhiteSpace(resp) && !_cdKeyResponses[i].added)
                {
                    _cdKeyResponses[i].key = keyListView.Items[i].Text;
                    _cdKeyResponses[i].added = true;

                    keyListView.Items[i].SubItems.Add(resp);
                    keyListView.EnsureVisible(i);
                }
            }

            if (Completed)
            {
                panelBtnRegisterWrapper.Visible = true;
                responseTimer.Stop();
            }
        }
    }
}
