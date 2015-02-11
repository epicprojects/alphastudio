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
using System.Threading;
using System.IO;

namespace Tester
{
    public partial class editor : FormWithPreview
    {
        walk wlk;
        public editor(walk w)
        {
            InitializeComponent();
            wlk = w;
        }

        #region Public section

        //<summary>
        //Draw preview
        //</summary>
        //<param name="bounds">bounds</param>
        //<param name="graphics">graphics</param>

        //public override void DrawPreview(Rectangle bounds, Graphics graphics)
        //{
        //    if (BackgroundImage == null)
        //    {
        //        base.DrawPreview(bounds, graphics);
        //        return;
        //    }

        //    if (BackgroundImage.Width == 0 || BackgroundImage.Height == 0)
        //    {
        //        base.DrawPreview(bounds, graphics);
        //        return;
        //    }

        //    double previewRatio = (double)bounds.Width / (double)bounds.Height;
        //    double imageRatio = (double)BackgroundImage.Width / (double)BackgroundImage.Height;

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
        //        width = (int)(height * imageRatio);
        //    }

        //    int left = bounds.Left + (bounds.Width - width) / 2;
        //    int top = bounds.Top + (bounds.Height - height) / 2;

        //    graphics.DrawImage(BackgroundImage, new Rectangle(left, top, width, height));

        //    graphics.DrawRectangle(Pens.DarkGray, bounds.Left, bounds.Top, bounds.Width - 1, bounds.Height - 1);
        //}

        #endregion Public section


        private void editor_Load(object sender, EventArgs e)
        {
         
        }

        public void tsFiles_TabStripItemClosing(FarsiLibrary.Win.TabStripItemClosingEventArgs e)
        {
            if ((e.Item.Controls[0] as FastColoredTextBox).IsChanged)
            {
            
                switch (MessageBox.Show("Do you want save " + e.Item.Title + " ?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information))
                {
                    case System.Windows.Forms.DialogResult.Yes:
                        if (!wlk.Save(e.Item))
                            e.Cancel = true;
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        break;
                }

                
               // e.Item.Controls[0].Dispose();
            }
        }

        private void tsFiles_TabStripItemSelectionChanged(TabStripItemChangedEventArgs e)
        {
           
        
            //MessageBox.Show("sd");
            if (wlk.CurrentTB != null)
            {
             
            wlk.CurrentTB.Focus();
                string text = wlk.CurrentTB.Text;

                ThreadPool.QueueUserWorkItem(
                    (o) => wlk.ReBuildObjectExplorer(text)
                );
          
                walk.title = e.Item.Title.ToString();

                switch (Path.GetExtension(e.Item.Title.ToString()))
                {
                    case ".html":
                        {
                            wlk.CurrentTB.Language = Language.HTML;
                            break;
                        }
                    case ".htm":
                        {
                            wlk.CurrentTB.Language = Language.HTML;
                            break;
                        }
                    case ".walk":
                        {
                            wlk.CurrentTB.Language = Language.Custom;
                            break;
                        }
                    case ".js":
                        {
                            wlk.CurrentTB.Language = Language.JS;
                            break;
                        }
                    case ".php":
                        {
                            wlk.CurrentTB.Language = Language.PHP;
                            break;
                        }
                    default:
                        {
                            wlk.CurrentTB.Language = Language.Custom;
                            break;
                        }



                }




                //   MessageBox.Show(CurrentTB..ToString());

            }
        }

        private void editor_MouseEnter(object sender, EventArgs e)
        {
           // this.Cursor = Cursors.Arrow;
        }

        private void tsFiles_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }



    }
}
