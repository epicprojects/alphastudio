namespace Tester
{
    partial class filemangemnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(filemangemnt));
            this.browser1 = new FileBrowser.Browser();
            this.SuspendLayout();
            // 
            // browser1
            // 
            this.browser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.browser1.ListViewMode = System.Windows.Forms.View.List;
            this.browser1.Location = new System.Drawing.Point(0, 0);
            this.browser1.Name = "browser1";
            this.browser1.SelectedNode = null;
            this.browser1.Size = new System.Drawing.Size(296, 441);
            this.browser1.SplitterDistance = 162;
            this.browser1.TabIndex = 0;
            // 
            // filemangemnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(296, 441);
            this.Controls.Add(this.browser1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "filemangemnt";
            this.Text = "File Explorer";
            this.Load += new System.EventHandler(this.filemangemnt_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private FileBrowser.Browser browser1;

    }
}