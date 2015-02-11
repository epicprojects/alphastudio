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


   


    public partial class property : FormWithPreview
    {
        walk wlk;
        public property(walk w)
        {
            InitializeComponent();
            wlk = w;
        }

        private void property_Load(object sender, EventArgs e)
        {
            propertyGrid1.SelectedObject = null;


           
        }
       
      



        private void propertyGrid1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
