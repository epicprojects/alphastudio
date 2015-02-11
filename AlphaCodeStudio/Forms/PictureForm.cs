using System;
using System.Drawing;
using System.Windows.Forms;

namespace Tester
{
   /// <summary>
   /// Picture form
   /// </summary>
   public class PictureForm : FormWithPreview
   {
       private System.Windows.Forms.Label label1;
      #region Instance

      /// <summary>
      /// Default constructor
      /// </summary>
      public PictureForm()
      {
         InitializeComponent();
      }

      #endregion Instance

      #region Public section

      //<summary>
      //Draw preview
      //</summary>
      //<param name="bounds">bounds</param>
      //<param name="graphics">graphics</param>
      //public override void DrawPreview(Rectangle bounds, Graphics graphics)
      //{
      //    Image c = new Bitmap("d:\\1.ico");
          
      //    if (c == null)
      //    {
      //        base.DrawPreview(bounds, graphics);
      //        return;
      //    }

      //    if (c.Width == 0 || c.Height == 0)
      //    {
      //        base.DrawPreview(bounds, graphics);
      //        return;
      //    }

      //    double previewRatio = (double)bounds.Width / (double)bounds.Height;
      //    double imageRatio = (double)c.Width / (double)BackgroundImage.Height;

      //    int width = 0;
      //    int height = 0;

      //    if (previewRatio < imageRatio)
      //    {
      //        width = Math.Min(bounds.Width, BackgroundImage.Width);
      //        height = (int)(width / imageRatio);
      //    }
      //    else
      //    {
      //        height = Math.Min(bounds.Height, BackgroundImage.Height);
      //        width = (int)(height); //* imageRatio);
      //    }

      //    int left = bounds.Left + (bounds.Width - width) / 2;
      //    int top = bounds.Top + (bounds.Height - height) / 2;

      //    graphics.DrawImage(c, new Rectangle(left, top, width, height));
          
      //    graphics.DrawRectangle(Pens.Black, bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);


      //    //if (BackgroundImage == null)
      //    //{
      //    //    base.DrawPreview(bounds, graphics);
      //    //    return;
      //    //}

      //    //if (BackgroundImage.Width == 0 || BackgroundImage.Height == 0)
      //    //{
      //    //    base.DrawPreview(bounds, graphics);
      //    //    return;
      //    //}

      //    //double previewRatio = (double)bounds.Width / (double)bounds.Height;
      //    //double imageRatio = (double)BackgroundImage.Width / (double)BackgroundImage.Height;

      //    //int width = 0;
      //    //int height = 0;

      //    //if (previewRatio < imageRatio)
      //    //{
      //    //    width = Math.Min(bounds.Width, BackgroundImage.Width);
      //    //    height = (int)(width / imageRatio);
      //    //}
      //    //else
      //    //{
      //    //    height = Math.Min(bounds.Height, BackgroundImage.Height);
      //    //    width = (int)(height * imageRatio);
      //    //}

      //    //int left = bounds.Left + (bounds.Width - width) / 2;
      //    //int top = bounds.Top + (bounds.Height - height) / 2;

      //    //graphics.DrawImage(BackgroundImage, new Rectangle(left, top, width, height));

      //    //graphics.DrawRectangle(Pens.DarkGray, bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);


      //}

      #endregion Public section

      #region Private section

      private void InitializeComponent()
      {
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PictureForm));
          this.label1 = new System.Windows.Forms.Label();
          this.SuspendLayout();
          // 
          // label1
          // 
          this.label1.AutoSize = true;
          this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.label1.ForeColor = System.Drawing.Color.White;
          this.label1.Location = new System.Drawing.Point(84, 55);
          this.label1.Name = "label1";
          this.label1.Size = new System.Drawing.Size(151, 39);
          this.label1.TabIndex = 0;
          this.label1.Text = "MYTIME";
          // 
          // PictureForm
          // 
          this.BackColor = System.Drawing.Color.Black;
          this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
          this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
          this.ClientSize = new System.Drawing.Size(273, 364);
          this.Controls.Add(this.label1);
          this.DoubleBuffered = true;
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
          this.Name = "PictureForm";
          this.Text = "My Time";
          this.Load += new System.EventHandler(this.PictureForm_Load);
          this.ResumeLayout(false);
          this.PerformLayout();

      }

      #endregion Private section

      private void PictureForm_Load(object sender, EventArgs e)
      {
          
      }
   }
}
