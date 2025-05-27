using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace shopix.usercontrol
{
    public partial class checkoutpanel : UserControl
    {
        public checkoutpanel()
        {
            InitializeComponent();
        }

        #region Properties for the icon, name, description, and price

        private string cpname;
        private string cpquantity;
        private string cpPrice;

        [Category("Custom Props")]

        public string cName
        {
            get { return cpname; }
            set { cpname = value; nameCP.Text = value; }
        }

        [Category("Custom Props")]

        public string cQauntity
        {
            get { return cpquantity; }
            set { cpquantity = value; qtyCP.Text = value; }
        }

        [Category("Custom Props")]

        public string cPrice
        {
            get { return cpPrice; }
            set { cpPrice = value; priceCP.Text = value; }
        }

        #endregion

        private void label2_Click(object sender, EventArgs e)
        {

        }


    }
}
