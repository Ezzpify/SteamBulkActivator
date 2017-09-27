using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using Microsoft.Win32;

namespace SteamBulkActivator
{
    public partial class BrowserForm : Form
    {
        private const int HT_CAPTION = 0x2;
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int cGrip = 16;
        private const int cCaption = 32;

        private Color _buttonBackgroundNormal = Color.FromArgb(36, 41, 45);
        private Color _buttonBackgroundHover = Color.FromArgb(15, 174, 220);

        public BrowserForm()
        {
            InitializeComponent();
        }

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
        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - cGrip, ClientSize.Height - cGrip, cGrip, cGrip);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
            rc = new Rectangle(0, 0, ClientSize.Width, cCaption);
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = PointToClient(pos);

                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }
                if (pos.X >= ClientSize.Width - cGrip && pos.Y >= ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }

        private void BrowserForm_Load(object sender, EventArgs e)
        {
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private void panelHeader_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

            if (e.Clicks > 1)
            {
                ChangeWindowState();
            }
        }

        private void pic_MoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                NativeMethods.ReleaseCapture();
                NativeMethods.SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }

            if (e.Clicks > 1)
            {
                ChangeWindowState();
            }
        }

        private void web_Browser_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txt_Url.Text = web_Browser.Url.AbsoluteUri;
        }

        private void btn_Humblebundle_Click(object sender, EventArgs e)
        {
            web_Browser.Navigate("https://www.humblebundle.com");
        }

        private void btn_Bundlestars_Click(object sender, EventArgs e)
        {
            web_Browser.Navigate("https://www.bundlestars.com");
        }

        private void btn_Close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void btn_Max_Click(object sender, EventArgs e)
        {
            ChangeWindowState();
        }

        private void btn_Close_MouseEnter(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.close_bg_hover;
        }

        private void btn_Close_MouseLeave(object sender, EventArgs e)
        {
            btn_Close.Image = Properties.Resources.close_bg;
        }

        private void btn_Max_MouseEnter(object sender, EventArgs e)
        {
            btn_Max.Image = Properties.Resources.max_bg_hover;
        }

        private void btn_Max_MouseLeave(object sender, EventArgs e)
        {
            btn_Max.Image = Properties.Resources.max_bg;
        }

        private void btn_Min_MouseEnter(object sender, EventArgs e)
        {
            btn_Min.Image = Properties.Resources.min_bg_hover;
        }

        private void btn_Min_MouseLeave(object sender, EventArgs e)
        {
            btn_Min.Image = Properties.Resources.min_bg;
        }

        private void ChangeWindowState()
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void txt_Url_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                Uri uriResult;
                string input = txt_Url.Text.Trim();
                if (Uri.TryCreate(input, UriKind.Absolute, out uriResult) && (uriResult.Scheme == Uri.UriSchemeHttp || uriResult.Scheme == Uri.UriSchemeHttps))
                {
                    web_Browser.Navigate(uriResult);
                }
                else
                {
                    web_Browser.Navigate($"https://www.google.rs/search?q={input}");
                }
            }
        }

        private void btn_Humblebundle_MouseEnter(object sender, EventArgs e)
        {
            btn_Humblebundle.BackColor = _buttonBackgroundHover;
        }

        private void btn_Humblebundle_MouseLeave(object sender, EventArgs e)
        {
            btn_Humblebundle.BackColor = _buttonBackgroundNormal;
        }

        private void btn_Bundlestars_MouseEnter(object sender, EventArgs e)
        {
            btn_Bundlestars.BackColor = _buttonBackgroundHover;
        }

        private void btn_Bundlestars_MouseLeave(object sender, EventArgs e)
        {
            btn_Bundlestars.BackColor = _buttonBackgroundNormal;
        }
    }
}
