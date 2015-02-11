namespace Tester
{
    partial class output
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(output));
            this.output_richbox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // output_richbox
            // 
            this.output_richbox.AcceptsTab = true;
            this.output_richbox.BackColor = System.Drawing.Color.White;
            this.output_richbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.output_richbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.output_richbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output_richbox.Location = new System.Drawing.Point(0, 0);
            this.output_richbox.Name = "output_richbox";
            this.output_richbox.ReadOnly = true;
            this.output_richbox.Size = new System.Drawing.Size(175, 115);
            this.output_richbox.TabIndex = 0;
            this.output_richbox.Text = "--- Console Output ---";
            // 
            // output
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(175, 115);
            this.Controls.Add(this.output_richbox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "output";
            this.Text = "Output";
            this.Load += new System.EventHandler(this.output_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.RichTextBox output_richbox;

    }
}