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
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
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

           
        }

        private void parrotNavigationBar1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            button3.Show();
            button4.Show();
            button5.Show();
            button6.Show();
            button7.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
        }
    }
}
