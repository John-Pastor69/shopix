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

        #region dynamic user control

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


        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            mainpanel.Show();
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            panel2.Hide();
            panelcheckout.Hide();
            confirmbtn.Hide();
            ChangeButtonColor(buttonHome, Color.LightBlue);

        }
        
private void buttonHome_Click(object sender, EventArgs e)
        {
            mainpanel.Show();
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            panel2.Hide();
            panelcheckout.Hide();
            confirmbtn.Hide();

            // Change button color for Home button  
            ChangeButtonColor(buttonHome, Color.LightBlue);
            ChangeButtonColor(buttonBrowse, SystemColors.Control);
            ChangeButtonColor(buttonCheckout, SystemColors.Control);
        }

        private void buttonBrowse_Click_1(object sender, EventArgs e)
        {
            timerBrowse.Start();

            // Change button color for Browse button  
            ChangeButtonColor(buttonBrowse, Color.LightBlue);
            ChangeButtonColor(buttonHome, SystemColors.Control);
            ChangeButtonColor(buttonCheckout, SystemColors.Control);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mainpanel.Hide();
            
            cartpanel.Show();
            flowLayoutPanel1.Show();
            panel2.Show();

            dynamicControl();
        }

        private void buttonCheckout_Click(object sender, EventArgs e)
        {
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            mainpanel.Show();
            panel2.Hide();
            panelcheckout.Show();
            confirmbtn.Show();

            // Change button color for Checkout button  
            ChangeButtonColor(buttonCheckout, Color.LightBlue);
            ChangeButtonColor(buttonHome, SystemColors.Control);
            ChangeButtonColor(buttonBrowse, SystemColors.Control);
        }

        private void buttonClearAll_Click(object sender, EventArgs e)
        {
            flowLayoutPanel2.Controls.Clear();
            flowLayoutCheckOut.Controls.Clear();
            TotalL.Hide();
            // Reset the total price
            UpdateTotalPrice();
        }

        private void buybtn_Click(object sender, EventArgs e)
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
            panelcheckout.Hide();
            confirmbtn.Hide();
            flowLayoutPanel2.Controls.Clear();
            TotalL.Hide();


            //mag shoshow sana ng bagong panel na confimed reciept na

            //panelcheckout2.Show();
            //flowLayoutCheckOut2.Show();
            //subtotal2.Show();   
        }

        #region change button color method
        // A method that changes the button's color when clicked
        private void ChangeButtonColor(Button button, Color color)
        {
            if (button != null)
            {
                button.BackColor = color;
            }
        }
        #endregion
    }
}
