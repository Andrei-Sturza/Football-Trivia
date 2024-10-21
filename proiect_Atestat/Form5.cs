using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_Atestat
{
    public partial class F5 : Form
    {
        public F5()
        {
            InitializeComponent();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            rtb.Visible = false;
            rtb.LoadFile("Lionel Messi.rtf");
            Image image = Image.FromFile("Lionel Messi.jpg");
            pb.Image = image;
            rtb.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtb.Visible = false;
            rtb.LoadFile("Diego Maradona.rtf");
            Image image = Image.FromFile("Diego Maradona.jpg");
            pb.Image = image;
            rtb.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            rtb.Visible = false;
            rtb.LoadFile("Di Stefano.rtf");
            Image image = Image.FromFile("Di Stefano.jpg");
            pb.Image = image;
            rtb.Visible = true;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            rtb.Visible = false;
            rtb.LoadFile("Mario Kempes.rtf");
            Image image = Image.FromFile("Mario Kempes.png");
            pb.Image = image;
            rtb.Visible = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            rtb.Visible = false;
            rtb.LoadFile("Javier Zanetti.rtf");
            Image image = Image.FromFile("Javier Zanetti.jpg");
            pb.Image = image;
            rtb.Visible = true;
        }
    }
}
