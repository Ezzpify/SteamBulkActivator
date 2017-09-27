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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panelHeader = new System.Windows.Forms.Panel();
            this.panelControlHeader = new System.Windows.Forms.Panel();
            this.btn_Min = new System.Windows.Forms.PictureBox();
            this.panelControlHeaderSpacer1 = new System.Windows.Forms.PictureBox();
            this.btn_Close = new System.Windows.Forms.PictureBox();
            this.panelControlHeaderSpacer2 = new System.Windows.Forms.PictureBox();
            this.panelMain = new System.Windows.Forms.Panel();
            this.panelBitcoin = new System.Windows.Forms.Panel();
            this.panelBitcoinBottomSpacer = new System.Windows.Forms.PictureBox();
            this.txt_BitcoinAddress = new System.Windows.Forms.TextBox();
            this.pic_MoveForm = new System.Windows.Forms.PictureBox();
            this.panelDonate = new System.Windows.Forms.Panel();
            this.btn_Bitcoin = new System.Windows.Forms.PictureBox();
            this.panelDonateSpacerMid = new System.Windows.Forms.PictureBox();
            this.btn_Paypal = new System.Windows.Forms.PictureBox();
            this.panelDonateTopSpacer = new System.Windows.Forms.PictureBox();
            this.panelDonateBottomSpacer = new System.Windows.Forms.PictureBox();
            this.panelActionHolder = new System.Windows.Forms.Panel();
            this.panelActionHolderSpacer = new System.Windows.Forms.PictureBox();
            this.btn_Scrape = new System.Windows.Forms.Button();
            this.btn_Register = new System.Windows.Forms.Button();
            this.panelContent = new System.Windows.Forms.Panel();
            this.txtKeys = new System.Windows.Forms.RichTextBox();
            this.txtKeysSpacerBottom = new System.Windows.Forms.PictureBox();
            this.txtKeysSpacerTop = new System.Windows.Forms.PictureBox();
            this.txtKeysSpacerRight = new System.Windows.Forms.PictureBox();
            this.txtKeysSpacerLeft = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.lbl_KeyCount = new System.Windows.Forms.Label();
            this.panelMenuSpacer1 = new System.Windows.Forms.PictureBox();
            this.btn_Donate = new System.Windows.Forms.PictureBox();
            this.panelMenuSpacer2 = new System.Windows.Forms.PictureBox();
            this.btn_Github = new System.Windows.Forms.PictureBox();
            this.panelLoading = new System.Windows.Forms.Panel();
            this.lblError = new System.Windows.Forms.Label();
            this.tmr_LoveAnimation = new System.Windows.Forms.Timer(this.components);
            this.topSpacer = new System.Windows.Forms.PictureBox();
            this.tmr_Update = new System.Windows.Forms.Timer(this.components);
            this.num_RegDelay = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panelHeader.SuspendLayout();
            this.panelControlHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHeaderSpacer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHeaderSpacer2)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelBitcoin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBitcoinBottomSpacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MoveForm)).BeginInit();
            this.panelDonate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Bitcoin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonateSpacerMid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Paypal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonateTopSpacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonateBottomSpacer)).BeginInit();
            this.panelActionHolder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelActionHolderSpacer)).BeginInit();
            this.panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeysSpacerBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeysSpacerTop)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeysSpacerRight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeysSpacerLeft)).BeginInit();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenuSpacer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Donate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenuSpacer2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Github)).BeginInit();
            this.panelLoading.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RegDelay)).BeginInit();
            this.SuspendLayout();
            // 
            // panelHeader
            // 
            this.panelHeader.BackColor = System.Drawing.Color.Transparent;
            this.panelHeader.Controls.Add(this.panelControlHeader);
            this.panelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelHeader.Location = new System.Drawing.Point(0, 5);
            this.panelHeader.Name = "panelHeader";
            this.panelHeader.Size = new System.Drawing.Size(313, 20);
            this.panelHeader.TabIndex = 0;
            this.panelHeader.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelHeader_MouseDown);
            // 
            // panelControlHeader
            // 
            this.panelControlHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelControlHeader.BackgroundImage")));
            this.panelControlHeader.Controls.Add(this.btn_Min);
            this.panelControlHeader.Controls.Add(this.panelControlHeaderSpacer1);
            this.panelControlHeader.Controls.Add(this.btn_Close);
            this.panelControlHeader.Controls.Add(this.panelControlHeaderSpacer2);
            this.panelControlHeader.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlHeader.Location = new System.Drawing.Point(247, 0);
            this.panelControlHeader.Name = "panelControlHeader";
            this.panelControlHeader.Size = new System.Drawing.Size(66, 20);
            this.panelControlHeader.TabIndex = 0;
            // 
            // btn_Min
            // 
            this.btn_Min.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Min.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Min.Image = global::SteamBulkActivator.Properties.Resources.min_bg;
            this.btn_Min.Location = new System.Drawing.Point(19, 0);
            this.btn_Min.Name = "btn_Min";
            this.btn_Min.Size = new System.Drawing.Size(20, 20);
            this.btn_Min.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Min.TabIndex = 1;
            this.btn_Min.TabStop = false;
            this.btn_Min.Click += new System.EventHandler(this.btn_Min_Click);
            this.btn_Min.MouseEnter += new System.EventHandler(this.btn_Min_MouseEnter);
            this.btn_Min.MouseLeave += new System.EventHandler(this.btn_Min_MouseLeave);
            // 
            // panelControlHeaderSpacer1
            // 
            this.panelControlHeaderSpacer1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlHeaderSpacer1.Location = new System.Drawing.Point(39, 0);
            this.panelControlHeaderSpacer1.Name = "panelControlHeaderSpacer1";
            this.panelControlHeaderSpacer1.Size = new System.Drawing.Size(2, 20);
            this.panelControlHeaderSpacer1.TabIndex = 3;
            this.panelControlHeaderSpacer1.TabStop = false;
            // 
            // btn_Close
            // 
            this.btn_Close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Close.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_Close.Image = global::SteamBulkActivator.Properties.Resources.close_bg;
            this.btn_Close.Location = new System.Drawing.Point(41, 0);
            this.btn_Close.Name = "btn_Close";
            this.btn_Close.Size = new System.Drawing.Size(20, 20);
            this.btn_Close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Close.TabIndex = 0;
            this.btn_Close.TabStop = false;
            this.btn_Close.Click += new System.EventHandler(this.btn_Close_Click);
            this.btn_Close.MouseEnter += new System.EventHandler(this.btn_Close_MouseEnter);
            this.btn_Close.MouseLeave += new System.EventHandler(this.btn_Close_MouseLeave);
            // 
            // panelControlHeaderSpacer2
            // 
            this.panelControlHeaderSpacer2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelControlHeaderSpacer2.Location = new System.Drawing.Point(61, 0);
            this.panelControlHeaderSpacer2.Name = "panelControlHeaderSpacer2";
            this.panelControlHeaderSpacer2.Size = new System.Drawing.Size(5, 20);
            this.panelControlHeaderSpacer2.TabIndex = 2;
            this.panelControlHeaderSpacer2.TabStop = false;
            // 
            // panelMain
            // 
            this.panelMain.BackColor = System.Drawing.Color.Transparent;
            this.panelMain.Controls.Add(this.label1);
            this.panelMain.Controls.Add(this.num_RegDelay);
            this.panelMain.Controls.Add(this.panelBitcoin);
            this.panelMain.Controls.Add(this.pic_MoveForm);
            this.panelMain.Controls.Add(this.panelDonate);
            this.panelMain.Controls.Add(this.panelActionHolder);
            this.panelMain.Controls.Add(this.panelContent);
            this.panelMain.Controls.Add(this.panelMenu);
            this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Location = new System.Drawing.Point(0, 25);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(313, 361);
            this.panelMain.TabIndex = 7;
            this.panelMain.Visible = false;
            // 
            // panelBitcoin
            // 
            this.panelBitcoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.panelBitcoin.Controls.Add(this.panelBitcoinBottomSpacer);
            this.panelBitcoin.Controls.Add(this.txt_BitcoinAddress);
            this.panelBitcoin.Location = new System.Drawing.Point(12, 57);
            this.panelBitcoin.Name = "panelBitcoin";
            this.panelBitcoin.Size = new System.Drawing.Size(289, 39);
            this.panelBitcoin.TabIndex = 20;
            this.panelBitcoin.Visible = false;
            this.panelBitcoin.MouseLeave += new System.EventHandler(this.panelBitcoin_MouseLeave);
            // 
            // panelBitcoinBottomSpacer
            // 
            this.panelBitcoinBottomSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.panelBitcoinBottomSpacer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelBitcoinBottomSpacer.Location = new System.Drawing.Point(0, 37);
            this.panelBitcoinBottomSpacer.Name = "panelBitcoinBottomSpacer";
            this.panelBitcoinBottomSpacer.Size = new System.Drawing.Size(289, 2);
            this.panelBitcoinBottomSpacer.TabIndex = 11;
            this.panelBitcoinBottomSpacer.TabStop = false;
            this.panelBitcoinBottomSpacer.MouseLeave += new System.EventHandler(this.panelBitcoinBottomSpacer_MouseLeave);
            // 
            // txt_BitcoinAddress
            // 
            this.txt_BitcoinAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.txt_BitcoinAddress.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_BitcoinAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_BitcoinAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.txt_BitcoinAddress.Location = new System.Drawing.Point(15, 11);
            this.txt_BitcoinAddress.Name = "txt_BitcoinAddress";
            this.txt_BitcoinAddress.ReadOnly = true;
            this.txt_BitcoinAddress.Size = new System.Drawing.Size(259, 15);
            this.txt_BitcoinAddress.TabIndex = 3;
            this.txt_BitcoinAddress.Text = "1MYkqbpQLEXVkZ9tn67ksRapdBrvjcKTkF";
            this.txt_BitcoinAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pic_MoveForm
            // 
            this.pic_MoveForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.pic_MoveForm.Location = new System.Drawing.Point(0, 0);
            this.pic_MoveForm.Name = "pic_MoveForm";
            this.pic_MoveForm.Size = new System.Drawing.Size(313, 21);
            this.pic_MoveForm.TabIndex = 24;
            this.pic_MoveForm.TabStop = false;
            this.pic_MoveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MoveForm_MouseDown);
            // 
            // panelDonate
            // 
            this.panelDonate.BackColor = System.Drawing.Color.Transparent;
            this.panelDonate.Controls.Add(this.btn_Bitcoin);
            this.panelDonate.Controls.Add(this.panelDonateSpacerMid);
            this.panelDonate.Controls.Add(this.btn_Paypal);
            this.panelDonate.Controls.Add(this.panelDonateTopSpacer);
            this.panelDonate.Controls.Add(this.panelDonateBottomSpacer);
            this.panelDonate.Location = new System.Drawing.Point(80, 55);
            this.panelDonate.Name = "panelDonate";
            this.panelDonate.Size = new System.Drawing.Size(133, 33);
            this.panelDonate.TabIndex = 23;
            this.panelDonate.Visible = false;
            this.panelDonate.MouseLeave += new System.EventHandler(this.panelDonate_MouseLeave);
            // 
            // btn_Bitcoin
            // 
            this.btn_Bitcoin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Bitcoin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Bitcoin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Bitcoin.Image = ((System.Drawing.Image)(resources.GetObject("btn_Bitcoin.Image")));
            this.btn_Bitcoin.Location = new System.Drawing.Point(68, 2);
            this.btn_Bitcoin.Name = "btn_Bitcoin";
            this.btn_Bitcoin.Size = new System.Drawing.Size(66, 29);
            this.btn_Bitcoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Bitcoin.TabIndex = 8;
            this.btn_Bitcoin.TabStop = false;
            this.btn_Bitcoin.Click += new System.EventHandler(this.btn_Bitcoin_Click);
            this.btn_Bitcoin.MouseEnter += new System.EventHandler(this.btn_Bitcoin_MouseEnter);
            this.btn_Bitcoin.MouseLeave += new System.EventHandler(this.btn_Bitcoin_MouseLeave);
            // 
            // panelDonateSpacerMid
            // 
            this.panelDonateSpacerMid.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelDonateSpacerMid.Location = new System.Drawing.Point(66, 2);
            this.panelDonateSpacerMid.Name = "panelDonateSpacerMid";
            this.panelDonateSpacerMid.Size = new System.Drawing.Size(2, 29);
            this.panelDonateSpacerMid.TabIndex = 7;
            this.panelDonateSpacerMid.TabStop = false;
            // 
            // btn_Paypal
            // 
            this.btn_Paypal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Paypal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Paypal.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Paypal.Image = ((System.Drawing.Image)(resources.GetObject("btn_Paypal.Image")));
            this.btn_Paypal.Location = new System.Drawing.Point(0, 2);
            this.btn_Paypal.Name = "btn_Paypal";
            this.btn_Paypal.Size = new System.Drawing.Size(66, 29);
            this.btn_Paypal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Paypal.TabIndex = 6;
            this.btn_Paypal.TabStop = false;
            this.btn_Paypal.Click += new System.EventHandler(this.btn_Paypal_Click);
            this.btn_Paypal.MouseEnter += new System.EventHandler(this.btn_Paypal_MouseEnter);
            this.btn_Paypal.MouseLeave += new System.EventHandler(this.btn_Paypal_MouseLeave);
            // 
            // panelDonateTopSpacer
            // 
            this.panelDonateTopSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDonateTopSpacer.Location = new System.Drawing.Point(0, 0);
            this.panelDonateTopSpacer.Name = "panelDonateTopSpacer";
            this.panelDonateTopSpacer.Size = new System.Drawing.Size(133, 2);
            this.panelDonateTopSpacer.TabIndex = 9;
            this.panelDonateTopSpacer.TabStop = false;
            this.panelDonateTopSpacer.MouseLeave += new System.EventHandler(this.panelDonateTopSpacer_MouseLeave);
            // 
            // panelDonateBottomSpacer
            // 
            this.panelDonateBottomSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.panelDonateBottomSpacer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelDonateBottomSpacer.Location = new System.Drawing.Point(0, 31);
            this.panelDonateBottomSpacer.Name = "panelDonateBottomSpacer";
            this.panelDonateBottomSpacer.Size = new System.Drawing.Size(133, 2);
            this.panelDonateBottomSpacer.TabIndex = 10;
            this.panelDonateBottomSpacer.TabStop = false;
            this.panelDonateBottomSpacer.MouseLeave += new System.EventHandler(this.panelDonateBottomSpacer_MouseLeave);
            // 
            // panelActionHolder
            // 
            this.panelActionHolder.Controls.Add(this.panelActionHolderSpacer);
            this.panelActionHolder.Controls.Add(this.btn_Register);
            this.panelActionHolder.Controls.Add(this.btn_Scrape);
            this.panelActionHolder.Location = new System.Drawing.Point(12, 284);
            this.panelActionHolder.Name = "panelActionHolder";
            this.panelActionHolder.Size = new System.Drawing.Size(289, 42);
            this.panelActionHolder.TabIndex = 22;
            // 
            // panelActionHolderSpacer
            // 
            this.panelActionHolderSpacer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelActionHolderSpacer.Location = new System.Drawing.Point(0, 0);
            this.panelActionHolderSpacer.Name = "panelActionHolderSpacer";
            this.panelActionHolderSpacer.Size = new System.Drawing.Size(2, 42);
            this.panelActionHolderSpacer.TabIndex = 21;
            this.panelActionHolderSpacer.TabStop = false;
            this.panelActionHolderSpacer.Visible = false;
            // 
            // btn_Scrape
            // 
            this.btn_Scrape.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Scrape.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Scrape.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Scrape.FlatAppearance.BorderSize = 0;
            this.btn_Scrape.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.btn_Scrape.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.btn_Scrape.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Scrape.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Scrape.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btn_Scrape.Location = new System.Drawing.Point(0, 0);
            this.btn_Scrape.Name = "btn_Scrape";
            this.btn_Scrape.Size = new System.Drawing.Size(289, 42);
            this.btn_Scrape.TabIndex = 20;
            this.btn_Scrape.Text = "Scrape bundle sites";
            this.btn_Scrape.UseVisualStyleBackColor = false;
            this.btn_Scrape.Visible = false;
            this.btn_Scrape.Click += new System.EventHandler(this.btn_Scrape_Click);
            // 
            // btn_Register
            // 
            this.btn_Register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Register.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btn_Register.FlatAppearance.BorderSize = 0;
            this.btn_Register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.btn_Register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(174)))), ((int)(((byte)(220)))));
            this.btn_Register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.btn_Register.Location = new System.Drawing.Point(0, 0);
            this.btn_Register.Name = "btn_Register";
            this.btn_Register.Size = new System.Drawing.Size(289, 42);
            this.btn_Register.TabIndex = 19;
            this.btn_Register.Text = "Register keys";
            this.btn_Register.UseVisualStyleBackColor = false;
            this.btn_Register.Click += new System.EventHandler(this.btn_Register_Click);
            // 
            // panelContent
            // 
            this.panelContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.panelContent.Controls.Add(this.txtKeys);
            this.panelContent.Controls.Add(this.txtKeysSpacerBottom);
            this.panelContent.Controls.Add(this.txtKeysSpacerTop);
            this.panelContent.Controls.Add(this.txtKeysSpacerRight);
            this.panelContent.Controls.Add(this.txtKeysSpacerLeft);
            this.panelContent.Location = new System.Drawing.Point(12, 74);
            this.panelContent.Name = "panelContent";
            this.panelContent.Size = new System.Drawing.Size(289, 193);
            this.panelContent.TabIndex = 21;
            // 
            // txtKeys
            // 
            this.txtKeys.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.txtKeys.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtKeys.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtKeys.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtKeys.Location = new System.Drawing.Point(15, 15);
            this.txtKeys.Name = "txtKeys";
            this.txtKeys.Size = new System.Drawing.Size(259, 163);
            this.txtKeys.TabIndex = 15;
            this.txtKeys.Text = "";
            this.txtKeys.TextChanged += new System.EventHandler(this.txtKeys_TextChanged);
            this.txtKeys.Enter += new System.EventHandler(this.txtKeys_Enter);
            // 
            // txtKeysSpacerBottom
            // 
            this.txtKeysSpacerBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtKeysSpacerBottom.Location = new System.Drawing.Point(15, 178);
            this.txtKeysSpacerBottom.Name = "txtKeysSpacerBottom";
            this.txtKeysSpacerBottom.Size = new System.Drawing.Size(259, 15);
            this.txtKeysSpacerBottom.TabIndex = 19;
            this.txtKeysSpacerBottom.TabStop = false;
            // 
            // txtKeysSpacerTop
            // 
            this.txtKeysSpacerTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtKeysSpacerTop.Location = new System.Drawing.Point(15, 0);
            this.txtKeysSpacerTop.Name = "txtKeysSpacerTop";
            this.txtKeysSpacerTop.Size = new System.Drawing.Size(259, 15);
            this.txtKeysSpacerTop.TabIndex = 18;
            this.txtKeysSpacerTop.TabStop = false;
            // 
            // txtKeysSpacerRight
            // 
            this.txtKeysSpacerRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtKeysSpacerRight.Location = new System.Drawing.Point(274, 0);
            this.txtKeysSpacerRight.Name = "txtKeysSpacerRight";
            this.txtKeysSpacerRight.Size = new System.Drawing.Size(15, 193);
            this.txtKeysSpacerRight.TabIndex = 17;
            this.txtKeysSpacerRight.TabStop = false;
            // 
            // txtKeysSpacerLeft
            // 
            this.txtKeysSpacerLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtKeysSpacerLeft.Location = new System.Drawing.Point(0, 0);
            this.txtKeysSpacerLeft.Name = "txtKeysSpacerLeft";
            this.txtKeysSpacerLeft.Size = new System.Drawing.Size(15, 193);
            this.txtKeysSpacerLeft.TabIndex = 16;
            this.txtKeysSpacerLeft.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Transparent;
            this.panelMenu.Controls.Add(this.lbl_KeyCount);
            this.panelMenu.Controls.Add(this.panelMenuSpacer1);
            this.panelMenu.Controls.Add(this.btn_Donate);
            this.panelMenu.Controls.Add(this.panelMenuSpacer2);
            this.panelMenu.Controls.Add(this.btn_Github);
            this.panelMenu.Location = new System.Drawing.Point(12, 24);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(289, 31);
            this.panelMenu.TabIndex = 18;
            // 
            // lbl_KeyCount
            // 
            this.lbl_KeyCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.lbl_KeyCount.Cursor = System.Windows.Forms.Cursors.Default;
            this.lbl_KeyCount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_KeyCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_KeyCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.lbl_KeyCount.Location = new System.Drawing.Point(136, 0);
            this.lbl_KeyCount.Name = "lbl_KeyCount";
            this.lbl_KeyCount.Size = new System.Drawing.Size(153, 31);
            this.lbl_KeyCount.TabIndex = 17;
            this.lbl_KeyCount.Text = "Valid keys: 0";
            this.lbl_KeyCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMenuSpacer1
            // 
            this.panelMenuSpacer1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuSpacer1.Location = new System.Drawing.Point(134, 0);
            this.panelMenuSpacer1.Name = "panelMenuSpacer1";
            this.panelMenuSpacer1.Size = new System.Drawing.Size(2, 31);
            this.panelMenuSpacer1.TabIndex = 6;
            this.panelMenuSpacer1.TabStop = false;
            // 
            // btn_Donate
            // 
            this.btn_Donate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Donate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Donate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Donate.Image = ((System.Drawing.Image)(resources.GetObject("btn_Donate.Image")));
            this.btn_Donate.Location = new System.Drawing.Point(68, 0);
            this.btn_Donate.Name = "btn_Donate";
            this.btn_Donate.Size = new System.Drawing.Size(66, 31);
            this.btn_Donate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Donate.TabIndex = 5;
            this.btn_Donate.TabStop = false;
            this.btn_Donate.MouseEnter += new System.EventHandler(this.btn_Donate_MouseEnter);
            this.btn_Donate.MouseLeave += new System.EventHandler(this.btn_Donate_MouseLeave);
            // 
            // panelMenuSpacer2
            // 
            this.panelMenuSpacer2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenuSpacer2.Location = new System.Drawing.Point(66, 0);
            this.panelMenuSpacer2.Name = "panelMenuSpacer2";
            this.panelMenuSpacer2.Size = new System.Drawing.Size(2, 31);
            this.panelMenuSpacer2.TabIndex = 4;
            this.panelMenuSpacer2.TabStop = false;
            // 
            // btn_Github
            // 
            this.btn_Github.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.btn_Github.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Github.Dock = System.Windows.Forms.DockStyle.Left;
            this.btn_Github.Image = ((System.Drawing.Image)(resources.GetObject("btn_Github.Image")));
            this.btn_Github.Location = new System.Drawing.Point(0, 0);
            this.btn_Github.Name = "btn_Github";
            this.btn_Github.Size = new System.Drawing.Size(66, 31);
            this.btn_Github.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.btn_Github.TabIndex = 0;
            this.btn_Github.TabStop = false;
            this.btn_Github.Click += new System.EventHandler(this.btn_Github_Click);
            this.btn_Github.MouseEnter += new System.EventHandler(this.btn_Github_MouseEnter);
            this.btn_Github.MouseLeave += new System.EventHandler(this.btn_Github_MouseLeave);
            // 
            // panelLoading
            // 
            this.panelLoading.BackColor = System.Drawing.Color.Transparent;
            this.panelLoading.Controls.Add(this.lblError);
            this.panelLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelLoading.Location = new System.Drawing.Point(0, 25);
            this.panelLoading.Name = "panelLoading";
            this.panelLoading.Size = new System.Drawing.Size(313, 361);
            this.panelLoading.TabIndex = 11;
            // 
            // lblError
            // 
            this.lblError.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblError.ForeColor = System.Drawing.Color.Gray;
            this.lblError.Location = new System.Drawing.Point(0, 0);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(313, 361);
            this.lblError.TabIndex = 0;
            this.lblError.Text = "Unable to connect to Steam client ...";
            this.lblError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tmr_LoveAnimation
            // 
            this.tmr_LoveAnimation.Interval = 3500;
            this.tmr_LoveAnimation.Tick += new System.EventHandler(this.tmr_LoveAnimation_Tick);
            // 
            // topSpacer
            // 
            this.topSpacer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(22)))), ((int)(((byte)(24)))));
            this.topSpacer.Dock = System.Windows.Forms.DockStyle.Top;
            this.topSpacer.Location = new System.Drawing.Point(0, 0);
            this.topSpacer.Name = "topSpacer";
            this.topSpacer.Size = new System.Drawing.Size(313, 5);
            this.topSpacer.TabIndex = 10;
            this.topSpacer.TabStop = false;
            this.topSpacer.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topSpacer_MouseDown);
            // 
            // tmr_Update
            // 
            this.tmr_Update.Enabled = true;
            this.tmr_Update.Interval = 500;
            this.tmr_Update.Tick += new System.EventHandler(this.tmr_Update_Tick);
            // 
            // num_RegDelay
            // 
            this.num_RegDelay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.num_RegDelay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.num_RegDelay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_RegDelay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(214)))), ((int)(((byte)(214)))));
            this.num_RegDelay.Increment = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.num_RegDelay.Location = new System.Drawing.Point(126, 328);
            this.num_RegDelay.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.num_RegDelay.Name = "num_RegDelay";
            this.num_RegDelay.Size = new System.Drawing.Size(175, 18);
            this.num_RegDelay.TabIndex = 25;
            this.num_RegDelay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.num_RegDelay.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(41)))), ((int)(((byte)(45)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 18);
            this.label1.TabIndex = 26;
            this.label1.Text = "Register delay";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(18)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(313, 386);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelLoading);
            this.Controls.Add(this.panelHeader);
            this.Controls.Add(this.topSpacer);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SBA";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.Deactivate += new System.EventHandler(this.MainForm_Deactivate);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.panelHeader.ResumeLayout(false);
            this.panelControlHeader.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Min)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHeaderSpacer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControlHeaderSpacer2)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelBitcoin.ResumeLayout(false);
            this.panelBitcoin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelBitcoinBottomSpacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_MoveForm)).EndInit();
            this.panelDonate.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_Bitcoin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonateSpacerMid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Paypal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonateTopSpacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelDonateBottomSpacer)).EndInit();
            this.panelActionHolder.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelActionHolderSpacer)).EndInit();
            this.panelContent.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtKeysSpacerBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeysSpacerTop)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeysSpacerRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtKeysSpacerLeft)).EndInit();
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelMenuSpacer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Donate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelMenuSpacer2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Github)).EndInit();
            this.panelLoading.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.topSpacer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_RegDelay)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.PictureBox topSpacer;
        private System.Windows.Forms.Panel panelLoading;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lbl_KeyCount;
        private System.Windows.Forms.RichTextBox txtKeys;
        private System.Windows.Forms.Panel panelControlHeader;
        private System.Windows.Forms.PictureBox btn_Min;
        private System.Windows.Forms.PictureBox btn_Close;
        private System.Windows.Forms.PictureBox panelControlHeaderSpacer2;
        private System.Windows.Forms.PictureBox panelControlHeaderSpacer1;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox btn_Donate;
        private System.Windows.Forms.PictureBox panelMenuSpacer2;
        private System.Windows.Forms.PictureBox btn_Github;
        private System.Windows.Forms.PictureBox panelMenuSpacer1;
        private System.Windows.Forms.Button btn_Scrape;
        private System.Windows.Forms.Button btn_Register;
        private System.Windows.Forms.Panel panelContent;
        private System.Windows.Forms.Panel panelActionHolder;
        private System.Windows.Forms.PictureBox panelActionHolderSpacer;
        private System.Windows.Forms.PictureBox txtKeysSpacerBottom;
        private System.Windows.Forms.PictureBox txtKeysSpacerTop;
        private System.Windows.Forms.PictureBox txtKeysSpacerRight;
        private System.Windows.Forms.PictureBox txtKeysSpacerLeft;
        private System.Windows.Forms.Panel panelDonate;
        private System.Windows.Forms.PictureBox btn_Bitcoin;
        private System.Windows.Forms.PictureBox panelDonateSpacerMid;
        private System.Windows.Forms.PictureBox btn_Paypal;
        private System.Windows.Forms.PictureBox panelDonateTopSpacer;
        private System.Windows.Forms.PictureBox panelDonateBottomSpacer;
        private System.Windows.Forms.PictureBox pic_MoveForm;
        private System.Windows.Forms.Panel panelBitcoin;
        private System.Windows.Forms.TextBox txt_BitcoinAddress;
        private System.Windows.Forms.PictureBox panelBitcoinBottomSpacer;
        private System.Windows.Forms.Timer tmr_LoveAnimation;
        private System.Windows.Forms.Timer tmr_Update;
        private System.Windows.Forms.NumericUpDown num_RegDelay;
        private System.Windows.Forms.Label label1;
    }
}

