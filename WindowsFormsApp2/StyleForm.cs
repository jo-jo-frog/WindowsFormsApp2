using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class StyleForm : Form
    {
        public Color backgroundColor { get; set; }
        public Image backgroundImage { get; set; }

        public StyleForm()
        {
            InitializeComponent();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                backgroundColor = colorDialog1.Color;
                backgroundImage = null; // Убираем изображение фона
                panel1.Invalidate();
            }
        }
        private void GradientButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (LinearGradientBrush brush = new LinearGradientBrush(new Rectangle(0, 0, bmp.Width, bmp.Height), Color.Purple, Color.LightPink, 90F))
                {
                    g.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                }
            }
            backgroundImage = bmp;
            backgroundColor = System.Drawing.Color.Empty; // Убираем цвет фона
            panel1.Invalidate();
        }

        private void HatchButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (HatchBrush brush = new HatchBrush(HatchStyle.Cross, Color.Gray, Color.Transparent))
                {
                    g.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                }
            }
            backgroundImage = bmp;
            backgroundColor = Color.Empty; // Убираем цвет фона
            panel1.Invalidate();
        }

        private void TextureButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (TextureBrush brush = new TextureBrush(new Bitmap("C:\\Users\\Кирилл\\Desktop\\фсякое\\scale_1200.jpg")))
                {
                    g.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                }
            }
            backgroundImage = bmp;
            backgroundColor = Color.Empty; // Убираем цвет фона
            panel1.Invalidate();
        }

        private void PatternButton_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.ClientSize.Width, this.ClientSize.Height);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                using (TextureBrush brush = new TextureBrush(new Bitmap("C:\\Users\\Кирилл\\Desktop\\фсякое\\1613287244_126-p-sinii-fon-kiberpank-230.jpg")))
                {
                    g.FillRectangle(brush, 0, 0, bmp.Width, bmp.Height);
                }
            }
            backgroundImage = bmp;
            backgroundColor = Color.Empty; // Убираем цвет фона
            panel1.Invalidate();
        }

        private void SomeButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Something");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            if (backgroundColor != Color.Empty)
            {
                panel1.BackgroundImage = null;
                panel1.BackColor = backgroundColor;
            }
            else if (backgroundImage != null) 
            {
                panel1.BackColor = Color.White;
                panel1.BackgroundImage = backgroundImage;
            }
        }
    }
}
