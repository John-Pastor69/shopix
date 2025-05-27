using shopix.usercontrol;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace shopix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Inserting data into DB

        private void InsertProduct()
        {
            string consTring = "Data Source=LAPTOP-7VOGQI5Q\\SQLEXPRESS;Initial Catalog=DB_Shoppix;Integrated Security=True;TrustServerCertificate=True";

            Image img = Properties.Resources.burnice;

            // Convert image to byte[]
            byte[] imgBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                imgBytes = ms.ToArray();
            }


            // Insert into database
            using (SqlConnection con = new SqlConnection(consTring))
            {
                string query = "INSERT INTO Product (Product_ID, Product, Price, Stock, Description, Image_pic, Category_ID) " +
                               "VALUES (@Pid, @name, @price, @stock, @desc, @img, @cat)";

                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Pid", 30);
                cmd.Parameters.AddWithValue("@name", "La Serenísima Yogurt Drink");
                cmd.Parameters.AddWithValue("@price", 67);
                cmd.Parameters.AddWithValue("@stock", 100);
                cmd.Parameters.AddWithValue("@desc", "Flavored yogurt drink imported from Argentina.");
                cmd.Parameters.AddWithValue("@img", imgBytes);
                cmd.Parameters.AddWithValue("@cat", 1);

                /* •	Selecta Moo Chocolate Milk – Chocolate-flavored UHT milk, a popular kids’ drink. (₱25/200ml) 
                   •	Dutch Mill Yogurt Drink – Probiotic milk drink with fruity flavors; good for digestion. (₱10/90ml) 
                   •	Magnolia Gold Butter – Premium-quality dairy butter, ideal for baking and spreads. (₱170/225g) 
                   •	Nestlé Cream – All-purpose cream used in Filipino salads and desserts. (₱60/250ml) 
                   •	Arla Cream Cheese – Soft, spreadable cream cheese, great for baking and dips. (₱140/230g) 
                   •	NESTLÉ Greek Yogurt – Thick and creamy yogurt, available in plain and flavored varieties. (₱50/100g) 
                   7.	Kraft Eden Cheese – Filipino staple processed cheese block. (₱55/165g) 
                   5.	La Serenísima Yogurt Drink – Flavored yogurt drink imported from Argentina. (₱35/200ml) 

                  */

                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Product saved with resource image.");
            }
        }

        #endregion

        #region Update Total Price Method

        public void UpdateTotalPrice()
        {
            decimal total = 0;

            for (int i = 0; i < flowLayoutPanel2.Controls.Count; i++)
            {
                Control ctrl = flowLayoutPanel2.Controls[i];
                if (ctrl is shopix.usercontrol.panelcart)
                {
                    shopix.usercontrol.panelcart cartItem = (shopix.usercontrol.panelcart)ctrl;

                    decimal price = 0;
                    int qty = 0;

                    // Safely parse price and quantity
                    decimal.TryParse(cartItem.price.Text, out price);
                    int.TryParse(cartItem.quantity.Text, out qty);

                    total += price * qty;
                }
            }
            TotalL.Text = ": ₱" + total.ToString("0.00");
            subtotal.Text = ": ₱" + total.ToString("0.00");

        }


        #endregion

        #region browse panel expand/collapse

        bool BrowseExpand;

        public void ShowBrowsePanel()
        {
            buttonBrowse_Click_1(this, EventArgs.Empty);
        }


        private void timerBrowse_Tick(object sender, EventArgs e)
        {
            if (BrowseExpand)  //if BrowseExpand is true, expand the panel
            {
                panelBrowseContainer.Height += 10;
                if (panelBrowseContainer.Height == panelBrowseContainer.MaximumSize.Height)
                {
                    BrowseExpand = false;
                    timerBrowse.Stop();
                }
            }
            else  // if BrowseExpand is false, collapse the panel
            {
                panelBrowseContainer.Height -= 10;
                if (panelBrowseContainer.Height == panelBrowseContainer.MinimumSize.Height)
                {
                    BrowseExpand = true;
                    timerBrowse.Stop();
                }
            }
            // Move the panel below to follow the expanding/collapsing panel

            panelCheckoutContainer.Top = panelBrowseContainer.Bottom - 45;
        }


        #endregion


        #region
        private void dynamicControl(int categoryId)
        {
            flowLayoutPanel1.Controls.Clear();
            List<items> listItems = new List<items>();

            using (SqlConnection con = new SqlConnection("Data Source=LAPTOP-7VOGQI5Q\\SQLEXPRESS;Initial Catalog=DB_Shoppix;Integrated Security=True;TrustServerCertificate=True"))
            {
                string query = "SELECT Product, Description, Price, Image_pic FROM Product WHERE Category_ID = @Category_ID";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Category_ID", categoryId);

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    items itemControl = new items();

                    itemControl.Name = reader["Product"].ToString();
                    itemControl.Desc = reader["Description"].ToString();
                    itemControl.Price = reader["Price"].ToString();

                    if (reader["Image_pic"] != DBNull.Value)
                    {
                        byte[] imgBytes = (byte[])reader["Image_pic"];
                        using (MemoryStream ms = new MemoryStream(imgBytes))
                        {
                            itemControl.Icon = Image.FromStream(ms);
                        }
                    }

                    listItems.Add(itemControl);
                }

                con.Close();

                for (int i = 0; i < listItems.Count; i++)
                {
                    flowLayoutPanel1.Controls.Add(listItems[i]);
                }

            }
        }



        #endregion


        public void CartItem_ItemRemoved(object sender, EventArgs e)
        {
            panelcart removedItem = sender as panelcart;
            if (removedItem != null)
            {
                // Remove the corresponding checkoutpanel item
                for (int i = flowLayoutCheckOut.Controls.Count - 1; i >= 0; i--)
                {
                    Control ctrl = flowLayoutCheckOut.Controls[i];
                    if (ctrl is checkoutpanel cp && cp.cName == removedItem.iName)
                    {
                        flowLayoutCheckOut.Controls.Remove(cp);
                        cp.Dispose();
                        break;
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelhome.Show();
            mainpanel.Hide();
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            panel2.Hide();
            panelcheckout.Hide();
            confirmbtn.Hide();

            // Corrected: Use the ChangeButtonColor method from the Form1 class
            ChangeButtonColor(buttonHome, Color.LightBlue);
        }
        #region Products category Buttons
        // Add this helper method to your class
        private void ResetCategoryButtonColors()
        {
            ChangeButtonColor(buttonCanGoods, SystemColors.Control);
            ChangeButtonColor(buttonSnack, SystemColors.Control);
            ChangeButtonColor(buttonGrainsandCereal, SystemColors.Control);
            ChangeButtonColor(buttonDairy, SystemColors.Control);
        }

        // Update your main navigation button handlers to reset category colors
        private void buttonHome_Click(object sender, EventArgs e) // Home button
        {
            panelhome.Show();
            mainpanel.Hide();
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            panel2.Hide();
            panelcheckout.Hide();
            confirmbtn.Hide();
            buttonStart.Show();

            ChangeButtonColor(buttonHome, Color.LightBlue);
            ChangeButtonColor(buttonBrowse, SystemColors.Control);
            ChangeButtonColor(buttonCheckout, SystemColors.Control);
            ResetCategoryButtonColors();
        }

        private void buttonCheckout_Click(object sender, EventArgs e) // Checkout button
        {
            panelhome.Hide();
            buttonStart.Hide();
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            mainpanel.Show();
            panel2.Hide();
            panelcheckout.Show();
            confirmbtn.Show();

            ChangeButtonColor(buttonCheckout, Color.LightBlue);
            ChangeButtonColor(buttonHome, SystemColors.Control);
            ChangeButtonColor(buttonBrowse, SystemColors.Control);
            ResetCategoryButtonColors(); 
        }

        private void buttonBrowse_Click_1(object sender, EventArgs e) // Browse button
        {
            panelhome.Hide();
            buttonStart.Hide();
            panelcheckout.Hide();
            buttonBrowse.Show();
            timerBrowse.Start();
            buttonCanGoods.PerformClick();

            // Change button color for Browse button  
            ChangeButtonColor(buttonBrowse, Color.LightBlue);
            ChangeButtonColor(buttonHome, SystemColors.Control);
            ChangeButtonColor(buttonCheckout, SystemColors.Control);
        }

        private void ChangeCategoryButtonColor(Button activeButton) // Method to change the color of the active category button
        {
            // Reset all category buttons to default color
            ChangeButtonColor(buttonCanGoods, SystemColors.Control);
            ChangeButtonColor(buttonSnack, SystemColors.Control);
            ChangeButtonColor(buttonGrainsandCereal, SystemColors.Control);
            ChangeButtonColor(buttonDairy, SystemColors.Control);

            // Set the active button to highlighted color
            ChangeButtonColor(activeButton, Color.LightBlue);

            // Also highlight the Browse button
            ChangeButtonColor(buttonBrowse, Color.LightBlue);
            // Reset Home and Checkout buttons
            ChangeButtonColor(buttonHome, SystemColors.Control);
            ChangeButtonColor(buttonCheckout, SystemColors.Control);
        }

        private void buttonCanGoods_Click(object sender, EventArgs e) // Can Goods button
        {
            panelhome.Hide();
            mainpanel.Hide();
            buttonStart.Hide();
            cartpanel.Show();
            flowLayoutPanel1.Show();
            panel2.Show();

            dynamicControl(2);
            ChangeCategoryButtonColor(buttonCanGoods);
        }

        private void buttonSnack_Click(object sender, EventArgs e) // Snack button
        {
            panelhome.Hide();
            mainpanel.Hide();
            buttonStart.Hide();
            cartpanel.Show();
            flowLayoutPanel1.Show();
            panel2.Show();

            dynamicControl(3);
            ChangeCategoryButtonColor(buttonSnack);
        }

        private void buttonGrainsandCereal_Click(object sender, EventArgs e) // Grains and Cereal button
        {
            panelhome.Hide();
            mainpanel.Hide();
            buttonStart.Hide();
            cartpanel.Show();
            flowLayoutPanel1.Show();
            panel2.Show();

            dynamicControl(4);
            ChangeCategoryButtonColor(buttonGrainsandCereal);
        }

        private void buttonDairy_Click(object sender, EventArgs e) // Dairy button
        {
            panelhome.Hide();
            mainpanel.Hide();
            buttonStart.Hide();
            cartpanel.Show();
            flowLayoutPanel1.Show();
            panel2.Show();

            dynamicControl(1);
            ChangeCategoryButtonColor(buttonDairy);
        }
        #endregion
                
        private void buttonClearAll_Click(object sender, EventArgs e) // Clear all button
        {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutCheckOut.Controls.Clear();
            TotalL.Hide();
            // Reset the total price
            UpdateTotalPrice();
        }

        private void buybtn_Click(object sender, EventArgs e) //BUY button
        {
            panelcheckout.Show();
            TotalL.Show();
            confirmbtn.Show();
            // Simulate a button press on the checkout tab button  
            buttonCheckout.PerformClick();
        }

        private void confirmbtn_Click(object sender, EventArgs e)
        {
            flowLayoutCheckOut.Controls.Clear();
            this.confirmbtn.Hide(); // Ensure 'confirmbtn' is a member of the Form1 class  
            flowLayoutPanel2.Controls.Clear();
            TotalL.Hide();

            // Placeholder for showing a new panel for confirmed receipt  
            // panelcheckout2.Show();  
            // flowLayoutCheckOut2.Show();  
            // subtotal2.Show();  
        }

        
        // A method that changes the button's color when clicked
        private void ChangeButtonColor(Button button, Color color)
        {
            if (button != null)
            {
                button.BackColor = color;
            }
        }


        private void buttonStart_Click_1(object sender, EventArgs e)
        {
            buttonBrowse.PerformClick();    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            buttonBrowse.PerformClick();
        }
    }
}
