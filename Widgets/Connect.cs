using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Widgets
{
    class Connect
    {
        public static WebClient CLIENT { get; set; }

        // Send a request to the server to retrieve weather and forecast for a certain location
        public static string SendRequest(string url)
        {
            try
            {
                return CLIENT.DownloadString(new Uri(url));
            }
            catch (WebException ex)
            {
                MessageBox.Show("Error while receiving data from the server:\n" + ex.Message, 
                                "Something broke.. :(", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return null;
            }
        }
    }
}
