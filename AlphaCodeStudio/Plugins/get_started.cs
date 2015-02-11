using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Tester
{
    public partial class get_started : Form
    {
        walk w;
        public get_started(walk wlk)
        {
            InitializeComponent();
            w = wlk;
        }

        private void get_started_Load(object sender, EventArgs e)
        {

        }

        private void get_started_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void get_started_FormClosing(object sender, FormClosingEventArgs e)
        {
           // this.Dispose();
        }
    }
}
