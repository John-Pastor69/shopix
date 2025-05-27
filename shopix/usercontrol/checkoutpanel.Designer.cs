namespace shopix.usercontrol
{
    partial class checkoutpanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.nameCP = new System.Windows.Forms.Label();
            this.qtyCP = new System.Windows.Forms.Label();
            this.priceCP = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.panel1.Controls.Add(this.priceCP);
            this.panel1.Controls.Add(this.qtyCP);
            this.panel1.Controls.Add(this.nameCP);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(360, 36);
            this.panel1.TabIndex = 0;
            // 
            // nameCP
            // 
            this.nameCP.AutoSize = true;
            this.nameCP.Location = new System.Drawing.Point(3, 9);
            this.nameCP.Name = "nameCP";
            this.nameCP.Size = new System.Drawing.Size(41, 16);
            this.nameCP.TabIndex = 0;
            this.nameCP.Text = "name";
            // 
            // qtyCP
            // 
            this.qtyCP.AutoSize = true;
            this.qtyCP.Location = new System.Drawing.Point(203, 9);
            this.qtyCP.Name = "qtyCP";
            this.qtyCP.Size = new System.Drawing.Size(25, 16);
            this.qtyCP.TabIndex = 1;
            this.qtyCP.Text = "qty";
            this.qtyCP.Click += new System.EventHandler(this.label2_Click);
            // 
            // priceCP
            // 
            this.priceCP.AutoSize = true;
            this.priceCP.Location = new System.Drawing.Point(287, 9);
            this.priceCP.Name = "priceCP";
            this.priceCP.Size = new System.Drawing.Size(37, 16);
            this.priceCP.TabIndex = 2;
            this.priceCP.Text = "price";
            // 
            // checkoutpanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "checkoutpanel";
            this.Size = new System.Drawing.Size(360, 35);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label qtyCP;
        public System.Windows.Forms.Label nameCP;
        public System.Windows.Forms.Label priceCP;
    }
}
