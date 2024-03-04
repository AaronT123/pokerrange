using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pokerrange
{
    public partial class frmImage : Form
    {
        public frmImage(Image rangeImg)
        {
            InitializeComponent();
            pictureBox1.Image = rangeImg;
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            this.TopMost = true;
            
        }

        private void frmImage_Load(object sender, EventArgs e)
        {

        }
    }
}
