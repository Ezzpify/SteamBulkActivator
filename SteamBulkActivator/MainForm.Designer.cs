namespace SteamBulkActivator
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Label();
            this.linkGithub = new System.Windows.Forms.PictureBox();
            this.panelHeaderDivider3 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBtnRegisterWrapper = new System.Windows.Forms.Panel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnRegisterIcon = new System.Windows.Forms.PictureBox();
            this.ContainerInput = new System.Windows.Forms.Panel();
            this.ContainerInputRightSpacer = new System.Windows.Forms.PictureBox();
            this.ContainerInputLeftSpacer = new System.Windows.Forms.PictureBox();
            this.ContainerKeyCount = new System.Windows.Forms.Panel();
            this.lblKeyCount = new System.Windows.Forms.Label();
            this.topSpacer = new System.Windows.Forms.PictureBox();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.txtKeys = new System.Windows.Forms.RichTextBox();
            this.panelHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.linkGithub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderDivider3)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBtnRegisterWrapper.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnRegisterIcon)).BeginInit();
            this.ContainerInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputRightSpacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputLeftSpacer)).BeginInit();
            this.ContainerKeyCount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).BeginInit();
            this.panelLoading.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.btnMinimize);
            this.panelHeader.Controls.Add(this.btnClose);
            this.panelHeader.Controls.Add(this.linkGithub);
            this.panelHeader.Controls.Add(this.panelHeaderDivider3);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(269, 25);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnMinimize.Location = new System.Drawing.Point(214, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 10;
            this.btnMinimize.Text = "_";
            this.btnMinimize.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            this.btnMinimize.MouseEnter += new System.EventHandler(this.btnMinimize_MouseEnter);
            this.btnMinimize.MouseLeave += new System.EventHandler(this.btnMinimize_MouseLeave);
            // 
            // btnClose
            // 
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnClose.Location = new System.Drawing.Point(239, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(25, 25);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "X";
            this.btnClose.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            this.btnClose.MouseEnter += new System.EventHandler(this.btnClose_MouseEnter);
            this.btnClose.MouseLeave += new System.EventHandler(this.btnClose_MouseLeave);
            // 
            // linkGithub
            // 
            this.linkGithub.Cursor = System.Windows.Forms.Cursors.Hand;
            this.linkGithub.Dock = System.Windows.Forms.DockStyle.Left;
            this.linkGithub.Image = ((System.Drawing.Image)(resources.GetObject("linkGithub.Image")));
            this.linkGithub.Location = new System.Drawing.Point(0, 0);
            this.linkGithub.Name = "linkGithub";
            this.linkGithub.Size = new System.Drawing.Size(41, 25);
            this.linkGithub.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.linkGithub.TabIndex = 8;
            this.linkGithub.TabStop = false;
            this.linkGithub.Click += new System.EventHandler(this.linkGithub_Click);
            // 
            // panelHeaderDivider3
            // 
            this.panelHeaderDivider3.BackColor = System.Drawing.Color.Transparent;
            this.panelHeaderDivider3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelHeaderDivider3.Location = new System.Drawing.Point(264, 0);
            this.panelHeaderDivider3.Name = "panelHeaderDivider3";
            this.panelHeaderDivider3.Size = new System.Drawing.Size(5, 25);
            this.panelHeaderDivider3.TabIndex = 7;
            this.panelHeaderDivider3.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.panelBtnRegisterWrapper);
            this.panelMain.Controls.Add(this.ContainerInput);
            this.panelMain.Controls.Add(this.ContainerKeyCount);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 30);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(269, 270);
            this.panelMain.TabIndex = 7;
            this.panelMain.Visible = false;
            // 
            // panelBtnRegisterWrapper
            // 
            this.panelBtnRegisterWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtnRegisterWrapper.Controls.Add(this.btnRegister);
            this.panelBtnRegisterWrapper.Controls.Add(this.btnRegisterIcon);
            this.panelBtnRegisterWrapper.Location = new System.Drawing.Point(65, 219);
            this.panelBtnRegisterWrapper.Name = "panelBtnRegisterWrapper";
            this.panelBtnRegisterWrapper.Size = new System.Drawing.Size(143, 25);
            this.panelBtnRegisterWrapper.TabIndex = 16;
            // 
            // btnRegister
            // 
            this.btnRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(168)))), ((int)(((byte)(199)))));
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegister.FlatAppearance.BorderSize = 0;
            this.btnRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(190)))), ((int)(((byte)(224)))));
            this.btnRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(190)))), ((int)(((byte)(224)))));
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegister.Location = new System.Drawing.Point(25, 0);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(118, 25);
            this.btnRegister.TabIndex = 14;
            this.btnRegister.Text = "REGISTER KEYS";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnRegisterIcon
            // 
            this.btnRegisterIcon.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRegisterIcon.BackgroundImage")));
            this.btnRegisterIcon.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRegisterIcon.Location = new System.Drawing.Point(0, 0);
            this.btnRegisterIcon.Name = "btnRegisterIcon";
            this.btnRegisterIcon.Size = new System.Drawing.Size(25, 25);
            this.btnRegisterIcon.TabIndex = 15;
            this.btnRegisterIcon.TabStop = false;
            // 
            // ContainerInput
            // 
            this.ContainerInput.Controls.Add(this.txtKeys);
            this.ContainerInput.Controls.Add(this.ContainerInputRightSpacer);
            this.ContainerInput.Controls.Add(this.ContainerInputLeftSpacer);
            this.ContainerInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerInput.Location = new System.Drawing.Point(0, 44);
            this.ContainerInput.Name = "ContainerInput";
            this.ContainerInput.Size = new System.Drawing.Size(269, 154);
            this.ContainerInput.TabIndex = 13;
            // 
            // ContainerInputRightSpacer
            // 
            this.ContainerInputRightSpacer.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContainerInputRightSpacer.Location = new System.Drawing.Point(219, 0);
            this.ContainerInputRightSpacer.Name = "ContainerInputRightSpacer";
            this.ContainerInputRightSpacer.Size = new System.Drawing.Size(50, 154);
            this.ContainerInputRightSpacer.TabIndex = 14;
            this.ContainerInputRightSpacer.TabStop = false;
            // 
            // ContainerInputLeftSpacer
            // 
            this.ContainerInputLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContainerInputLeftSpacer.Location = new System.Drawing.Point(0, 0);
            this.ContainerInputLeftSpacer.Name = "ContainerInputLeftSpacer";
            this.ContainerInputLeftSpacer.Size = new System.Drawing.Size(50, 154);
            this.ContainerInputLeftSpacer.TabIndex = 13;
            this.ContainerInputLeftSpacer.TabStop = false;
            // 
            // ContainerKeyCount
            // 
            this.ContainerKeyCount.Controls.Add(this.lblKeyCount);
            this.ContainerKeyCount.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerKeyCount.Location = new System.Drawing.Point(0, 0);
            this.ContainerKeyCount.Name = "ContainerKeyCount";
            this.ContainerKeyCount.Size = new System.Drawing.Size(269, 44);
            this.ContainerKeyCount.TabIndex = 18;
            // 
            // lblKeyCount
            // 
            this.lblKeyCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKeyCount.ForeColor = System.Drawing.Color.Gray;
            this.lblKeyCount.Location = new System.Drawing.Point(0, 0);
            this.lblKeyCount.Name = "lblKeyCount";
            this.lblKeyCount.Size = new System.Drawing.Size(269, 44);
            this.lblKeyCount.TabIndex = 17;
            this.lblKeyCount.Text = "Valid keys: 0";
            this.lblKeyCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // topSpacer
            // 
            this.topSpacer.BackColor = System.Drawing.Color.Transparent;
            this.topSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSpacer.Location = new System.Drawing.Point(0, 0);
            this.topSpacer.Name = "topSpacer";
            this.topSpacer.Size = new System.Drawing.Size(269, 5);
            this.topSpacer.TabIndex = 10;
            this.topSpacer.TabStop = false;
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.Transparent;
            this.panelLoading.Controls.Add(this.lblError);
            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.Location = new System.Drawing.Point(0, 30);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(269, 270);
            this.panelLoading.TabIndex = 11;
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.ForeColor = System.Drawing.Color.Gray;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(269, 270);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Unable to connect to Steam client ...";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtKeys
            // 
            this.txtKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.txtKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKeys.Location = new System.Drawing.Point(50, 0);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(169, 154);
            this.txtKeys.TabIndex = 15;
            this.txtKeys.Text = "";
            this.txtKeys.TextChanged += new System.EventHandler(this.txtKeys_TextChanged);
            this.txtKeys.Enter += new System.EventHandler(this.txtKeys_Enter);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(269, 300);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.topSpacer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Steam Bulk Activator";
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panelHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.linkGithub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelHeaderDivider3)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelBtnRegisterWrapper.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnRegisterIcon)).EndInit();
            this.ContainerInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputRightSpacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputLeftSpacer)).EndInit();
            this.ContainerKeyCount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).EndInit();
            this.panelLoading.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.PictureBox panelHeaderDivider3;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox topSpacer;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Panel ContainerInput;
        private System.Windows.Forms.PictureBox ContainerInputRightSpacer;
        private System.Windows.Forms.PictureBox ContainerInputLeftSpacer;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel panelBtnRegisterWrapper;
        private System.Windows.Forms.PictureBox btnRegisterIcon;
        private System.Windows.Forms.Panel ContainerKeyCount;
        private System.Windows.Forms.Label lblKeyCount;
        private System.Windows.Forms.PictureBox linkGithub;
        private System.Windows.Forms.Label btnMinimize;
        private System.Windows.Forms.Label btnClose;
        private System.Windows.Forms.RichTextBox txtKeys;
    }
}

