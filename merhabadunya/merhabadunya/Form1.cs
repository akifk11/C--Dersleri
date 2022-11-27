namespace merhabadunya
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Merhaba dunya");
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void yazdir_Click(object sender, EventArgs e)
        {
            label2.Text = "akif";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label6.Text = "Mehmet Akif";
            label7.Text = "Kiraz";
            label8.Text = "Developer";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // textBox1.Text = "Yazýlým Mühendisliði";
            label9.Text = textBox1.Text;
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            label10.Text = textBox2.Text;
            label11.Text = textBox3.Text;
            label12.Text = textBox4.Text;
        }
    }
}
