namespace SteamBulkActivator
{
    partial class BrowserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BrowserForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_Max = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.web_Browser = new System.Windows.Forms.WebBrowser();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txt_Url = new System.Windows.Forms.TextBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.btn_Bundlestars = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.btn_Humblebundle = new System.Windows.Forms.PictureBox();
            this.pic_MoveForm = new System.Windows.Forms.PictureBox();
            this.topSpacer = new System.Windows.Forms.PictureBox();
            this.panelHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Max)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Bundlestars)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Humblebundle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MoveForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.panel1);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(1000, 20);
            this.panelHeader.TabIndex = 12;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.btn_Min);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.btn_Max);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.btn_Close);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(917, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 20);
            this.panel1.TabIndex = 0;
            // 
            // btn_Min
            // 
            this.btn_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Min.Image = global::SteamBulkActivator.Properties.Resources.min_bg;
            this.btn_Min.Location = new System.Drawing.Point(14, 0);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(20, 20);
            this.btn_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Min.TabIndex = 1;
            this.btn_Min.TabStop = false;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            this.btn_Min.MouseEnter += new System.EventHandler(this.btn_Min_MouseEnter);
            this.btn_Min.MouseLeave += new System.EventHandler(this.btn_Min_MouseLeave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Location = new System.Drawing.Point(34, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(2, 20);
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            // 
            // btn_Max
            // 
            this.btn_Max.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Max.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Max.Image = ((System.Drawing.Image)(resources.GetObject("btn_Max.Image")));
            this.btn_Max.Location = new System.Drawing.Point(36, 0);
            this.btn_Max.Name = "btn_Max";
            this.btn_Max.Size = new System.Drawing.Size(20, 20);
            this.btn_Max.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Max.TabIndex = 4;
            this.btn_Max.TabStop = false;
            this.btn_Max.Click += new System.EventHandler(this.btn_Max_Click);
            this.btn_Max.MouseEnter += new System.EventHandler(this.btn_Max_MouseEnter);
            this.btn_Max.MouseLeave += new System.EventHandler(this.btn_Max_MouseLeave);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox4.Location = new System.Drawing.Point(56, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(2, 20);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.Image = global::SteamBulkActivator.Properties.Resources.close_bg;
            this.btn_Close.Location = new System.Drawing.Point(58, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Close_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(78, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(5, 20);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.web_Browser);
            this.panel2.Location = new System.Drawing.Point(12, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(976, 512);
            this.panel2.TabIndex = 13;
            // 
            // web_Browser
            // 
            this.web_Browser.AllowWebBrowserDrop = false;
            this.web_Browser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web_Browser.Location = new System.Drawing.Point(0, 0);
            this.web_Browser.MinimumSize = new System.Drawing.Size(20, 20);
            this.web_Browser.Name = "web_Browser";
            this.web_Browser.ScriptErrorsSuppressed = true;
            this.web_Browser.Size = new System.Drawing.Size(976, 512);
            this.web_Browser.TabIndex = 0;
            this.web_Browser.Url = new System.Uri("https://www.humblebundle.com", System.UriKind.Absolute);
            this.web_Browser.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_Browser_DocumentCompleted);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pictureBox8);
            this.panel3.Controls.Add(this.btn_Bundlestars);
            this.panel3.Controls.Add(this.pictureBox6);
            this.panel3.Controls.Add(this.btn_Humblebundle);
            this.panel3.Location = new System.Drawing.Point(12, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(976, 31);
            this.panel3.TabIndex = 26;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(204, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(772, 31);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel5.Controls.Add(this.pictureBox1);
            this.panel5.Controls.Add(this.txt_Url);
            this.panel5.Location = new System.Drawing.Point(21, 7);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(730, 18);
            this.panel5.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox1.Location = new System.Drawing.Point(0, 17);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(730, 1);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txt_Url
            // 
            this.txt_Url.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.txt_Url.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_Url.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_Url.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Url.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txt_Url.Location = new System.Drawing.Point(0, 0);
            this.txt_Url.Name = "txt_Url";
            this.txt_Url.Size = new System.Drawing.Size(730, 15);
            this.txt_Url.TabIndex = 4;
            this.txt_Url.Text = "Loading ...";
            this.txt_Url.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Url.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_Url_KeyUp);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox8.Location = new System.Drawing.Point(202, 0);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(2, 31);
            this.pictureBox8.TabIndex = 6;
            this.pictureBox8.TabStop = false;
            // 
            // btn_Bundlestars
            // 
            this.btn_Bundlestars.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Bundlestars.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bundlestars.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Bundlestars.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bundlestars.Image")));
            this.btn_Bundlestars.Location = new System.Drawing.Point(102, 0);
            this.btn_Bundlestars.Name = "btn_Bundlestars";
            this.btn_Bundlestars.Size = new System.Drawing.Size(100, 31);
            this.btn_Bundlestars.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Bundlestars.TabIndex = 5;
            this.btn_Bundlestars.TabStop = false;
            this.btn_Bundlestars.Click += new System.EventHandler(this.btn_Bundlestars_Click);
            this.btn_Bundlestars.MouseEnter += new System.EventHandler(this.btn_Bundlestars_MouseEnter);
            this.btn_Bundlestars.MouseLeave += new System.EventHandler(this.btn_Bundlestars_MouseLeave);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox6.Location = new System.Drawing.Point(100, 0);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(2, 31);
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // btn_Humblebundle
            // 
            this.btn_Humblebundle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Humblebundle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Humblebundle.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Humblebundle.Image = ((System.Drawing.Image)(resources.GetObject("btn_Humblebundle.Image")));
            this.btn_Humblebundle.Location = new System.Drawing.Point(0, 0);
            this.btn_Humblebundle.Name = "btn_Humblebundle";
            this.btn_Humblebundle.Size = new System.Drawing.Size(100, 31);
            this.btn_Humblebundle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Humblebundle.TabIndex = 0;
            this.btn_Humblebundle.TabStop = false;
            this.btn_Humblebundle.Click += new System.EventHandler(this.btn_Humblebundle_Click);
            this.btn_Humblebundle.MouseEnter += new System.EventHandler(this.btn_Humblebundle_MouseEnter);
            this.btn_Humblebundle.MouseLeave += new System.EventHandler(this.btn_Humblebundle_MouseLeave);
            // 
            // pic_MoveForm
            // 
            this.pic_MoveForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_MoveForm.Location = new System.Drawing.Point(0, 25);
            this.pic_MoveForm.Name = "pic_MoveForm";
            this.pic_MoveForm.Size = new System.Drawing.Size(1000, 21);
            this.pic_MoveForm.TabIndex = 25;
            this.pic_MoveForm.TabStop = false;
            this.pic_MoveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MoveForm_MouseDown);
            // 
            // topSpacer
            // 
            this.topSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.topSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSpacer.Location = new System.Drawing.Point(0, 0);
            this.topSpacer.Name = "topSpacer";
            this.topSpacer.Size = new System.Drawing.Size(1000, 5);
            this.topSpacer.TabIndex = 11;
            this.topSpacer.TabStop = false;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pic_MoveForm);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.topSpacer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(700, 425);
            this.Name = "BrowserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SBA :: Browser";
            this.Load += new System.EventHandler(this.BrowserForm_Load);
            this.panelHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Max)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Bundlestars)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Humblebundle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MoveForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox topSpacer;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_Min;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic_MoveForm;
        private System.Windows.Forms.WebBrowser web_Browser;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox btn_Bundlestars;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox btn_Humblebundle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txt_Url;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox btn_Max;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}