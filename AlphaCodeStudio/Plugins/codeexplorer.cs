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
    public partial class codeexplorer : FormWithPreview
    {
        walk wlk;
        public codeexplorer(walk w)
        {
            InitializeComponent();
            wlk = w;
        }

        private void codeexplorer_Load(object sender, EventArgs e)
        {

        }
    }
}
