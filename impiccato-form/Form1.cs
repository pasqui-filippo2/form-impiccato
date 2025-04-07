using System.Net.Sockets;

namespace impiccato_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tentativi = 0, scelta = 0, cercaL = 0;
        string Psecret = "", Ptratt = "", lett = "";
        char[] lettere = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'z' };
        bool easy = false, medium = false, hard = false, vittoria = false;
        Random rnd = new Random();
        char[] trasforma_parola(string parola, char[] lett, int scelta, char[] secret)
        {
            Random rnd = new Random();
            int month = rnd.Next(1, Psecret.Length - 1);
            if (scelta == 1)
            {
                for (int i = 0; i < parola.Length; i++)
                {
                    for (int j = 0; j < lettere.Length; j++)
                    {

                        if (Psecret[i] == lettere[j])
                        {
                            if (i == 0)
                            {
                                secret[i] = lettere[j];

                            }
                            else if (i == month)
                            {
                                secret[i] = lettere[j];
                            }
                            else
                            {
                                secret[i] = '_';
                            }

                        }


                    }
                }
                return secret;
            }
            if (scelta == 2)
            {
                for (int i = 0; i < Psecret.Length; i++)
                {
                    for (int j = 0; j < lett.Length; j++)
                    {

                        if (Psecret[i] == lettere[j])
                        {
                            if (i == month)
                            {
                                secret[i] = lettere[j];
                            }
                            else
                            {
                                secret[i] = '_';
                            }

                        }


                    }
                }
                return secret;
            }
            if (scelta == 3)
            {
                for (int i = 0; i < Psecret.Length; i++)
                {
                    for (int j = 0; j < lett.Length; j++)
                    {

                        if (Psecret[i] == lett[j])
                        {
                            secret[i] = '_';
                        }
                    }
                }
                return secret;
            }
            return secret;
        }
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnEasy_Click(object sender, EventArgs e)
        {
            tentativi = 7;
            scelta = 1;
            nup1.Value = tentativi;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            tentativi = 6;
            scelta = 2;
            nup1.Value = tentativi;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            tentativi = 5;
            scelta = 3;
            nup1.Value = tentativi;
        }

        private void btnGenerete_Click(object sender, EventArgs e)
        {
            string filePath = "1st-level.txt.txt"; // Nome del file CSV 

            string[] lines = File.ReadAllLines(filePath); // Legge tutte le righe e le mette in un vettore
            int random = rnd.Next(1, lines.Length - 1);
            Psecret = lines[random];
            char[] secret = new char[Psecret.Length];
            for (int i = 0; i < Psecret.Length; i++)
            {
                for (int j = 0; j < lettere.Length; j++)
                {
                    if (Psecret[i] == lettere[j])
                    {
                        Ptratt += "_";
                    }
                }
            }
            txtParola.Text = Ptratt;



        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtParola_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnB_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "b";
            textBox1.Text = lett;

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "a";
            textBox1.Text = lett;

        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (Psecret.Contains(lett))
            {
                Ptratt = Psecret;
                for (int i = 0; i < Psecret.Length; i++)
                {
                    if (Psecret != lett)
                    {
                        Ptratt += "_";
                    }
                }
            }
            else
            {
                tentativi--;
                nup1.Value = tentativi;
                lblErr.Text = "Hai sbagliato lettera";
                lblLettErrate.Text = lett;
                if (tentativi == 0)
                {
                    lblParoleSbagliata.Text = Psecret + ",";
                }
            }
            txtParola.Text = "";
            txtParola.Text = Ptratt;
            cercaL = 0;
            for (int i = 0; i < Ptratt.Length; i++)
            {
                for (int j = 0; j < lettere.Length; j++)
                {
                    if (Ptratt[i] == lettere[j])
                    {
                        cercaL++;
                    }
                }
            }
            if (cercaL == Psecret.Length)
            {
                vittoria = true;
                lblInd.Text = "Hai indovinato la parola";
            }
        }

        private void btnWorld_Click(object sender, EventArgs e)
        {
            if (Psecret.Contains(textBox1.Text))
            {
                lblInd.Text = "Hai indovinato la poarola";
            }
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "c";
            textBox1.Text = lett;
        }

        private void btnD_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "d";
            textBox1.Text = lett;
        }

        private void btnE_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "e";
            textBox1.Text = lett;
        }

        private void btnF_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "f";
            textBox1.Text = lett;
        }

        private void btnG_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "g";
            textBox1.Text = lett;
        }

        private void btnH_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "h";
            textBox1.Text = lett;
        }

        private void btnI_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "i";
            textBox1.Text = lett;
        }

        private void btnL_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "l";
            textBox1.Text = lett;
        }

        private void btnM_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "m";
            textBox1.Text = lett;
        }

        private void btnN_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "n";
            textBox1.Text = lett;
        }

        private void btnO_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "o";
            textBox1.Text = lett;
        }

        private void btnP_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "p";
            textBox1.Text = lett;
        }

        private void btnQ_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "q";
            textBox1.Text = lett;
        }

        private void btnR_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "r";
            textBox1.Text = lett;
        }

        private void btnS_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "s";
            textBox1.Text = lett;
        }

        private void btnT_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "t";
            textBox1.Text = lett;
        }

        private void btnU_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "u";
            textBox1.Text = lett;
        }

        private void btnV_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "v";
            textBox1.Text = lett;
        }

        private void btnZ_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            lett = "z";
            textBox1.Text = lett;
        }
    }
}
