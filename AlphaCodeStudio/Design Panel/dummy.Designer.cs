namespace Tester
{
    partial class dummy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cshape = new Microsoft.VisualBasic.PowerPacks.RectangleShape();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.control_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.layerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToFrontToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bringToAllFrontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sendToAllBackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.leftAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rightAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.topAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bottomAlignToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.duplicateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.page_menu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
            this.pasteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.lockControlsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.propertiesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripSeparator();
            this.viewWalkCodeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.control_menu.SuspendLayout();
            this.page_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // cshape
            // 
            this.cshape.BackColor = System.Drawing.Color.White;
            this.cshape.BorderStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            this.cshape.Location = new System.Drawing.Point(159, 165);
            this.cshape.Name = "cshape";
            this.cshape.SelectionColor = System.Drawing.Color.Transparent;
            this.cshape.Size = new System.Drawing.Size(25, 26);
            this.cshape.Tag = "";
            this.cshape.Visible = false;
            this.cshape.Click += new System.EventHandler(this.cshape_Click);
            this.cshape.MouseDown += new System.Windows.Forms.MouseEventHandler(this.cshape_MouseDown);
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.cshape});
            this.shapeContainer1.Size = new System.Drawing.Size(340, 293);
            this.shapeContainer1.TabIndex = 0;
            this.shapeContainer1.TabStop = false;
            // 
            // control_menu
            // 
            this.control_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.layerToolStripMenuItem,
            this.alignToolStripMenuItem,
            this.toolStripMenuItem2,
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem5,
            this.duplicateToolStripMenuItem,
            this.toolStripMenuItem4,
            this.propertiesToolStripMenuItem});
            this.control_menu.Name = "control_menu";
            this.control_menu.Size = new System.Drawing.Size(128, 210);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(124, 6);
            // 
            // layerToolStripMenuItem
            // 
            this.layerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bringToFrontToolStripMenuItem1,
            this.bringToolStripMenuItem,
            this.bringToAllFrontToolStripMenuItem,
            this.sendToAllBackToolStripMenuItem});
            this.layerToolStripMenuItem.Name = "layerToolStripMenuItem";
            this.layerToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.layerToolStripMenuItem.Text = "Layer";
            // 
            // bringToFrontToolStripMenuItem1
            // 
            this.bringToFrontToolStripMenuItem1.Name = "bringToFrontToolStripMenuItem1";
            this.bringToFrontToolStripMenuItem1.Size = new System.Drawing.Size(164, 22);
            this.bringToFrontToolStripMenuItem1.Text = "Bring to Front";
            // 
            // bringToolStripMenuItem
            // 
            this.bringToolStripMenuItem.Name = "bringToolStripMenuItem";
            this.bringToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.bringToolStripMenuItem.Text = "Send to Back";
            // 
            // bringToAllFrontToolStripMenuItem
            // 
            this.bringToAllFrontToolStripMenuItem.Name = "bringToAllFrontToolStripMenuItem";
            this.bringToAllFrontToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.bringToAllFrontToolStripMenuItem.Text = "Bring to All Front";
            // 
            // sendToAllBackToolStripMenuItem
            // 
            this.sendToAllBackToolStripMenuItem.Name = "sendToAllBackToolStripMenuItem";
            this.sendToAllBackToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.sendToAllBackToolStripMenuItem.Text = "Send to All Back";
            // 
            // alignToolStripMenuItem
            // 
            this.alignToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.leftAlignToolStripMenuItem,
            this.rightAlignToolStripMenuItem,
            this.topAlignToolStripMenuItem,
            this.bottomAlignToolStripMenuItem});
            this.alignToolStripMenuItem.Name = "alignToolStripMenuItem";
            this.alignToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.alignToolStripMenuItem.Text = "Align";
            // 
            // leftAlignToolStripMenuItem
            // 
            this.leftAlignToolStripMenuItem.Name = "leftAlignToolStripMenuItem";
            this.leftAlignToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.leftAlignToolStripMenuItem.Text = "Left Align";
            // 
            // rightAlignToolStripMenuItem
            // 
            this.rightAlignToolStripMenuItem.Name = "rightAlignToolStripMenuItem";
            this.rightAlignToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.rightAlignToolStripMenuItem.Text = "Right Align";
            // 
            // topAlignToolStripMenuItem
            // 
            this.topAlignToolStripMenuItem.Name = "topAlignToolStripMenuItem";
            this.topAlignToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.topAlignToolStripMenuItem.Text = "Top Align";
            // 
            // bottomAlignToolStripMenuItem
            // 
            this.bottomAlignToolStripMenuItem.Name = "bottomAlignToolStripMenuItem";
            this.bottomAlignToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.bottomAlignToolStripMenuItem.Text = "Bottom Align";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(124, 6);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(124, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(124, 6);
            // 
            // duplicateToolStripMenuItem
            // 
            this.duplicateToolStripMenuItem.Name = "duplicateToolStripMenuItem";
            this.duplicateToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.duplicateToolStripMenuItem.Text = "Duplicate";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(124, 6);
            // 
            // propertiesToolStripMenuItem
            // 
            this.propertiesToolStripMenuItem.Name = "propertiesToolStripMenuItem";
            this.propertiesToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.propertiesToolStripMenuItem.Text = "Properties";
            // 
            // page_menu
            // 
            this.page_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem7,
            this.pasteToolStripMenuItem1,
            this.lockControlsToolStripMenuItem,
            this.toolStripMenuItem6,
            this.propertiesToolStripMenuItem1,
            this.toolStripMenuItem8,
            this.viewWalkCodeToolStripMenuItem});
            this.page_menu.Name = "page_menu";
            this.page_menu.Size = new System.Drawing.Size(148, 110);
            // 
            // toolStripMenuItem7
            // 
            this.toolStripMenuItem7.Name = "toolStripMenuItem7";
            this.toolStripMenuItem7.Size = new System.Drawing.Size(144, 6);
            // 
            // pasteToolStripMenuItem1
            // 
            this.pasteToolStripMenuItem1.Name = "pasteToolStripMenuItem1";
            this.pasteToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.pasteToolStripMenuItem1.Text = "Paste";
            // 
            // lockControlsToolStripMenuItem
            // 
            this.lockControlsToolStripMenuItem.Name = "lockControlsToolStripMenuItem";
            this.lockControlsToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.lockControlsToolStripMenuItem.Text = "Lock Controls";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(144, 6);
            // 
            // propertiesToolStripMenuItem1
            // 
            this.propertiesToolStripMenuItem1.Name = "propertiesToolStripMenuItem1";
            this.propertiesToolStripMenuItem1.Size = new System.Drawing.Size(147, 22);
            this.propertiesToolStripMenuItem1.Text = "Properties";
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.Size = new System.Drawing.Size(144, 6);
            // 
            // viewWalkCodeToolStripMenuItem
            // 
            this.viewWalkCodeToolStripMenuItem.Name = "viewWalkCodeToolStripMenuItem";
            this.viewWalkCodeToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.viewWalkCodeToolStripMenuItem.Text = "View Code";
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dummy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 293);
            this.ControlBox = false;
            this.Controls.Add(this.shapeContainer1);
            this.Name = "dummy";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = " Form";
            this.Load += new System.EventHandler(this.dummy_Load);
            this.ResizeBegin += new System.EventHandler(this.dummy_ResizeBegin);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dummy_MouseDown);
            this.MouseEnter += new System.EventHandler(this.dummy_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.dummy_MouseLeave);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.dummy_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.dummy_MouseUp);
            this.control_menu.ResumeLayout(false);
            this.page_menu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.VisualBasic.PowerPacks.RectangleShape cshape;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        public System.Windows.Forms.ContextMenuStrip control_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem layerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringToFrontToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem bringToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bringToAllFrontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendToAllBackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem leftAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rightAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem topAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bottomAlignToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem duplicateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip page_menu;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem lockControlsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem propertiesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem viewWalkCodeToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
    }
}