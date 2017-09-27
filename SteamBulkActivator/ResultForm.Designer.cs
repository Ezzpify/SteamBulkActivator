namespace SteamBulkActivator
{
    partial class ResultForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResultForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelControlHeader = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ContainerInput = new System.Windows.Forms.Panel();
            this.keyListView = new System.Windows.Forms.ListView();
            this.keyHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.resultHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ContainerInputRightSpacer = new System.Windows.Forms.PictureBox();
            this.ContainerInputLeftSpacer = new System.Windows.Forms.PictureBox();
            this.responseTimer = new System.Windows.Forms.Timer(this.components);
            this.topSpacer = new System.Windows.Forms.PictureBox();
            this.btn_Save = new System.Windows.Forms.Button();
            this.panelActions = new System.Windows.Forms.Panel();
            this.lbl_NextResult = new System.Windows.Forms.Label();
            this.tmr_NextResult = new System.Windows.Forms.Timer(this.components);
            this.panelHeader.SuspendLayout();
            this.panelControlHeader.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.ContainerInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputRightSpacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputLeftSpacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).BeginInit();
            this.panelActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.panelControlHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(454, 39);
            this.panelHeader.TabIndex = 1;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // panelControlHeader
            // 
            this.panelControlHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelControlHeader.Controls.Add(this.panel2);
            this.panelControlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlHeader.Location = new System.Drawing.Point(0, 0);
            this.panelControlHeader.Name = "panelControlHeader";
            this.panelControlHeader.Size = new System.Drawing.Size(454, 20);
            this.panelControlHeader.TabIndex = 1;
            this.panelControlHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelControlHeader_MouseDown);
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel2.BackgroundImage")));
            this.panel2.Controls.Add(this.btn_Min);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(414, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(40, 20);
            this.panel2.TabIndex = 0;
            // 
            // btn_Min
            // 
            this.btn_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Min.Image = global::SteamBulkActivator.Properties.Resources.min_bg;
            this.btn_Min.Location = new System.Drawing.Point(15, 0);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(20, 20);
            this.btn_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Min.TabIndex = 1;
            this.btn_Min.TabStop = false;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            this.btn_Min.MouseEnter += new System.EventHandler(this.btn_Min_MouseEnter);
            this.btn_Min.MouseLeave += new System.EventHandler(this.btn_Min_MouseLeave);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Location = new System.Drawing.Point(35, 0);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(5, 20);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // ContainerInput
            // 
            this.ContainerInput.BackColor = System.Drawing.Color.Transparent;
            this.ContainerInput.Controls.Add(this.keyListView);
            this.ContainerInput.Controls.Add(this.ContainerInputRightSpacer);
            this.ContainerInput.Controls.Add(this.ContainerInputLeftSpacer);
            this.ContainerInput.Dock = System.Windows.Forms.DockStyle.Top;
            this.ContainerInput.Location = new System.Drawing.Point(0, 44);
            this.ContainerInput.Name = "ContainerInput";
            this.ContainerInput.Size = new System.Drawing.Size(454, 175);
            this.ContainerInput.TabIndex = 14;
            // 
            // keyListView
            // 
            this.keyListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
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
            // responseTimer
            // 
            this.responseTimer.Enabled = true;
            this.responseTimer.Interval = 250;
            this.responseTimer.Tick += new System.EventHandler(this.responseTimer_Tick);
            // 
            // topSpacer
            // 
            this.topSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.topSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSpacer.Location = new System.Drawing.Point(0, 0);
            this.topSpacer.Name = "topSpacer";
            this.topSpacer.Size = new System.Drawing.Size(454, 5);
            this.topSpacer.TabIndex = 11;
            this.topSpacer.TabStop = false;
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Save.FlatAppearance.BorderSize = 0;
            this.btn_Save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.btn_Save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.btn_Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Save.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Save.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btn_Save.Location = new System.Drawing.Point(0, 0);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(418, 42);
            this.btn_Save.TabIndex = 20;
            this.btn_Save.Text = "Save results";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Visible = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // panelActions
            // 
            this.panelActions.Controls.Add(this.lbl_NextResult);
            this.panelActions.Controls.Add(this.btn_Save);
            this.panelActions.Location = new System.Drawing.Point(18, 235);
            this.panelActions.Name = "panelActions";
            this.panelActions.Size = new System.Drawing.Size(418, 42);
            this.panelActions.TabIndex = 21;
            // 
            // lbl_NextResult
            // 
            this.lbl_NextResult.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.lbl_NextResult.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_NextResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_NextResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NextResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.lbl_NextResult.Location = new System.Drawing.Point(0, 0);
            this.lbl_NextResult.Name = "lbl_NextResult";
            this.lbl_NextResult.Size = new System.Drawing.Size(418, 42);
            this.lbl_NextResult.TabIndex = 21;
            this.lbl_NextResult.Text = "Starting ...";
            this.lbl_NextResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_NextResult
            // 
            this.tmr_NextResult.Tick += new System.EventHandler(this.tmr_NextResult_Tick);
            // 
            // ResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(454, 297);
            this.Controls.Add(this.panelActions);
            this.Controls.Add(this.ContainerInput);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.topSpacer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SBA :: Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.panelHeader.ResumeLayout(false);
            this.panelControlHeader.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ContainerInput.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputRightSpacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContainerInputLeftSpacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).EndInit();
            this.panelActions.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel ContainerInput;
        private System.Windows.Forms.ListView keyListView;
        private System.Windows.Forms.PictureBox ContainerInputRightSpacer;
        private System.Windows.Forms.PictureBox ContainerInputLeftSpacer;
        private System.Windows.Forms.ColumnHeader keyHeader;
        private System.Windows.Forms.ColumnHeader resultHeader;
        private System.Windows.Forms.Timer responseTimer;
        private System.Windows.Forms.Panel panelControlHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btn_Min;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox topSpacer;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Panel panelActions;
        private System.Windows.Forms.Label lbl_NextResult;
        private System.Windows.Forms.Timer tmr_NextResult;
    }
}