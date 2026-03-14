namespace Modul3_103022400132
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null || comboBox2.SelectedItem == null)
            {
                MessageBox.Show("Pilih Satuan Terlebih Dahulu!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (double.TryParse(richTextBox1.Text, out double nilaiawal))
            {
                string dari = comboBox1.SelectedItem.ToString();
                string ke = comboBox2.SelectedItem.ToString();
                double hasil = 0;
                double celcius = 0;

                if (dari == "Celcius")
                {
                    hasil = nilaiawal;
                }
                else if (dari == "Fahrenheit")
                {
                    celcius = (nilaiawal - 32) * 5 / 9;
                }
                else if(dari == "Kelvin")
                {
                    celcius = nilaiawal - 273.15;
                }
                else if(dari == "Reamur")
                {
                    celcius = nilaiawal * 4 / 5;
                }

                if(ke == "Celcius")
                {
                    hasil = nilaiawal;
                }
                else if(ke == "Fahrenheit")
                {
                    hasil = (nilaiawal * 9 / 5) + 32;
                }
                else if(ke == "Kelvin")
                {
                    hasil = nilaiawal + 273.15;
                }
                else if(ke == "Reamur")
                {
                    hasil = nilaiawal * 4 / 5;
                    
                }
                richTextBox2.Text = hasil.ToString();
                
            }
            else
            {
                MessageBox.Show("Masukan Angka Yang Valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
