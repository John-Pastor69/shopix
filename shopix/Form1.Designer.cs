namespace shopix
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelHomeContainer = new System.Windows.Forms.Panel();
            this.buttonHome = new System.Windows.Forms.Button();
            this.panelCheckoutContainer = new System.Windows.Forms.Panel();
            this.buttonCheckout = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cartpanel = new System.Windows.Forms.Panel();
            this.TotalL = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.buybtn = new System.Windows.Forms.Button();
            this.buttonClearAll = new System.Windows.Forms.Button();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.panelcheckout = new System.Windows.Forms.Panel();
            this.checkoutname = new System.Windows.Forms.Label();
            this.checkoutprice = new System.Windows.Forms.Label();
            this.checkoutqty = new System.Windows.Forms.Label();
            this.subtotal = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.flowLayoutCheckOut = new System.Windows.Forms.FlowLayoutPanel();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.panelBrowseContainer = new System.Windows.Forms.Panel();
            this.buttonBrowse = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.timerBrowse = new System.Windows.Forms.Timer(this.components);
            this.hopeForm2 = new ReaLTaiizor.Forms.HopeForm();
            this.panel1.SuspendLayout();
            this.panelHomeContainer.SuspendLayout();
            this.panelCheckoutContainer.SuspendLayout();
            this.cartpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            this.mainpanel.SuspendLayout();
            this.panelcheckout.SuspendLayout();
            this.panelBrowseContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.Controls.Add(this.panelHomeContainer);
            this.panel1.Controls.Add(this.panelCheckoutContainer);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(226, 735);
            this.panel1.TabIndex = 6;
            // 
            // panelHomeContainer
            // 
            this.panelHomeContainer.Controls.Add(this.buttonHome);
            this.panelHomeContainer.Location = new System.Drawing.Point(0, 0);
            this.panelHomeContainer.Name = "panelHomeContainer";
            this.panelHomeContainer.Size = new System.Drawing.Size(226, 55);
            this.panelHomeContainer.TabIndex = 16;
            // 
            // buttonHome
            // 
            this.buttonHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonHome.Location = new System.Drawing.Point(3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(220, 50);
            this.buttonHome.TabIndex = 7;
            this.buttonHome.Text = "HOME";
            this.buttonHome.UseVisualStyleBackColor = true;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // panelCheckoutContainer
            // 
            this.panelCheckoutContainer.Controls.Add(this.buttonCheckout);
            this.panelCheckoutContainer.Location = new System.Drawing.Point(0, 342);
            this.panelCheckoutContainer.Name = "panelCheckoutContainer";
            this.panelCheckoutContainer.Size = new System.Drawing.Size(226, 57);
            this.panelCheckoutContainer.TabIndex = 15;
            // 
            // buttonCheckout
            // 
            this.buttonCheckout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCheckout.Location = new System.Drawing.Point(3, 3);
            this.buttonCheckout.Name = "buttonCheckout";
            this.buttonCheckout.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.buttonCheckout.Size = new System.Drawing.Size(220, 50);
            this.buttonCheckout.TabIndex = 13;
            this.buttonCheckout.Text = "CHECKOUT";
            this.buttonCheckout.UseVisualStyleBackColor = true;
            this.buttonCheckout.Click += new System.EventHandler(this.buttonCheckout_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(730, 735);
            this.panel2.TabIndex = 7;
            // 
            // cartpanel
            // 
            this.cartpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cartpanel.Controls.Add(this.TotalL);
            this.cartpanel.Controls.Add(this.flowLayoutPanel2);
            this.cartpanel.Controls.Add(this.buybtn);
            this.cartpanel.Controls.Add(this.buttonClearAll);
            this.cartpanel.Controls.Add(this.pictureBox8);
            this.cartpanel.Controls.Add(this.label31);
            this.cartpanel.Controls.Add(this.label30);
            this.cartpanel.Location = new System.Drawing.Point(1014, 58);
            this.cartpanel.Name = "cartpanel";
            this.cartpanel.Size = new System.Drawing.Size(360, 735);
            this.cartpanel.TabIndex = 8;
            // 
            // TotalL
            // 
            this.TotalL.AutoSize = true;
            this.TotalL.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalL.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TotalL.Location = new System.Drawing.Point(40, 666);
            this.TotalL.Name = "TotalL";
            this.TotalL.Size = new System.Drawing.Size(0, 32);
            this.TotalL.TabIndex = 13;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(3, 94);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(354, 537);
            this.flowLayoutPanel2.TabIndex = 11;
            // 
            // buybtn
            // 
            this.buybtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buybtn.BackColor = System.Drawing.Color.Red;
            this.buybtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buybtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buybtn.Location = new System.Drawing.Point(258, 662);
            this.buybtn.Name = "buybtn";
            this.buybtn.Size = new System.Drawing.Size(84, 43);
            this.buybtn.TabIndex = 10;
            this.buybtn.Text = "Buy";
            this.buybtn.UseVisualStyleBackColor = false;
            this.buybtn.Click += new System.EventHandler(this.buybtn_Click);
            // 
            // buttonClearAll
            // 
            this.buttonClearAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClearAll.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonClearAll.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonClearAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClearAll.Location = new System.Drawing.Point(258, 26);
            this.buttonClearAll.Name = "buttonClearAll";
            this.buttonClearAll.Size = new System.Drawing.Size(84, 43);
            this.buttonClearAll.TabIndex = 9;
            this.buttonClearAll.Text = "Clear";
            this.buttonClearAll.UseVisualStyleBackColor = false;
            this.buttonClearAll.Click += new System.EventHandler(this.buttonClearAll_Click);
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = global::shopix.Properties.Resources.shopping_cart;
            this.pictureBox8.Location = new System.Drawing.Point(15, 19);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(48, 50);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 5;
            this.pictureBox8.TabStop = false;
            // 
            // label31
            // 
            this.label31.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(69, 27);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(92, 42);
            this.label31.TabIndex = 4;
            this.label31.Text = "Cart";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(12, 646);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(51, 20);
            this.label30.TabIndex = 3;
            this.label30.Text = "Total";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(254, 58);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(6);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(744, 735);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // mainpanel
            // 
            this.mainpanel.BackColor = System.Drawing.Color.White;
            this.mainpanel.Controls.Add(this.panel2);
            this.mainpanel.Controls.Add(this.panelcheckout);
            this.mainpanel.Controls.Add(this.confirmbtn);
            this.mainpanel.Location = new System.Drawing.Point(254, 58);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1120, 735);
            this.mainpanel.TabIndex = 9;
            // 
            // panelcheckout
            // 
            this.panelcheckout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.panelcheckout.Controls.Add(this.checkoutname);
            this.panelcheckout.Controls.Add(this.checkoutprice);
            this.panelcheckout.Controls.Add(this.checkoutqty);
            this.panelcheckout.Controls.Add(this.subtotal);
            this.panelcheckout.Controls.Add(this.label5);
            this.panelcheckout.Controls.Add(this.label4);
            this.panelcheckout.Controls.Add(this.label3);
            this.panelcheckout.Controls.Add(this.label2);
            this.panelcheckout.Controls.Add(this.label1);
            this.panelcheckout.Controls.Add(this.flowLayoutCheckOut);
            this.panelcheckout.Location = new System.Drawing.Point(215, 0);
            this.panelcheckout.Name = "panelcheckout";
            this.panelcheckout.Size = new System.Drawing.Size(366, 729);
            this.panelcheckout.TabIndex = 1;
            // 
            // checkoutname
            // 
            this.checkoutname.AutoSize = true;
            this.checkoutname.Location = new System.Drawing.Point(9, 94);
            this.checkoutname.Name = "checkoutname";
            this.checkoutname.Size = new System.Drawing.Size(41, 16);
            this.checkoutname.TabIndex = 9;
            this.checkoutname.Text = "name";
            // 
            // checkoutprice
            // 
            this.checkoutprice.AutoSize = true;
            this.checkoutprice.Location = new System.Drawing.Point(323, 96);
            this.checkoutprice.Name = "checkoutprice";
            this.checkoutprice.Size = new System.Drawing.Size(37, 16);
            this.checkoutprice.TabIndex = 3;
            this.checkoutprice.Text = "price";
            // 
            // checkoutqty
            // 
            this.checkoutqty.AutoSize = true;
            this.checkoutqty.Location = new System.Drawing.Point(215, 96);
            this.checkoutqty.Name = "checkoutqty";
            this.checkoutqty.Size = new System.Drawing.Size(25, 16);
            this.checkoutqty.TabIndex = 8;
            this.checkoutqty.Text = "qty";
            // 
            // subtotal
            // 
            this.subtotal.AutoSize = true;
            this.subtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.subtotal.ForeColor = System.Drawing.Color.Black;
            this.subtotal.Location = new System.Drawing.Point(228, 615);
            this.subtotal.Name = "subtotal";
            this.subtotal.Size = new System.Drawing.Size(48, 25);
            this.subtotal.TabIndex = 7;
            this.subtotal.Text = "$$$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(3, 562);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(357, 36);
            this.label5.TabIndex = 6;
            this.label5.Text = "::::::::::::::::::::::::::::::::::::::";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(357, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "::::::::::::::::::::::::::::::::::::::";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(6, 609);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(145, 32);
            this.label3.TabIndex = 4;
            this.label3.Text = "Sub Total";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(111, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Confirm?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(81, 676);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(195, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "THANK YOU!";
            // 
            // flowLayoutCheckOut
            // 
            this.flowLayoutCheckOut.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.flowLayoutCheckOut.Location = new System.Drawing.Point(3, 115);
            this.flowLayoutCheckOut.Name = "flowLayoutCheckOut";
            this.flowLayoutCheckOut.Size = new System.Drawing.Size(360, 444);
            this.flowLayoutCheckOut.TabIndex = 0;
            // 
            // confirmbtn
            // 
            this.confirmbtn.BackColor = System.Drawing.Color.Red;
            this.confirmbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmbtn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.confirmbtn.Location = new System.Drawing.Point(714, 72);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(220, 50);
            this.confirmbtn.TabIndex = 13;
            this.confirmbtn.Text = "CONFIRM";
            this.confirmbtn.UseVisualStyleBackColor = false;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // panelBrowseContainer
            // 
            this.panelBrowseContainer.Controls.Add(this.buttonBrowse);
            this.panelBrowseContainer.Controls.Add(this.button3);
            this.panelBrowseContainer.Controls.Add(this.button4);
            this.panelBrowseContainer.Controls.Add(this.button5);
            this.panelBrowseContainer.Controls.Add(this.button6);
            this.panelBrowseContainer.Location = new System.Drawing.Point(12, 117);
            this.panelBrowseContainer.MaximumSize = new System.Drawing.Size(226, 281);
            this.panelBrowseContainer.MinimumSize = new System.Drawing.Size(226, 57);
            this.panelBrowseContainer.Name = "panelBrowseContainer";
            this.panelBrowseContainer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panelBrowseContainer.Size = new System.Drawing.Size(226, 57);
            this.panelBrowseContainer.TabIndex = 17;
            // 
            // buttonBrowse
            // 
            this.buttonBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBrowse.Location = new System.Drawing.Point(3, 3);
            this.buttonBrowse.Name = "buttonBrowse";
            this.buttonBrowse.Size = new System.Drawing.Size(220, 50);
            this.buttonBrowse.TabIndex = 12;
            this.buttonBrowse.Text = "BROWSE";
            this.buttonBrowse.UseVisualStyleBackColor = true;
            this.buttonBrowse.Click += new System.EventHandler(this.buttonBrowse_Click_1);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button3.Location = new System.Drawing.Point(3, 59);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(220, 50);
            this.button3.TabIndex = 13;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button4.Location = new System.Drawing.Point(3, 115);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(220, 50);
            this.button4.TabIndex = 14;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button5.Location = new System.Drawing.Point(3, 171);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(220, 50);
            this.button5.TabIndex = 15;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.button6.Location = new System.Drawing.Point(3, 227);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(220, 50);
            this.button6.TabIndex = 16;
            this.button6.Text = "button6";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // timerBrowse
            // 
            this.timerBrowse.Enabled = true;
            this.timerBrowse.Interval = 10;
            this.timerBrowse.Tick += new System.EventHandler(this.timerBrowse_Tick);
            // 
            // hopeForm2
            // 
            this.hopeForm2.ControlBoxColorH = System.Drawing.Color.FromArgb(((int)(((byte)(228)))), ((int)(((byte)(231)))), ((int)(((byte)(237)))));
            this.hopeForm2.ControlBoxColorHC = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.hopeForm2.ControlBoxColorN = System.Drawing.Color.White;
            this.hopeForm2.Cursor = System.Windows.Forms.Cursors.Default;
            this.hopeForm2.Dock = System.Windows.Forms.DockStyle.Top;
            this.hopeForm2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hopeForm2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(246)))), ((int)(((byte)(252)))));
            this.hopeForm2.Image = global::shopix.Properties.Resources.Shoppix_logo_transparent;
            this.hopeForm2.ImeMode = System.Windows.Forms.ImeMode.On;
            this.hopeForm2.Location = new System.Drawing.Point(0, 0);
            this.hopeForm2.MaximizeBox = false;
            this.hopeForm2.MinimizeBox = false;
            this.hopeForm2.Name = "hopeForm2";
            this.hopeForm2.Size = new System.Drawing.Size(1386, 40);
            this.hopeForm2.TabIndex = 4;
            this.hopeForm2.Text = "Shoppix";
            this.hopeForm2.ThemeColor = System.Drawing.Color.DarkSlateGray;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1386, 805);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panelBrowseContainer);
            this.Controls.Add(this.cartpanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.hopeForm2);
            this.Controls.Add(this.mainpanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1920, 1020);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(190, 40);
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Purple;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panelHomeContainer.ResumeLayout(false);
            this.panelCheckoutContainer.ResumeLayout(false);
            this.cartpanel.ResumeLayout(false);
            this.cartpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            this.mainpanel.ResumeLayout(false);
            this.panelcheckout.ResumeLayout(false);
            this.panelcheckout.PerformLayout();
            this.panelBrowseContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private ReaLTaiizor.Forms.HopeForm hopeForm2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel cartpanel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonCheckout;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.Button buttonClearAll;
        private System.Windows.Forms.Button buybtn;
        private System.Windows.Forms.Panel mainpanel;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panelHomeContainer;
        private System.Windows.Forms.Panel panelCheckoutContainer;
        private System.Windows.Forms.Panel panelBrowseContainer;
        private System.Windows.Forms.Button buttonBrowse;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Timer timerBrowse;
        public System.Windows.Forms.Label TotalL;
        private System.Windows.Forms.Panel panelcheckout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label subtotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label checkoutname;
        private System.Windows.Forms.Label checkoutprice;
        private System.Windows.Forms.Label checkoutqty;
        public System.Windows.Forms.FlowLayoutPanel flowLayoutCheckOut;
        private System.Windows.Forms.Button confirmbtn;
    }
}

