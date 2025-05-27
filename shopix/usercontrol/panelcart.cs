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
        public event EventHandler ItemRemoved;
        public panelcart()
        {
            InitializeComponent();
        }

        #region Properties for the icon, name, description, and price

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
        public string iQuantity 
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


        private void button1_Click(object sender, EventArgs e)
        {
            int qty = Convert.ToInt32(quantity.Text);
            Form1 form = this.FindForm() as Form1;
            if (form == null) return;

            // Find the corresponding checkoutpanel
            checkoutpanel cp = null;
            foreach (Control ctrl in form.flowLayoutCheckOut.Controls)
            {
                if (ctrl is checkoutpanel panel && panel.cName == this.iName)
                {
                    cp = panel;
                    break;
                }
            }

            if (qty > 1)
            {
                qty--;
                quantity.Text = qty.ToString();
                this.iQuantity = qty.ToString();

                // Update checkoutpanel quantity
                if (cp != null)
                {
                    cp.qtyCP.Text = qty.ToString();
                    cp.cQauntity = qty.ToString();
                }

                form.UpdateTotalPrice();
            }
            else if (qty == 1)
            {
                // Remove this panel from the parent (i.e., the cart)
                form.flowLayoutPanel2.Controls.Remove(this);
                ItemRemoved?.Invoke(this, EventArgs.Empty); // Notify parent

                // Remove checkoutpanel as well
                if (cp != null)
                {
                    form.flowLayoutCheckOut.Controls.Remove(cp);
                    cp.Dispose();
                }

                form.UpdateTotalPrice();
            }
        }


        #endregion
    }
}
