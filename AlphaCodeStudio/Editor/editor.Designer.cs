namespace Tester
{
    partial class editor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(editor));
            this.tsFiles = new FarsiLibrary.Win.FATabStrip();
            ((System.ComponentModel.ISupportInitialize)(this.tsFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // tsFiles
            // 
            this.tsFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsFiles.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.tsFiles.Location = new System.Drawing.Point(0, 0);
            this.tsFiles.Name = "tsFiles";
            this.tsFiles.Size = new System.Drawing.Size(284, 262);
            this.tsFiles.TabIndex = 2;
            this.tsFiles.Text = "faTabStrip1";
            this.tsFiles.TabStripItemClosing += new FarsiLibrary.Win.TabStripItemClosingHandler(this.tsFiles_TabStripItemClosing);
            this.tsFiles.TabStripItemSelectionChanged += new FarsiLibrary.Win.TabStripItemChangedHandler(this.tsFiles_TabStripItemSelectionChanged);
            this.tsFiles.MouseEnter += new System.EventHandler(this.tsFiles_MouseEnter);
            // 
            // editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.ControlBox = false;
            this.Controls.Add(this.tsFiles);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "editor";
            this.ShowInTaskbar = false;
            this.Text = "Editor";
            this.Load += new System.EventHandler(this.editor_Load);
            this.MouseEnter += new System.EventHandler(this.editor_MouseEnter);
            ((System.ComponentModel.ISupportInitialize)(this.tsFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public FarsiLibrary.Win.FATabStrip tsFiles;
    }
}