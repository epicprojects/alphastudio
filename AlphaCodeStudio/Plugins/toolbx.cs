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
    public partial class toolbx : FormWithPreview
    {
        walk wlk;
        //public static bool flg = false;
        bool f = false;
        public static dummy d;
        public static int selected_control = 0;
        public toolbx(walk w)
        {
            InitializeComponent();
            wlk = w;
        }

        private void toolbx_Load(object sender, EventArgs e)
        {

        }

        private void label2_MouseEnter(object sender, EventArgs e)
        {
            //pointer
            clearall();
            label2.BorderStyle = BorderStyle.FixedSingle;
          
        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
            //button
            clearall();
            label3.BorderStyle = BorderStyle.FixedSingle;
          
        }

        private void label4_MouseEnter(object sender, EventArgs e)
        {
            //text
            clearall();
            label4.BorderStyle = BorderStyle.FixedSingle;
         
        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            //image
            clearall();
            label5.BorderStyle = BorderStyle.FixedSingle;
           
        }



      

        void clearall()
        {
            label2.BorderStyle = BorderStyle.None;
            label3.BorderStyle = BorderStyle.None;
            label4.BorderStyle = BorderStyle.None;
            label5.BorderStyle = BorderStyle.None;
            label6.BorderStyle = BorderStyle.None;
            label7.BorderStyle = BorderStyle.None;
            label8.BorderStyle = BorderStyle.None;
            label9.BorderStyle = BorderStyle.None;
            label10.BorderStyle = BorderStyle.None;
            label11.BorderStyle = BorderStyle.None;
            label12.BorderStyle = BorderStyle.None;
            label13.BorderStyle = BorderStyle.None;
        }

        private void toolbx_MouseLeave(object sender, EventArgs e)
        {
           // MessageBox.Show("d");
        }

        private void label2_MouseDown(object sender, MouseEventArgs e)
        {
            //pointer
            selected_control = 1;
            d.SetArrowCusrsor();

        }

        private void label3_MouseDown(object sender, MouseEventArgs e)
        {
            //button
            selected_control = 2;
            d.SetCrossCusrsor();
             
        }

        private void label4_MouseDown(object sender, MouseEventArgs e)
        {
            //text
            selected_control = 3;
            d.SetCrossCusrsor();
        }

        private void label5_MouseDown(object sender, MouseEventArgs e)
        {
            //image
            selected_control = 4;
            d.SetCrossCusrsor();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            //textbox
            clearall();
            label6.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label7_MouseDown(object sender, MouseEventArgs e)
        {
            //check
            selected_control = 6;
            d.SetCrossCusrsor();

        }

        private void label8_MouseEnter(object sender, EventArgs e)
        {
            //combo
            clearall();
            label8.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label7_MouseEnter(object sender, EventArgs e)
        {
            //checkbox
            clearall();
            label7.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label9_MouseEnter(object sender, EventArgs e)
        {
            //div
            clearall();
            label9.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label10_MouseEnter(object sender, EventArgs e)
        {
            //link
            clearall();
            label10.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label11_MouseEnter(object sender, EventArgs e)
        {
            //list
            clearall();
            label11.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label12_MouseEnter(object sender, EventArgs e)
        {
            //radio
            clearall();
            label12.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label13_DragEnter(object sender, DragEventArgs e)
        {
            
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            //rich
            clearall();
            label13.BorderStyle = BorderStyle.FixedSingle;
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            //textbox
            selected_control = 5;
            d.SetCrossCusrsor();
        }

        private void label8_MouseDown(object sender, MouseEventArgs e)
        {
            //combo
            selected_control = 7;
            d.SetCrossCusrsor();
        }

        private void label9_MouseDown(object sender, MouseEventArgs e)
        {
            //div
            selected_control = 8;
            d.SetCrossCusrsor();
        }

        private void label10_MouseDown(object sender, MouseEventArgs e)
        {
            //link
            selected_control = 9;
            d.SetCrossCusrsor();
        }

        private void label11_MouseDown(object sender, MouseEventArgs e)
        {
            //list
            selected_control = 10;
            d.SetCrossCusrsor();
        }

        private void label12_MouseDown(object sender, MouseEventArgs e)
        {
            //radio
            selected_control = 11;
            d.SetCrossCusrsor();
        }

        private void label13_MouseDown(object sender, MouseEventArgs e)
        {
            //rich
            selected_control = 12;
            d.SetCrossCusrsor();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            
        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void toolbx_MouseEnter(object sender, EventArgs e)
        {
          
        }

        private void flowLayoutPanel1_MouseEnter(object sender, EventArgs e)
        {
          
        }

  

        private void label1_MouseMove(object sender, MouseEventArgs e)
        {
            //MessageBox.Show("hllo");

            //if (flg)
            //{
            //    flowLayoutPanel1.Visible = true;
            //}
            //else
            //{
            //    flowLayoutPanel1.Visible = false;
            //}
            if (wlk.design_tab != null)
            {


                

                if (wlk.design_tab.IsSelected)
                {
                    flowLayoutPanel1.Visible = true;
                }
                else
                {
                    
                    if (wlk.toolbox_tab.IsSelected == true)
                    {
                        flowLayoutPanel1.Visible = true;
                    }
                    else
                    {
                        flowLayoutPanel1.Visible = false;
                    }


                }


               

            }
           // MessageBox.Show(wlk.design_tab.IsSelected.ToString());

        }

       
    }

}
