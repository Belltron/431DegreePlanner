using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace DegreePlanner
{
    public partial class WelcomeScreen : Form
    {
        public WelcomeScreen()
        {
            InitializeComponent();
        }

         private void proceedToSchedule(object sender, EventArgs e)
        {
            this.Hide();
            //WelcomeScreen point = this;
            Form1 f = new Form1();
            f.Show();
           // point.Close();
        }
    }
}
