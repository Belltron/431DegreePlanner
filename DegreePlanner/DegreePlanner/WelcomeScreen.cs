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
            label1.BackColor = Color.Transparent;
            Image image = Image.FromFile(@"C:\Users\Brian\Pictures\backgrounds\atm.jpg");
            this.BackgroundImage = image;
        }

         private void proceedToSchedule(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Form1 f = new Form1();
            this.Hide();
            this.Cursor = Cursors.Default;
            f.ShowDialog();
            this.Show();
        }

    }
}
