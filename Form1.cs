namespace _3LB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            textBox4.Text = "Результат работы программы" + Environment.NewLine;
            textBox4.Text += " При X =" + textBox1.Text + Environment.NewLine;
            textBox4.Text += " При Y =" + textBox2.Text + Environment.NewLine;
            double d;
            if (x > y)
                d = Math.Pow((x * x) + y, 3) - Math.Atan(x * x);
            else
            if (y > x)
                d = Math.Pow(y - (x * x), 3) - Math.Atan(x * x);
            else
                d = Math.Pow(y + (x * x), 3) + 0.5;
            textBox4.Text += " a = " + d.ToString() + Environment.NewLine;
        }
    }
}