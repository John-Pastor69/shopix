using shopix.Properties;
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
using System.Media;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml.Schema;

namespace shopix
{
    public partial class Form1 : Form
    {

        private void InsertProduct()
        {
            string consTring = "Data Source=LAPTOP-7VOGQI5Q\\SQLEXPRESS;Initial Catalog=DB_Shoppix;Integrated Security=True;TrustServerCertificate=True";

            // Get image from WinForms resources (replace with your resource name)
            Image imageFromResources = Properties.Resources.burnice;

            // Convert the image to byte array
            byte[] imageBytes;
            using (MemoryStream ms = new MemoryStream())
            {
                imageFromResources.Save(ms, imageFromResources.RawFormat);
                imageBytes = ms.ToArray();
            }

            using (SqlConnection conn = new SqlConnection(consTring))
            {
                string query = @"INSERT INTO Product (Product_ID, Product, Price, Stock, Description, Image_pic, Category_ID)
                         VALUES (@Product_ID, @Product, @Price, @Stock, @Description, @Image_pic, @Category_ID)";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Product_ID", 1);
                    cmd.Parameters.AddWithValue("@Product", "Coke");
                    cmd.Parameters.AddWithValue("@Price", 99);
                    cmd.Parameters.AddWithValue("@Stock", 50);
                    cmd.Parameters.AddWithValue("@Description", "This is a test product.");
                    cmd.Parameters.Add("@Image_pic", SqlDbType.Image).Value = imageBytes;
                    cmd.Parameters.AddWithValue("@Category_ID", 1);  // Ensure this ID exists in your Category table

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Product inserted successfully!");
                }
            }
        }
        


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
        }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            mainpanel.Hide();

            InsertProduct();

     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();

            SoundPlayer sp = new SoundPlayer(Resources.yamete   );
            //sp.Play();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            mainpanel.Show();
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartpanel.Show();
            flowLayoutPanel1.Show();
            mainpanel.Hide();
            panel2.Show();
        }

        
        //dynamic user control
        private void dynamicControl()
        {
            flowLayoutPanel1.Controls.Clear();

            items[] listItems = new items[5];

            string[] titles = new string[5] { "camellya's armpit", "Vivian's nude", "Master shifu", "pyromaniac armpit", "summer chocolate", };
            string[] descriptions = new string[5] { "some juicy shit", "im hard rn", "very powerful ally", "smells like nitro fuel", "this is a supposed child wtf", };
            string[] price = new string[5] { "377.99", "739.99", "455.99", "599.99", "289.99", };
            Image[] icons = new Image[5] { Properties.Resources.camellya, Properties.Resources.vivian, Properties.Resources.master, Properties.Resources.burnice, Properties.Resources.iori };

            for (int i = 0; i < listItems.Length; i++)
            {
                //store control object on list array
                listItems[i] = new items();

                listItems[i].Name = titles[i];
                listItems[i].Desc = descriptions[i];
                listItems[i].Price = price[i];
                listItems[i].Icon = icons[i];

                flowLayoutPanel1.Controls.Add(listItems[i]);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Item button

            SoundPlayer sp = new SoundPlayer(Resources.daddy);
            //sp.Play();
            dynamicControl();
           
        }

        private void button30_Click(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer(Resources.anime);
            //sp.Play();
            flowLayoutPanel2.Controls.Clear();

            // Reset the total price
            UpdateTotalPrice();

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
