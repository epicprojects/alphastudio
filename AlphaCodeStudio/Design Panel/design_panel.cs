using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading;

namespace Tester
{
    public partial class design_panel : Form
    {
       
        //public enum Contorlx
        //{
        //pointer = 1,
        //button = 2,
        //text = 3,
        //image = 4,
        //textbox = 5,
        //checkbox = 6,
        //combobox = 7,
        //div = 8,
        //link = 9,
        //list = 10,
        //radio = 11,
        //rich = 12
        //}

 

        Control SelectedControl;
        drag_drop dd;
        walk w;
        property p;
        toolbx t;
       static property temp_holder;
      //  page_property pp = new page_property();

    public dummy bt;
    public static string d_page_name = null;
    public static string d_css_name = null;
    public static string d_page_title = "";
    public static string d_meta_discription = "";
    public static string d_meta_keyword = "";
    public static string d_meta_author = "";

    public static Color f_color = Color.Black;
    public static Color b_color = Color.White;
    public static Color u_color = Color.Blue;
    public static Color v_color = Color.Purple;
    public static Color m_color = Color.Blue;
    public static Color a_color = Color.Red;

    public static bool center = false;
        
        
        
        public design_panel(walk wl, ref property pp,toolbx tt)
        {
            InitializeComponent();
            //drag_drop.p = pp.propertyGrid1;
            //dd = new drag_drop(this, pp.propertyGrid1);
            //drag_drop.frmmain = this;
            w = wl;
            temp_holder = pp;
            t = tt;
            //p = pp;
            //drag_drop.t = this.timer1;
            //w = wl;
            //toolbx.d = this;
            //cshape.Tag = "dragger";


            try
            {

                //this.TopLevel = true;
                //this.IsMdiContainer = true;
                bt = new dummy(w, ref temp_holder,ref t);
                bt.Location = new Point(10, 10);
                //bt.MdiParent = this;
                bt.Dock = DockStyle.None;
                bt.TopLevel = false;

                this.Controls.Clear();
                this.Controls.Add(bt);
                bt.Visible = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


           
        }


       


        private void design_panel_Load(object sender, EventArgs e)
        {

            //try
            //{
                
            //    //this.TopLevel = true;
            //    //this.IsMdiContainer = true;
            //    bt = new dummy(w, ref temp_holder);
            //    bt.Location = new Point(10, 10);
            //    //bt.MdiParent = this;
            //    bt.Dock = DockStyle.None;
            //    bt.TopLevel = false;
               
            //    this.Controls.Clear();
            //    this.Controls.Add(bt);
            //    bt.Visible = true;
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}



            //start the timer that will be monitoring the mouse movement every 500 ms.
           
            //TextBox ctrl = new TextBox();
            //ctrl.Text = "New Textbox";
            //ctrl.Location = new Point(0,0);
            //ctrl.Tag = "eventinit";
            //ctrl.Width = 0;
            //ctrl.Height = 0;
            ////ctrl.Image = 
            ////ctrl.ReadOnly = true;
            //ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //Controls.Add(ctrl);

            //timer1.Start();
           
        }

        private void cshape_Click(object sender, EventArgs e)
        {

        }

        private void cshape_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void design_panel_MouseDown(object sender, MouseEventArgs e)
        {
            
            //this.Refresh();
            //cshape.Visible = true;
            //cshape.Left = e.X;
            //cshape.Top = e.Y;
            //cshape.Width = 0;
            //cshape.Height = 0;


            //p.propertyGrid1.SelectedObject = null;
     
            //drag_drop.isselected = false;
            //drag_drop.resizing = false;

            //if (e.Button == MouseButtons.Right)
            //{
            //    page_menu.Show(this, e.X, e.Y);
            //}
        }

        private void design_panel_MouseMove(object sender, MouseEventArgs e)
        {
           
                //dd.Form1_MouseMove(sender, e);


                //if (drag_drop.isselected == false && drag_drop.resizing != true)
                //{

                //    if (e.Button == MouseButtons.Left)
                //    {

                //        cshape.Width = e.X - cshape.Left;
                //        cshape.Height = e.Y - cshape.Top;
                        
                        

                //    }
                //    else
                //    {
                //        cshape.Visible = false;
                //    }

                //}


        
              //this.Text = "(X=" + e.X + " : Y=" + e.Y + ")" + "  c_left=" + cshape.Left + "  c_rite= " + cshape.Right;
          //      w.lbWordUnderMouse.Text = "(X=" + e.X + " : Y=" + e.Y + ")";
        }

        private void design_panel_MouseUp(object sender, MouseEventArgs e)
        {
            //cshape.Visible = false;

            //switch (toolbx.selected_control)
            //{
            //    case (int)Contorlx.pointer:
            //        {

            //            break;
            //        }
            //    case (int)Contorlx.button:
            //        {
            //            Button ctrl = new Button();
            //            ctrl.Text = "New Button";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 23)
            //            {
            //                cshape.Height = 23;
            //            }
            //            if (cshape.Width < 75)
            //            {
            //                cshape.Width = 75;
            //            }

            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            ctrl.BackColor = Color.Transparent;
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown +=new KeyEventHandler(dd.ctrl_KeyDown);
            //        //    ctrl.KeyPress +=new KeyPressEventHandler(dd.ctrl_KeyPress);
            //            Controls.Add(ctrl);
            //            toolbx.selected_control = 0;
            //            break;
            //        }
            //    case (int)Contorlx.text:
            //        {
            //            Label ctrl = new Label();
            //            ctrl.Text = "New Text";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 20)
            //            {
            //                cshape.Height = 20;
            //            }
            //            if (cshape.Width < 100)
            //            {
            //                cshape.Width = 100;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            ctrl.ContextMenuStrip = control_menu;
            //            Controls.Add(ctrl);
            //            toolbx.selected_control = 0;
            //            break;
            //        }
            //    case (int)Contorlx.image:
            //        {
            //            PictureBox ctrl = new PictureBox();
            //            ctrl.Text = "New Picture";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 100)
            //            {
            //                cshape.Height = 100;
            //            }
            //            if (cshape.Width < 100)
            //            {
            //                cshape.Width = 100;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            ctrl.Image = Properties.Resources.dmx;
            //            ctrl.SizeMode = PictureBoxSizeMode.StretchImage;
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            ctrl.ContextMenuStrip = control_menu;
            //            Controls.Add(ctrl);
            //            toolbx.selected_control = 0;
            //            break;
            //        }

            //    case (int)Contorlx.checkbox:
            //        {
            //            CheckBox ctrl = new CheckBox();
            //            ctrl.Text = "New CheckBox";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 15)
            //            {
            //                cshape.Height = 15;
            //            }
            //            if (cshape.Width < 15)
            //            {
            //                cshape.Width = 15;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            //ctrl.Image = 
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            Controls.Add(ctrl);
            //            ctrl.ContextMenuStrip = control_menu;
            //            toolbx.selected_control = 0;
            //            break;
                       
            //        }
            //    case (int)Contorlx.combobox:
            //        {
            //            ComboBox ctrl = new ComboBox();
            //            ctrl.Text = "New Combo";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 21)
            //            {
            //                cshape.Height = 21;
            //            }
            //            if (cshape.Width < 121)
            //            {
            //                cshape.Width = 121;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            //ctrl.Image = 
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            ctrl.ContextMenuStrip = control_menu;
            //            Controls.Add(ctrl);

            //            toolbx.selected_control = 0;
            //            break;
                       
            //        }
            //    case (int)Contorlx.div:
            //        {
            //            Panel ctrl = new Panel();
            //            ctrl.Text = "New Div";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 100)
            //            {
            //                cshape.Height = 100;
            //            }
            //            if (cshape.Width < 250)
            //            {
            //                cshape.Width = 250;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            ctrl.BorderStyle = BorderStyle.FixedSingle;
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            ctrl.ContextMenuStrip = control_menu;
            //            Controls.Add(ctrl);
            //            toolbx.selected_control = 0;
            //            break;
            //        }
            //    case (int)Contorlx.link:
            //        {

            //            LinkLabel ctrl = new LinkLabel();
            //            ctrl.Text = "New HyperLink";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 13)
            //            {
            //                cshape.Height = 13;
            //            }
            //            if (cshape.Width < 100)
            //            {
            //                cshape.Width = 100;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            //ctrl.Image = 
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            ctrl.ContextMenuStrip = control_menu;
            //            Controls.Add(ctrl);
            //            toolbx.selected_control = 0;
            //            break;
            //        }
            //    case (int)Contorlx.list:
            //        {

            //            break;
            //        }
            //    case (int)Contorlx.radio:
            //        {
            //            RadioButton ctrl = new RadioButton();
            //            ctrl.Text = "New Radio";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 13)
            //            {
            //                cshape.Height = 13;
            //            }
            //            if (cshape.Width < 14)
            //            {
            //                cshape.Width = 14;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            //ctrl.Image = 
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            ctrl.ContextMenuStrip = control_menu;
            //            Controls.Add(ctrl);
            //            toolbx.selected_control = 0;
            //            break;
                       
            //        }
            //    case (int)Contorlx.rich:
            //        {
            //            RichTextBox ctrl = new RichTextBox();
            //            ctrl.Text = "New RichBox";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 90)
            //            {
            //                cshape.Height = 90;
            //            }
            //            if (cshape.Width < 145)
            //            {
            //                cshape.Width = 145;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            //ctrl.Image = 
            //           // ctrl.ReadOnly = true;
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            ctrl.ContextMenuStrip = control_menu;
            //            Controls.Add(ctrl);
            //            toolbx.selected_control = 0;
            //            break;
            //        }
            //    case (int)Contorlx.textbox:
            //        {
            //            TextBox ctrl = new TextBox();
            //            ctrl.Text = "New Textbox";
            //            ctrl.Location = new Point(cshape.Left, cshape.Top);
            //            if (cshape.Height < 21)
            //            {
            //                cshape.Height = 21;
            //            }
            //            if (cshape.Width < 150)
            //            {
            //                cshape.Width = 150;
            //            }
            //            ctrl.Width = cshape.Width;
            //            ctrl.Height = cshape.Height;
            //            //ctrl.Image = 
            //            //ctrl.ReadOnly = true;
            //            ctrl.MouseEnter += new EventHandler(dd.control_MouseEnter);
            //            ctrl.MouseLeave += new EventHandler(dd.control_MouseLeave);
            //            ctrl.MouseDown += new MouseEventHandler(dd.control_MouseDown);
            //            ctrl.MouseMove += new MouseEventHandler(dd.control_MouseMove);
            //            ctrl.MouseUp += new MouseEventHandler(dd.control_MouseUp);
            //            ctrl.KeyDown += new KeyEventHandler(dd.ctrl_KeyDown);
            //            ctrl.ContextMenuStrip = control_menu;
            //            Controls.Add(ctrl);
            //            toolbx.selected_control = 0;
            //            break;
                      
            //        }

                    
            //}

            



            //if (SelectedControl != null)
            //    dd.DrawControlBorder(this, SelectedControl);

            //timer1.Start();


            //w.lbWordUnderMouse.Text = "";
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
            //dd.timer1_Tick(sender, e);
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            
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

        
     

        private void design_panel_Click(object sender, EventArgs e)
        {
            //drag_drop.isselected = false;
           // drag_drop.isselected = false;
         //   MessageBox.Show("w");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(count_controls().ToString());
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

                //if (c.GetType().Name.ToLower() == "checkbox")
                //{
                //    CheckBox cx = (CheckBox)c;
                //    cx.BorderStyle = BorderStyle.FixedSingle;

                //}

                //if (c.GetType().Name.ToLower() == "radiobox")
                //{
                //    RadioButton cx = (RadioButton)c;
                //    cx.BorderStyle = BorderStyle.FixedSingle;

                //}




            }


        public void set_boundry()
        {
            foreach (Control c in this.Controls)
            {
                if (c.GetType().Name.ToLower() == "label")
                {
                    Label cx = (Label)c;
                    cx.BorderStyle = BorderStyle.FixedSingle;

                }

                if (c.GetType().Name.ToLower() == "picturebox")
                {
                    PictureBox cx = (PictureBox)c;
                    cx.BorderStyle = BorderStyle.FixedSingle;

                }

                if (c.GetType().Name.ToLower() == "panel")
                {
                    Panel cx = (Panel)c;
                    cx.BorderStyle = BorderStyle.FixedSingle;

                }
                if (c.GetType().Name.ToLower() == "linklabel")
                {
                    LinkLabel cx = (LinkLabel)c;
                    cx.BorderStyle = BorderStyle.FixedSingle;

                }
            }

        }
            public void remove_boundary()
            {
                foreach (Control c in this.Controls)
            {
                if (c.GetType().Name.ToLower() == "label")
                {
                    Label cx = (Label)c;
                    cx.BorderStyle = BorderStyle.None;

                }

                if (c.GetType().Name.ToLower() == "picturebox")
                {
                    PictureBox cx = (PictureBox)c;
                    cx.BorderStyle = BorderStyle.None;

                }

                if (c.GetType().Name.ToLower() == "panel")
                {
                    Panel cx = (Panel)c;
                    cx.BorderStyle = BorderStyle.None;

                }
                if (c.GetType().Name.ToLower() == "linklabel")
                {
                     LinkLabel cx = (LinkLabel)c;
                    cx.BorderStyle = BorderStyle.None;

                }
            }


        }

            private void bringToAllFrontToolStripMenuItem_Click(object sender, EventArgs e)
            {
                //MessageBox.Show(drag_drop.SelectedControl.ToString());
                int i=1;
                Control[] temp =  new Control[this.Controls.Count];
                temp[0] = drag_drop.SelectedControl;
                foreach (Control c in this.Controls)
                {
                    if (c == drag_drop.SelectedControl)
                    {
                        i--;
                    }
                    else
                    {
                        temp[i] = c;
                    }
                    i++;
                }
                this.Controls.Clear();
                this.Controls.AddRange(temp);
            }

            private void sendToAllBackToolStripMenuItem_Click(object sender, EventArgs e)
            {
                int i = 0;
                Control[] temp = new Control[this.Controls.Count];
                temp[this.Controls.Count-1] = drag_drop.SelectedControl;
                foreach (Control c in this.Controls)
                {
                    if (c == drag_drop.SelectedControl)
                    {
                        i--;
                    }
                    else
                    {
                        temp[i] = c;
                    }
                    i++;
                }
                this.Controls.Clear();
                this.Controls.AddRange(temp);
            }

            private void bringToolStripMenuItem_Click(object sender, EventArgs e)
            {
                int i = 0;

                Control temp = null;
                Control[] new_controls = new Control[this.Controls.Count];
                foreach (Control c in this.Controls)
                {
                    if (c == drag_drop.SelectedControl)
                    {
                       temp = this.Controls[i + 1];
                    }
                    i++;
                }

                i=0;
                foreach (Control c in this.Controls)
                {
                    if (c == temp && temp != null)
                    {
                        new_controls[i] = drag_drop.SelectedControl;
                    }
                    else if (c == drag_drop.SelectedControl && temp != null)
                    {
                        new_controls[i] = temp;
                    }
                    else
                    {
                        new_controls[i] = c;
                    }
                    i++;
                }

                this.Controls.Clear();
                this.Controls.AddRange(new_controls);
            }

            private void bringToFrontToolStripMenuItem1_Click(object sender, EventArgs e)
            {
                int i = 0;

                Control temp = null;
                Control[] new_controls = new Control[this.Controls.Count];
                foreach (Control c in this.Controls)
                {
                    if (c == drag_drop.SelectedControl && i > 0)
                    {
                        temp = this.Controls[i - 1];
                    }
                    i++;
                }

                i = 0;
                foreach (Control c in this.Controls)
                {
                    if (c == temp && temp != null)
                    {
                        new_controls[i] = drag_drop.SelectedControl;
                    }
                    else if (c == drag_drop.SelectedControl && temp != null)
                    {
                        new_controls[i] = temp;
                    }
                    else
                    {
                        new_controls[i] = c;
                    }
                    i++;
                }

                this.Controls.Clear();
                this.Controls.AddRange(new_controls);
            }

            private void leftAlignToolStripMenuItem_Click(object sender, EventArgs e)
            {
                foreach (Control c in this.Controls)
                {
                    if (c == drag_drop.SelectedControl)
                    {
                        c.Left = 0;
                    }
                }
            }

            private void topAlignToolStripMenuItem_Click(object sender, EventArgs e)
            {
                foreach (Control c in this.Controls)
                {
                    if (c == drag_drop.SelectedControl)
                    {
                        c.Top = 0;
                    }
                }
            }

            private void rightAlignToolStripMenuItem_Click(object sender, EventArgs e)
            {
          

                foreach (Control c in this.Controls)
                {
                    if (c == drag_drop.SelectedControl)
                    {

                        c.Left = this.Width;
                    }
                }
            }

            private void bottomAlignToolStripMenuItem_Click(object sender, EventArgs e)
            {
                foreach (Control c in this.Controls)
                {
                    if (c == drag_drop.SelectedControl)
                    {
                        c.Top = this.Height;
                    }
                }
            }

            private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
            {
                this.Controls.Remove(drag_drop.SelectedControl);
                drag_drop.SelectedControl = null;
                drag_drop.isselected = false;
            }

            private void duplicateToolStripMenuItem_Click(object sender, EventArgs e)
            {
             
              //  ControlCloneEngine cce = new ControlCloneEngine();
              //Control new_clone =  //cce.Copy(drag_drop.SelectedControl);
              //new_clone.Top = new_clone.Top + 50;
              //new_clone.Height = new_clone.Height + 50;
              //this.Controls.Add(new_clone);

            }

            #region DESIGN TO WALK (ABANDON)

            
            public string DesignToWALK()
            {
                LinkedList<String> walk_skeleton = new LinkedList<String>();
                LinkedListNode<String> curr;
                string currendpage = "";

                if (d_page_name != null || d_page_name != "")
                {
                    walk_skeleton.AddFirst("new page " + d_page_name+"\n\n");
                    walk_skeleton.AddLast("end page " + d_page_name);


                          if (d_css_name == null || d_css_name == "")
                            {

                                curr = walk_skeleton.Find("new page " + d_page_name + "\n\n");

                                walk_skeleton.AddAfter(curr, "\tadd css = untitled.css\n");

                            }
                            else
                            {

                                curr = walk_skeleton.Find("new page " + d_page_name + "\n\n");

                                walk_skeleton.AddAfter(curr, "\tadd css = " + d_css_name+"\n");
                            }

                          currendpage = "end page " + d_page_name;
                }
                else
                {
                    walk_skeleton.AddFirst("new page untitled\n\n");
                    walk_skeleton.AddFirst("end page untitled");


                    if (d_css_name == null || d_css_name == "")
                    {
                        curr = walk_skeleton.Find("new page untitled\n\n");

                        walk_skeleton.AddAfter(curr, "\tadd css = untitled.css"+"\n");   
                    }
                    else
                    {
                     
                        curr = walk_skeleton.Find("new page untitled\n\n");

                        walk_skeleton.AddAfter(curr, "\tadd css = " + d_css_name+"\n");
                    }

                    currendpage = "end page untitled";

                }




                if (d_page_title == null || d_page_title == "")
                {

                }
                else
                {
                    curr = walk_skeleton.Find(currendpage);
                    walk_skeleton.AddBefore(curr, "\tset title = " + d_page_title+"\n");
                }


                    curr = walk_skeleton.Find(currendpage);
                    walk_skeleton.AddBefore(curr, "\tset meta = " +d_meta_discription+","+d_meta_keyword+","+d_meta_author+"\n");

                    curr = walk_skeleton.Find(currendpage);
                    walk_skeleton.AddBefore(curr, "\tset color = " + f_color.ToString() + "," + b_color.ToString() + "," + u_color.ToString() + "," + v_color.ToString() + "," + m_color.ToString() + "," + a_color.ToString() + "\n");

                    


                    if (center && this.Controls.Count > 2)
                    {

                        int[] max_w = new int[this.Controls.Count - 2];
                        int[] max_dl = new int[this.Controls.Count - 2];
                        int[] min_dr = new int[this.Controls.Count - 2];
                        int i = 0;
                        int maxw;
                        int maxw_i = 0;
                        int maxdl;
                        int mindr;
                        int mindr_i;
                        foreach (Control cnt in this.Controls)
                        {

                            if (cnt.Tag == "eventinit")
                            {
                                continue;
                            }

                            if (cnt.GetType().Name == "ShapeContainer")
                            {
                                continue;
                            }

                            max_w[i] = cnt.Width;
                            max_dl[i] = cnt.Left;
                            min_dr[i] = cnt.Right;

                            i++;

                        }

                        maxw = max_w.Max();
                        maxdl = max_dl.Max();
                        mindr = min_dr.Min();

                        i = 0;
                        foreach (int w in max_w)
                        {
                            if (maxw == max_w[i])
                            {
                                maxw_i = i;
                                break;
                            }

                            i++;
                        }

                        //i = 0;
                        //foreach (int l in min_dr)
                        //{
                        //    if (mindr == min_dr[i])
                        //    {
                        //        mindr_i = i;
                        //        break;
                        //    }

                        //    i++;
                        //}


                        int final_width = (maxw + (max_dl[maxw_i] * 2));


                        curr = walk_skeleton.Find(currendpage);
                        walk_skeleton.AddBefore(curr, "\tset align = center,relative,"+final_width+"\n");

                    }

                foreach (Control cnt in this.Controls)
                {

                    if (cnt.Tag == "eventinit")
                    {
                        continue;
                    }

                    if (cnt.GetType().Name == "ShapeContainer")
                    {
                        continue;
                    }


              //      MessageBox.Show(cnt.GetType().Name);


                    switch (cnt.GetType().Name)
                    {
                        case "Button":
                            {

                                break;
                            }
                        case "PictureBox":
                            {
                                //add img = header_image.jpg,header image,header,absolute,hidden,0,0,267,846,0
                                curr = walk_skeleton.Find(currendpage);
                                //walk_skeleton.AddBefore(curr, "\tadd img = ");
                                break;
                            }
                        case "Label":
                            {
                                break;
                            }
                        case "Textbox":
                            {
                                break;
                            }
                        case "ComboBox":
                            {
                                break;
                            }
                        case "CheckBox":
                            {
                                break;
                            }
                        case "RadioButton":
                            {
                                break;
                            }
                        case "Panel":
                            {
                                break;
                            }
                        case "LinkLabel":
                            {
                                break;
                            }
                        case "RichTextbox":
                            {
                                break;
                            }
                 
                    }
                    
                    
                  
                }

                return "";
            }

            #endregion

            private void propertiesToolStripMenuItem1_Click(object sender, EventArgs e)
            {
             
                //if (pp.Visible != true)
                //{
                //    pp = new page_property();
                //    pp.Show();
                //}
            }

            private void design_panel_MouseEnter(object sender, EventArgs e)
            {
                this.Cursor = Cursors.Arrow;
                t.flowLayoutPanel1.Visible = true;
                //toolbx.flg = true;
           
            }

            private void design_panel_MouseLeave(object sender, EventArgs e)
            {
        //        t.flowLayoutPanel1.Visible = false;
         //       toolbx.flg = false;
            }

    }




}
