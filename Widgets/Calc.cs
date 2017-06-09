using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widgets
{
    public partial class Calc : Form
    {
        int num1, num2;
        char oper;
        bool num1Flag = false, operFlag = false;

        private void number_Click(object sender, EventArgs e)
        {

            if (this.num1Flag)
            {
                this.num1 = int.Parse(((Button)sender).Text);
                this.num1Flag = true;
                this.lbRes.Text = this.num1.ToString();
            }
            else
            {
                var a = (Button)sender;
                this.num2 = int.Parse(((Button)sender).Text);
                this.num1Flag = false;
                this.lbRes.Text += this.num2.ToString();
            }
        }

        private void operClick(object sender, EventArgs e)
        {
            this.oper = ((Button)sender).Text.ToCharArray()[0];
            this.lbRes.Text += oper;
            //this.Enabled = false;
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }

        public Calc()
        {
            InitializeComponent();
        }
    }
}
