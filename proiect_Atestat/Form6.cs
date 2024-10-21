using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace proiect_Atestat
{
    public partial class F6 : Form
    {
        int cate = 0;
        public F6()
        {
            InitializeComponent();
        }

        private void Iesire_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            label3.Visible = false;
            gb1.Visible = true;
            gb2.Visible = true;
            gb3.Visible = true;
            gb4.Visible = true;
            label2.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked && checkBox3.Checked)) cate++;
            if (radioButton2.Checked) cate++;
            if (radioButton7.Checked) cate++;
            if (radioButton11.Checked) cate++;
            if (cate == 1) MessageBox.Show("Ai răsapuns corect la " + cate.ToString() + " întrebare");
            else MessageBox.Show("Ai răsapuns corect la " + cate.ToString() + " întrebări");
            if (cate == 4) this.Close();
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}