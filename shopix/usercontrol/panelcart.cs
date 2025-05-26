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

        public string Qauntity
        {
            get { return pcquantity; }
            set { pcquantity = value; quantity.Text = value; }
        }

        public string Price
        {
            get { return pcprice; }
            set { pcprice = value; price.Text = value; }
        }

    }
}
