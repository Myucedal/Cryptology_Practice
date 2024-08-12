namespace KriptolojiOdevler8
{
    public partial class Form1 : Form
    {
        public Form1()
        {

            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vigenere vigenere = new Vigenere();
            vigenere.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Yerdegistirme yerdegistirme = new Yerdegistirme();
            yerdegistirme.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Permutasyon permutasyon = new Permutasyon();
            permutasyon.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RotaAlgoritmasi rotaAlgoritmasi = new RotaAlgoritmasi();
            rotaAlgoritmasi.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Zigzag zigzag = new Zigzag();
            zigzag.Show();
            this.Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            DortKareMatrisForm dortKareMatrisForm = new DortKareMatrisForm();
            dortKareMatrisForm.Show();
            this.Hide();
        }
    }
}
