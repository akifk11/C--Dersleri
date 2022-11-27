namespace Degiskenler_string
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //  string adsoyad, meslek;
            //  adsoyad = "akif kiraz";
            //  meslek = "developer";
            //  label1.Text = adsoyad;
            //  label2.Text = meslek;
            string sehir;
            sehir = textBox1.Text;
            label1.Text = sehir;
        }
    }
}
