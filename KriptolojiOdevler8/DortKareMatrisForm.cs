using System;
using System.Windows.Forms;

namespace KriptolojiOdevler8
{
    public partial class DortKareMatrisForm : Form
    {
        private readonly char[,] alfabeMatris = new char[6, 5];
        private readonly char[,] rastgeleMatris = new char[6, 5];
        private readonly Random random = new Random();

        public DortKareMatrisForm()
        {
            InitializeComponent();
            AlfabeleriOlustur();
        }

        private void AlfabeleriOlustur()
        {
            string alfabe = "abcçdefgğhıijklmnoöprsştuüvyzx"; 
            string rastgeleAlfabe = "xniğkzydsöctpbhuvjflgüarçmşeoi"; 
            
            for (int i = 0; i < 30; i++)
            {
                int row = i / 5;
                int col = i % 5;
                alfabeMatris[row, col] = alfabe[i];
            }
            
            char[,] rastgeleMatris = new char[5, 5];

            for (int i = 0; i < 25; i++)
            {
                int row = i / 5;
                int col = i % 5;
                rastgeleMatris[row, col] = rastgeleAlfabe[i];
            }


        }


        private string Sifrele(string metin)
        {
           
            char[] sifrelenmisMetin = new char[metin.Length + 1];

            for (int i = 0; i < metin.Length; i += 2) 
            {
                var pozisyon1 = HarfPozisyonu(metin[i], alfabeMatris);
                var pozisyon2 = HarfPozisyonu(metin[i + 1], alfabeMatris);

                if (pozisyon1 == (-1, -1) || pozisyon2 == (-1, -1))
                {
                    MessageBox.Show("Metin içinde geçersiz karakterler var.");
                    return string.Empty;
                }

                sifrelenmisMetin[i] = rastgeleMatris[pozisyon1.Item1, pozisyon2.Item2];
                sifrelenmisMetin[i + 1] = rastgeleMatris[pozisyon2.Item1, pozisyon1.Item2];
            }

            return new string(sifrelenmisMetin);
        }

        private string Coz(string sifreliMetin)
        {
            char[] cozulmusMetin = new char[sifreliMetin.Length];
            for (int i = 0; i < sifreliMetin.Length; i += 2)
            {
                var pozisyon1 = HarfPozisyonu(sifreliMetin[i], rastgeleMatris);
                var pozisyon2 = HarfPozisyonu(sifreliMetin[i + 1], rastgeleMatris);

                if (pozisyon1 == (-1, -1) || pozisyon2 == (-1, -1))
                {
                    MessageBox.Show("Şifreli metin içinde geçersiz karakterler var.");
                    return string.Empty;
                }

                cozulmusMetin[i] = alfabeMatris[pozisyon1.Item1, pozisyon2.Item2];
                cozulmusMetin[i + 1] = alfabeMatris[pozisyon2.Item1, pozisyon1.Item2];
            }
            return new string(cozulmusMetin);
        }

        private (int, int) HarfPozisyonu(char harf, char[,] matris)
        {
            for (int i = 0; i < 6; i++) 
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matris[i, j] == harf)
                    {
                        return (i, j);
                    }
                }
            }
            return (-1, -1); 
        }

        private void btnkaresifrele_Click(object sender, EventArgs e)
        {
            string alfabe = "abcçdefgğhıijklmnoöprsştuüvyzx";
            char[] harfler = alfabe.ToCharArray();
            char[,] chars1 = new char[6, 5];
            string sifreli = "";
            int p = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    chars1[i, j] = harfler[p];
                    p++;
                }
            }
            char[,] chars2 = new char[6, 5];
            string sifre = "xniğkzydsöctpbhuvjflgüarçmşeoi";
            char[] crypt = sifre.ToCharArray();
            int k = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    chars2[i, j] = crypt[k];
                    k++;
                }
            }
            string metin = karerichtxt1.Text;
            char[] chars = metin.ToCharArray();
            while (chars.Length % 2 != 0)
            {
                Array.Resize(ref chars, chars.Length + 1);
                chars[chars.Length - 1] = 'z';
            }

            karerichtxt2.Text = sifrele(sifreli, chars, chars1, chars2);
        }
        private string sifrele(string sifreli, char[] chars, char[,] chars1, char[,] chars2)
        {

            for (int i = 0; i < chars.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if (chars1[j, k] == chars[i])
                            {
                                for (int l = 0; l < 6; l++)
                                {
                                    for (int m = 0; m < 5; m++)
                                    {
                                        if (chars[i + 1] == chars1[l, m])
                                        {
                                            sifreli += chars2[j, m];//m => m-1
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
                if (i % 2 == 1)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if (chars1[j, k] == chars[i])
                            {
                                for (int l = 0; l < 6; l++)
                                {
                                    for (int m = 0; m < 5; m++)
                                    {
                                        if (chars1[l, m] == chars[i - 1])
                                        {
                                            sifreli += chars2[j, m];// m => m+1
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }

            }

            return sifreli;
        }
        private string cozumle(string cozumlu, char[] chars, char[,] chars1, char[,] chars2)
        {
            for (int i = 0; i < chars.Length; i++)
            {
                if (i % 2 == 0)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if (chars2[j, k] == chars[i])
                            {
                                for (int l = 0; l < 6; l++)
                                {
                                    for (int m = 0; m < 5; m++)
                                    {
                                        if (chars[i + 1] == chars2[l, m])
                                        {
                                            cozumlu += chars1[j, m];//m => m-1
                                        }
                                    }
                                }

                            }
                        }
                    }
                }
                if (i % 2 == 1)
                {
                    for (int j = 0; j < 6; j++)
                    {
                        for (int k = 0; k < 5; k++)
                        {
                            if (chars2[j, k] == chars[i])
                            {
                                for (int l = 0; l < 6; l++)
                                {
                                    for (int m = 0; m < 5; m++)
                                    {
                                        if (chars2[l, m] == chars[i - 1])
                                        {
                                            cozumlu += chars1[j, m];// m => m+1
                                            break;
                                        }
                                    }
                                }
                                break;
                            }
                        }
                    }
                }

            }
            return cozumlu;
        }
        private void btnkarecozumle_Click(object sender, EventArgs e)
        {
            string alfabe = "abcçdefgğhıijklmnoöprsştuüvyzx";
            char[] harfler = alfabe.ToCharArray();
            char[,] chars1 = new char[6, 5];
            string cozumlu = "";
            int p = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    chars1[i, j] = harfler[p];
                    p++;
                }
            }
            char[,] chars2 = new char[6, 5];
            string sifre = "xniğkzydsöctpbhuvjflgüarçmşeoix";
            char[] crypt = sifre.ToCharArray();
            int k = 0;
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 5; j++)
                {

                    chars2[i, j] = crypt[k];
                    k++;
                }
            }
            string metin = karerichtxt1.Text;
            char[] chars = metin.ToCharArray();
            while (chars.Length % 2 != 0)
            {
                Array.Resize(ref chars, chars.Length + 1);
                chars[chars.Length - 1] = 'z';
            }

            karerichtxt2.Text = cozumle(cozumlu, chars, chars1, chars2);
        }
    }
}
