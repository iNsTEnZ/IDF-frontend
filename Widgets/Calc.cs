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
        bool  firstNumber;
        Button[] operators;
        Button[] numbers;

        private void number_Click(object sender, EventArgs e)
        {

            if (this.firstNumber)
            {
                this.num1 = int.Parse(((Button)sender).Text);
                this.lbRes.Text += this.num1.ToString();
                changeButtonState(this.operators, true);
            }
            else
            {
                var a = (Button)sender;
                this.num2 = int.Parse(((Button)sender).Text);
                this.firstNumber = false;
                this.lbRes.Text += this.num2.ToString();
                changeButtonState(new Button[] { this.btnEqual }, true);
            }
        }

        private void operClick(object sender, EventArgs e)
        {
            this.oper = ((Button)sender).Text.ToCharArray()[0];
            this.lbRes.Text += oper;
            changeButtonState(this.operators, false);
            this.firstNumber = false;
            
        }

　
        private void btnEqual_Click(object sender, EventArgs e)
        {
            this.lbRes.Text += "=";
            changeButtonState(this.numbers, false);
            changeButtonState(new Button[] { this.btnEqual }, false);
        }

        public Calc()
        {
            InitializeComponent();
            this.firstNumber = true;
            this.operators = new Button[] { this.btnDiv,this.btnMinus,this.btnMul, this.btnPlus};
            this.numbers = new Button[] { this.button1, this.button2, this.button3, this.button4, this.button5, this.button6, this.button7, this.button8, this.button9, this.button0 };
            newCalc();
        }

        private void callAPI()
        {
            string response = Connect.SendRequest("http://localhost:8888/api/calc/?operator=" + this.oper + "?fvalue=" + this.num1 + "?lvalue=" + this.num2);
            // Check if the server returned a respond
            if (response != null)
            {
                // Parse it
                this.lbRes.Text += response;
            }

            else
            {
                MessageBox.Show("Error with input");
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            
            newCalc();
        }

        public void newCalc()
        {
            changeButtonState(this.operators, false);
            changeButtonState(new Button[] { this.btnEqual}, false);
            changeButtonState(this.numbers, true);
        }
        public void changeButtonState(Button[] arr,bool enabled)
        {
            foreach (var item in arr)
            {
                ((Button)item).Enabled = enabled;
            }
        }
    }
}
