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
            validityLabel.Text = output;
        }

        private void closeWindow(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
