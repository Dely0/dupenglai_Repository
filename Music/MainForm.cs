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

        bool IsMouseDown = false;
        Point MousePos;

        private void MainForm_Resize(object sender, EventArgs e)
        {
            this.splitContainer1.Panel1.Left = 10;
            this.splitContainer1.SplitterDistance = 220;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (PlayButton.state == PlayButtonState.play)
            {
                pictureBox1.ImageLocation = PlayButton.Puase_Press_URL;
                PlayButton.state = PlayButtonState.puase;
            }
            else
            {
                pictureBox1.ImageLocation = PlayButton.Play_Press_URL;
                PlayButton.state = PlayButtonState.play;
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            pictureBox1.Size = pictureBox1.Image.Equals(null) ? pictureBox1.Size : pictureBox1.Image.Size;
            pictureBox2.Size = pictureBox2.Image.Equals(null) ? pictureBox2.Size : pictureBox2.Image.Size;
            pictureBox3.Size = pictureBox3.Image.Equals(null) ? pictureBox3.Size : pictureBox3.Image.Size;
            pictureBox4.Size = pictureBox4.Image.Equals(null) ? pictureBox4.Size : pictureBox4.Image.Size;
            pictureBox5.Size = pictureBox5.Image.Equals(null) ? pictureBox5.Size : pictureBox5.Image.Size;
            pictureBox6.Size = pictureBox6.Image.Equals(null) ? pictureBox6.Size : pictureBox6.Image.Size;
            pictureBox7.Size = pictureBox7.Image.Equals(null) ? pictureBox7.Size : pictureBox6.Image.Size;
        }

        private void Title_Panel_DoubleClick(object sender, EventArgs e)
        {
            switch (TitleState.TitleSize)
            {
                case TitleSize.Max:
                    this.WindowState = FormWindowState.Normal;
                    TitleState.TitleSize = TitleSize.Normal;
                    break;
                case TitleSize.Min:
                    break;
                case TitleSize.Normal:
                    this.WindowState = FormWindowState.Maximized;
                    TitleState.TitleSize = TitleSize.Max;
                    break;
                default:
                    break;
            }
        }

        private void pictureBox1_MouseEnter(object sender, EventArgs e)
        {
            if (PlayButton.state == PlayButtonState.play)
            {
                this.pictureBox1.ImageLocation = PlayButton.Play_Press_URL;
            }
            else
            {
                this.pictureBox1.ImageLocation = PlayButton.Puase_Press_URL;
            }
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            if (PlayButton.state == PlayButtonState.play)
            {
                this.pictureBox1.ImageLocation = PlayButton.Play_URL;
            }
            else
            {
                this.pictureBox1.ImageLocation = PlayButton.Puase_URL;
            }
        }

        private void pictureBox3_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox3.ImageLocation = PlayButton.Next_Press_URL;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox3.ImageLocation = PlayButton.Next_URL;
        }

        private void pictureBox2_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox2.ImageLocation = PlayButton.Previous_Press_URL;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            this.pictureBox2.ImageLocation = PlayButton.Previous_URL;
        }

        /// <summary>
        /// 鼠标按下，开启移动
        /// </summary>
        /// <param name="e"></param>
        private void Title_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            base.OnMouseDown(e);
            MousePos = Cursor.Position;
            IsMouseDown = true;
        }

        /// <summary>
        /// 鼠标抬起，关闭移动
        /// </summary>
        /// <param name="e"></param>
        private void Title_Panel_MouseUp(object sender, MouseEventArgs e)
        {
            base.OnMouseUp(e);
            IsMouseDown = false;
            this.Focus();
        }

        /// <summary>
        /// 移动窗口
        /// </summary>
        /// <param name="e"></param>
        private void Title_Panel_MouseMove(object sender, MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (IsMouseDown)
            {
                Point tempPos = Cursor.Position;
                this.Location = new Point(Location.X + (tempPos.X - MousePos.X), Location.Y + (tempPos.Y - MousePos.Y));
                MousePos = Cursor.Position;
            }
        }

        private void pictureBox4_MouseEnter(object sender, EventArgs e)
        {
            this.pictureBox4.ImageLocation = @"resource\close_Press.png";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Title_Panel_DoubleClick(sender, e);
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
