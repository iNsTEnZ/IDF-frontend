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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            // Set form and combo box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Set the transperaty of the widget
            this.Opacity = 0.8;

            Connect.CLIENT = new System.Net.WebClient();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Connect.CLIENT.Dispose();
            this.Close();
        }

        private void btnWeather_Click(object sender, EventArgs e)
        {
            Weather wtr = new Weather();
            wtr.Show();
        }

        private void btnStocks_Click(object sender, EventArgs e)
        {
            Stocks stck = new Stocks();
            stck.Show();
        }

        private void btnBooks_Click(object sender, EventArgs e)
        {
            Books bk = new Books();
            bk.Show();
        }

        private void btnClock_Click(object sender, EventArgs e)
        {
            Clocks clck = new Clocks();
            clck.Show();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            Calculator calc = new Calculator();
            calc.Show();
        }
    }
}
