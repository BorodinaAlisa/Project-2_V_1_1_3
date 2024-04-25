namespace design
{
    partial class MarkWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MarkWindow));
            Picture9 = new PictureBox();
            Star1 = new Button();
            Star2 = new Button();
            Star3 = new Button();
            Star4 = new Button();
            Star5 = new Button();
            ((System.ComponentModel.ISupportInitialize)Picture9).BeginInit();
            SuspendLayout();
            // 
            // Picture9
            // 
            Picture9.Image = (Image)resources.GetObject("Picture9.Image");
            Picture9.Location = new Point(-1, -1);
            Picture9.Margin = new Padding(3, 4, 3, 4);
            Picture9.Name = "Picture9";
            Picture9.Size = new Size(801, 454);
            Picture9.SizeMode = PictureBoxSizeMode.StretchImage;
            Picture9.TabIndex = 0;
            Picture9.TabStop = false;
            // 
            // Star1
            // 
            Star1.Location = new Point(67, 201);
            Star1.Margin = new Padding(3, 4, 3, 4);
            Star1.Name = "Star1";
            Star1.Size = new Size(100, 125);
            Star1.TabIndex = 1;
            Star1.Text = "button1";
            Star1.UseVisualStyleBackColor = true;
            Star1.Click += Star1_Click;
            // 
            // Star2
            // 
            Star2.Location = new Point(208, 201);
            Star2.Margin = new Padding(3, 4, 3, 4);
            Star2.Name = "Star2";
            Star2.Size = new Size(100, 125);
            Star2.TabIndex = 2;
            Star2.Text = "button2";
            Star2.UseVisualStyleBackColor = true;
            Star2.Click += Star2_Click;
            // 
            // Star3
            // 
            Star3.Location = new Point(354, 201);
            Star3.Margin = new Padding(3, 4, 3, 4);
            Star3.Name = "Star3";
            Star3.Size = new Size(100, 125);
            Star3.TabIndex = 3;
            Star3.Text = "button3";
            Star3.UseVisualStyleBackColor = true;
            Star3.Click += Star3_Click;
            // 
            // Star4
            // 
            Star4.Location = new Point(495, 201);
            Star4.Margin = new Padding(3, 4, 3, 4);
            Star4.Name = "Star4";
            Star4.Size = new Size(100, 125);
            Star4.TabIndex = 4;
            Star4.Text = "button4";
            Star4.UseVisualStyleBackColor = true;
            Star4.Click += Star4_Click;
            // 
            // Star5
            // 
            Star5.Location = new Point(633, 201);
            Star5.Margin = new Padding(3, 4, 3, 4);
            Star5.Name = "Star5";
            Star5.Size = new Size(100, 125);
            Star5.TabIndex = 5;
            Star5.Text = "button5";
            Star5.UseVisualStyleBackColor = true;
            Star5.Click += Star5_Click;
            // 
            // MarkWindow
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 451);
            Controls.Add(Star5);
            Controls.Add(Star4);
            Controls.Add(Star3);
            Controls.Add(Star2);
            Controls.Add(Star1);
            Controls.Add(Picture9);
            FormBorderStyle = FormBorderStyle.SizableToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MarkWindow";
            StartPosition = FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)Picture9).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox Picture9;
        private System.Windows.Forms.Button Star1;
        private System.Windows.Forms.Button Star2;
        private System.Windows.Forms.Button Star3;
        private System.Windows.Forms.Button Star4;
        private System.Windows.Forms.Button Star5;
    }
}