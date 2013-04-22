using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DegreePlanner
{
    public partial class scheduleCheckOutput : Form
    {
        public scheduleCheckOutput()
        {
            InitializeComponent();
        }

        public scheduleCheckOutput(string output)
        {
            InitializeComponent();
         
            errorBox.Text = output;
        }

        public scheduleCheckOutput(List<string> errorList)
        {
            InitializeComponent();

            foreach (string s in errorList)
            {
                errorBox.Text += s;
    
                errorBox.Text += "\r\n";
            }
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }

        private void scheduleCheckOutput_Load(object sender, EventArgs e)
        {

        }
    }
}
