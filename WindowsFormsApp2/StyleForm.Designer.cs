namespace WindowsFormsApp2
{
    partial class StyleForm
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
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.ColorButton = new System.Windows.Forms.Button();
            this.GradientButton = new System.Windows.Forms.Button();
            this.HatchButton = new System.Windows.Forms.Button();
            this.TextureButton = new System.Windows.Forms.Button();
            this.PatternButton = new System.Windows.Forms.Button();
            this.SomeButton = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // ColorButton
            // 
            this.ColorButton.Location = new System.Drawing.Point(473, 63);
            this.ColorButton.Name = "ColorButton";
            this.ColorButton.Size = new System.Drawing.Size(135, 76);
            this.ColorButton.TabIndex = 0;
            this.ColorButton.Text = "Color";
            this.ColorButton.UseVisualStyleBackColor = true;
            this.ColorButton.Click += new System.EventHandler(this.ColorButton_Click);
            // 
            // GradientButton
            // 
            this.GradientButton.Location = new System.Drawing.Point(473, 174);
            this.GradientButton.Name = "GradientButton";
            this.GradientButton.Size = new System.Drawing.Size(135, 75);
            this.GradientButton.TabIndex = 1;
            this.GradientButton.Text = "Gradient";
            this.GradientButton.UseVisualStyleBackColor = true;
            this.GradientButton.Click += new System.EventHandler(this.GradientButton_Click);
            // 
            // HatchButton
            // 
            this.HatchButton.Location = new System.Drawing.Point(473, 283);
            this.HatchButton.Name = "HatchButton";
            this.HatchButton.Size = new System.Drawing.Size(135, 76);
            this.HatchButton.TabIndex = 2;
            this.HatchButton.Text = "Hatch";
            this.HatchButton.UseVisualStyleBackColor = true;
            this.HatchButton.Click += new System.EventHandler(this.HatchButton_Click);
            // 
            // TextureButton
            // 
            this.TextureButton.Location = new System.Drawing.Point(641, 63);
            this.TextureButton.Name = "TextureButton";
            this.TextureButton.Size = new System.Drawing.Size(135, 76);
            this.TextureButton.TabIndex = 3;
            this.TextureButton.Text = "Create Texture";
            this.TextureButton.UseVisualStyleBackColor = true;
            this.TextureButton.Click += new System.EventHandler(this.TextureButton_Click);
            // 
            // PatternButton
            // 
            this.PatternButton.Location = new System.Drawing.Point(641, 174);
            this.PatternButton.Name = "PatternButton";
            this.PatternButton.Size = new System.Drawing.Size(135, 75);
            this.PatternButton.TabIndex = 4;
            this.PatternButton.Text = "Pattern";
            this.PatternButton.UseVisualStyleBackColor = true;
            this.PatternButton.Click += new System.EventHandler(this.PatternButton_Click);
            // 
            // SomeButton
            // 
            this.SomeButton.Location = new System.Drawing.Point(641, 283);
            this.SomeButton.Name = "SomeButton";
            this.SomeButton.Size = new System.Drawing.Size(135, 76);
            this.SomeButton.TabIndex = 5;
            this.SomeButton.Text = "Something";
            this.SomeButton.UseVisualStyleBackColor = true;
            this.SomeButton.Click += new System.EventHandler(this.SomeButton_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(42, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(351, 296);
            this.panel1.TabIndex = 6;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // StyleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.SomeButton);
            this.Controls.Add(this.PatternButton);
            this.Controls.Add(this.TextureButton);
            this.Controls.Add(this.HatchButton);
            this.Controls.Add(this.GradientButton);
            this.Controls.Add(this.ColorButton);
            this.Name = "StyleForm";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button ColorButton;
        private System.Windows.Forms.Button GradientButton;
        private System.Windows.Forms.Button HatchButton;
        private System.Windows.Forms.Button TextureButton;
        private System.Windows.Forms.Button PatternButton;
        private System.Windows.Forms.Button SomeButton;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel panel1;
    }
}