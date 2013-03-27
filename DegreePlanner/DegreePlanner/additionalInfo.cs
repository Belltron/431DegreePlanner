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
    public partial class additionalInfo : Form
    {
        public additionalInfo()
        {
            InitializeComponent();
        }

        public additionalInfo(string courseDescription)
        {
            InitializeComponent();
            Label label = new Label();
            label.Text = courseDescription;
            this.Controls.Add(label);

        }
    }
}
