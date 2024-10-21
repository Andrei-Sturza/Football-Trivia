using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proiect_Atestat
{
    public partial class F4 : Form
    {
        public F4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            pb_echipa.Visible = true;
            Image image = Image.FromFile("echipa-finala.jpg");
            pb_echipa.Image = image;
            rtb.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            rtb.Visible = true;
            rtb.LoadFile("istoric_mondial.rtf");
            pb_echipa.Visible = false;
        }

        private void F4_Load(object sender, EventArgs e)
        {

        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
