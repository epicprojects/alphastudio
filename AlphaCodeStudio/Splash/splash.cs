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
    public partial class splash : Form
    {

        walk w = new walk();
        Reg.RegistryEdit reg = new Reg.RegistryEdit();

        public splash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            if (progressBar1.Value < 100)
            {
                progressBar1.Value += 10;
            }
            else
            {
                timer1.Enabled = false;
                this.Hide();
                GC.Collect();
                //w.Show();
                w.Opacity = 1;
                w.Visible = true;
            }

            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void splash_Load(object sender, EventArgs e)
        {
            reg.SubKey = ".asln";
            reg.Write("", "ALPHA.asln");

            reg.SubKey = "ALPHA.asln\\DefaultIcon";
            string q = @"""";
            string complete = q + Application.StartupPath + "\\Alpha Studio.exe" + q + ",0";
            reg.Write("",complete);

           // reg.Write("HKEY_CLASSES_ROOT\\Alpha.asln\\DefaultIcon", Application.StartupPath + "\\Alpha Studio.exe");
            timer1.Enabled = true;
            w.Show();
            w.Opacity = 0;
            w.Visible = false;
            
        }
    }
}
