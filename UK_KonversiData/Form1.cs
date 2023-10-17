using System.Windows.Forms;

namespace UK_KonversiData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int nilai;
            if (int.TryParse(textBox1.Text, out nilai))
            {
                string hasil_konversi = "";

                if (nilai > 90 && nilai < 101)
                {
                    hasil_konversi = "Amat Baik";
                }
                else if (nilai >= 81 && nilai <= 90)
                {
                    hasil_konversi = "Baik";
                }
                else if (nilai >= 71 && nilai <= 80)
                {
                    hasil_konversi = "Cukup Baik";
                }
                else if (nilai >= 61 && nilai <= 70)
                {
                    hasil_konversi = "Cukup";
                }
                else if (nilai <= 60)
                {
                    hasil_konversi = "Kurang";
                }
                else if (nilai > 100)
                {
                    hasil_konversi = "Masukan nilai numerik yang valid.";
                }


                string nama = textBoxNama.Text; // Get the name from the input field
                string outputText = "Nama: " + nama + "\nPredikat Nilai: " + hasil_konversi;

                textBox2.Text = outputText;
            }
            else
            {
                textBox2.Text = "Masukan nilai numerik yang valid.";
            }
        }
    }
}
