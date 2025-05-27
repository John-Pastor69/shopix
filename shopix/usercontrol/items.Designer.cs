namespace shopix.usercontrol
{
    partial class items
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Items_Quantitylabel = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.btnPlus = new System.Windows.Forms.Button();
            this.icon = new System.Windows.Forms.PictureBox();
            this.name = new System.Windows.Forms.Label();
            this.desc = new System.Windows.Forms.Label();
            this.btnAddCart = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.Goldenrod;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.Items_Quantitylabel);
            this.panel2.Controls.Add(this.price);
            this.panel2.Controls.Add(this.btnPlus);
            this.panel2.Controls.Add(this.icon);
            this.panel2.Controls.Add(this.name);
            this.panel2.Controls.Add(this.desc);
            this.panel2.Controls.Add(this.btnAddCart);
            this.panel2.Controls.Add(this.btnMinus);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 179);
            this.panel2.TabIndex = 9;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Location = new System.Drawing.Point(0, 267);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(505, 3);
            this.panel3.TabIndex = 9;
            // 
            // Items_Quantitylabel
            // 
            this.Items_Quantitylabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Items_Quantitylabel.BackColor = System.Drawing.Color.White;
            this.Items_Quantitylabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.Items_Quantitylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items_Quantitylabel.Location = new System.Drawing.Point(217, 145);
            this.Items_Quantitylabel.Margin = new System.Windows.Forms.Padding(3);
            this.Items_Quantitylabel.Name = "Items_Quantitylabel";
            this.Items_Quantitylabel.Size = new System.Drawing.Size(50, 23);
            this.Items_Quantitylabel.TabIndex = 8;
            this.Items_Quantitylabel.Text = "1";
            this.Items_Quantitylabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Location = new System.Drawing.Point(158, 44);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(37, 16);
            this.price.TabIndex = 7;
            this.price.Text = "price";
            // 
            // btnPlus
            // 
            this.btnPlus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlus.Location = new System.Drawing.Point(273, 148);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(70, 20);
            this.btnPlus.TabIndex = 5;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click_1);
            // 
            // icon
            // 
            this.icon.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.icon.Location = new System.Drawing.Point(3, 3);
            this.icon.Name = "icon";
            this.icon.Size = new System.Drawing.Size(136, 123);
            this.icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.icon.TabIndex = 0;
            this.icon.TabStop = false;
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Location = new System.Drawing.Point(158, 12);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(93, 16);
            this.name.TabIndex = 1;
            this.name.Text = "product NAem";
            // 
            // desc
            // 
            this.desc.AutoSize = true;
            this.desc.Location = new System.Drawing.Point(158, 78);
            this.desc.Name = "desc";
            this.desc.Size = new System.Drawing.Size(37, 16);
            this.desc.TabIndex = 2;
            this.desc.Text = "desc";
            // 
            // btnAddCart
            // 
            this.btnAddCart.Location = new System.Drawing.Point(13, 132);
            this.btnAddCart.Name = "btnAddCart";
            this.btnAddCart.Size = new System.Drawing.Size(111, 38);
            this.btnAddCart.TabIndex = 3;
            this.btnAddCart.Text = "Add to Cart";
            this.btnAddCart.UseVisualStyleBackColor = true;
            this.btnAddCart.Click += new System.EventHandler(this.btnAddCart_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMinus.Location = new System.Drawing.Point(141, 148);
            this.btnMinus.Margin = new System.Windows.Forms.Padding(3, 8, 3, 3);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(70, 20);
            this.btnMinus.TabIndex = 4;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click_1);
            // 
            // items
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel2);
            this.Name = "items";
            this.Size = new System.Drawing.Size(357, 179);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.icon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label Items_Quantitylabel;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.PictureBox icon;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.Label desc;
        private System.Windows.Forms.Button btnAddCart;
        private System.Windows.Forms.Button btnMinus;
    }
}
