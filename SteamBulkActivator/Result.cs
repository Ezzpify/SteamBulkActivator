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
            public string Key { get; set; }

            public string Response { get; set; }

            public bool Added { get; set; }
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

        private void btnSaveResults_Click(object sender, EventArgs e)
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
                panelBtnRegisterWrapper.Visible = true;
                responseTimer.Stop();
            }
        }
    }
}
