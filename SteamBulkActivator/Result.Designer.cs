namespace SteamBulkActivator
{
    partial class Result
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Result));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.ContainerInput = new System.Windows.Forms.Panel();
            this.keyListView = new System.Windows.Forms.ListView();
            this.keyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContainerInputRightSpacer = new System.Windows.Forms.PictureBox();
            this.ContainerInputLeftSpacer = new System.Windows.Forms.PictureBox();
            this.topSpacer = new System.Windows.Forms.PictureBox();
            this.panelBtnRegisterWrapper = new System.Windows.Forms.Panel();
            this.btnSaveResults = new System.Windows.Forms.Button();
            this.responseTimer = new System.Windows.Forms.Timer(this.components);
            this.ContainerInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputRightSpacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputLeftSpacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).BeginInit();
            this.panelBtnRegisterWrapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 0);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(454, 25);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // ContainerInput
            // 
            this.ContainerInput.BackColor = System.Drawing.Color.Transparent;
            this.ContainerInput.Controls.Add(this.keyListView);
            this.ContainerInput.Controls.Add(this.ContainerInputRightSpacer);
            this.ContainerInput.Controls.Add(this.ContainerInputLeftSpacer);
            this.ContainerInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerInput.Location = new System.Drawing.Point(0, 58);
            this.ContainerInput.Name = "ContainerInput";
            this.ContainerInput.Size = new System.Drawing.Size(454, 175);
            this.ContainerInput.TabIndex = 14;
            // 
            // keyListView
            // 
            this.keyListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.keyListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.keyListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.keyHeader,
            this.resultHeader});
            this.keyListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.keyListView.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.keyListView.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.keyListView.Location = new System.Drawing.Point(18, 0);
            this.keyListView.Name = "keyListView";
            this.keyListView.Size = new System.Drawing.Size(418, 175);
            this.keyListView.TabIndex = 15;
            this.keyListView.UseCompatibleStateImageBehavior = false;
            this.keyListView.View = System.Windows.Forms.View.Details;
            // 
            // keyHeader
            // 
            this.keyHeader.Text = "Key";
            this.keyHeader.Width = 148;
            // 
            // resultHeader
            // 
            this.resultHeader.Text = "Result";
            this.resultHeader.Width = 267;
            // 
            // ContainerInputRightSpacer
            // 
            this.ContainerInputRightSpacer.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContainerInputRightSpacer.Location = new System.Drawing.Point(436, 0);
            this.ContainerInputRightSpacer.Name = "ContainerInputRightSpacer";
            this.ContainerInputRightSpacer.Size = new System.Drawing.Size(18, 175);
            this.ContainerInputRightSpacer.TabIndex = 14;
            this.ContainerInputRightSpacer.TabStop = false;
            // 
            // ContainerInputLeftSpacer
            // 
            this.ContainerInputLeftSpacer.BackColor = System.Drawing.Color.Transparent;
            this.ContainerInputLeftSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContainerInputLeftSpacer.Location = new System.Drawing.Point(0, 0);
            this.ContainerInputLeftSpacer.Name = "ContainerInputLeftSpacer";
            this.ContainerInputLeftSpacer.Size = new System.Drawing.Size(18, 175);
            this.ContainerInputLeftSpacer.TabIndex = 13;
            this.ContainerInputLeftSpacer.TabStop = false;
            // 
            // topSpacer
            // 
            this.topSpacer.BackColor = System.Drawing.Color.Transparent;
            this.topSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSpacer.Location = new System.Drawing.Point(0, 25);
            this.topSpacer.Name = "topSpacer";
            this.topSpacer.Size = new System.Drawing.Size(454, 33);
            this.topSpacer.TabIndex = 16;
            this.topSpacer.TabStop = false;
            this.topSpacer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topSpacer_MouseDown);
            // 
            // panelBtnRegisterWrapper
            // 
            this.panelBtnRegisterWrapper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panelBtnRegisterWrapper.Controls.Add(this.btnSaveResults);
            this.panelBtnRegisterWrapper.Location = new System.Drawing.Point(137, 248);
            this.panelBtnRegisterWrapper.Name = "panelBtnRegisterWrapper";
            this.panelBtnRegisterWrapper.Size = new System.Drawing.Size(180, 25);
            this.panelBtnRegisterWrapper.TabIndex = 17;
            this.panelBtnRegisterWrapper.Visible = false;
            // 
            // btnSaveResults
            // 
            this.btnSaveResults.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(168)))), ((int)(((byte)(199)))));
            this.btnSaveResults.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSaveResults.FlatAppearance.BorderSize = 0;
            this.btnSaveResults.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(190)))), ((int)(((byte)(224)))));
            this.btnSaveResults.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(190)))), ((int)(((byte)(224)))));
            this.btnSaveResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveResults.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.btnSaveResults.Location = new System.Drawing.Point(0, 0);
            this.btnSaveResults.Name = "btnSaveResults";
            this.btnSaveResults.Size = new System.Drawing.Size(180, 25);
            this.btnSaveResults.TabIndex = 14;
            this.btnSaveResults.Text = "CLOSE AND SAVE RESULTS";
            this.btnSaveResults.UseVisualStyleBackColor = false;
            this.btnSaveResults.Click += new System.EventHandler(this.btnSaveResults_Click);
            // 
            // responseTimer
            // 
            this.responseTimer.Enabled = true;
            this.responseTimer.Interval = 250;
            this.responseTimer.Tick += new System.EventHandler(this.responseTimer_Tick);
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(454, 300);
            this.Controls.Add(this.panelBtnRegisterWrapper);
            this.Controls.Add(this.ContainerInput);
            this.Controls.Add(this.topSpacer);
            this.Controls.Add(this.panelHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.ContainerInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputRightSpacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputLeftSpacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).EndInit();
            this.panelBtnRegisterWrapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel ContainerInput;
        private System.Windows.Forms.ListView keyListView;
        private System.Windows.Forms.PictureBox ContainerInputRightSpacer;
        private System.Windows.Forms.PictureBox ContainerInputLeftSpacer;
        private System.Windows.Forms.PictureBox topSpacer;
        private System.Windows.Forms.ColumnHeader keyHeader;
        private System.Windows.Forms.ColumnHeader resultHeader;
        private System.Windows.Forms.Panel panelBtnRegisterWrapper;
        private System.Windows.Forms.Button btnSaveResults;
        private System.Windows.Forms.Timer responseTimer;
    }
}