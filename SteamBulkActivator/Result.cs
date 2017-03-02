using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SteamBulkActivator
{
    public partial class Result : Form
    {
        class KeyResponse
        {
            public string response { get; set; }

            public bool added { get; set; }
        }

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
            _cdKeyResponses.Add(new KeyResponse()
            {
                response = result,
                added = false
            });
        }

        private void Result_Load(object sender, EventArgs e)
        {
            foreach (var key in _cdKeyList)
            {
                keyListView.Items.Add(key);
                autoResizeView();
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
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
            var tmpList = _cdKeyResponses.ToList();
            for (int i = 0; i < tmpList.Count; i++)
            {
                string resp = tmpList[i].response;

                if (!string.IsNullOrWhiteSpace(resp) && !tmpList[i].added)
                {
                    keyListView.Items[i].SubItems.Add(resp);
                    tmpList[i].added = true;
                    autoResizeView();
                }
            }
        }

        private void autoResizeView()
        {
            keyListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            keyListView.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }
    }
}
