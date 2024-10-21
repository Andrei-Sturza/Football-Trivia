namespace proiect_Atestat
{
    public partial class F1 : Form
    {
        public F1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form F2 = new F2();
            this.Hide();
            F2.ShowDialog();
            this.Close();
        }
    }
}