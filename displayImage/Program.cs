using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace displayImage
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
     

           /* try
            {
                PictureBox pb1 = new PictureBox();
                pb1.ImageLocation = "C:\\Users\\paich\\source\\repos\\PictureBox\\PictureBox\\bin\\Debug\\hll881bpat301.jpg";
                pb1.SizeMode = PictureBoxSizeMode.StretchImage;

                PictureBox pictureBox1 = new PictureBox();
                try
                {
                    pictureBox1.ImageLocation = "test.png"; //path to image
                    pictureBox1.SizeMode = PictureBoxSizeMode.AutoSize;
                    pictureBox1.Show();
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message);
                }


            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            */

        }
    }
}
