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
                    label2.Text = myString2;
                    mClick = false;
                }
                else
                {
                    q = q - 1;
                    string myString = q.ToString();
                    label2.Text = myString;
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
                label2.Text = myString;
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


            // store to setter in panelcart
            pc.iName = _name;
            pc.Price = _price;

            panelcart[] a = new panelcart[1];


            // store to array
            //string[] Name = new string[1] { pc.name.Text };
            //string[] price = new string[1] { pc.price.Text };

            string[] Name = new string[1] { pc.iName };
            string[] price = new string[1] { pc.Price };
            string[] quantity = new string[1] { "v" };

            

            // loop to flowlayout2
            for (int c = 0; c < a.Length; c++)
            {
                //store control object on list array
                a[c] = new panelcart();

                a[c].name.Text = Name[c];
                a[c].price.Text = price[c];

                f.flowLayoutPanel2.Controls.Add(a[c]);
            }

            MessageBox.Show(pc.name.Text);
            MessageBox.Show(pc.price.Text);

        }
    }
}
