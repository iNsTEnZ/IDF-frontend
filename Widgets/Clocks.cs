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
    public partial class Clocks : Form
    {
        Timer t = new Timer();

        public Clocks()
        {
            InitializeComponent();

            // Set form and combo box corners to be round
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            // Set the transperaty of the widget
            this.Opacity = 0.9;
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

        private void Clocks_Load(object sender, EventArgs e)
        {
            // Timer interval in milliseconds
            t.Interval = 1000;

            t.Tick += new EventHandler(this.t_Tick);

            // Start timer when form loads
            t.Start();
        }

        // Timer eventhandler
        private void t_Tick(object sender, EventArgs e)
        {
            // Get current time
            int hh = DateTime.Now.Hour;
            int mm = DateTime.Now.Minute;
            int ss = DateTime.Now.Second;

            // Time
            string time = "";

            // Padding leading zero
            if (hh < 10)
            {
                time += "0" + hh;
            }
            else
            {
                time += hh;
            }

            time += ":";

            // Padding leading zero
            if (mm < 10)
            {
                time += "0" + mm;
            }
            else
            {
                time += mm;
            }

            time += ":";

            // Padding leading zero
            if (ss < 10)
            {
                time += "0" + ss;
            }
            else
            {
                time += ss;
            }

            // Update lable
            this.lblTime.Text = time;
        }
    }
}
