using System.Drawing;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ButtonSpace = new System.Windows.Forms.GroupBox();
            this.Func = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.Save = new System.Windows.Forms.Button();
            this.Style = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new WindowsFormsApp2.DoubleBuffPanel();
            this.GlassButton = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.ButtonSpace.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonSpace
            // 
            this.ButtonSpace.Controls.Add(this.GlassButton);
            this.ButtonSpace.Controls.Add(this.Func);
            this.ButtonSpace.Controls.Add(this.Color);
            this.ButtonSpace.Controls.Add(this.Save);
            this.ButtonSpace.Controls.Add(this.Style);
            this.ButtonSpace.Dock = System.Windows.Forms.DockStyle.Right;
            this.ButtonSpace.Location = new System.Drawing.Point(600, 0);
            this.ButtonSpace.Name = "ButtonSpace";
            this.ButtonSpace.Size = new System.Drawing.Size(200, 450);
            this.ButtonSpace.TabIndex = 0;
            this.ButtonSpace.TabStop = false;
            // 
            // Func
            // 
            this.Func.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Func.Location = new System.Drawing.Point(40, 21);
            this.Func.Name = "Func";
            this.Func.Size = new System.Drawing.Size(124, 69);
            this.Func.TabIndex = 0;
            this.Func.Text = "Random Func";
            this.Func.UseVisualStyleBackColor = true;
            this.Func.Click += new System.EventHandler(this.Func_Click);
            // 
            // Color
            // 
            this.Color.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Color.Location = new System.Drawing.Point(40, 107);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(124, 69);
            this.Color.TabIndex = 1;
            this.Color.Text = "Change Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Save
            // 
            this.Save.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Save.Location = new System.Drawing.Point(40, 193);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(124, 69);
            this.Save.TabIndex = 2;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Style
            // 
            this.Style.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Style.Location = new System.Drawing.Point(40, 281);
            this.Style.Name = "Style";
            this.Style.Size = new System.Drawing.Size(124, 69);
            this.Style.TabIndex = 3;
            this.Style.Text = "Style";
            this.Style.UseVisualStyleBackColor = true;
            this.Style.Click += new System.EventHandler(this.Style_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // panel1
            // 
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 450);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // GlassButton
            // 
            this.GlassButton.Location = new System.Drawing.Point(40, 371);
            this.GlassButton.Name = "GlassButton";
            this.GlassButton.Size = new System.Drawing.Size(124, 67);
            this.GlassButton.TabIndex = 4;
            this.GlassButton.Text = "Glass";
            this.GlassButton.UseVisualStyleBackColor = true;
            this.GlassButton.Click += new System.EventHandler(this.GlassButton_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ButtonSpace);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            this.ButtonSpace.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox ButtonSpace;
        private System.Windows.Forms.Button Func;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.Button Style;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private DoubleBuffPanel panel1;
        private Button GlassButton;
        private Timer timer1;
    }
}