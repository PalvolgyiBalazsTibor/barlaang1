using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
namespace BarlangokGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Barlang> barlangok = new List<Barlang>();


        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                string[] lines = File.ReadAllLines("barlangok.txt");
                foreach (var line in lines)
                {
                    var parts = line.Split(';');
                    if (parts.Length == 4)
                    {
                        Barlang barlang = new Barlang
                        {
                            Azonosito = int.Parse(parts[0]),
                            Nev = parts[1],
                            Hossz = int.Parse(parts[2]),
                            Melyseg = int.Parse(parts[3])
                        };
                        barlangok.Add(barlang);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt a fájl beolvasásakor: " + ex.Message);
            }

        }

        private void btnKereses_Click(object sender, EventArgs e)
        {
            int azonosito = int.Parse(azonosito_txtbox.Text);
            var barlang = barlangok.Find(b => b.Azonosito == azonosito);


            if (barlang != null)
            {
                neve.Text = barlang.Nev;
                Hosszusag_txtbox.Text = barlang.Hossz.ToString();
                melyseg_txtbox.Text = barlang.Melyseg.ToString();
                adatokmentese_btn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Ezzel az azonosítóval nem létezik barlang!");
                torles();
            }
        }

        private void torles()
        {
            Hosszusag_txtbox.Clear();
            melyseg_txtbox.Clear();
            adatokmentese_btn.Enabled = false;

        }

        private void adatokmentese_btn_Click(object sender, EventArgs e)
        {

            int azonosito = int.Parse(azonosito_txtbox.Text);
            var barlang = barlangok.Find(b => b.Azonosito == azonosito);

            if (barlang != null)
            {
                barlang.Hossz = int.Parse(Hosszusag_txtbox.Text);
                barlang.Melyseg = int.Parse(melyseg_txtbox.Text);

                SaveToFile();
            }
        }

        private void SaveToFile()
        {
            try
            {
                using (StreamWriter writer = new StreamWriter("barlangok.txt"))
                {
                    foreach (var barlang in barlangok)
                    {
                        writer.WriteLine($"{barlang.Azonosito};{barlang.Nev};{barlang.Hossz};{barlang.Melyseg}");
                    }
                }
                MessageBox.Show("Adatok mentve!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba történt az adatok mentésekor: " + ex.Message);
            }
        }
    }
}
