using System;
using System.Windows.Forms;

namespace KriptolojiOdevler8
{
    public partial class RotaAlgoritmasi : Form
    {
        public RotaAlgoritmasi()
        {
            InitializeComponent();
        }

        // Yukarı yönlü şifreleme metodu
        private char[] SifreleYukari(char[,] matris, bool[,] gezilenMatris)
        {
            int satir = matris.GetLength(0) - 1; // Sol alt köşeden başlanacak
            int sutun = 0;
            char[] sifrelenmisMetin = new char[matris.GetLength(0) * matris.GetLength(1)];
            int index = 0;

            while (true)
            {
                while (satir >= 0 && !gezilenMatris[satir, sutun])
                {
                    sifrelenmisMetin[index++] = matris[satir, sutun];
                    gezilenMatris[satir, sutun] = true;
                    satir--;
                }

                satir++;
                sutun++;

                if (sutun >= matris.GetLength(1) || gezilenMatris[satir, sutun]) break;

                while (sutun < matris.GetLength(1) && !gezilenMatris[satir, sutun])
                {
                    sifrelenmisMetin[index++] = matris[satir, sutun];
                    gezilenMatris[satir, sutun] = true;
                    sutun++;
                }

                sutun--;
                satir++;

                if (satir >= matris.GetLength(0) || gezilenMatris[satir, sutun]) break;

                while (satir < matris.GetLength(0) && !gezilenMatris[satir, sutun])
                {
                    sifrelenmisMetin[index++] = matris[satir, sutun];
                    gezilenMatris[satir, sutun] = true;
                    satir++;
                }

                satir--;
                sutun--;

                if (sutun < 0 || gezilenMatris[satir, sutun]) break;

                while (sutun >= 0 && !gezilenMatris[satir, sutun])
                {
                    sifrelenmisMetin[index++] = matris[satir, sutun];
                    gezilenMatris[satir, sutun] = true;
                    sutun--;
                }

                sutun++;
                satir--;

                if (satir < 0 || gezilenMatris[satir, sutun]) break;
            }

            return sifrelenmisMetin;
        }

        private void btnrotasifrele_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (rotarichtxt1.Text == "")
                {
                    MessageBox.Show("Herhangi bir metin girmediniz. Lütfen metin giriniz.");
                    rotarichtxt2.Text = string.Empty;
                }
                else
                {
                    string metin = rotarichtxt1.Text;
                    char[] metinChar = metin.ToCharArray();
                    int rotaAnahtari = Convert.ToInt16(txtrotaanahtar.Text);

                    int satirSayisi = (metinChar.Length + rotaAnahtari - 1) / rotaAnahtari;

                    while (metinChar.Length % rotaAnahtari != 0)
                    {
                        Array.Resize(ref metinChar, metinChar.Length + 1);
                        metinChar[metinChar.Length - 1] = 'z';
                    }

                    char[,] rotaMatris = new char[satirSayisi, rotaAnahtari];
                    for (int x = 0; x < satirSayisi; x++)
                    {
                        for (int y = 0; y < rotaAnahtari; y++)
                        {
                            rotaMatris[x, y] = metinChar[x * rotaAnahtari + y];
                        }
                    }

                    char[] sifrelenmisMetin = SifreleYukari(rotaMatris, new bool[satirSayisi, rotaAnahtari]);

                    rotarichtxt2.Text = new string(sifrelenmisMetin).TrimEnd('\0');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnrotacozumle_Click(object sender, EventArgs e)
        {
            try
            {
                if (rotarichtxt1.Text == "")
                {
                    MessageBox.Show("Şifreli metin girmediniz. Lütfen şifreli metin giriniz.");
                    rotarichtxt1.Text = string.Empty;
                }
                else
                {
                    string sifreliMetin = rotarichtxt1.Text;
                    char[] sifreliMetinChar = sifreliMetin.ToCharArray();
                    int rotaAnahtari = Convert.ToInt16(txtrotaanahtar.Text);

                    int satirSayisi = (sifreliMetinChar.Length + rotaAnahtari - 1) / rotaAnahtari;

                    char[,] rotaMatris = new char[satirSayisi, rotaAnahtari];
                    bool[,] gezilenMatris = new bool[satirSayisi, rotaAnahtari];

                    // Şifreli metni yukarı yönlü şekilde matrise yerleştir
                    int index = 0;
                    int satir = satirSayisi - 1;
                    int sutun = 0;

                    while (index < sifreliMetinChar.Length)
                    {
                        while (satir >= 0 && !gezilenMatris[satir, sutun] && index < sifreliMetinChar.Length)
                        {
                            rotaMatris[satir, sutun] = sifreliMetinChar[index++];
                            gezilenMatris[satir, sutun] = true;
                            satir--;
                        }
                        satir++;
                        sutun++;

                        if (sutun >= rotaAnahtari || gezilenMatris[satir, sutun]) break;

                        while (sutun < rotaAnahtari && !gezilenMatris[satir, sutun] && index < sifreliMetinChar.Length)
                        {
                            rotaMatris[satir, sutun] = sifreliMetinChar[index++];
                            gezilenMatris[satir, sutun] = true;
                            sutun++;
                        }
                        sutun--;
                        satir++;

                        if (satir >= satirSayisi || gezilenMatris[satir, sutun]) break;

                        while (satir < satirSayisi && !gezilenMatris[satir, sutun] && index < sifreliMetinChar.Length)
                        {
                            rotaMatris[satir, sutun] = sifreliMetinChar[index++];
                            gezilenMatris[satir, sutun] = true;
                            satir++;
                        }
                        satir--;
                        sutun--;

                        if (sutun < 0 || gezilenMatris[satir, sutun]) break;

                        while (sutun >= 0 && !gezilenMatris[satir, sutun] && index < sifreliMetinChar.Length)
                        {
                            rotaMatris[satir, sutun] = sifreliMetinChar[index++];
                            gezilenMatris[satir, sutun] = true;
                            sutun--;
                        }
                        sutun++;
                        satir--;

                        if (satir < 0 || gezilenMatris[satir, sutun]) break;
                    }

                    // Çözümlenmiş metni matrise yukarıdan aşağıya ve soldan sağa okuyarak elde et
                    index = 0;
                    char[] cozulmusMetin = new char[sifreliMetinChar.Length];
                    for (int x = 0; x < satirSayisi; x++)
                    {
                        for (int y = 0; y < rotaAnahtari; y++)
                        {
                            if (rotaMatris[x, y] != '\0')
                            {
                                cozulmusMetin[index++] = rotaMatris[x, y];
                            }
                        }
                    }

                    rotarichtxt2.Text = new string(cozulmusMetin).TrimEnd('z');
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void btnrotageri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
