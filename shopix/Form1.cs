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
            button3.Hide();
            button4.Hide();
            button5.Hide();
            button6.Hide();
            button7.Hide();
            mainpanel.Hide();
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

        private void button17_Click(object sender, EventArgs e)
        {
            cartpanel.Hide();
            flowLayoutPanel1.Hide();
            mainpanel.Show();
            panel2.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            cartpanel.Show();
            flowLayoutPanel1.Show();
            mainpanel.Hide();
            panel2.Show();
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

        private void button3_Click(object sender, EventArgs e)
        {
            dynamicControl();
        }

        private void button30_Click(object sender, EventArgs e)
        {
           
        }
    }
}
