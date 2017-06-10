using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widgets
{
    public partial class Calculator : Form
    {
        public string op { get; set; }
        public string od1 { get; set; }
        public string od2 { get; set; }

        private bool flage;

        public Calculator()
        {
            InitializeComponent();

            // Set form and combo box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Set the transperaty of the widget
            this.Opacity = 0.8;

            this.op = "";
            this.od1 = "";
            this.od2 = "";
        }

        // Creates rounded corners
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect, // x-coordinate of upper-left corner
            int nTopRect, // y-coordinate of upper-left corner
            int nRightRect, // x-coordinate of lower-right corner
            int nBottomRect, // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
         );

        // Closes the form
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {

            this.lblCalc.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "6";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "3";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += ".";
            this.btnDot.Enabled = false;
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            if (this.op == string.Empty)
            {
                this.od1 = this.lblCalc.Text;
            }
            else
            {
                this.lblCalc.Text = this.lblCalc.Text.Substring(0, this.lblCalc.Text.Length - 3);
            }

            this.op = "div";
            this.lblCalc.Text += " ÷ ";
            this.btnDot.Enabled = true;
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            if (this.op == string.Empty)
            {
                this.od1 = this.lblCalc.Text;
            }
            else
            {
                this.lblCalc.Text = this.lblCalc.Text.Substring(0, this.lblCalc.Text.Length - 3);
            }

            this.op = "mul";
            this.lblCalc.Text += " x ";
            this.btnDot.Enabled = true;
        }

        private void btnSub_Click(object sender, EventArgs e)
        {
            if (this.op == string.Empty)
            {
                this.od1 = this.lblCalc.Text;
            }
            else
            {
                this.lblCalc.Text = this.lblCalc.Text.Substring(0, this.lblCalc.Text.Length - 3);
            }

            this.op = "sub";
            this.lblCalc.Text += " - ";
            this.btnDot.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.op == string.Empty)
            {
                this.od1 = this.lblCalc.Text;
            }
            else
            {
                this.lblCalc.Text = this.lblCalc.Text.Substring(0, this.lblCalc.Text.Length - 3);
            }

            this.op = "add";
            this.lblCalc.Text += " + ";
            this.btnDot.Enabled = true;
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            this.op = "";
            this.od1 = "";
            this.od2 = "";
            this.lblCalc.Text = "";
            this.handelControls(this, true);

        }

        private void btnRes_Click(object sender, EventArgs e)
        {
            if ((this.od1 != string.Empty) && (this.op != "") && (this.lblCalc.Text[this.lblCalc.Text.Length - 1] != '.'))
            {
                this.od2 = this.lblCalc.Text.Split(' ')[2];

                string response = Connect.SendRequest("http://localhost:8888/api/calculator/?operand1=" + this.od1 +
                                                      "&operator=" + this.op + "&operand2=" + this.od2);

                // Check if there was a response
                if (response != string.Empty)
                {
                    this.lblCalc.Text = response;
                    this.handelControls(this, false);
                    this.enableControl(btnExit);
                    this.enableControl(btnClear);
                }
            }
        }

        private void handelControls(Control con, bool toDo)
        {
            foreach (Control c in con.Controls)
            {
                handelControls(c, toDo);
            }
            con.Enabled = toDo;
        }

        private void enableControl(Control con)
        {
            if (con != null)
            {
                con.Enabled = true;
                enableControl(con.Parent);
            }
        }
    }
}
