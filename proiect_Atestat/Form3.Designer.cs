namespace proiect_Atestat
{
    partial class F3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F3));
            info_Arg = new RichTextBox();
            iesire = new Button();
            info = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // info_Arg
            // 
            info_Arg.BackColor = SystemColors.ActiveCaption;
            info_Arg.Location = new Point(12, 12);
            info_Arg.Name = "info_Arg";
            info_Arg.Size = new Size(776, 400);
            info_Arg.TabIndex = 0;
            info_Arg.Text = "";
            info_Arg.Visible = false;
            // 
            // iesire
            // 
            iesire.Cursor = Cursors.Hand;
            iesire.Location = new Point(634, 418);
            iesire.Name = "iesire";
            iesire.Size = new Size(75, 23);
            iesire.TabIndex = 1;
            iesire.Text = "iesire";
            iesire.UseVisualStyleBackColor = true;
            iesire.Click += iesire_Click;
            // 
            // info
            // 
            info.Cursor = Cursors.Hand;
            info.Location = new Point(95, 418);
            info.Name = "info";
            info.Size = new Size(127, 23);
            info.TabIndex = 2;
            info.Text = "Despre Aregentina";
            info.UseVisualStyleBackColor = true;
            info.Click += info_Click;
            // 
            // button1
            // 
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(338, 418);
            button1.Name = "button1";
            button1.Size = new Size(127, 23);
            button1.TabIndex = 3;
            button1.Text = "Recorduri";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // F3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(info);
            Controls.Add(iesire);
            Controls.Add(info_Arg);
            FormBorderStyle = FormBorderStyle.None;
            Name = "F3";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form3";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox info_Arg;
        private Button iesire;
        private Button info;
        private Button button1;
    }
}