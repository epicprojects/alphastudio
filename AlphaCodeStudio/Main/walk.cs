using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FarsiLibrary.Win;
using FastColoredTextBoxNS;
using System.IO;
using System.Text.RegularExpressions;
using System.Threading;
using System.Drawing.Drawing2D;
using Crom.Controls.Docking;
using System.Xml;
//using walk;
using System.Diagnostics;
using System.Collections;
using System.Runtime.InteropServices;

namespace Tester
{
    public partial class walk : Form
    {

        [DllImport("KERNEL32.DLL", EntryPoint = "SetProcessWorkingSetSize", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern bool SetProcessWorkingSetSize(IntPtr pProcess, int dwMinimumWorkingSetSize, int dwMaximumWorkingSetSize);

        [DllImport("KERNEL32.DLL", EntryPoint = "GetCurrentProcess", SetLastError = true, CallingConvention = CallingConvention.StdCall)]
        internal static extern IntPtr GetCurrentProcess();

       public static New_Project np;

       public static Dictionary<design_panel, DockableFormInfo> Dpanelx = new Dictionary<design_panel, DockableFormInfo>();

      public DockableFormInfo GetStarted_tab;
      public DockableFormInfo editor_tab;
      public DockableFormInfo design_tab;

      public DockableFormInfo solution_explorer_tab;
      public DockableFormInfo code_explorer_tab;
      public DockableFormInfo error_display_tab;
      public DockableFormInfo output_display_tab;
      public DockableFormInfo file_manage_tab;

      public DockableFormInfo toolbox_tab;
      public DockableFormInfo properties_tab;
     

        editor ed;
        codeexplorer ce;
        errlist errl;
        filemangemnt fm;
        output op;
        property pro;
        solutionexplorer se;
        toolbx tb;
        design_panel dp;
        get_started gs;


       public static string sol_path = "";
       public static string bin_path = "";
       public static string forms_path = "";
       public static string resources_path = "";
       public static string source_path = "";
       public static string project_name = "";
       public static string project_type = "";
       public static string project_platform = "";

        public static String function_regex = "";

        public static string title = null;
        int i = 0;
        string[] keywords = { "#include","abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", "using", "virtual", "void", "volatile", "while", "add", "alias", "ascending", "descending", "dynamic", "from", "get", "global", "group", "into", "join", "let", "orderby", "partial", "remove", "select", "set", "value", "var", "where", "yield" };
       public ArrayList methods_php;
       
        //public string[] methods_js;
       //public string[] html_keywords;
       //public string[] walk_keywords = {"new page","add","set","end page"};
       //public string[] walk_subkeywords = { "title", "meta", "align", "color", "img", "tohead", "tobody", "ahtml", "bhtml", "bbody", "img", "css", "text", "line", "form", "button", "textbox", "richbox", "combo", "checkbox", "label", "radio", "hfield", "file" };

        string[] snippets = { "if(^)\n{\n;\n}", "if(^)\n{\n;\n}\nelse\n{\n;\n}", "for(^;;)\n{\n;\n}", "while(^)\n{\n;\n}", "do\n{\n^;\n}while();", "switch(^)\n{\ncase : break;\n}" };
        string[] declarationSnippets = { 
               "public class ^\n{\n}", "private class ^\n{\n}", "internal class ^\n{\n}",
               "public struct ^\n{\n;\n}", "private struct ^\n{\n;\n}", "internal struct ^\n{\n;\n}",
               "public void ^()\n{\n;\n}", "private void ^()\n{\n;\n}", "internal void ^()\n{\n;\n}", "protected void ^()\n{\n;\n}",
               "public ^{ get; set; }", "private ^{ get; set; }", "internal ^{ get; set; }", "protected ^{ get; set; }"
               };
        Style invisibleCharsStyle = new InvisibleCharsRenderer(Pens.Gray);
        Color currentLineColor = Color.FromArgb(100, 210, 210, 255);
        Color changedLineColor = Color.FromArgb(255, 230, 230, 255);
      

        public walk()
        {
            
            try
            {
                //  Load the XML file
                XmlTextReader reader = new XmlTextReader(Application.StartupPath + "\\c.xml");
                //methods_php = new string[2];
                methods_php = new ArrayList();
                //i = 0;
                //  Loop over the XML file
                while (reader.Read())
                {
                    //  Here we check the type of the node, in this case we are looking for element
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        //  If the element is "profile"
                        if (reader.Name == "KeyWord")
                        {
                            function_regex += reader.GetAttribute("name").ToString() + "|";
                          //  methods_php[i++] = reader.GetAttribute("name").ToString() + "()";
                            methods_php.Add(reader.GetAttribute("name").ToString() + "()");
                            //MessageBox.Show(reader.GetAttribute("name").ToString());

                        }
                    }

                }
                //           MessageBox.Show(i.ToString());
                reader.Close();

            
            }
            catch (Exception ex)
            {
                MessageBox.Show("XML Files Missing");
            }





           
            InitializeComponent();
            // ed = new editor(this);
            //ce = new codeexplorer(this);
            //errl = new errlist(this);
            //fm = new filemangemnt(this);
            //op = new output(this);
            //pro = new property(this);
            //se = new solutionexplorer(this);
            //tb = new toolbx(this);
            //dp  = new design_panel(this,ref pro);
            gs = new get_started(this);
          

            //init menu images
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(walk));
            copyToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            cutToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            pasteToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));


     
     
            dockContainer1.PreviewRenderer = new CustomPreviewRenderer();
            dockContainer1.ShowContextMenu += OnDockerShowContextMenu;
            dockContainer1.FormClosing += OnDockerFormClosing;
            dockContainer1.FormClosed += OnDockerFormClosed;
            //DockableFormInfo editor_tab = dockContainer1.Add(ed, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e001"));

           
            //DockableFormInfo solution_explorer_tab = dockContainer1.Add(se, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e004"));

            //DockableFormInfo code_explorer_tab = dockContainer1.Add(ce, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e005"));

            //DockableFormInfo error_display_tab = dockContainer1.Add(errl, zAllowedDock.Bottom, new Guid("3d8466c1-e406-4e47-b744-6915afe6e006"));

            //DockableFormInfo output_display_tab = dockContainer1.Add(op, zAllowedDock.Bottom, new Guid("3d8466c1-e406-4e47-b744-6915afe6e007"));

            //DockableFormInfo file_manage_tab = dockContainer1.Add(fm, zAllowedDock.Left, new Guid("3d8466c1-e406-4e47-b744-6915afe6e008"));

            //DockableFormInfo properties_tab = dockContainer1.Add(pro, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e009"));

  
            //DockableFormInfo toolbox_tab = dockContainer1.Add(tb, zAllowedDock.Left, new Guid("3d8466c1-e406-4e47-b744-6915afe6e010"));


            GetStarted_tab = dockContainer1.Add(gs, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e012"));
  
            
            // design_tab = dockContainer1.Add(dp, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e011"));
            



            //error_display_tab.ShowFormAutoPanel();
            
            //editor_tab.ShowCloseButton = false;
            //editor_tab.ShowContextMenuButton = false;


            dockContainer1.DockForm(GetStarted_tab, DockStyle.Fill, zDockMode.None);
          
           // dockContainer1.DockForm(solution_explorer_tab, DockStyle.Right, zDockMode.Inner);

           // dockContainer1.DockForm(code_explorer_tab, DockStyle.Right, zDockMode.Inner);

           // dockContainer1.DockForm(error_display_tab, DockStyle.Bottom, zDockMode.Inner);

           // dockContainer1.DockForm(output_display_tab, DockStyle.Bottom, zDockMode.Inner);

           // dockContainer1.DockForm(file_manage_tab, DockStyle.Left, zDockMode.Inner);


           // dockContainer1.DockForm(toolbox_tab, DockStyle.Left, zDockMode.Inner);

           // dockContainer1.DockForm(properties_tab, DockStyle.Right, zDockMode.Inner);


           // dockContainer1.DockForm(editor_tab,GetStarted_tab, DockStyle.Fill, zDockMode.None);
           //dockContainer1.DockForm(design_tab,GetStarted_tab, DockStyle.Fill, zDockMode.None);




           // dockContainer1.SetAutoHide(solution_explorer_tab, true);
           // dockContainer1.SetAutoHide(code_explorer_tab, true);

           // dockContainer1.SetAutoHide(error_display_tab, true);
           // dockContainer1.SetAutoHide(output_display_tab, true);

           // dockContainer1.SetAutoHide(file_manage_tab, true);


           // dockContainer1.SetAutoHide(properties_tab, true);
           // dockContainer1.SetAutoHide(toolbox_tab, true);


           // editor_tab.IsSelected = true;
            GetStarted_tab.IsSelected = true;

        
        }

      

         void OnDockerShowContextMenu(object sender, FormContextMenuEventArgs e)
        {
           // contextMenuStrip1.Show(e.Form, e.MenuLocation);
        }

        void OnDockerFormClosed(object sender, FormEventArgs e)
        {
            e.Form.Close();
        }

        

        void OnDockerFormClosing(object sender, DockableFormClosingEventArgs e)
        {
            DockableFormInfo info = dockContainer1.GetFormInfo(e.Form);
            if (info.Id == new Guid("3d8466c1-e406-4e47-b744-6915afe6e001"))
            {
                e.Cancel = true;
            }
        }


        void CloseSolution()
        {
           dockContainer1.Visible = false;

           if(editor_tab != null)
            if (!(editor_tab.IsDisposed))
            {
                editor_tab.Dispose();
                ed = null;
            }

           if(solution_explorer_tab != null)
            if (!(solution_explorer_tab.IsDisposed))
            {
                solution_explorer_tab.Dispose();
                se = null;
            }
           
           if(code_explorer_tab != null)
            if (!(code_explorer_tab.IsDisposed))
            {
                code_explorer_tab.Dispose();
                ce = null;
            }
            
           if(error_display_tab != null)
            if (!(error_display_tab.IsDisposed))
            {
                error_display_tab.Dispose();
                errl = null;
            }
            
           if(output_display_tab != null)
            if (!(output_display_tab.IsDisposed))
            {
                output_display_tab.Dispose();
                op = null;
            }

           if(file_manage_tab != null)
            if (!(file_manage_tab.IsDisposed))
            {
                file_manage_tab.Dispose();
                fm = null;
            }

           if(design_tab != null)
            if (!(design_tab.IsDisposed))
            {
                design_tab.Dispose();
                dp = null;
            }

           if(toolbox_tab != null)
            if (!(toolbox_tab.IsDisposed))
            {
                toolbox_tab.Dispose();
                tb = null;
            }

           if (properties_tab != null)
               if (!(properties_tab.IsDisposed))
               {
                   properties_tab.Dispose();
                   pro = null;
               }

           GC.Collect();

           dockContainer1.Visible = true;

        }


       public void create_treeview(String path)
        {
            se.treeView1.Nodes.Clear();
            string asln_path = path;
            
            //solution_explorer_tab = dockContainer1.Add(se, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e004"));
            //dockContainer1.DockForm(solution_explorer_tab, DockStyle.Right, zDockMode.Inner);
            //dockContainer1.SetAutoHide(solution_explorer_tab, true);


            using (XmlReader reader = XmlReader.Create(path))
            {

                sol_path = Path.GetDirectoryName(path);
                string txt = "";
                string txt2 = "";
                reader.MoveToContent();
                while (reader.Read())
                {
                    txt = "";
                    txt2 = "";
                  if (reader.NodeType == XmlNodeType.Element)
                    {
                        txt += reader.Name;
                        reader.Read();
                    }
                 
                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        txt2 += reader.Value;
                    }

                    if (txt != "" && txt2 != "")
                    {
                        
                            if (txt == "ProjectName")
                                project_name = txt2;

                            if (txt == "ProjectType")
                                project_type = txt2;

                            if (txt == "ProjectPlatform")
                                project_platform = txt2;

                            if (txt == "ResourcePath")
                                resources_path = sol_path+ "\\" + txt2;

                            if (txt == "FormsPath")
                                forms_path = sol_path + "\\" + txt2;

                            if (txt == "SourcePath")
                                source_path = sol_path + "\\" + txt2;

                            if (txt == "BinaryPath")
                                bin_path = sol_path + "\\" + txt2;
                        
                    }
                    
                    
                }

                
            }

            //Font font = new Font(se.treeView1.Font, FontStyle.Bold);
            TreeNode SolutionNode = new TreeNode("Solution '"+ project_name +"'",0,0);
            SolutionNode.Tag = "sol";
            SolutionNode.ContextMenuStrip = se.solMenu;
        
            //SolutionNode.NodeFont = font;
//            SolutionNode.EnsureVisible();

            foreach (var d in Directory.GetDirectories(sol_path))
            {
                //MessageBox.Show(Path.GetFileName(d).ToString());    
                
               TreeNode FolderNode = new TreeNode(Path.GetFileName(d).ToString(), 1, 1);
               FolderNode.Tag = "folder";
               FolderNode.ContextMenuStrip = se.folderMenu;

               foreach (var f in Directory.GetFiles(d.ToString()))
               {
                   if (Path.GetFileName(d).ToString() == "Forms")
                   {
                      
                       //4
                       TreeNode FormNode = new TreeNode(Path.GetFileNameWithoutExtension(f).ToString(), 4, 4);
                       FormNode.Tag = "forms|"+f;
                       FormNode.ContextMenuStrip = se.fileMenu;
                       FolderNode.Nodes.Add(FormNode);
                   }
                   else if (Path.GetFileName(d).ToString() == "Source")
                   {
                      
                       //2
                       TreeNode SourceNode = new TreeNode(Path.GetFileNameWithoutExtension(f).ToString(), 2, 2);
                       SourceNode.Tag = "src|"+f;
                       SourceNode.ContextMenuStrip = se.fileMenu;
                       FolderNode.Nodes.Add(SourceNode);
                   }
                   else if (Path.GetFileName(d).ToString() == "Resources")
                   {
                      
                       //3
                       TreeNode ResNode = new TreeNode(Path.GetFileNameWithoutExtension(f).ToString(), 3, 3);
                       ResNode.Tag = "res|"+f;
                       ResNode.ContextMenuStrip = se.fileMenu;
                       FolderNode.Nodes.Add(ResNode);
                   }
                   
               }

                if(Path.GetFileName(d).ToString() != "Binaries")
                SolutionNode.Nodes.Add(FolderNode);
            }


            se.treeView1.Nodes.Add(SolutionNode);
            se.treeView1.ExpandAll();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //CreateTab(null);
            GC.Collect();

            if (ed != null)
            {
                if (MessageBox.Show("Are you sure you want to close the current alpha solution? Please Save Your Files Before Creating New Solution.", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CloseSolution();
                    np = null;
                    //np.Dispose();
                    np = new New_Project(this);
                    np.Show();
                }
               
            }
            else
            {
                if (np == null)
                {
                    np = new New_Project(this);
                    np.Show();
                }
            }
            
        }


        public void initCLIenvoirment(String pth, String main_path)
        {
            if(ce == null)
            ce = new codeexplorer(this);
            if (errl == null)
            errl = new errlist(this);
            if (fm == null)
            fm = new filemangemnt(this);
            if (op == null)
            op = new output(this);
            if (se == null)
            se = new solutionexplorer(this);
            if (ed == null)
            ed = new editor(this);


            dockContainer1.Visible = false;

            
            if (GetStarted_tab.IsDisposed)
            {
                editor_tab = dockContainer1.Add(ed, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e001"));
                editor_tab.ShowCloseButton = false;
                editor_tab.ShowContextMenuButton = false;
                editor_tab.IsSelected = true;
             
                dockContainer1.DockForm(editor_tab, DockStyle.Fill, zDockMode.None);

                if (pth != "?")
                {
                    if (pth != "" || pth != null)
                        CreateTab(pth);
                    else
                        CreateTab(null);
                }
            }
            else
            {

                editor_tab = dockContainer1.Add(ed, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e001"));
                editor_tab.ShowCloseButton = false;
                editor_tab.ShowContextMenuButton = false;
                editor_tab.IsSelected = true;
                dockContainer1.DockForm(editor_tab, GetStarted_tab, DockStyle.Fill, zDockMode.None);

                if (pth != "?")
                {
                    if (pth != "" || pth != null)
                        CreateTab(pth);
                    else
                        CreateTab(null);
                }
            }



            GC.Collect();
            Application.DoEvents();

            solution_explorer_tab = dockContainer1.Add(se, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e004"));
            dockContainer1.DockForm(solution_explorer_tab, DockStyle.Right, zDockMode.Inner);
            dockContainer1.SetAutoHide(solution_explorer_tab, true);

            code_explorer_tab = dockContainer1.Add(ce, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e005"));
            dockContainer1.DockForm(code_explorer_tab, DockStyle.Right, zDockMode.Inner);
            dockContainer1.SetAutoHide(code_explorer_tab, true);

            error_display_tab = dockContainer1.Add(errl, zAllowedDock.Bottom, new Guid("3d8466c1-e406-4e47-b744-6915afe6e006"));
            error_display_tab.ShowFormAutoPanel();
            dockContainer1.DockForm(error_display_tab, DockStyle.Bottom, zDockMode.Inner);
            dockContainer1.SetAutoHide(error_display_tab, true);

            output_display_tab = dockContainer1.Add(op, zAllowedDock.Bottom, new Guid("3d8466c1-e406-4e47-b744-6915afe6e007"));
            dockContainer1.DockForm(output_display_tab, DockStyle.Bottom, zDockMode.Inner);
            dockContainer1.SetAutoHide(output_display_tab, true);

            file_manage_tab = dockContainer1.Add(fm, zAllowedDock.Left, new Guid("3d8466c1-e406-4e47-b744-6915afe6e008"));
            dockContainer1.DockForm(file_manage_tab, DockStyle.Left, zDockMode.Inner);
            dockContainer1.SetAutoHide(file_manage_tab, true);


            create_treeview(main_path);
            dockContainer1.Visible = true;

        }

        public void initGUIenvoirment(String pth, String main_path)
        {
            if (ce == null)
                ce = new codeexplorer(this);
            if (errl == null)
                errl = new errlist(this);
            if (fm == null)
                fm = new filemangemnt(this);
            if (op == null)
                op = new output(this);
            if (se == null)
                se = new solutionexplorer(this);
            if (ed == null)
                ed = new editor(this);
            if (tb == null)
                tb = new toolbx(this);
            if (pro == null)
                pro = new property(this);
            //if (dp == null)
            //    dp = new design_panel(this, ref pro);


            dockContainer1.Visible = false;


            //CLI

            if (GetStarted_tab.IsDisposed)
            {
                editor_tab = dockContainer1.Add(ed, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e001"));
                editor_tab.ShowCloseButton = false;
                editor_tab.ShowContextMenuButton = false;
                editor_tab.IsSelected = true;

                dockContainer1.DockForm(editor_tab, DockStyle.Fill, zDockMode.None);
                if (pth != "?")
                {

                    if (pth != "" || pth != null)
                        CreateTab(pth);
                    else
                        CreateTab(null);
                }
            }
            else
            {

                editor_tab = dockContainer1.Add(ed, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e001"));
                editor_tab.ShowCloseButton = false;
                editor_tab.ShowContextMenuButton = false;
                editor_tab.IsSelected = true;
                dockContainer1.DockForm(editor_tab, GetStarted_tab, DockStyle.Fill, zDockMode.None);

                if (pth != "?")
                {
                    if (pth != "" || pth != null)
                        CreateTab(pth);
                    else
                        CreateTab(null);
                }
            }


            ////GUI init
            //try
            //{
            //    if (GetStarted_tab.IsDisposed)
            //    {

            //        design_tab = dockContainer1.Add(dp, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e011"));
            //        dockContainer1.DockForm(design_tab, DockStyle.Fill, zDockMode.None);
            //        design_tab.IsSelected = true;


            //    }
            //    else
            //    {
            //        design_tab = dockContainer1.Add(dp, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e011"));
            //        dockContainer1.DockForm(design_tab, GetStarted_tab, DockStyle.Fill, zDockMode.None);
            //        design_tab.IsSelected = true;


                    
            //    }


            //    Dpanelx.Add(dp,design_tab);
            //}
            //catch (Exception exx)
            //{
            //    MessageBox.Show(exx.Message);
            //}


            GC.Collect();
            Application.DoEvents();

            solution_explorer_tab = dockContainer1.Add(se, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e004"));
            dockContainer1.DockForm(solution_explorer_tab, DockStyle.Right, zDockMode.Inner);
            dockContainer1.SetAutoHide(solution_explorer_tab, true);

            code_explorer_tab = dockContainer1.Add(ce, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e005"));
            dockContainer1.DockForm(code_explorer_tab, DockStyle.Right, zDockMode.Inner);
            dockContainer1.SetAutoHide(code_explorer_tab, true);

            error_display_tab = dockContainer1.Add(errl, zAllowedDock.Bottom, new Guid("3d8466c1-e406-4e47-b744-6915afe6e006"));
            error_display_tab.ShowFormAutoPanel();
            dockContainer1.DockForm(error_display_tab, DockStyle.Bottom, zDockMode.Inner);
            dockContainer1.SetAutoHide(error_display_tab, true);

            output_display_tab = dockContainer1.Add(op, zAllowedDock.Bottom, new Guid("3d8466c1-e406-4e47-b744-6915afe6e007"));
            dockContainer1.DockForm(output_display_tab, DockStyle.Bottom, zDockMode.Inner);
            dockContainer1.SetAutoHide(output_display_tab, true);

            file_manage_tab = dockContainer1.Add(fm, zAllowedDock.Left, new Guid("3d8466c1-e406-4e47-b744-6915afe6e008"));
            dockContainer1.DockForm(file_manage_tab, DockStyle.Left, zDockMode.Inner);
            dockContainer1.SetAutoHide(file_manage_tab, true);

            properties_tab = dockContainer1.Add(pro, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e009"));
            dockContainer1.DockForm(properties_tab, DockStyle.Right, zDockMode.Inner);
            dockContainer1.SetAutoHide(properties_tab, true);
            

            toolbox_tab = dockContainer1.Add(tb, zAllowedDock.Left, new Guid("3d8466c1-e406-4e47-b744-6915afe6e010"));
            dockContainer1.DockForm(toolbox_tab, DockStyle.Left, zDockMode.Inner);
            dockContainer1.SetAutoHide(toolbox_tab, true);

            create_treeview(main_path);

            dockContainer1.Visible = true;
        }

       

        public void CreateForm(string path)
        {

            //FIX PROPERTY VISIBLITY ISSUE
            //FIX DIALOG SAVE THINGI

            string txt = "form";
            Size size = new Size(356,331);
            Color backcolor = Color.FromName("control");
            Color forecolor = Color.FromName("black");
            Control[] controls = null;

            using (XmlReader reader = XmlReader.Create(path))
            {

                string node1 = "";
                string node2 = "";

                reader.MoveToContent();
                while (reader.Read())
                {
                    node1 = "";
                    node2 = "";
                    
                    if (reader.NodeType == XmlNodeType.Element)
                    {
                        node1 = reader.Name;
                        reader.Read();
                    }

                    if (reader.NodeType == XmlNodeType.Text)
                    {
                        node2 = reader.Value;
                    }

                    if (node1 != "" && node2 != "")
                    {
                        //if (node1 == "FormName")
                        //    nam = node2;
                        if (node1 == "FormText")
                            txt = node2;
                        if (node1 == "FormSize")
                        {
                            size.Height = Convert.ToInt32(node2.Split(',').GetValue(0).ToString());
                            size.Width = Convert.ToInt32(node2.Split(',').GetValue(1).ToString());
                        }
                        if(node1 == "BackColor")
                        {
                            backcolor = Color.FromName(node2);
                        }
                        if (node1 == "ForeColor")
                        {
                            forecolor = Color.FromName(node2);
                        }

                        //ADD XML to CONTROLS SHIT
                            
                    }
                }
            }


            ////TEMP CODE
            //if (pro == null)
            //    pro = new property(this);
            ////=========      
           
            dp = new design_panel(this, ref pro,tb);
            dp.Text = txt;
            //dp.Name = nam;
            dp.bt.Text = txt;
            dp.bt.Size = size;
            dp.bt.BackColor = backcolor;
            dp.bt.ForeColor = forecolor;
           
            if (controls != null)
            {
                foreach (Control c in controls)
                {
                    dp.bt.Controls.Add(c);
                }
            }
         

            //GUI init
            try
            {
                if (GetStarted_tab.IsDisposed)
                {

                    design_tab = dockContainer1.Add(dp, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e011"));
                    dockContainer1.DockForm(design_tab, DockStyle.Fill, zDockMode.None);
                    design_tab.IsSelected = true;


                }
                else
                {
                    design_tab = dockContainer1.Add(dp, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e011"));
                    dockContainer1.DockForm(design_tab, GetStarted_tab, DockStyle.Fill, zDockMode.None);
                    design_tab.IsSelected = true;



                }


                Dpanelx.Add(dp, design_tab);
            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }

          
        }
        

        public void CreateTab(string fileName)
        {
            try
            {
            

                if (ed == null)
                {
                    ed = new editor(this);
                    editor_tab = dockContainer1.Add(ed, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e001"));
                   if(GetStarted_tab.IsDisposed)
                    {
                       dockContainer1.DockForm(editor_tab, DockStyle.Fill, zDockMode.None);
                        
                    }
                   else
                    {
                        dockContainer1.DockForm(editor_tab, GetStarted_tab, DockStyle.Fill, zDockMode.None);
                    }

                    editor_tab.ShowCloseButton = true;
                }

                GC.Collect();

                var tb = new FastColoredTextBox();
                tb.Language = Language.CSharp;
                tb.ContextMenuStrip = cmMain;
                tb.Dock = DockStyle.Fill;
                tb.BorderStyle = BorderStyle.Fixed3D;
                tb.LeftPadding = 17;
                //tb.Language = Language.CSharp;
                tb.AddStyle(new MarkerStyle(new SolidBrush(Color.FromArgb(50, Color.Gray))));//same words style
                var tab = new FATabStripItem(fileName != null ? Path.GetFileName(fileName) : "[new]", tb);
                tab.Tag = fileName;
                if (fileName != null)
                    tb.Text = File.ReadAllText(fileName);
                tb.ClearUndo();
                tb.Tag = new TbInfo();
                tb.IsChanged = false;
                ed.tsFiles.AddTab(tab);
                ed.tsFiles.SelectedItem = tab;
                tb.Focus();
                tb.DelayedTextChangedInterval = 1000;
                tb.DelayedEventsInterval = 1000;
                tb.TextChangedDelayed += new EventHandler<TextChangedEventArgs>(tb_TextChangedDelayed);
                tb.SelectionChangedDelayed += new EventHandler(tb_SelectionChangedDelayed);
                tb.KeyDown += new KeyEventHandler(tb_KeyDown);
                tb.MouseMove += new MouseEventHandler(tb_MouseMove);
                tb.LineRemoved += new EventHandler<LineRemovedEventArgs>(tb_LineRemoved);
                tb.PaintLine += new EventHandler<PaintLineEventArgs>(tb_PaintLine);
                tb.ChangedLineColor = changedLineColor;
                if (btHighlightCurrentLine.Checked)
                    tb.CurrentLineColor = currentLineColor;
                tb.HighlightingRangeType = HighlightingRangeType.VisibleRange;
                //create autocomplete popup menu
                AutocompleteMenu popupMenu = new AutocompleteMenu(tb);
                popupMenu.Items.ImageList = ilAutocomplete;
                popupMenu.Opening += new EventHandler<CancelEventArgs>(popupMenu_Opening);
                BuildAutocompleteMenu(popupMenu);
                (tb.Tag as TbInfo).popupMenu = popupMenu;
                tb.Text = tb.Text.ToString();
                tb.Undo();
                tb.Redo();
                tb.Focus();
                //tb.Select();
               // tb.Text = code;
                //tb.Language = Language.CSharp;

              
             
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == System.Windows.Forms.DialogResult.Retry)
                    CreateTab(fileName);
            }
        }

        void popupMenu_Opening(object sender, CancelEventArgs e)
        {
           
            //---block autocomplete menu for comments
            //get index of green style (used for comments)
            var iGreenStyle = CurrentTB.GetStyleIndex(CurrentTB.SyntaxHighlighter.GreenStyle);
            if (iGreenStyle >= 0)
                if (CurrentTB.Selection.Start.iChar > 0)
                {
                    //current char (before caret)
                    var c = CurrentTB[CurrentTB.Selection.Start.iLine][CurrentTB.Selection.Start.iChar - 1];
                    //green Style
                    var greenStyleIndex = Range.ToStyleIndex(iGreenStyle);
                    //if char contains green style then block popup menu
                    if ((c.style & greenStyleIndex) != 0)
                        e.Cancel = true;
                }
        }

        void tb_PaintLine(object sender, PaintLineEventArgs e)
        {
            TbInfo info = (sender as FastColoredTextBox).Tag as TbInfo;

            //draw bookmark
            if (info.bookmarksLineId.Contains((sender as FastColoredTextBox)[e.LineIndex].UniqueId))
            {
                e.Graphics.FillEllipse(new LinearGradientBrush(new Rectangle(0, e.LineRect.Top, 15, 15), Color.White, Color.PowderBlue, 45), 0, e.LineRect.Top, 15, 15);
                e.Graphics.DrawEllipse(Pens.PowderBlue, 0, e.LineRect.Top, 15, 15);
            }
        }

        void tb_LineRemoved(object sender, LineRemovedEventArgs e)
        {
            TbInfo info = (sender as FastColoredTextBox).Tag as TbInfo;

            //remove lines from bookmarks
            foreach (int id in e.RemovedLineUniqueIds)
                if (info.bookmarksLineId.Contains(id))
                {
                    info.bookmarksLineId.Remove(id);
                    info.bookmarks.Remove(id);
                }
        }



        private void BuildAutocompleteMenu(AutocompleteMenu popupMenu)
        {

                      List<AutocompleteItem> items = new List<AutocompleteItem>();

                        foreach (var item in snippets)
                            items.Add(new SnippetAutocompleteItem(item) { ImageIndex = 1 });
                        foreach (var item in declarationSnippets)
                            items.Add(new DeclarationSnippet(item) { ImageIndex = 0 });
                        foreach (string item in methods_php)
                         // items.Add(new MethodAutocompleteItem(item) { ImageIndex = 2 });
                            items.Add(new AutocompleteItem(item) { ImageIndex = 2 });
                          foreach (var item in keywords)
                            items.Add(new AutocompleteItem(item));

                        items.Add(new InsertSpaceSnippet());
                        items.Add(new InsertSpaceSnippet(@"^(\w+)([=<>!:]+)(\w+)$"));
                        items.Add(new InsertEnterSnippet());

                        //set as autocomplete source
                        popupMenu.Items.SetAutocompleteItems(items);
                        popupMenu.SearchPattern = @"[\w\.:=!<>]";

   
        }

        void tb_MouseMove(object sender, MouseEventArgs e)
        {
            var tb = sender as FastColoredTextBox;
            var place = tb.PointToPlace(e.Location);
            var r = new Range(tb, place, place);
            string text = r.GetFragment("[a-zA-Z]").Text;
            lbWordUnderMouse.Text = text;
        }

        void tb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Control && e.KeyCode == Keys.OemMinus)
            {
                NavigateBackward();
                e.Handled = true;
            }

            if (e.Modifiers == (Keys.Control|Keys.Shift) && e.KeyCode == Keys.OemMinus)
            {
                NavigateForward();
                e.Handled = true;
            }

            if (e.KeyData == (Keys.K | Keys.Control))
            {
                //forced show (MinFragmentLength will be ignored)
                (CurrentTB.Tag as TbInfo).popupMenu.Show(true);
                e.Handled = true;
            }
        }

        void tb_SelectionChangedDelayed(object sender, EventArgs e)
        {
            var tb = sender as FastColoredTextBox;
            //remember last visit time
            if (tb.Selection.Start == tb.Selection.End && tb.Selection.Start.iLine < tb.LinesCount)
            {
                if (lastNavigatedDateTime != tb[tb.Selection.Start.iLine].LastVisit)
                {
                    tb[tb.Selection.Start.iLine].LastVisit = DateTime.Now;
                    lastNavigatedDateTime = tb[tb.Selection.Start.iLine].LastVisit;
                }
            }

            //highlight same words
            tb.VisibleRange.ClearStyle(tb.Styles[0]);
            if (tb.Selection.Start != tb.Selection.End)
                return;//user selected diapason
            //get fragment around caret
            var fragment = tb.Selection.GetFragment(@"\w");
            string text = fragment.Text;
            if (text.Length == 0)
                return;
            //highlight same words
            var ranges = tb.VisibleRange.GetRanges("\\b" + text + "\\b").ToArray();
            if (ranges.Length > 1)
                foreach (var r in ranges)
                    r.SetStyle(tb.Styles[0]);
        }

        void tb_TextChangedDelayed(object sender, TextChangedEventArgs e)
        {
            FastColoredTextBox tb = (sender as FastColoredTextBox);
            //rebuild object explorer
            string text = (sender as FastColoredTextBox).Text;
            ThreadPool.QueueUserWorkItem(
                (o)=>ReBuildObjectExplorer(text)
            );

            //show invisible chars
            HighlightInvisibleChars(e.ChangedRange);
        }

        private void HighlightInvisibleChars(Range range)
        {
            range.ClearStyle(invisibleCharsStyle);
            if (btInvisibleChars.Checked)
                range.SetStyle(invisibleCharsStyle, @".$|.\r\n|\s");
        }

        List<ExplorerItem> explorerList = new List<ExplorerItem>();

        public void ReBuildObjectExplorer(string text)
        {
            try
            {
                List<ExplorerItem> list = new List<ExplorerItem>();
                int lastClassIndex = -1;
                //find classes, methods and properties
                Regex regex = new Regex(@"^(?<range>[\w\s]+\b(class|struct|enum|interface)\s+[\w<>,\s]+)|^\s*(public|private|internal|protected)[^\n]+(\n?\s*{|;)?", RegexOptions.Multiline);
                foreach (Match r in regex.Matches(text))
                    try
                    {
                        string s = r.Value;
                        int i = s.IndexOfAny(new char[] { '=', '{', ';' });
                        if (i >= 0)
                            s = s.Substring(0, i);
                        s = s.Trim();

                        var item = new ExplorerItem() { title = s, position = r.Index };
                        if (Regex.IsMatch(item.title, @"\b(class|struct|enum|interface)\b"))
                        {
                            item.title = item.title.Substring(item.title.LastIndexOf(' ')).Trim();
                            item.type = ExplorerItemType.Class;
                            list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), new ExplorerItemComparer());
                            lastClassIndex = list.Count;
                        }
                        else
                            if (item.title.Contains(" event "))
                            {
                                int ii = item.title.LastIndexOf(' ');
                                item.title = item.title.Substring(ii).Trim();
                                item.type = ExplorerItemType.Event;
                            }
                            else
                                if (item.title.Contains("("))
                                {
                                    var parts = item.title.Split('(');
                                    item.title = parts[0].Substring(parts[0].LastIndexOf(' ')).Trim() + "(" + parts[1];
                                    item.type = ExplorerItemType.Method;
                                }
                                else
                                    if (item.title.EndsWith("]"))
                                    {
                                        var parts = item.title.Split('[');
                                        if (parts.Length < 2) continue;
                                        item.title = parts[0].Substring(parts[0].LastIndexOf(' ')).Trim() + "[" + parts[1];
                                        item.type = ExplorerItemType.Method;
                                    }
                                    else
                                    {
                                        int ii = item.title.LastIndexOf(' ');
                                        item.title = item.title.Substring(ii).Trim();
                                        item.type = ExplorerItemType.Property;
                                    }
                        list.Add(item);
                    }
                    catch { ;}

                list.Sort(lastClassIndex + 1, list.Count - (lastClassIndex + 1), new ExplorerItemComparer());

                BeginInvoke(
                    new Action(() =>
                        {
                            explorerList = list;
                            //dgvObjectExplorer.RowCount = explorerList.Count;
                            //dgvObjectExplorer.Invalidate();
                        })
                );
            }
            catch { ;}
        }

        enum ExplorerItemType
        {
            Class, Method, Property, Event
        }

        class ExplorerItem
        {
            public ExplorerItemType type;
            public string title;
            public int position;
        }

        class ExplorerItemComparer : IComparer<ExplorerItem>
        {
            public int Compare(ExplorerItem x, ExplorerItem y)
            {
                return x.title.CompareTo(y.title);
            }
        }


        //private void tsFiles_TabStripItemClosing_1(TabStripItemClosingEventArgs e)
        //{

        //}
        public bool Save(FATabStripItem tab)
        {
            var tb = (tab.Controls[0] as FastColoredTextBox);
            if (tab.Tag == null)
            {
                if (sfdMain.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return false;
                tab.Title = Path.GetFileName(sfdMain.FileName);
                tab.Tag = sfdMain.FileName;
            }

            try
            {
                File.WriteAllText(tab.Tag as string, tb.Text);
                tb.IsChanged = false;
            }
            catch (Exception ex)
            {
                if (MessageBox.Show(ex.Message, "Error", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error) == DialogResult.Retry)
                    return Save(tab);
                else
                    return false;
            }

            tb.Invalidate();

            return true;
        }

    
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
            if (ed.tsFiles.SelectedItem != null)
                Save(ed.tsFiles.SelectedItem);
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ed.tsFiles.SelectedItem != null)
            {
                string oldFile = ed.tsFiles.SelectedItem.Tag as string;
                ed.tsFiles.SelectedItem.Tag = null;
                if (!Save(ed.tsFiles.SelectedItem))
                if(oldFile!=null)
                {
                    ed.tsFiles.SelectedItem.Tag = oldFile;
                    ed.tsFiles.SelectedItem.Title = Path.GetFileName(oldFile);
                }
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // ofdMain.ShowDialog();
            //openFileDialog1.ShowDialog();
            //IF SOME SOLUTION IS CURRENTLY LOADED
            if (ed != null)
            {
                if (MessageBox.Show("Are you sure you want to close the current alpha solution and open a new one? Please Save Your Files Before Creating New Solution!!", "Notification", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    CloseSolution();
                    //ofdMain.Reset();

                    ofdMain.ShowDialog();

                    if (ofdMain.CheckPathExists)
                    {
                        if (ofdMain.FileName != null && ofdMain.FileName != "")
                        {
                            //READ THE ASLN N LOAD ALL SHIT


                            using (XmlReader reader = XmlReader.Create(ofdMain.FileName))
                            {

                                sol_path = Path.GetDirectoryName(ofdMain.FileName);
                                string txt = "";
                                string txt2 = "";
                                reader.MoveToContent();
                                while (reader.Read())
                                {
                                    txt = "";
                                    txt2 = "";
                                    if (reader.NodeType == XmlNodeType.Element)
                                    {
                                        txt += reader.Name;
                                        reader.Read();
                                    }

                                    if (reader.NodeType == XmlNodeType.Text)
                                    {
                                        txt2 += reader.Value;
                                    }

                                    if (txt != "" && txt2 != "")
                                    {

                                        if (txt == "ProjectName")
                                            project_name = txt2;

                                        if (txt == "ProjectType")
                                            project_type = txt2;

                                        if (txt == "ProjectPlatform")
                                            project_platform = txt2;

                                        if (txt == "ResourcePath")
                                            resources_path = sol_path + "\\" + txt2;

                                        if (txt == "FormsPath")
                                            forms_path = sol_path + "\\" + txt2;

                                        if (txt == "SourcePath")
                                            source_path = sol_path + "\\" + txt2;

                                        if (txt == "BinaryPath")
                                            bin_path = sol_path + "\\" + txt2;

                                    }


                                }


                            }




                            //INIT OPEN STARTS HERE
                            this.Text = this.Text + " - " + project_name;

                            //Handling Project Type
                            if (project_type == "Empty")
                            {
                                initCLIenvoirment(null, ofdMain.FileName);
                            }
                            else if (project_type == "Console")
                            {
                                //Handels CLI Architecture
                                if (project_platform == "x86")
                                {
                                    initCLIenvoirment("?", ofdMain.FileName);
                                }
                                else if (project_platform == "x64")
                                {
                                    initCLIenvoirment("?", ofdMain.FileName);
                                }
                                else
                                {
                                    MessageBox.Show("Project Not Recognized", "Alpha Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    goto nil;
                                }
                            }
                            else if (project_type == "ConsoleAdv")
                            {
                                initCLIenvoirment("?", ofdMain.FileName);
                            }
                            else if (project_type == "Win32")
                            {
                                //Handels GUI Architecture
                                if (project_platform == "x86")
                                {
                                    initGUIenvoirment("?", ofdMain.FileName);
                                }
                                else if (project_platform == "x64")
                                {
                                    initGUIenvoirment("?", ofdMain.FileName);
                                }
                                else
                                {
                                    MessageBox.Show("Project Not Recognized", "Alpha Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    goto nil;
                                }

                            }
                            else if (project_type == "Win32Adv")
                            {
                                initGUIenvoirment("?", ofdMain.FileName);
                            }
                            else
                            {
                                MessageBox.Show("Project Not Recognized", "Alpha Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto nil;
                            }


                        }
                    }


                nil:
                    ;
                }
            }
            else
            {
                //IF NO SOLUTION IS CURRENTLY LOADED
               // ofdMain.Reset();

                ofdMain.ShowDialog();

                if (ofdMain.CheckPathExists)
                {
                    if (ofdMain.FileName != null && ofdMain.FileName != "")
                    {
                        //READ THE ASLN N LOAD ALL SHIT


                        using (XmlReader reader = XmlReader.Create(ofdMain.FileName))
                        {

                            sol_path = Path.GetDirectoryName(ofdMain.FileName);
                            string txt = "";
                            string txt2 = "";
                            reader.MoveToContent();
                            while (reader.Read())
                            {
                                txt = "";
                                txt2 = "";
                                if (reader.NodeType == XmlNodeType.Element)
                                {
                                    txt += reader.Name;
                                    reader.Read();
                                }

                                if (reader.NodeType == XmlNodeType.Text)
                                {
                                    txt2 += reader.Value;
                                }

                                if (txt != "" && txt2 != "")
                                {

                                    if (txt == "ProjectName")
                                        project_name = txt2;

                                    if (txt == "ProjectType")
                                        project_type = txt2;

                                    if (txt == "ProjectPlatform")
                                        project_platform = txt2;

                                    if (txt == "ResourcePath")
                                        resources_path = sol_path + "\\" + txt2;

                                    if (txt == "FormsPath")
                                        forms_path = sol_path + "\\" + txt2;

                                    if (txt == "SourcePath")
                                        source_path = sol_path + "\\" + txt2;

                                    if (txt == "BinaryPath")
                                        bin_path = sol_path + "\\" + txt2;

                                }


                            }


                        }




                        //INIT OPEN STARTS HERE
                        this.Text = this.Text + " - " + project_name;

                        //Handling Project Type
                        if (project_type == "Empty")
                        {
                            initCLIenvoirment(null, ofdMain.FileName);
                        }
                        else if (project_type == "Console")
                        {
                            //Handels CLI Architecture
                            if (project_platform == "x86")
                            {
                                initCLIenvoirment("?", ofdMain.FileName);
                            }
                            else if (project_platform == "x64")
                            {
                                initCLIenvoirment("?", ofdMain.FileName);
                            }
                            else
                            {
                                MessageBox.Show("Project Not Recognized", "Alpha Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto nil;
                            }
                        }
                        else if (project_type == "ConsoleAdv")
                        {
                            initCLIenvoirment("?", ofdMain.FileName);
                        }
                        else if (project_type == "Win32")
                        {
                            //Handels GUI Architecture
                            if (project_platform == "x86")
                            {
                                initGUIenvoirment("?", ofdMain.FileName);
                            }
                            else if (project_platform == "x64")
                            {
                                initGUIenvoirment("?", ofdMain.FileName);
                            }
                            else
                            {
                                MessageBox.Show("Project Not Recognized", "Alpha Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                goto nil;
                            }

                        }
                        else if (project_type == "Win32Adv")
                        {
                            initGUIenvoirment("?", ofdMain.FileName);
                        }
                        else
                        {
                            MessageBox.Show("Project Not Recognized", "Alpha Studio", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            goto nil;
                        }


                    }
                }


            nil:
                ;
            }

           
        }

     public FastColoredTextBox CurrentTB
        {
            get {
                if (ed.tsFiles.SelectedItem == null)
                    return null;
                return (ed.tsFiles.SelectedItem.Controls[0] as FastColoredTextBox);
            }

            set
            {
                ed.tsFiles.SelectedItem = (value.Parent as FATabStripItem);
                value.Focus();
            }
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.Cut();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.Selection.SelectAll();
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentTB.UndoEnabled)
                CurrentTB.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (CurrentTB.RedoEnabled)
                CurrentTB.Redo();
        }

        private void tmUpdateInterface_Tick(object sender, EventArgs e)
        {
            try
            {
                if(CurrentTB != null && ed.tsFiles.Items.Count>0)
                {
                    var tb = CurrentTB;
                    undoStripButton.Enabled = undoToolStripMenuItem.Enabled = tb.UndoEnabled;
                    redoStripButton.Enabled = redoToolStripMenuItem.Enabled = tb.RedoEnabled;
                    saveToolStripButton.Enabled = saveToolStripMenuItem.Enabled = tb.IsChanged;
                    saveAsToolStripMenuItem.Enabled = true;
                    pasteToolStripButton.Enabled = pasteToolStripMenuItem.Enabled = true;
                    cutToolStripButton.Enabled = cutToolStripMenuItem.Enabled =
                    copyToolStripButton.Enabled = copyToolStripMenuItem.Enabled = tb.Selection.Start != tb.Selection.End;
                    printToolStripButton.Enabled = true;
                }
                else
                {
                    saveToolStripButton.Enabled = saveToolStripMenuItem.Enabled = false;
                    saveAsToolStripMenuItem.Enabled = false;
                    cutToolStripButton.Enabled = cutToolStripMenuItem.Enabled =
                    copyToolStripButton.Enabled = copyToolStripMenuItem.Enabled = false;
                    pasteToolStripButton.Enabled = pasteToolStripMenuItem.Enabled = false;
                    printToolStripButton.Enabled = false;
                    undoStripButton.Enabled = undoToolStripMenuItem.Enabled = false;
                    redoStripButton.Enabled = redoToolStripMenuItem.Enabled = false;
                  //  dgvObjectExplorer.RowCount = 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if(CurrentTB!=null)
            {
                var settings = new PrintDialogSettings();
                settings.Title = ed.tsFiles.SelectedItem.Title;
                settings.Header = "&b&w&b";
                settings.Footer = "&b&p";
                CurrentTB.Print(settings);
            }
        }

        bool tbFindChanged = false;

        private void tbFind_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r' && CurrentTB != null)
            {
                Range r = tbFindChanged?CurrentTB.Range.Clone():CurrentTB.Selection.Clone();
                tbFindChanged = false;
                r.End = new Place(CurrentTB[CurrentTB.LinesCount - 1].Count, CurrentTB.LinesCount - 1);
                var pattern = Regex.Replace(tbFind.Text, FastColoredTextBoxNS.FindForm.RegexSpecSymbolsPattern, "\\$0");
                foreach (var found in r.GetRanges(pattern))
                {
                    found.Inverse();
                    CurrentTB.Selection = found;
                    CurrentTB.DoSelectionVisible();
                    return;
                }
                MessageBox.Show("Not found.");
            }
            else
                tbFindChanged = true;
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.ShowFindDialog();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.ShowReplaceDialog();
        }

        private void PowerfulCSharpEditor_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                List<FATabStripItem> list = new List<FATabStripItem>();
                foreach (FATabStripItem tab in ed.tsFiles.Items)
                    list.Add(tab);
                foreach (var tab in list)
                {
                    TabStripItemClosingEventArgs args = new TabStripItemClosingEventArgs(tab);
                    ed.tsFiles_TabStripItemClosing(args);
                    if (args.Cancel)
                    {
                        e.Cancel = true;
                        return;
                    }
                    ed.tsFiles.RemoveTab(tab);
                }
            }
            catch
            {
                //this.Dispose();
                //Application.Exit();
                GC.Collect();
            }
        }

        private void dgvObjectExplorer_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (CurrentTB != null)
            {
                var item = explorerList[e.RowIndex];
                CurrentTB.GoEnd();
                CurrentTB.SelectionStart = item.position;
                CurrentTB.DoSelectionVisible();
                CurrentTB.Focus();
            }
        }

        private void dgvObjectExplorer_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {
            try
            {
                ExplorerItem item = explorerList[e.RowIndex];
                if (e.ColumnIndex == 1)
                    e.Value = item.title;
                else
                    switch (item.type)
                    {
                        case ExplorerItemType.Class:
                            e.Value = global::Tester.Properties.Resources.class_libraries;
                            return;
                        case ExplorerItemType.Method:
                            e.Value = global::Tester.Properties.Resources.box;
                            return;
                        case ExplorerItemType.Event:
                            e.Value = global::Tester.Properties.Resources.lightning;
                            return;
                        case ExplorerItemType.Property:
                            e.Value = global::Tester.Properties.Resources.property;
                            return;
                    }
            }
            catch{;}
        }


        //private void tsFiles_TabStripItemSelectionChanged_1(TabStripItemChangedEventArgs e)
        //{
        //    MessageBox.Show("sd");
        //}
     
        private void backStripButton_Click(object sender, EventArgs e)
        {
            NavigateBackward();
        }

        private void forwardStripButton_Click(object sender, EventArgs e)
        {
            NavigateForward();
        }

        DateTime lastNavigatedDateTime = DateTime.Now;

        private bool NavigateBackward()
        {
            DateTime max = new DateTime();
            int iLine = -1;
            FastColoredTextBox tb = null;
            for (int iTab = 0; iTab < ed.tsFiles.Items.Count; iTab++)
            {
                var t = (ed.tsFiles.Items[iTab].Controls[0] as FastColoredTextBox);
                for (int i = 0; i < t.LinesCount; i++)
                    if (t[i].LastVisit < lastNavigatedDateTime && t[i].LastVisit > max)
                    {
                        max = t[i].LastVisit;
                        iLine = i;
                        tb = t;
                    }
            }
            if (iLine >= 0)
            {
                ed.tsFiles.SelectedItem = (tb.Parent as FATabStripItem);
                tb.Navigate(iLine);
                lastNavigatedDateTime = tb[iLine].LastVisit;
                Console.WriteLine("Backward: " + lastNavigatedDateTime);
                tb.Focus();
                tb.Invalidate();
                return true;
            }
            else
                return false;
        }

        private bool NavigateForward()
        {
            DateTime min = DateTime.Now;
            int iLine = -1;
            FastColoredTextBox tb = null;
            for (int iTab = 0; iTab < ed.tsFiles.Items.Count; iTab++)
            {
                var t = (ed.tsFiles.Items[iTab].Controls[0] as FastColoredTextBox);
                for (int i = 0; i < t.LinesCount; i++)
                    if (t[i].LastVisit > lastNavigatedDateTime && t[i].LastVisit < min)
                    {
                        min = t[i].LastVisit;
                        iLine = i;
                        tb = t;
                    }
            }
            if (iLine >= 0)
            {
                ed.tsFiles.SelectedItem = (tb.Parent as FATabStripItem);
                tb.Navigate(iLine);
                lastNavigatedDateTime = tb[iLine].LastVisit;
                Console.WriteLine("Forward: " + lastNavigatedDateTime);
                tb.Focus();
                tb.Invalidate();
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// This item appears when any part of snippet text is typed
        /// </summary>
        class DeclarationSnippet : SnippetAutocompleteItem
        {
            public DeclarationSnippet(string snippet)
                : base(snippet)
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var pattern = Regex.Replace(fragmentText, FastColoredTextBoxNS.FindForm.RegexSpecSymbolsPattern, "\\$0");
                if (Regex.IsMatch(Text, "\\b" + pattern, RegexOptions.IgnoreCase))
                    return CompareResult.Visible;
                return CompareResult.Hidden;
            }
        }

        /// <summary>
        /// Divides numbers and words: "123AND456" -> "123 AND 456"
        /// Or "i=2" -> "i = 2"
        /// </summary>
        class InsertSpaceSnippet : AutocompleteItem
        {
            string pattern;

            public InsertSpaceSnippet(string pattern)
                : base("")
            {
                this.pattern = pattern;
            }

            public InsertSpaceSnippet()
                : this(@"^(\d+)([a-zA-Z_]+)(\d*)$")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                if (Regex.IsMatch(fragmentText, pattern))
                {
                    Text = InsertSpaces(fragmentText);
                    if (Text != fragmentText)
                        return CompareResult.Visible;
                }
                return CompareResult.Hidden;
            }

            public string InsertSpaces(string fragment)
            {
                var m = Regex.Match(fragment, pattern);
                if (m == null)
                    return fragment;
                if (m.Groups[1].Value == "" && m.Groups[3].Value == "")
                    return fragment;
                return (m.Groups[1].Value + " " + m.Groups[2].Value + " " + m.Groups[3].Value).Trim();
            }

            public override string ToolTipTitle
            {
                get
                {
                    return Text;
                }
            }
        }

        /// <summary>
        /// Inerts line break after '}'
        /// </summary>
        class InsertEnterSnippet : AutocompleteItem
        {
            Place enterPlace = Place.Empty;

            public InsertEnterSnippet()
                : base("[Line break]")
            {
            }

            public override CompareResult Compare(string fragmentText)
            {
                var r = Parent.Fragment.Clone();
                while (r.Start.iChar > 0)
                {
                    if (r.CharBeforeStart == '}')
                    {
                        enterPlace = r.Start;
                        return CompareResult.Visible;
                    }

                    r.GoLeftThroughFolded();
                }

                return CompareResult.Hidden;
            }

            public override string GetTextForReplace()
            {
                //extend range
                Range r = Parent.Fragment;
                Place end = r.End;
                r.Start = enterPlace;
                r.End = r.End;
                //insert line break
                return Environment.NewLine + r.Text;
            }

            public override void OnSelected(AutocompleteMenu popupMenu, SelectedEventArgs e)
            {
                base.OnSelected(popupMenu, e);
                if (Parent.Fragment.tb.AutoIndent)
                    Parent.Fragment.tb.DoAutoIndent();
            }

            public override string ToolTipTitle
            {
                get
                {
                    return "Insert line break after '}'";
                }
            }
        }

        private void autoIndentSelectedTextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.DoAutoIndent();
        }

        private void btInvisibleChars_Click(object sender, EventArgs e)
        {
            foreach (FATabStripItem tab in ed.tsFiles.Items)
                HighlightInvisibleChars((tab.Controls[0] as FastColoredTextBox).Range);
            if (CurrentTB!=null)
                CurrentTB.Invalidate();
        }

        private void btHighlightCurrentLine_Click(object sender, EventArgs e)
        {
            foreach (FATabStripItem tab in ed.tsFiles.Items)
            {
                if (btHighlightCurrentLine.Checked)
                    (tab.Controls[0] as FastColoredTextBox).CurrentLineColor = currentLineColor;
                else
                    (tab.Controls[0] as FastColoredTextBox).CurrentLineColor = Color.Transparent;
            }
            if (CurrentTB != null)
                CurrentTB.Invalidate();
        }

        private void commentSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {

                        CurrentTB.InsertLinePrefix("//");
                        CurrentTB.Text = CurrentTB.Text;

                        CurrentTB.Undo();

                        CurrentTB.Redo();
        }

        private void uncommentSelectedToolStripMenuItem_Click(object sender, EventArgs e)
        {


                        CurrentTB.RemoveLinePrefix("//");
                        CurrentTB.Text = CurrentTB.Text;

                        CurrentTB.Undo();

                        CurrentTB.Redo();
        }

        private void cloneLinesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //expand selection
            CurrentTB.Selection.Expand();
            //get text of selected lines
            string text = Environment.NewLine + CurrentTB.Selection.Text;
            //move caret to end of selected lines
            CurrentTB.Selection.Start = CurrentTB.Selection.End;
            //insert text
            CurrentTB.InsertText(text);
        }

        private void cloneLinesAndCommentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //start autoUndo block
            CurrentTB.BeginAutoUndo();
            //expand selection
            CurrentTB.Selection.Expand();
            //get text of selected lines
            string text = Environment.NewLine + CurrentTB.Selection.Text;
            //comment lines
            CurrentTB.InsertLinePrefix("//");
            //move caret to end of selected lines
            CurrentTB.Selection.Start = CurrentTB.Selection.End;
            //insert text
            CurrentTB.InsertText(text);
            //end of autoUndo block
            CurrentTB.EndAutoUndo();
        }

        private void bookmarkPlusButton_Click(object sender, EventArgs e)
        {
            if(CurrentTB == null) 
                return;
            TbInfo info = CurrentTB.Tag as TbInfo;
            //get UniqueId of current line
            int id = CurrentTB[CurrentTB.Selection.Start.iLine].UniqueId;
            if (info.bookmarksLineId.Contains(id))
                return;
            //add bookmark
            info.bookmarks.Add(id);
            info.bookmarksLineId.Add(id);
            //repaint
            CurrentTB.Invalidate();
        }

        private void bookmarkMinusButton_Click(object sender, EventArgs e)
        {
            if (CurrentTB == null)
                return;
            TbInfo info = CurrentTB.Tag as TbInfo;
            //get UniqueId of current line
            int id = CurrentTB[CurrentTB.Selection.Start.iLine].UniqueId;
            if (!info.bookmarksLineId.Contains(id))
                return;
            //remove bookmark
            info.bookmarks.Remove(id);
            info.bookmarksLineId.Remove(id);
            //repaint
            CurrentTB.Invalidate();
        }

        private void gotoButton_DropDownOpening(object sender, EventArgs e)
        {
            gotoButton.DropDownItems.Clear();
            foreach (Control tab in ed.tsFiles.Items)
            {
                FastColoredTextBox tb = tab.Controls[0] as FastColoredTextBox;
                TbInfo info = tb.Tag as TbInfo;
                for (int i = 0; i < info.bookmarks.Count; i++)
                {
                    var item = gotoButton.DropDownItems.Add("Bookmark " + gotoButton.DropDownItems.Count + " [" + Path.GetFileNameWithoutExtension(tab.Tag as String) + "]");
                    item.Tag = new BookmarkInfo() { tb = tb, iBookmark = i };
                    item.Click += (o, a) => GoTo((BookmarkInfo)(o as ToolStripItem).Tag);
                }
            }
        }

        public class BookmarkInfo
        {
            public int iBookmark;
            public FastColoredTextBox tb;
        }

        private void GoTo(BookmarkInfo bookmark)
        {
            TbInfo info = bookmark.tb.Tag as TbInfo;

            try
            {
                CurrentTB = bookmark.tb;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (bookmark.iBookmark < 0 || bookmark.iBookmark >= info.bookmarks.Count)
                return;

            int id = info.bookmarks[bookmark.iBookmark];
            for (int i = 0; i < CurrentTB.LinesCount; i++)
                if (CurrentTB[i].UniqueId == id)
                {
                    CurrentTB.Selection.Start = new Place(0, i);
                    CurrentTB.DoSelectionVisible();
                    CurrentTB.Invalidate();
                    break;
                }
        }

        private void walk_Load(object sender, EventArgs e)
        {
            
            


            //  Load the XML file
    //        XmlTextReader reader = new XmlTextReader(Application.StartupPath + "\\javascript.xml");
    //        string s = "";
    //        i = 0;
    //        //  Loop over the XML file
    //        while (reader.Read())
    //        {
    //            //  Here we check the type of the node, in this case we are looking for element
    //            if (reader.NodeType == XmlNodeType.Element)
    //            {
    //                //  If the element is "profile"
    //                if (reader.Name == "KeyWord")
    //                {
    //                    s = s + reader.GetAttribute("name").ToString()+"|";
    //                    //MessageBox.Show(reader.GetAttribute("name").ToString());

    //                }
    //            }

    //        }
    //        //           MessageBox.Show(i.ToString());
    //        reader.Close();

    //File.WriteAllText("D:\\js.txt", s);
            ////  Load the XML file
            //XmlTextReader reader = new XmlTextReader(Application.StartupPath+"\\php.xml");

            ////  Loop over the XML file
            //while (reader.Read())
            //{
            //    //  Here we check the type of the node, in this case we are looking for element
            //    if (reader.NodeType == XmlNodeType.Element)
            //    {
            //        //  If the element is "profile"
            //        if (reader.Name == "KeyWord")
            //        {
            //            MessageBox.Show(reader.GetAttribute("name").ToString());
                      
            //        }
            //    }
            //}

            //reader.Close();







            //DockableFormInfo phpadmin_tab = dockContainer1.Add(padmin, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e002"));

            //DockableFormInfo liveview_tab = dockContainer1.Add(lv, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e003"));

            //DockableFormInfo solution_explorer_tab = dockContainer1.Add(se, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e004"));

            //DockableFormInfo code_explorer_tab = dockContainer1.Add(ce, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e005"));

            //DockableFormInfo error_display_tab = dockContainer1.Add(errl, zAllowedDock.Bottom, new Guid("3d8466c1-e406-4e47-b744-6915afe6e006"));

            //DockableFormInfo output_display_tab = dockContainer1.Add(op, zAllowedDock.Bottom, new Guid("3d8466c1-e406-4e47-b744-6915afe6e007"));

            //DockableFormInfo file_manage_tab = dockContainer1.Add(fm, zAllowedDock.Left, new Guid("3d8466c1-e406-4e47-b744-6915afe6e008"));

            //DockableFormInfo properties_tab = dockContainer1.Add(pro, zAllowedDock.Right, new Guid("3d8466c1-e406-4e47-b744-6915afe6e009"));

            //DockableFormInfo toolbox_tab = dockContainer1.Add(tb, zAllowedDock.Left, new Guid("3d8466c1-e406-4e47-b744-6915afe6e010"));

            //editor_tab.ShowCloseButton = false;
            //editor_tab.ShowContextMenuButton = false;


            //phpadmin_tab.ShowCloseButton = false;
            //phpadmin_tab.ShowContextMenuButton = false;

            //liveview_tab.ShowCloseButton = false;
            //liveview_tab.ShowContextMenuButton = false;

         

            
            //dockContainer1.DockForm(phpadmin_tab, editor_tab, DockStyle.Fill, zDockMode.Inner);

            //dockContainer1.DockForm(liveview_tab, phpadmin_tab, DockStyle.Fill, zDockMode.Inner);


            //dockContainer1.DockForm(solution_explorer_tab, DockStyle.Right, zDockMode.Inner);

            //dockContainer1.DockForm(code_explorer_tab, DockStyle.Right, zDockMode.Inner);

            //dockContainer1.DockForm(error_display_tab, DockStyle.Bottom, zDockMode.Inner);

            //dockContainer1.DockForm(output_display_tab, DockStyle.Bottom, zDockMode.Inner);

            //dockContainer1.DockForm(file_manage_tab, DockStyle.Left, zDockMode.Inner);


            //dockContainer1.DockForm(toolbox_tab, DockStyle.Left, zDockMode.Inner);

            //dockContainer1.DockForm(properties_tab, DockStyle.Right, zDockMode.Inner);


            //dockContainer1.SetAutoHide(solution_explorer_tab, true);
            //dockContainer1.SetAutoHide(code_explorer_tab, true);
         
            //dockContainer1.SetAutoHide(error_display_tab, true);
            //dockContainer1.SetAutoHide(output_display_tab, true);

            //dockContainer1.SetAutoHide(file_manage_tab, true);


            //dockContainer1.SetAutoHide(properties_tab, true);
            //dockContainer1.SetAutoHide(toolbox_tab, true);


            //editor_tab.IsSelected = true;
           
             
        }

        //public void solution_explorer_tab_AutoHideModeChanged(object sender, EventArgs e)
        //{
        // //   MessageBox.Show(d.Id.ToString());
        
        //}

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printToolStripButton_Click(null, null);
        }

        private void undoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            undoToolStripMenuItem_Click(null, null);
        }

        private void redoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            redoToolStripMenuItem_Click(null, null);
        }

        private void cutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentTB.Cut();
        }

        private void copyToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentTB.Copy();
        }

        private void pasteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentTB.Paste();
        }

        private void findToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentTB.ShowFindDialog();
        }

        private void replaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CurrentTB.ShowReplaceDialog();
        }

        private void gotoLineNumberCtrlGToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
            CurrentTB.ShowGoToDialog();
        }

        private void showInvisibleCharsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btInvisibleChars_Click(null, null);
        }

        private void highlightCurrentLineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btHighlightCurrentLine_Click(null, null);
        }

        private void navigateLeftToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateBackward();
        }

        private void navigateRightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NavigateForward();
        }

        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmarkPlusButton_Click(null, null);
        }

        private void removeBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bookmarkMinusButton_Click(null, null);
        }

        private void selectAllCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CurrentTB.SelectAll();
          
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        
        }

        private void msMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        //private void tabControl1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (tabControl1.SelectedIndex == 2)
        //    {
        //        if (webBrowser1.DocumentTitle.Contains("php"))
        //        {
                   
         
        //            panic.Text = "";
        //        }
        //        else
        //        {
        //            webBrowser1.Navigate("about:blank");
        //            panic.Text = "Error: Invalid phpMyAdmin Path.";
        //        }

        //    }
        //    else
        //    {
        //        panic.Text = "";
        //    }
            
        //}

     

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void windowToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //design_panel d = new design_panel();
            //d.Show();

            //try
            //{

            //    design_panel d = new design_panel();
            //    d.TopLevel = false;
            //    var tab = new FATabStripItem("YO", d);
            //    d.Show();
            //    ed.tsFiles.AddTab(tab);
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message.ToString());
            //}


            //Graphics graph = null;
            //try
            //{
            //    Bitmap bmp = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
            //                            Screen.PrimaryScreen.Bounds.Height);
            //    graph = Graphics.FromImage(bmp);
            //    graph.CopyFromScreen(0, 0, 0, 0, bmp.Size);


            //    bmp.Save("d:\\1.jpg");
            //    //SaveImage(bmp);
            //}
            //finally
            //{
            //}
        }

        private void buildProjectgToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //errl.dataGridView1.Rows.Clear();
            //wlk.command_errz.Clear();
            //wlk.page_errz.Clear();
            //bool FoundErr;
            //FoundErr = false;
            //if (CurrentTB == null)
            //{
             
            //}
            //else
            //{
            //    if (Path.GetExtension(title).ToLower() == ".walk")
            //    {

            //        string htm = "";
            //        string cxx = "";

            //        wlk w = new wlk();
            //        string[] s = new string[1000];
            //       s = CurrentTB.Text.Split('\r');
                   
            //        i=0;

            //        foreach (string xx in s)
            //        {
            //            //if (xx == "\n")
            //           // {
            //          s[i] = s[i].Replace("\n", null);
            //            //}
            //            i++;
            //        }


            //       w.compile_wpal_script_tohtml(s);
            //       if (wlk.page_errz.Count > 0)
            //       {
            //           i = 1;
            //           foreach (string errz in wlk.page_errz)
            //           {

            //               string sxxx = errz; //errz.Split(';').GetValue(1).ToString();
            //               string[] row = { (i++).ToString(), errz, "","test","prototype" };
            //               errl.dataGridView1.Rows.Add(row);
            //               FoundErr = true;
            //           }
            //       }
            //       else if (wlk.command_errz.Count > 0)
            //       {
            //           i = 1;
            //           foreach (string errz in wlk.command_errz)
            //           {

            //               string sxxx = errz.Split(';').GetValue(1).ToString();
            //               string[] row = { (i++).ToString(), errz.Split(';').GetValue(0).ToString(), sxxx.Split('=').GetValue(1).ToString(), "test", "prototype" };
            //               errl.dataGridView1.Rows.Add(row);
            //               FoundErr = true;
            //           }
            //       }
            //       else
            //       {

                        
            //                   //data
            //           foreach (LinkedList<string> html in wlk.xxhtml)
            //           {
            //               if (html == null)
            //               {
            //               }
            //               else
            //               {
            //                   foreach (string h in html)
            //                   {
            //                       //css
            //                       //                               MessageBox.Show(c);

            //                       htm = htm + h;

            //                   }
            //               }
            //           }

            //           //  MessageBox.Show(v);
                   
            //       } 
                    

            //           foreach (LinkedList<string> cs in css.css)
            //           {

            //               if (cs == null)
            //               {
            //               }
            //               else
            //               {
            //                   foreach (string c in cs)
            //                   {
            //                       //css
            //                       //                               MessageBox.Show(c);

            //                       cxx = cxx + c;

            //                   }
            //               }
            //            }

            //           if (FoundErr)
            //           {
            //               MessageBox.Show("Walk Code Unsuccssful", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //           }
            //           else
            //           {
                        
            //               if (wlk.default_css_name != "" || wlk.default_css_name != null)
            //               {
            //                   File.WriteAllText(Application.StartupPath + "\\html\\" + wlk.default_css_name, cxx);
            //                   CreateTab(Application.StartupPath + "\\html\\" +wlk.default_css_name);
            //               }
            //               else
            //               {
            //                   File.WriteAllText(Application.StartupPath + "\\html\\default.css", cxx);
            //                   CreateTab(Application.StartupPath + "\\html\\default.css");
            //               }
                         
                         
            //               File.WriteAllText(Application.StartupPath + "\\html\\"+wlk.default_page_name+".html", htm);
                           
            //               MessageBox.Show("Walk Code Compiled successfully", "Notification", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //               CreateTab(Application.StartupPath + "\\html\\" + wlk.default_page_name+".html");
                           
            //           }

                  
            //    }
            //}
           
           
        }

        private void peferencesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // CreateTab();
        }

        private void mozillaFirefoxToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //if (Path.GetExtension(title) == ".html" || Path.GetExtension(title) == ".htm")
            //{
            //    Process.Start("C:\\Program Files (x86)\\Mozilla Firefox\\firefox.exe", Application.StartupPath + "\\html\\prototype.html");
            //}
            
        }

        private void fileZillaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void toolStripLabel4_Click(object sender, EventArgs e)
        {
            
        }

        private void showWireframeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dp.set_boundry();
        }

        private void hideWireframeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            dp.remove_boundary();
        }

        private void tsMain_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bulidingPropertiesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // dp.DesignToWALK();
        }

        private void walk_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
            Application.Exit();
        }

        private void alphaCodeFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //yo
            //if (ed == null)
            //{
            //    ed = new editor(this);
            //    editor_tab = dockContainer1.Add(ed, zAllowedDock.Fill, new Guid("3d8466c1-e406-4e47-b744-6915afe6e001"));
            //    dockContainer1.DockForm(editor_tab, GetStarted_tab, DockStyle.Fill, zDockMode.None);
            //}


          

            if (ofdMain.ShowDialog() == System.Windows.Forms.DialogResult.OK)

                for (int i = 0; i <= ofdMain.FileNames.Length - 1; i++)
                {
                    //   MessageBox.Show(Path.GetExtension(ofdMain.FileNames[i]));
                    //CreateTab(ofdMain.FileNames[i], Path.GetExtension(ofdMain.FileNames[i]));   
                    CreateTab(ofdMain.FileNames[i]);
                }


           

                 
        }

        private void alphaProjectToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
           
        }
       
        private void toolStripDropDownButton1_Click(object sender, EventArgs e)
        {

          //  CreateForm("C:\\Users\\Dv6\\Desktop\\myapp\\Forms\\form1.af");
         
        }

        private void MemoryCollector_Tick(object sender, EventArgs e)
        {
            Application.DoEvents();
            GC.Collect();
            IntPtr pHandle = GetCurrentProcess();
            SetProcessWorkingSetSize(pHandle, -1, -1);
            GC.Collect();

        }





       
    }

    public class InvisibleCharsRenderer : Style
    {
        Pen pen;

        public InvisibleCharsRenderer(Pen pen)
        {
            this.pen = pen;
        }

        public override void Draw(Graphics gr, Point position, Range range)
        {
            var tb = range.tb;
            using(Brush brush = new SolidBrush(pen.Color))
            foreach (var place in range)
            {
                switch (tb[place].c)
                {
                    case ' ':
                        {
                            var point = tb.PlaceToPoint(place);
                            point.Offset(tb.CharWidth / 2, tb.CharHeight / 2);
                            gr.DrawLine(pen, point.X, point.Y, point.X + 1, point.Y);
                            if (tb[place.iLine].Count - 1 == place.iChar)
                               goto default;
                            break;
                        }
                    default:
                        if (tb[place.iLine].Count - 1 == place.iChar)
                        {
                            var point = tb.PlaceToPoint(place);
                            point.Offset(tb.CharWidth, 0);
                            gr.DrawString("¶", tb.Font, brush, point);
                        }
                        break;
                }
            }
        }
    }

    public class TbInfo
    {
        // Key - Line.UniqueId
        public HashSet<int> bookmarksLineId = new HashSet<int>();
        // Index - bookmark number, Value - Line.UniqueId
        public List<int> bookmarks = new List<int>();
        //
        public AutocompleteMenu popupMenu;
    }
}
