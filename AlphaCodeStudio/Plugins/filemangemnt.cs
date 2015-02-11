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
    public partial class filemangemnt : FormWithPreview
    {
        walk wlk;
        public filemangemnt(walk w)
        {
            InitializeComponent();
            wlk = w;
        }

        private void filemangemnt_Load(object sender, EventArgs e)
        {

        }
    }
}
