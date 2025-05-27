using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace shopix.usercontrol
{
    public partial class panelcart : UserControl
    {
        public panelcart()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(quantity.Text);

            if (qty >= 1)
            {
                qty--;
                quantity.Text = qty.ToString();
            }
            else
            {
                // Remove this panel from the parent (i.e., the cart)
                Form1 f = this.FindForm() as Form1;
                if (f != null)
                {
                    f.flowLayoutPanel2.Controls.Remove(this);
                }
            }

            // Always update total price after quantity change or removal
            Form1 form = this.FindForm() as Form1;
            if (form != null)
            {
                form.UpdateTotalPrice();
            }
        }

        // Properties for the icon, name, description, and price

        private string pcname;
        private string pcquantity;
        private string pcprice;

        [Category("Custom Props")]

        public string iName
        {
            get { return pcname; }
            set { pcname = value; name.Text = value; }
        }

        [Category("Custom Props")]

        public string iQauntity
        {
            get { return pcquantity; }
            set { pcquantity = value; quantity.Text = value; }
        }

        [Category("Custom Props")]

        public string iPrice
        {
            get { return pcprice; }
            set { pcprice = value; price.Text = value; }
        }

        
    }
}
