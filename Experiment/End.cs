using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Experiment
{
    public partial class End : Form
    {
        public End()
        {
            InitializeComponent();
            
        }

        private void Yes_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Visible = true;
            this.Visible = false;

        }

        private void No_Click(object sender, EventArgs e)
        {
            Sure s = new Sure();
            s.Visible = true;
        }

        
    }
}
