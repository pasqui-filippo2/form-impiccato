namespace impiccato_form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int tentativi = 0;
        string Psecret = "";
        char[] lettere = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'z' };
        bool easy = false, medium = false, hard = false;
        Random rnd = new Random();
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
            easy = true;
            nup1.Value = tentativi;
        }

        private void btnMedium_Click(object sender, EventArgs e)
        {
            tentativi = 6;
            nup1.Value = tentativi;
        }

        private void btnHard_Click(object sender, EventArgs e)
        {
            tentativi = 5;
            nup1.Value = tentativi;
        }

        private void btnGenerete_Click(object sender, EventArgs e)
        {
            string filePath = "1st-level.txt.txt"; // Nome del file CSV 

            string[] lines = File.ReadAllLines(filePath); // Legge tutte le righe e le mette in un vettore
            int random = rnd.Next(1, lines.Length - 1);
            Psecret = lines[random];
            char[] secret = new char[Psecret.Length];
            if (easy == true)
            {
                for (int i = 0; i < Psecret.Length; i++)
                {
                    for (int j = 0; j < lettere.Length; j++)
                    {

                        if (Psecret[i] == lettere[j])
                        {
                            if (i == 0)
                            {
                                secret[i] = lettere[j];

                            }
                            else if (i == random)
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

            }


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
