using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Tester
{
    public partial class New_Project : Form
    {

        walk w;


        public New_Project(walk wlk)
        {
            InitializeComponent();
            w = wlk;
        }

        private void New_Project_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void New_Project_FormClosed(object sender, FormClosedEventArgs e)
        {
            walk.np = null;
        }

        private void New_Project_Load(object sender, EventArgs e)
        {
            //Icon icox;
            //icox = Icon.ExtractAssociatedIcon(Application.StartupPath + "\\alpha.ico");
            //imageList1.Images.Add(icox.ToBitmap());
            //listView1.Items.Add("Computer", imageList1.Images.Count - 1);

            //treeView1.GetNodeAt(0, 0).Expand();
            //treeView1.GetNodeAt(2, 1).Expand();
            //treeView1.Nodes[treeView1.Nodes.Count - 1].EnsureVisible();
            foreach (TreeNode t in treeView1.Nodes)
            {
                t.ExpandAll();
          
            }
            treeView1.SelectedNode = treeView1.Nodes[0].Nodes[0].Nodes[0];
            treeView1.Nodes[treeView1.Nodes.Count - 1].EnsureVisible();

        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {

            

        }

        private void treeView1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(treeView1.SelectedNode.Name.ToString());
            





        }

        private void button2_Click(object sender, EventArgs e)
        {
            walk.np = null;
            this.Dispose();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = "";
            folderBrowserDialog1.ShowDialog();
            textBox2.Text = folderBrowserDialog1.SelectedPath.ToString();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
           // textBox1.Text = treeView1.SelectedNode.Name.ToString();

            //button1.Enabled = false;
            listView1.Items.Clear();
            button1.Enabled = false;
            richTextBox2.Text = "";

            if (treeView1.SelectedNode.Name == "cli1")
            {
                Icon ico_console = Properties.Resources.Terminal;
                Icon empty = Properties.Resources.System_Box_Empty;
                Icon test = Properties.Resources.tests;

               
                imageList1.Images.Add(ico_console.ToBitmap());
                listView1.Items.Add("Simple Console Based Application", imageList1.Images.Count - 1);

                imageList1.Images.Add(empty.ToBitmap());
                listView1.Items.Add("Empty Project", imageList1.Images.Count - 1);

                imageList1.Images.Add(test.ToBitmap());
                listView1.Items.Add("Test Project", imageList1.Images.Count - 1);

            }
            else if (treeView1.SelectedNode.Name == "cli2")
            {
                
                Icon ico_console_adv = Properties.Resources.Apps_utilities_terminal;
                Icon empty = Properties.Resources.System_Box_Empty;
                Icon test = Properties.Resources.tests;


                Icon icox = Properties.Resources.sonyalpha;//Icon.ExtractAssociatedIcon(Application.StartupPath + "\\alpha.ico");

                imageList1.Images.Add(icox.ToBitmap());
                listView1.Items.Add("CLI x64 Application", imageList1.Images.Count - 1);


                imageList1.Images.Add(ico_console_adv.ToBitmap());
                listView1.Items.Add("Advance Console Based Application", imageList1.Images.Count - 1);

                imageList1.Images.Add(empty.ToBitmap());
                listView1.Items.Add("Empty Project", imageList1.Images.Count - 1);


                imageList1.Images.Add(test.ToBitmap());
                listView1.Items.Add("Test Project", imageList1.Images.Count - 1);

            }
            else if (treeView1.SelectedNode.Name == "gui1")
            {

                Icon gui = Properties.Resources.new_window1;
                Icon empty = Properties.Resources.System_Box_Empty;
                Icon test = Properties.Resources.tests;


                imageList1.Images.Add(gui.ToBitmap());
                listView1.Items.Add("Simple GUI Based Application", imageList1.Images.Count - 1);

                imageList1.Images.Add(empty.ToBitmap());
                listView1.Items.Add("Empty Project", imageList1.Images.Count - 1);


                imageList1.Images.Add(test.ToBitmap());
                listView1.Items.Add("Test Project", imageList1.Images.Count - 1);

            }
            else if (treeView1.SelectedNode.Name == "gui2")
            {
                Icon gui = Properties.Resources.New_Window;
                Icon empty = Properties.Resources.System_Box_Empty;
                Icon test = Properties.Resources.tests;


                Icon icox = Properties.Resources.alpha;//Icon.ExtractAssociatedIcon(Application.StartupPath + "\\alpha.ico");

                imageList1.Images.Add(icox.ToBitmap());
                listView1.Items.Add("GUI x64 Application", imageList1.Images.Count - 1);


                imageList1.Images.Add(gui.ToBitmap());
                listView1.Items.Add("Advance GUI Based Application", imageList1.Images.Count - 1);

                imageList1.Images.Add(empty.ToBitmap());
                listView1.Items.Add("Empty Project", imageList1.Images.Count - 1);


                imageList1.Images.Add(test.ToBitmap());
                listView1.Items.Add("Test Project", imageList1.Images.Count - 1);

            }
            else if (treeView1.SelectedNode.Name == "lib1")
            {
                Icon dll = Properties.Resources.Gear;
              
                
                Icon empty = Properties.Resources.System_Box_Empty;
                Icon test = Properties.Resources.tests;

                imageList1.Images.Add(dll.ToBitmap());
                listView1.Items.Add("Simple Library", imageList1.Images.Count - 1);

                imageList1.Images.Add(empty.ToBitmap());
                listView1.Items.Add("Empty Project", imageList1.Images.Count - 1);


                imageList1.Images.Add(test.ToBitmap());
                listView1.Items.Add("Test Project", imageList1.Images.Count - 1);

            }
            else if (treeView1.SelectedNode.Name == "lib2")
            {
                Icon dll = Properties.Resources.Spur_gear;


                Icon empty = Properties.Resources.System_Box_Empty;
                Icon test = Properties.Resources.tests;


                imageList1.Images.Add(dll.ToBitmap());
                listView1.Items.Add("Advance Library", imageList1.Images.Count - 1);

                imageList1.Images.Add(empty.ToBitmap());
                listView1.Items.Add("Empty Project", imageList1.Images.Count - 1);


                imageList1.Images.Add(test.ToBitmap());
                listView1.Items.Add("Test Project", imageList1.Images.Count - 1);

            }
            else if (treeView1.SelectedNode.Name == "sam1")
            {
                Icon icox = Properties.Resources.Terminal;
                


                imageList1.Images.Add(icox.ToBitmap());
                listView1.Items.Add("Console Based Sample Application", imageList1.Images.Count - 1);
                
            }
            else if (treeView1.SelectedNode.Name == "sam2")
            {
                Icon icox = Properties.Resources.New_Window;
                

                imageList1.Images.Add(icox.ToBitmap());
                listView1.Items.Add("GUI Based Sample Application", imageList1.Images.Count - 1);
            }
            //else
            //{
            //    listView1.Items.Clear();
            //}

            listView1.Refresh();
        }

        private void listView1_Click(object sender, EventArgs e)
        {
            
           
          

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "<solution name>")
            {
                textBox1.Text = "";
                textBox1.Focus();
                textBox1.ForeColor = Color.Black;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (listView1.SelectedItems.Count != 0)
            {
             
                if (textBox1.Text != "<solution name>" && textBox1.Text != "" && !(textBox1.Text.Contains(" ")) && textBox2.Text != "" && Directory.Exists(textBox2.Text))
                {
                    //Empty
                    if (listView1.SelectedItems[0].Text == "Empty Project")
                    {
                        //MessageBox.Show("This project type is currently not available in your Alpha Studio", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                       EmptyProject(textBox2.Text, textBox1.Text, "Empty", "x86", "bin", checkBox1.Checked);
                    }

                    //Test
                    if (listView1.SelectedItems[0].Text == "Test Project")
                    {
                        MessageBox.Show("This project type is currently not available in your Alpha Studio", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }


                    //Simple Console Based Application
                    if (listView1.SelectedItems[0].Text == "Simple Console Based Application")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        ConsoleProject(textBox2.Text, textBox1.Text, "Console", "x86", "bin", checkBox1.Checked);
                    }

                    //Advance Console Based Application
                    if (listView1.SelectedItems[0].Text == "Advance Console Based Application")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        ConsoleProject(textBox2.Text, textBox1.Text, "ConsoleAdv", "x86", "bin", checkBox1.Checked);
                    }

                    //x64 CLI
                    if (listView1.SelectedItems[0].Text == "CLI x64 Application")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        ConsoleProject(textBox2.Text, textBox1.Text, "Console", "x64", "bin", checkBox1.Checked);
                    }

                    //Simple GUI
                    if (listView1.SelectedItems[0].Text == "Simple GUI Based Application")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        GUIProject(textBox2.Text, textBox1.Text, "Win32", "x86", "bin", checkBox1.Checked);
                    }

                    //Advance GUI
                    if (listView1.SelectedItems[0].Text == "Advance GUI Based Application")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        GUIProject(textBox2.Text, textBox1.Text, "Win32Adv", "x86", "bin", checkBox1.Checked);
                    }

                    //x64 GUI
                    if (listView1.SelectedItems[0].Text == "GUI x64 Application")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        GUIProject(textBox2.Text, textBox1.Text, "Win32", "x64", "bin", checkBox1.Checked);
                    }

                    //lib
                    if (listView1.SelectedItems[0].Text == "Simple Library")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        MessageBox.Show("This project type is currently not available in your Alpha Studio", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //adv_lib
                    if (listView1.SelectedItems[0].Text == "Advance Library")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        MessageBox.Show("This project type is currently not available in your Alpha Studio", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //sample cli
                    if (listView1.SelectedItems[0].Text == "Console Based Sample Application")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        MessageBox.Show("This project type is currently not available in your Alpha Studio", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }

                    //sample gui
                    if (listView1.SelectedItems[0].Text == "GUI Based Sample Application")
                    {
                        //MessageBox.Show(listView1.SelectedItems[0].Text);
                        MessageBox.Show("This project type is currently not available in your Alpha Studio", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Please fill all fields correctly", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
        }

        private void listView1_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void listView1_MouseDown(object sender, MouseEventArgs e)
        {
            
        }

        private void listView1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Enabled = false;
            richTextBox2.Text = "";

            if (listView1.SelectedItems.Count != 0)
            {
                button1.Enabled = true;


                //Empty
                if (listView1.SelectedItems[0].Text == "Empty Project")
                {
                    //MessageBox.Show("This project type is currently not available in your Alpha Studio", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    richTextBox2.Text = "Allows you to create an empty project in your Alpha Studio which can further tranformed to either CLI,GUI or a Hybrid Project.";
                }

                //Test
                if (listView1.SelectedItems[0].Text == "Test Project")
                {
                    //MessageBox.Show("This project type is currently not available in your Alpha Studio", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    richTextBox2.Text = "Allows you to create an test project in your Alpha Studio which can used to test CLI,GUI or a Hybrid Project.";
                }


                //Simple Console Based Application
                if (listView1.SelectedItems[0].Text == "Simple Console Based Application")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Create simple console projects(CLI) including simple libraries (Recommended For Small Projects).";
                }

                //Advance Console Based Application
                if (listView1.SelectedItems[0].Text == "Advance Console Based Application")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Allows you to create a powerful console applications under Alpha Studio with vast Libraries.";
                }

                //x64 CLI
                if (listView1.SelectedItems[0].Text == "CLI x64 Application")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Creates console applications for x64 architecture machine with hard core functionalities of Alpha Studio.";
                }

                //Simple GUI
                if (listView1.SelectedItems[0].Text == "Simple GUI Based Application")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Provides highly rich envoirment to create graphical application, simple drag drops can lead to flexible application.";
                }

                //Advance GUI
                if (listView1.SelectedItems[0].Text == "Advance GUI Based Application")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Provides highly rich envoirment to create graphical application, simple drag drops can lead to flexible application (Includes Advance Libraries).";
                }

                //x64 GUI
                if (listView1.SelectedItems[0].Text == "GUI x64 Application")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Creates GUI applications for x64 architecture machine with hard core functionalities of Alpha Studio.";
                }

                //lib
                if (listView1.SelectedItems[0].Text == "Simple Library")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Allows you to creates library for your alpha projects.";
                }

                //adv_lib
                if (listView1.SelectedItems[0].Text == "Advance Library")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Allows you to creates library for your alpha projects (Included Advanced Features).";
                }

                //sample cli
                if (listView1.SelectedItems[0].Text == "Console Based Sample Application")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Creates a sample console application (CLI) for learning purpose.";
                }

                //sample gui
                if (listView1.SelectedItems[0].Text == "GUI Based Sample Application")
                {
                    //MessageBox.Show(listView1.SelectedItems[0].Text);
                    richTextBox2.Text = "Creates a sample GUI application for learning purpose.";
                }

            } 



        }

        private void treeView1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Enabled = false;
            richTextBox2.Text = "";

        }



        //EMPTY APP
        public void EmptyProject(String path,String SolName,String ProjectType ,String Arch, String GenType,bool CreateDir)
        {
            try
            {
                
                this.Hide();

                String asln = @"<AlphaStudioSolution>
    <SchemaVersion>1.0</SchemaVersion>
    <ProjectName>" + SolName + @"</ProjectName>
    <ProjectType>" + ProjectType + @"</ProjectType>
    <ProjectPlatform>" + Arch + @"</ProjectPlatform>
    <OutputType>" + GenType + @"</OutputType>
    <ResourcePath>Resources\</ResourcePath>
    <FormsPath>Forms\</FormsPath>
    <SourcePath>Source\</SourcePath>
    <BinaryPath>Binaries\</BinaryPath>
</AlphaStudioSolution>

<!-- Causing any change in this file can damage your solution file -->";


                String tpath = null;
                String mpath = null;
                if (CreateDir)
                {

                    Directory.CreateDirectory(path + "\\" + SolName);
                    String temp_newpath = path + "\\" + SolName;
  
                    File.WriteAllText(temp_newpath + "\\" + SolName + ".asln", asln, Encoding.ASCII);
                    mpath = temp_newpath + "\\" + SolName + ".asln";
                    Directory.CreateDirectory(temp_newpath + "\\Binaries");
                    Directory.CreateDirectory(temp_newpath + "\\Forms");
                    Directory.CreateDirectory(temp_newpath + "\\Resources");
                    Directory.CreateDirectory(temp_newpath + "\\Source");
                    
                }
                else
                {
                    File.WriteAllText(path + "\\" + SolName + ".asln", asln, Encoding.ASCII);
                    mpath = path + "\\" + SolName + ".asln";
                    Directory.CreateDirectory(path + "\\Binaries");
                    Directory.CreateDirectory(path + "\\Forms");
                    Directory.CreateDirectory(path + "\\Resources");
                    Directory.CreateDirectory(path + "\\Source");
                    

                }

                w.initCLIenvoirment(tpath,mpath);
                GC.Collect();
                DisposeThis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(),"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
                this.Show();
            }
        }


        //CONSOLE APP
        public void ConsoleProject(String path, String SolName, String ProjectType, String Arch, String GenType, bool CreateDir)
        {

            try
            {

                this.Hide();

                String asln = @"<AlphaStudioSolution>
    <SchemaVersion>1.0</SchemaVersion>
    <ProjectName>" + SolName + @"</ProjectName>
    <ProjectType>" + ProjectType + @"</ProjectType>
    <ProjectPlatform>" + Arch + @"</ProjectPlatform>
    <OutputType>" + GenType + @"</OutputType>
    <ResourcePath>Resources\</ResourcePath>
    <FormsPath>Forms\</FormsPath>
    <SourcePath>Source\</SourcePath>
    <BinaryPath>Binaries\</BinaryPath>
</AlphaStudioSolution>

<!-- Causing any change in this file can damage your solution file -->";


String stub = @"#include ""inout.alib""
#include ""con.alib""

/*
	Alpha Generated Code
*/

void main()
 { 	
	//Write your code here

	clrscr();
    string hello = ""This is my first program"";
	print(""Hello World"");
    printl(hello);
 }";


String tpath = null;
String mpath = null;

                if (CreateDir)
                {

                    Directory.CreateDirectory(path + "\\" + SolName);
                    String temp_newpath = path + "\\" + SolName;

                    File.WriteAllText(temp_newpath + "\\" + SolName + ".asln", asln, Encoding.ASCII);
                    mpath = temp_newpath + "\\" + SolName + ".asln";
                    Directory.CreateDirectory(temp_newpath + "\\Binaries");
                    Directory.CreateDirectory(temp_newpath + "\\Forms");
                    Directory.CreateDirectory(temp_newpath + "\\Resources");
                    Directory.CreateDirectory(temp_newpath + "\\Source");
                    
                    tpath = temp_newpath + "\\Source\\main.a";
                    File.WriteAllText(tpath, stub);
                    
                }
                else
                {
                    File.WriteAllText(path + "\\" + SolName + ".asln", asln, Encoding.ASCII);
                    mpath = path + "\\" + SolName + ".asln";
                    Directory.CreateDirectory(path + "\\Binaries");
                    Directory.CreateDirectory(path + "\\Forms");
                    Directory.CreateDirectory(path + "\\Resources");
                    Directory.CreateDirectory(path + "\\Source");

                    tpath = path + "\\Source\\main.a";
                    File.WriteAllText(tpath,stub);
                    

                }

                w.initCLIenvoirment(tpath,mpath);
                GC.Collect();
                DisposeThis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }
        }

        public void GUIProject(String path, String SolName, String ProjectType, String Arch, String GenType, bool CreateDir)
        {

            try
            {
                this.Hide();

                String asln = @"<AlphaStudioSolution>
    <SchemaVersion>1.0</SchemaVersion>
    <ProjectName>" + SolName + @"</ProjectName>
    <ProjectType>" + ProjectType + @"</ProjectType>
    <ProjectPlatform>" + Arch + @"</ProjectPlatform>
    <OutputType>" + GenType + @"</OutputType>
    <ResourcePath>Resources\</ResourcePath>
    <FormsPath>Forms\</FormsPath>
    <SourcePath>Source\</SourcePath>
    <BinaryPath>Binaries\</BinaryPath>
</AlphaStudioSolution>

<!-- Causing any change in this file can damage your solution file -->";




                //CLI STUB
                String stub = @"#include ""window.alib""

/*
	Alpha Generated Code
*/

void main()
 { 	
	//Write your code here
 }";


                //GUI STUB

String guiStub = @"<AlphaForm>
    <FormName>form1</FormName>
    <FormText>Form</FormText>
    <FormSize>356,331</FormSize>
    <FormLocation>Center</FormLocation>
    <BackColor>Control</BackColor>
    <ForeColor>Black</ForeColor>
    <WindowState>Normal</WindowState>
        <Controls>
        </Controls>
</AlphaForm>
";



                String mpath = null;
                String tpath = null;

                if (CreateDir)
                {

                    Directory.CreateDirectory(path + "\\" + SolName);
                    String temp_newpath = path + "\\" + SolName;

                    File.WriteAllText(temp_newpath + "\\" + SolName + ".asln", asln, Encoding.ASCII);
                    mpath = temp_newpath + "\\" + SolName + ".asln";
                    Directory.CreateDirectory(temp_newpath + "\\Binaries");
                    Directory.CreateDirectory(temp_newpath + "\\Forms");
                    Directory.CreateDirectory(temp_newpath + "\\Resources");
                    Directory.CreateDirectory(temp_newpath + "\\Source");

                    tpath = temp_newpath + "\\Source\\main.a";
                    File.WriteAllText(tpath, stub);
                    File.WriteAllText(temp_newpath+"\\Forms\\form1.af", guiStub);

                }
                else
                {
                    File.WriteAllText(path + "\\" + SolName + ".asln", asln, Encoding.ASCII);
                    mpath = path + "\\" + SolName + ".asln";
                    Directory.CreateDirectory(path + "\\Binaries");
                    Directory.CreateDirectory(path + "\\Forms");
                    Directory.CreateDirectory(path + "\\Resources");
                    Directory.CreateDirectory(path + "\\Source");

                    tpath = path + "\\Source\\main.a";
                    File.WriteAllText(tpath, stub);
                    File.WriteAllText(path + "\\Forms\\form1.af", guiStub);

                }

                w.initGUIenvoirment(tpath,mpath);
                GC.Collect();
                DisposeThis();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Show();
            }

        }

        public void DisposeThis()
        {
            walk.np = null;
            this.Dispose();
        }

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer2_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }


       

    }
}
