namespace proiect_Atestat
{
    partial class F4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F4));
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            pb_echipa = new PictureBox();
            rtb = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pb_echipa).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(659, 415);
            button1.Name = "button1";
            button1.Size = new Size(105, 23);
            button1.TabIndex = 0;
            button1.Text = "Iesire";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.Transparent;
            button2.Cursor = Cursors.Hand;
            button2.ForeColor = Color.Black;
            button2.Location = new Point(96, 415);
            button2.Name = "button2";
            button2.Size = new Size(109, 23);
            button2.TabIndex = 1;
            button2.Text = "Istoric";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.Transparent;
            button3.Cursor = Cursors.Hand;
            button3.Location = new Point(355, 415);
            button3.Name = "button3";
            button3.Size = new Size(118, 23);
            button3.TabIndex = 2;
            button3.Text = "Echipa";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // pb_echipa
            // 
            pb_echipa.BackgroundImageLayout = ImageLayout.Center;
            pb_echipa.Location = new Point(12, 12);
            pb_echipa.Name = "pb_echipa";
            pb_echipa.Size = new Size(776, 397);
            pb_echipa.TabIndex = 3;
            pb_echipa.TabStop = false;
            pb_echipa.Visible = false;
            // 
            // rtb
            // 
            rtb.Location = new Point(12, 12);
            rtb.Name = "rtb";
            rtb.Size = new Size(776, 397);
            rtb.TabIndex = 4;
            rtb.Text = "";
            rtb.Visible = false;
            rtb.TextChanged += rtb_TextChanged;
            // 
            // F4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(rtb);
            Controls.Add(pb_echipa);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F4";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form4";
            Load += F4_Load;
            ((System.ComponentModel.ISupportInitialize)pb_echipa).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private PictureBox pb_echipa;
        private RichTextBox rtb;
    }
}