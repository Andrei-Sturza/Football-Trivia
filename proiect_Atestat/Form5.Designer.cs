namespace proiect_Atestat
{
    partial class F5
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            rtb = new RichTextBox();
            pb = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pb).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(12, 12);
            button1.Name = "button1";
            button1.Size = new Size(97, 23);
            button1.TabIndex = 0;
            button1.Text = "Lionel Messi";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Cursor = Cursors.Hand;
            button2.Location = new Point(124, 12);
            button2.Name = "button2";
            button2.Size = new Size(132, 23);
            button2.TabIndex = 1;
            button2.Text = "Diego Maradona";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(273, 12);
            button3.Name = "button3";
            button3.Size = new Size(125, 23);
            button3.TabIndex = 2;
            button3.Text = "Alfredo Di Stefano";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Cursor = Cursors.Hand;
            button4.Location = new Point(416, 12);
            button4.Name = "button4";
            button4.Size = new Size(97, 23);
            button4.TabIndex = 3;
            button4.Text = "Mario Kempes";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Cursor = Cursors.Hand;
            button5.Location = new Point(530, 12);
            button5.Name = "button5";
            button5.Size = new Size(97, 23);
            button5.TabIndex = 4;
            button5.Text = "Javier Zanetti";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Cursor = Cursors.Hand;
            button6.Location = new Point(691, 12);
            button6.Name = "button6";
            button6.Size = new Size(97, 23);
            button6.TabIndex = 5;
            button6.Text = "Iesire";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // rtb
            // 
            rtb.ForeColor = SystemColors.WindowText;
            rtb.Location = new Point(12, 41);
            rtb.Name = "rtb";
            rtb.Size = new Size(386, 397);
            rtb.TabIndex = 6;
            rtb.Text = "";
            // 
            // pb
            // 
            pb.BackgroundImageLayout = ImageLayout.None;
            pb.Location = new Point(404, 41);
            pb.Name = "pb";
            pb.Size = new Size(384, 397);
            pb.SizeMode = PictureBoxSizeMode.StretchImage;
            pb.TabIndex = 7;
            pb.TabStop = false;
            // 
            // F5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pb);
            Controls.Add(rtb);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F5";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pb).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private RichTextBox rtb;
        private PictureBox pb;
    }
}