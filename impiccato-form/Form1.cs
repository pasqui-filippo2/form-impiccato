namespace impiccato_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tentativi = 0, scelta = 0;
        string Psecret = "", Ptratt = "", lett = "";
        char[] lettere = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'z' };
        bool easy = false, medium = false, hard = false;
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

        }

        private void btnA_Click(object sender, EventArgs e)
        {
            lett = "A";
            if(Ptratt.Contains(lett))
            {
                for(int i = 0;i < Ptratt.Length; i++)
                {

                }
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            textBox1.Text = "a";
        }
    }
}
