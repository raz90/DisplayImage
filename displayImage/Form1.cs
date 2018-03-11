using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace displayImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            
            InitializeComponent();
            Form1_Load();

        }

        private void Form1_Load()
        {
            //PictureBox pictureBox1 = new PictureBox();
            
            this.Controls.Add(pictureBox1);
            pictureBox1.ImageLocation = "test.png";
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

           // Thread.Sleep(2000);
            
            //pictureBox1.Width = pictureBox1.Resize;
           // pictureBox1.Height = 1000;
            //pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;

        }

        
    }
}
