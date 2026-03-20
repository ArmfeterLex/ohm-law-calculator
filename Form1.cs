namespace wf322
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal U = numericUpDown1.Value; decimal R = numericUpDown2.Value;
            textBox1.Text = Convert.ToString(U/R);
        }
    }
}
