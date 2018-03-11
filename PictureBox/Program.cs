using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace PictureBoxDisplay
{
    class Program
    {
        static void Main(string[] args)
        {


            try
            {
                MessageBox.Show("check");
                PictureBox pb1 = new PictureBox();
                pb1.ImageLocation = "hll881bpat301.jpg";
                pb1.SizeMode = PictureBoxSizeMode.AutoSize;
               
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }



        }
    }
}
