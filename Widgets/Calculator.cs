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

        public Calculator()
        {
            InitializeComponent();

            // Set form and combo box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Set the transperaty of the widget
            this.Opacity = 0.8;

            this.op  = "";
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

        // Adds a number to the expression
        private void num_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += (sender as Button).Text;
        }

        // Adds a dot, and prevents from writting double dots
        private void btnDot_Click(object sender, EventArgs e)
        {
            this.lblCalc.Text += ".";
            this.btnDot.Enabled = false;
        }

        // Changes the operator according to the button 
        private void op_Click(object sender, EventArgs e)
        {
            // Checks that the operator is not the first to be inserted
            if (this.lblCalc.Text != string.Empty)
            {
                char lastChar = this.lblCalc.Text[this.lblCalc.Text.Length - 1];

                // Will update the operator if one of these conditions will take place:
                // 1. The last inserted char is a number and there isn't an operator char (the expression isn't complete)
                // 2. The last inserted char is an operator (the operator is wished to be changed) 
                if (((Char.IsNumber(lastChar)) && (lblCalc.Text.IndexOfAny("+-x÷".ToCharArray()) == -1)) || 
                    ("+-x÷".IndexOf(lastChar) != -1))
                {
                    // Check if it's the first time chosing an operator
                    if (this.op == string.Empty)
                    {
                        // save first operand
                        this.od1 = this.lblCalc.Text;
                    }

                    // changing operator - deletes the previous one
                    else
                    {
                        this.lblCalc.Text = this.lblCalc.Text.Substring(0, this.lblCalc.Text.Length - 1);
                    }

                    // Set the operator
                    this.op = (sender as Button).Text;
                    this.lblCalc.Text += (sender as Button).Text;
                    this.btnDot.Enabled = true;
                }
            }
        }

        // Rests form
        private void btnClear_Click(object sender, EventArgs e)
        {
            this.op = "";
            this.od1 = "";
            this.od2 = "";
            this.lblCalc.Text = "";
            this.handelControls(this, true);

        }

        // Calculates the insereted experssion
        private void btnRes_Click(object sender, EventArgs e)
        {
            // Checks a complete expression was insert
            if ((this.od1 != string.Empty) && (this.op != "") && (this.lblCalc.Text[this.lblCalc.Text.Length - 1] != '.'))
            {
                // Get the second operator
                int start  = this.lblCalc.Text.IndexOfAny("+-x÷".ToCharArray()) + 1;
                int length = this.lblCalc.Text.Length - start;
                this.od2   = this.lblCalc.Text.Substring(start,length);

                // Format operator to server understandable format
                switch (this.op)
                {
                    case "+":
                        this.op = "add";
                        break;
                    case "-":
                        this.op = "sub";
                        break;
                    case "x":
                        this.op = "mul";
                        break;
                    case "÷":
                        this.op = "div";
                        break;
                }

                // Send expression to server to calculate answer
                string response = Connect.SendRequest("http://localhost:8888/api/calculator/?operand1=" + this.od1 +
                                                      "&operator=" + this.op + "&operand2=" + this.od2);

                // Check if there was a response and display it
                if (response != null)
                {
                    this.lblCalc.Text = response;
                    this.handelControls(this, false);
                    this.enableControl(btnExit);
                    this.enableControl(btnClear);
                }
            }
        }

        // Enables or disables controls con according to toDO
        private void handelControls(Control con, bool toDo)
        {
            foreach (Control c in con.Controls)
            {
                handelControls(c, toDo);
            }
            con.Enabled = toDo;
        }

        // Enables a control and all it's parent controls
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
