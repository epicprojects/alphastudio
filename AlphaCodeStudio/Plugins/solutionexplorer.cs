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
    public partial class solutionexplorer : FormWithPreview
    {
        walk wlk;
        public solutionexplorer(walk w)
        {
            InitializeComponent();
            wlk = w;
        }

        private void solutionexplorer_Load(object sender, EventArgs e)
        {
 
        }

        private void treeView1_DoubleClick(object sender, EventArgs e)
        {
            //MessageBox.Show(treeView1.SelectedNode.Text.ToString()+" "+treeView1.SelectedNode.Tag.ToString());
            if (treeView1.SelectedNode.Tag.ToString().Split('|').GetValue(0).ToString() == "forms")
            {
                wlk.CreateForm(treeView1.SelectedNode.Tag.ToString().Split('|').GetValue(1).ToString());
                //string[] s = treeView1.SelectedNode.Tag.ToString().Split(':');
                //MessageBox.Show(s[1]);
            }
            if (treeView1.SelectedNode.Tag.ToString().Split('|').GetValue(0).ToString() == "src")
            {
                wlk.CreateTab(treeView1.SelectedNode.Tag.ToString().Split('|').GetValue(1).ToString());
            }
            if (treeView1.SelectedNode.Tag.ToString().Split('|').GetValue(0).ToString() == "res")
            {
                MessageBox.Show("This Feature is not available yet :(", "Alpha Studio", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
        }
    }
}
