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
    public partial class errlist : FormWithPreview
    {
        walk wlk;
        public errlist(walk w)
        {
            InitializeComponent();
            wlk = w;
        }

        private void errlist_Load(object sender, EventArgs e)
        {
            //dataGridView1.AllowUserToAddRows = false;
            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        //DataGridView1.AllowUserToAddRows = False
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
