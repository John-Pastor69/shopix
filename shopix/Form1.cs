using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void mouse_enter (object sender, EventArgs e)
        {
            this.ForeColor = Color.LightGray;
        }

        private void mouse_click(object sender, EventArgs e)
        {
            this.BackColor = Color.DarkOrange;
        }

        private void parrotNavigationBar1_MouseHover(object sender, EventArgs e)
        {
            this.ForeColor = Color.LightGray;
        }

        private void parrotNavigationBar1_MouseEnter(object sender, EventArgs e)
        {
            this.ForeColor = Color.DarkOrange;
        }
    }
}
