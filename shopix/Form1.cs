using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using shopix.usercontrol;
using System.Windows.Forms;
using System.Runtime.CompilerServices;
using System.Diagnostics;
using System.Security.Cryptography;
using System.Xml.Linq;

namespace shopix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mainpanel.Show();
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            panel2.Hide();
            panelcheckout.Hide();
            label7.Hide();
        }
        

        private void buttonHome_Click(object sender, EventArgs e)
        {
            mainpanel.Show();
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            panel2.Hide();
            panelcheckout.Hide();
            label7.Hide();

        }
        private void buttonBrowse_Click_1(object sender, EventArgs e)
        {

            timerBrowse.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainpanel.Hide();
            
            cartpanel.Show();
            flowLayoutPanel1.Show();
            panel2.Show();

            dynamicControl();
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

        bool BrowseExpand;
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
        

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            mainpanel.Show();
            panel2.Hide();
            label7.Show();
        }


        //dynamic user control
        private void dynamicControl()
        {
            flowLayoutPanel1.Controls.Clear();

            items[] listItems = new items[5];

            string[] titles = new string[5] { "camellya's armpit", "Vivian's nude", "Master shifu", "pyromaniac armpit", "summer chocolate", };
            string[] descriptions = new string[5] { "some juicy shit", "im hard rn", "very powerful ally", "smells like nitro fuel", "this is a supposed child wtf", };
            string[] price = new string[5] { "377.99", "739.99", "455.99", "599.99", "289.99", };
            Image[] icons = new Image[5] { Properties.Resources.camellya, Properties.Resources.me, Properties.Resources.menu, Properties.Resources.burnice, Properties.Resources.shopping_cart };

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

        private void button30_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();

            // Reset the total price
            UpdateTotalPrice();
        }

        private void buybtn_Click(object sender, EventArgs e)
        {
            panelcheckout.Show();
        }
    }
}
