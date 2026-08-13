namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double res = num1 + num2;
            txt3.Text = res.ToString();
        }

        private void min_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double res = num1 - num2;
            txt3.Text = res.ToString();
        }

        private void mult_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double res = num1 * num2;
            txt3.Text = res.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txt1.Text);
            double num2 = double.Parse(txt2.Text);
            double res = num1 / num2;
            txt3.Text = res.ToString();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            txt1.Clear();
            txt2.Clear();
            txt3.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
