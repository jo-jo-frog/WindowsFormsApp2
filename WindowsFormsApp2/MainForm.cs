using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.AxHost;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace WindowsFormsApp2
{
    public partial class MainForm : Form
    {
        public float zoomFactor = 1.0f;

        Pen pen = new Pen(System.Drawing.Color.Black, 3f);

        public int choice = 0;
        public bool ChangeColor = false;
        public bool start = true;
        public bool flag_glass = false;
        public int time = 0;

        public bool isDragging = false;
        public float offsetY = 0;
        public float offsetX = 0;
        public PointF lastMousePosition;

        public Color backColor = System.Drawing.Color.Empty;
        public Image backImage = null;

        IFunction function;

        List<PointF> points = new List<PointF>();
        private void Graph_Calc(IFunction function)
        {
            points.Clear();
            for (int i = 0; i < panel1.Width; i++)
            {
                float x = (i - panel1.Width / 2 + offsetX) / zoomFactor; 
                float y = function.calc(x);
                points.Add(new PointF(i, (panel1.Height / 2) - y * zoomFactor + offsetY));
            }
            function = null;
        }

        public MainForm()
        {
            InitializeComponent();
            MouseWheel += new MouseEventHandler(panel1_MouseWheel);
            Save.Click += Save_Click;
        }
        
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(e.Graphics);
        }
        private void DrawGraph(Graphics graphics)
        {
            if (backColor != System.Drawing.Color.Empty) graphics.Clear(backColor);
            else if (backImage != null) { graphics.DrawImage(backImage, 0, 0, panel1.Width, panel1.Height); }
            else { graphics.Clear(System.Drawing.Color.White); }

            Pen SystemPen = new Pen(System.Drawing.Color.Black, 3f);
            graphics.DrawLine(SystemPen, 0, panel1.Height / 2, panel1.Width, panel1.Height / 2);
            graphics.DrawLine(SystemPen, panel1.Width / 2, 0, panel1.Width / 2, panel1.Height);

            SystemPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;

            graphics.DrawEllipse(SystemPen, ((panel1.Width / 2) - 25 * zoomFactor), ((panel1.Height / 2) - 25 * zoomFactor), 50 * zoomFactor, 50 * zoomFactor);
            {
                // выравнивание
                //square
                //graphics.DrawLine(pen, (panel1.Width / 2) + 25, (panel1.Height / 2), (panel1.Width / 2) + 25, (panel1.Height / 2) - 200);
                //graphics.DrawLine(pen, (panel1.Width / 2) - 10, (panel1.Height / 2) - 25, (panel1.Width / 2) + 100, (panel1.Height / 2) - 25);
                // sine
                //graphics.DrawLine(pen, (panel1.Width / 2) - 100, (panel1.Height / 2) - 25, (panel1.Width / 2) + 100, (panel1.Height / 2) - 25);  
                // LF
                //graphics.DrawLine(pen, (panel1.Width / 2) - 10, (panel1.Height / 2) - 25, (panel1.Width / 2) + 100, (panel1.Height / 2) - 25);
                //graphics.DrawLine(pen, (panel1.Width / 2) - 10, (panel1.Height / 2) - 50, (panel1.Width / 2) + 100, (panel1.Height / 2) - 50);
                //graphics.DrawLine(pen, (panel1.Width / 2) - 10, (panel1.Height / 2) - 75, (panel1.Width / 2) + 100, (panel1.Height / 2) - 75);
                //graphics.DrawLine(pen, (panel1.Width / 2) - 10, (panel1.Height / 2) - 100, (panel1.Width / 2) + 100, (panel1.Height / 2) - 100);
                //graphics.DrawLine(pen, (panel1.Width / 2) - 10, (panel1.Height / 2) - 125, (panel1.Width / 2) + 100, (panel1.Height / 2) - 125);
            }
            Random random = new Random();
            if (start != true)
            {
                if (!ChangeColor) { choice = random.Next(0, 4); zoomFactor = 1.0f; offsetX = 0; offsetY = 0; }
                switch (choice)
                {
                    case 0:
                        function = new Sine(); break;
                    case 1:
                        function = new Square(); break;
                    case 2:
                        function = new Tangent(); break;
                    case 3:
                        function = new Cube(); break;
                    case 4:
                        function = new LinerFunc(); break;
                }
                Graph_Calc(function);
                if (zoomFactor != 1.0f) { string output = zoomFactor.ToString("0.0"); graphics.DrawString("Масштаб: " + output, this.Font, Brushes.Black, new PointF(panel1.Width - 80, 0)); }
                if (function is Tangent)
                {
                    for (int i = 0; i < points.Count - 4; i++)
                    {
                        if (points[i].Y < points[i + 1].Y)
                        {
                            graphics.DrawLine(pen, points[i], new PointF(points[i + 1].X, 0));
                            graphics.DrawLine(pen, points[i + 4], new PointF(points[i + 1].X, panel1.Height));
                        }
                        else
                        {
                            graphics.DrawLine(pen, points[i], points[i + 1]);
                        }
                    }
                }
                else
                {
                    graphics.DrawLines(pen, points.ToArray());
                }
                if (flag_glass)
                {
                    SystemPen.Color = System.Drawing.Color.Green;
                    SystemPen.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
                    foreach (var it in points)
                    {
                        graphics.DrawLine(SystemPen, it, new PointF(it.X + 1, it.Y - 2 * time));
                    }
                }
            }  
            ChangeColor = false;
        }
        private void Func_Click(object sender, EventArgs e)
        {
            start = false;
            panel1.Invalidate();
        }
        private void Save_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog1 = new SaveFileDialog())
            {
                saveFileDialog1.Filter = "PNG Image|*.png|JPEG Image|*.jpg|Bitmap Image|*.bmp";
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                using (Bitmap bitmap = new Bitmap(panel1.Width, panel1.Height))
                {
                    panel1.DrawToBitmap(bitmap, new Rectangle(0, 0, panel1.Width, panel1.Height));
                    bitmap.Save(saveFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            MessageBox.Show("График сохранен!");
        }
        private void Style_Click(object sender, EventArgs e)
        {
            using (StyleForm Form2 = new StyleForm())
            {
                if (Form2.ShowDialog() == DialogResult.Cancel)
                {
                    Console.WriteLine("Style selected");
                    // Применяем выбранный стиль фона
                    if (Form2.backgroundImage != null)
                    {
                        backColor = System.Drawing.Color.Empty;
                        backImage = Form2.backgroundImage;
                    }
                    else if (Form2.backgroundColor != System.Drawing.Color.Empty)
                    {
                        backImage = null;
                        backColor = Form2.backgroundColor;
                    }
                    ChangeColor = true;
                    panel1.Invalidate();
                }
            }
        }
        private void Color_Click(object sender, EventArgs e)
        {
            using (ColorDialog colorDialog = new ColorDialog())
            {
                if (colorDialog1.ShowDialog() == DialogResult.OK)
                {
                    pen.Color = colorDialog1.Color;
                }
            }
            ChangeColor = true;
            panel1.Invalidate();
        }
        private void panel1_MouseWheel(object sender, MouseEventArgs e)
        {
            if (e.Delta > 0)
                zoomFactor += 0.1f;
            else if (zoomFactor <= 0.2f)
                zoomFactor = 0.1f;
            else if (e.Delta < 0)
                zoomFactor -= 0.1f;

            ChangeColor = true;
            panel1.Invalidate();
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = true;
                ChangeColor = true;
                lastMousePosition = e.Location;
            }
        }
        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                isDragging = false;
                ChangeColor = true;
            }
        }
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (isDragging)
            {
                offsetX += (lastMousePosition.X - e.X) / zoomFactor;
                offsetY += (e.Y - lastMousePosition.Y) / zoomFactor;
                lastMousePosition = e.Location;
                ChangeColor = true;
                panel1.Invalidate();
            }
        }
        private void MainForm_Resize(object sender, EventArgs e)
        {
            ChangeColor = true;
            panel1.Invalidate();
        }

        private void GlassButton_Click(object sender, EventArgs e)
        {
            flag_glass = true;
            ChangeColor = true;
            InitializeTimer();
            panel1.Invalidate();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            while (time < 5)
            {
                time++;
                ChangeColor = true;
                panel1.Invalidate();
            }
        }
        private void InitializeTimer()
        {
            timer1.Interval = 1000;
            timer1.Tick += new EventHandler(timer1_Tick);
            timer1.Enabled = true;
        }
    }
    /*
можно добавлять собственные линии собственные графики добавляются рисованием графика
    нарисованные попадает (IFunction)в случайные(подкласс)
    нарисованные можно открывать и перетаскивать(редактировать)
     */
}
