namespace UcusRezervasyon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("Rota: " + comboBox1.Text + "-" + comboBox2.Text + "Tarih: " + dateTimePicker1.Text + "Saat: " + maskedTextBox1.Text + "Yolcu Bilgileri // Ad-Soyad: " + textBox1.Text + "TC: " + maskedTextBox2.Text + "Telefon: " + maskedTextBox3.Text);
            MessageBox.Show("Yolcu kayd� yap�ld�");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            label9.Text = comboBox1.Text;
            comboBox1.Text = comboBox2.Text;
            comboBox2.Text = label9.Text;
        }
    }
}
