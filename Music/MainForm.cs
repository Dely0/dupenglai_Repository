using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Music
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1.Left = 10;
            this.splitContainer1.SplitterDistance = 220;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PlayButton.state == PlayButtonState.play)
            {
                pictureBox1.ImageLocation = PlayButton.Puase_URL;
                PlayButton.state = PlayButtonState.puase;
            }
            else
            {
                pictureBox1.ImageLocation = PlayButton.Play_URL;
                PlayButton.state = PlayButtonState.play;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = pictureBox1.Image.Equals(null) ? pictureBox1.Size : pictureBox1.Image.Size;
            pictureBox2.Size = pictureBox2.Image.Equals(null) ? pictureBox2.Size : pictureBox2.Image.Size;
            pictureBox3.Size = pictureBox3.Image.Equals(null) ? pictureBox3.Size : pictureBox3.Image.Size;
        }
    }
}
