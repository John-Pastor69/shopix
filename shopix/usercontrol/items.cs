using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopix.usercontrol
{
    public partial class items : UserControl
    {

        panelcart pc1 = new panelcart();


        public items()
        {
            InitializeComponent();
        }

        // Properties for the icon, name, description, and price

        private Image _icon;
        private string _name;
        private string _description;
        private string _price;

        [Category("Custom Props")]

        public Image Icon
        {
            get { return _icon; }
            set { _icon = value; icon.Image = value; }
        }

        [Category("Custom Props")]

        public string Name
        {
            get { return _name; }
            set { _name = value; name.Text = value; }
        }

        [Category("Custom Props")]

        public string Desc
        {
            get { return _description; }
            set { _description = value; desc.Text = value; }
        }

        public string Price
        {
            get { return _price; }
            set { _price = value; price.Text = value; }
        }

        // Quantity math

        int q = 1;
        bool mClick = false;

        private void btnMinus_Click_1(object sender, EventArgs e)
        {
            if (!mClick)
            {
                mClick = true;
                // if q is equal to 1, output is 1 else, continue to minus
                if (q == 1)
                {
                    int i = 1;
                    string myString2 = i.ToString();
                    Quantitylabel.Text = myString2;
                    mClick = false;
                }
                else
                {
                    q = q - 1;
                    string myString = q.ToString();
                    Quantitylabel.Text = myString;
                    mClick = false;
                }
            }
        }

        private void btnPlus_Click_1(object sender, EventArgs e)
        {
            if (!mClick)
            {
                mClick = true;
                q = q + 1;
                string myString = q.ToString();
                Quantitylabel.Text = myString;
                mClick = false;
            }
        }

        //dynamic control

        Form1 f = new Form1();
        panelcart pc = new panelcart();
        private void dynamicControl()
        {
            // no quantity yet

            // store items to cart


        }

        private void btnAddCart_Click(object sender, EventArgs e)
        {

            Form1 f = this.FindForm() as Form1;
            if (f == null) return;

            bool itemExists = false;

            for (int i = 0; i < f.flowLayoutPanel2.Controls.Count; i++)
            {
                Control ctrl = f.flowLayoutPanel2.Controls[i];
                if (ctrl is panelcart)
                {
                    panelcart existingPanel = (panelcart)ctrl;

                    if (existingPanel.iName == _name)
                    {
                        int oldQty = Convert.ToInt32(existingPanel.quantity.Text);
                        int newQty = oldQty + q;
                        existingPanel.quantity.Text = newQty.ToString();

                        itemExists = true;
                        break;
                    }
                }
            }

            if (!itemExists)
            {
                panelcart pc1 = new panelcart();

                pc1.iName = _name;
                pc1.Price = _price;
                pc1.quantity.Text = q.ToString();

                pc1.name.Text = _name;
                pc1.price.Text = _price;

                pc1.Visible = true;
                f.flowLayoutPanel2.Controls.Add(pc1);

                
            }

        }
    }
 }
