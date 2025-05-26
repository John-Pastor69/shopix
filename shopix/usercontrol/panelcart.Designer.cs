namespace shopix.usercontrol
{
    partial class panelcart
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
            this.price = new System.Windows.Forms.Label();
            this.quantity = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.price);
            this.panel1.Controls.Add(this.quantity);
            this.panel1.Controls.Add(this.name);
            this.panel1.Location = new System.Drawing.Point(3, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 47);
            this.panel1.TabIndex = 0;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(295, 15);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(37, 16);
            this.price.TabIndex = 2;
            this.price.Text = "price";
            // 
            // quantity
            // 
            this.quantity.AutoSize = true;
            this.quantity.Location = new System.Drawing.Point(111, 15);
            this.quantity.Name = "quantity";
            this.quantity.Size = new System.Drawing.Size(53, 16);
            this.quantity.TabIndex = 1;
            this.quantity.Text = "quantity";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(3, 15);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(41, 16);
            this.name.TabIndex = 0;
            this.name.Text = "name";
            // 
            // panelcart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Name = "panelcart";
            this.Size = new System.Drawing.Size(354, 47);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label name;
        public System.Windows.Forms.Label price;
        public System.Windows.Forms.Label quantity;
    }
}
