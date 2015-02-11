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



   


    public partial class dummy : Form
    {



        enum HitTest
        {
            Caption = 2,
            Transparent = -1,
            Nowhere = 0,
            Client = 1,
            Left = 10,
            Right = 11,
            Top = 12,
            TopLeft = 13,
            TopRight = 14,
            Bottom = 15,
            BottomLeft = 16,
            BottomRight = 17,
            Border = 18
        }


        public enum Contorlx
        {
            pointer = 1,
            button = 2,
            text = 3,
            image = 4,
            textbox = 5,
            checkbox = 6,
            combobox = 7,
            div = 8,
            link = 9,
            list = 10,
            radio = 11,
            rich = 12
        }



        Control SelectedControl;

        drag_drop dd;
        walk w;
        property p;
       // page_property pp = new page_property();
        toolbx t;

        public dummy(walk wl, ref property pp, ref toolbx tt)
        {
            InitializeComponent();

            t = tt;

            drag_drop.p = pp.propertyGrid1;
            dd = new drag_drop(this, pp.propertyGrid1);
            drag_drop.frmmain = this;


            p = pp;
            drag_drop.t = this.timer1;
            w = wl;
            toolbx.d = this;
            cshape.Tag = "dragger";
        }

        private void dummy_Load(object sender, EventArgs e)
        {


          //  start the timer that will be monitoring the mouse movement every 500 ms.

            TextBox ctrl = new TextBox();
            ctrl.Text = "New Textbox";
            ctrl.Location = new Point(0,0);
            ctrl.Tag = "eventinit";
            ctrl.Width = 0;
            ctrl.Height = 0;
            //ctrl.Image = 
            //ctrl.ReadOnly = true;
            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            Controls.Add(ctrl);

            timer1.Start();

        }


        protected override void WndProc(ref Message m)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (m.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = m.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }
           
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case 0x84: //WM_NCHITTEST
                    var result = (HitTest)m.Result.ToInt32();
                    if (result == HitTest.Top || result == HitTest.Left)
                        m.Result = new IntPtr((int)HitTest.Caption);
                    //if (result == HitTest.TopLeft || result == HitTest.Left)
                    //    m.Result = new IntPtr((int)HitTest.Left);
                    //if (result == HitTest.TopRight || result == HitTest.BottomRight)
                    //    m.Result = new IntPtr((int)HitTest.Right);

                    break;
            }
 
        
        }


        private void cshape_Click(object sender, EventArgs e)
        {

        }

        private void cshape_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void dummy_MouseDown(object sender, MouseEventArgs e)
        {
            this.Refresh();
            cshape.Visible = true;
            cshape.Left = e.X;
            cshape.Top = e.Y;
            cshape.Width = 0;
            cshape.Height = 0;


            p.propertyGrid1.SelectedObject = this;

            drag_drop.isselected = false;
            drag_drop.resizing = false;

            if (e.Button == MouseButtons.Right)
            {
                page_menu.Show(this, e.X, e.Y);
            }
        }

        private void dummy_MouseMove(object sender, MouseEventArgs e)
        {
            dd.Form1_MouseMove(sender, e);



            if (toolbx.selected_control > 1)
            {
                this.Cursor = Cursors.Cross;
            }
            //else
            //{
            //   // this.Cursor = Cursors.Arrow;
            //}

            if (drag_drop.isselected == false && drag_drop.resizing != true)
            {

                if (e.Button == MouseButtons.Left)
                {

                    cshape.Width = e.X - cshape.Left;
                    cshape.Height = e.Y - cshape.Top;



                }
                else
                {
                    cshape.Visible = false;
                }

            }


            w.lbWordUnderMouse.Visible = true;
            //this.Text = "(X=" + e.X + " : Y=" + e.Y + ")" + "  c_left=" + cshape.Left + "  c_rite= " + cshape.Right;
            w.lbWordUnderMouse.Text = "" + e.X + " , " + e.Y + "";
        }



       


        private void dummy_MouseUp(object sender, MouseEventArgs e)
        {
            cshape.Visible = false;

         


            switch (toolbx.selected_control)
            {
                case (int)Contorlx.pointer:
                    {

                        break;
                    }
                case (int)Contorlx.button:
                    {
                        Button ctrl = new Button();
                        ctrl.Text = "New Button";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 23)
                        {
                            cshape.Height = 23;
                        }
                        if (cshape.Width < 75)
                        {
                            cshape.Width = 75;
                        }

                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        ctrl.BackColor = Color.Transparent;
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        //    ctrl.KeyPress +=new KeyPressEventHandler(dd.ctrl_KeyPress);
                        Controls.Add(ctrl);
                        toolbx.selected_control = 0;
                        break;
                    }
                case (int)Contorlx.text:
                    {
                        Label ctrl = new Label();
                        ctrl.Text = "New Text";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 20)
                        {
                            cshape.Height = 20;
                        }
                        if (cshape.Width < 100)
                        {
                            cshape.Width = 100;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        ctrl.ContextMenuStrip = control_menu;
                        Controls.Add(ctrl);
                        toolbx.selected_control = 0;
                        break;
                    }
                case (int)Contorlx.image:
                    {
                        PictureBox ctrl = new PictureBox();
                        ctrl.Text = "New Picture";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 100)
                        {
                            cshape.Height = 100;
                        }
                        if (cshape.Width < 100)
                        {
                            cshape.Width = 100;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        ctrl.Image = Properties.Resources.dmx;
                        ctrl.SizeMode = PictureBoxSizeMode.StretchImage;
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        ctrl.ContextMenuStrip = control_menu;
                        Controls.Add(ctrl);
                        toolbx.selected_control = 0;
                        break;
                    }

                case (int)Contorlx.checkbox:
                    {
                        CheckBox ctrl = new CheckBox();
                        ctrl.Text = "New CheckBox";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 15)
                        {
                            cshape.Height = 15;
                        }
                        if (cshape.Width < 15)
                        {
                            cshape.Width = 15;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        //ctrl.Image = 
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        Controls.Add(ctrl);
                        ctrl.ContextMenuStrip = control_menu;
                        toolbx.selected_control = 0;
                        break;

                    }
                case (int)Contorlx.combobox:
                    {
                        ComboBox ctrl = new ComboBox();
                        ctrl.Text = "New Combo";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 21)
                        {
                            cshape.Height = 21;
                        }
                        if (cshape.Width < 121)
                        {
                            cshape.Width = 121;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        //ctrl.Image = 
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        ctrl.ContextMenuStrip = control_menu;
                        Controls.Add(ctrl);

                        toolbx.selected_control = 0;
                        break;

                    }
                case (int)Contorlx.div:
                    {
                        Panel ctrl = new Panel();
                        ctrl.Text = "New Div";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 100)
                        {
                            cshape.Height = 100;
                        }
                        if (cshape.Width < 250)
                        {
                            cshape.Width = 250;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        ctrl.BorderStyle = BorderStyle.FixedSingle;
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        ctrl.ContextMenuStrip = control_menu;
                        Controls.Add(ctrl);
                        toolbx.selected_control = 0;
                        break;
                    }
                case (int)Contorlx.link:
                    {

                        LinkLabel ctrl = new LinkLabel();
                        ctrl.Text = "New HyperLink";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 13)
                        {
                            cshape.Height = 13;
                        }
                        if (cshape.Width < 100)
                        {
                            cshape.Width = 100;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        //ctrl.Image = 
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        ctrl.ContextMenuStrip = control_menu;
                        Controls.Add(ctrl);
                        toolbx.selected_control = 0;
                        break;
                    }
                case (int)Contorlx.list:
                    {

                        break;
                    }
                case (int)Contorlx.radio:
                    {
                        RadioButton ctrl = new RadioButton();
                        ctrl.Text = "New Radio";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 13)
                        {
                            cshape.Height = 13;
                        }
                        if (cshape.Width < 14)
                        {
                            cshape.Width = 14;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        //ctrl.Image = 
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        ctrl.ContextMenuStrip = control_menu;
                        Controls.Add(ctrl);
                        toolbx.selected_control = 0;
                        break;

                    }
                case (int)Contorlx.rich:
                    {
                        RichTextBox ctrl = new RichTextBox();
                        ctrl.Text = "New RichBox";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 90)
                        {
                            cshape.Height = 90;
                        }
                        if (cshape.Width < 145)
                        {
                            cshape.Width = 145;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        //ctrl.Image = 
                        // ctrl.ReadOnly = true;
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        ctrl.ContextMenuStrip = control_menu;
                        Controls.Add(ctrl);
                        toolbx.selected_control = 0;
                        break;
                    }
                case (int)Contorlx.textbox:
                    {
                        TextBox ctrl = new TextBox();
                        ctrl.Text = "New Textbox";
                        ctrl.Location = new Point(cshape.Left, cshape.Top);
                        if (cshape.Height < 21)
                        {
                            cshape.Height = 21;
                        }
                        if (cshape.Width < 150)
                        {
                            cshape.Width = 150;
                        }
                        ctrl.Width = cshape.Width;
                        ctrl.Height = cshape.Height;
                        //ctrl.Image = 
                        //ctrl.ReadOnly = true;
                        ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
                        ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
                        ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
                        ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
                        ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
                        ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
                        ctrl.ContextMenuStrip = control_menu;
                        Controls.Add(ctrl);
                        toolbx.selected_control = 0;
                        break;

                    }


            }





            if (SelectedControl != null)
                dd.DrawControlBorder(this, SelectedControl);

            timer1.Start();


            w.lbWordUnderMouse.Text = "";

        }


        public void SetCrossCusrsor()
        {
        
            this.Cursor = Cursors.Cross;
        }

        public void SetArrowCusrsor()
        {
            this.Cursor = Cursors.Arrow;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //if (toolbx.selected_control > 1)
            //{
            //    this.Cursor = Cursors.Cross;
            //}
            //else
            //{
            //    this.Cursor = Cursors.Arrow;
            //}

            dd.timer1_Tick(sender, e);
        }


        public int count_controls()
        {
            int i = 0;
            foreach (Control c in Controls)
            {
                i++;
            }

            return i;
        }

        private void dummy_ResizeBegin(object sender, EventArgs e)
        {
            
        }

        private void dummy_MouseLeave(object sender, EventArgs e)
        {
            w.lbWordUnderMouse.Visible = false;
            
          
        }

        private void dummy_MouseEnter(object sender, EventArgs e)
        {
            t.flowLayoutPanel1.Visible = true;
           // toolbx.flg = true;
        }


    }
}
