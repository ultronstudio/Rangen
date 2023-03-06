using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rangen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnStartGen_Click(object sender, EventArgs e)
        {
            if(cboxNumToGen.SelectedIndex < 0)
            {
                // Pokud nebylo v comboboxu vybráno žádné číslo, aby aplikace věděla, kolik čísel ma vygenerovat
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nebylo vybráno žádné číslo.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(tboxInterval.Text == "")
            {
                // Pokud nebyl zadán interval, v jejímž rozmezí máaplikace generovat náhodná čísla
                SystemSounds.Asterisk.Play();
                MessageBox.Show("Nebyl zadán interval.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                // načtení třídy "Random"
                Random random = new Random();

                // "vyseparování" jednotlivých hodnot v intervalu zadaném uživatelem
                string[] interval = tboxInterval.Text.Split(',');

                if (interval.Length != 2)
                {
                    // pokud uživatel zadá neplatný interval (interval musí odpovídat formátu A,B)
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Byl zadán neplatný interval.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // Ověří, zda jsou hodnoty v intervalu číselné
                    if (int.TryParse(interval[0], out int cislo1) && int.TryParse(interval[1], out int cislo2))
                    {
                        // Pokud je rozmezí jednotivých čísel v intervalu větší než počet čísel k vygenerování
                        if((cislo2 - cislo1) >= int.Parse(cboxNumToGen.Text))
                        {
                            // Pro zamezení přetížení aplikace musí být rozmezí čísel v intervalu větší, než počet čísel k vygenerování (+ 50)
                            if ((cislo2 - cislo1) >= int.Parse(cboxNumToGen.Text) + 50)
                            {
                                tboxNumValGen.Text = "";
                                int GenNum;

                                for (int i = 0; i < int.Parse(cboxNumToGen.Text); i++)
                                {
                                    GenNum = random.Next(cislo1, cislo2);

                                    // Pokud již bylo vygenerováno stejné číslo, vygeneruje se jiné
                                    if (tboxNumValGen.Text.Contains($"{GenNum}"))
                                    {
                                        i--;
                                        continue;
                                    }

                                    tboxNumValGen.Text += $"{GenNum}\r\n";
                                }
                            }
                            else
                            {
                                // Pokud uživatel zadá interval, jehož rozmezí je menší než počet čísel k vygenerování (+ 50), čímž hrozí přetížení aplikace
                                SystemSounds.Asterisk.Play();
                                MessageBox.Show($"Zadáním intervalu {tboxInterval.Text} a výběrem {cboxNumToGen.Text} čísel k vygenerování hrozí přetížení paměti, proto ji program odmítl.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            // Pokud uživatel zadá interval, jehož rozmezí je menší než počet číel k vygenerování
                            SystemSounds.Asterisk.Play();
                            MessageBox.Show("Byl zadán interval, jehož rozmezí je menší než počet čísel k vygenerování.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        // Pokud uživatel zadáí do intervalu hodnoty, které jsou jiné, než celočíselné
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Zadané hodnoty do pole pro interval nejsou číselné.", "Chyba!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Po načtení aplikace se do comboboxu vloží jednotlové volby počtu čísel k vygenerování
            for (int i = 1; i < 101; i++)
            {
                cboxNumToGen.Items.Add(i);
            }
        }

        /// <summary>
        /// Kliknutí na ikonu otazníku v záhlaví aplikace zobrazí MessageBox s informacemi o aplikaci
        /// </summary>
        private void Form1_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            SystemSounds.Question.Play();
            MessageBox.Show($"Aplikace Rangen\n2023 © Petr Vurm\n\nVytvořeno jako domácí úkol z předmětu PROGRAMOVÁNÍ na SPŠ Hradební.", "O aplikaci", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
