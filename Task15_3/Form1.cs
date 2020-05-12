using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task15_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            button1.Text = "PUSH";
            button1.Width = 150;
            button1.Height = 100;

        }
        int a = 0;
        private void Button1_Click(object sender, EventArgs e)
        {
            switch (a)
            {
                case 0:
                    button1.Text = "You pushed me";
                    a = 1;
                    break;
                case 1:
                    this.Close();
                    break;
            }
        }
    }
}
