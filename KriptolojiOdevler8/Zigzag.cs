using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptolojiOdevler8
{
    public partial class Zigzag : Form
    {
        public Zigzag()
        {
            InitializeComponent();
        }

        private void btnzigzagsifrele_Click(object sender, EventArgs e)
        {
            try
            {
                if (zigzagrichtxt1.Text == "")
                {
                    MessageBox.Show("Herhangi bir metin girmediniz. Lütfen metin giriniz.");
                    zigzagrichtxt2.Text = string.Empty;
                }
                else
                {
                    string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                    char[] alfabechar = alfabe.ToCharArray();
                    string metin = zigzagrichtxt1.Text;
                    char[] metinChar = metin.ToCharArray();
                    int zigzagAnahtari = Convert.ToInt16(txtzigzaganahtar.Text);
                    int satirsayisi = zigzagAnahtari;
                    int sutunsayisi = metinChar.Length;
                    char[,] zigzagmatris = new char[satirsayisi, sutunsayisi];
                    int yer = 0;
                    int _anliksatir = 0;
                    int _anliksutun = 0;
                    char[] sifrelenmisMetin = new char[metinChar.Length];
                    for (int i = 0; i < metinChar.Length; i++)
                    {
                        if (_anliksatir == 0)
                        {
                            for (int j = 0; j < satirsayisi; j++)
                            {
                                if (_anliksutun != metinChar.Length)
                                {
                                    zigzagmatris[_anliksatir, _anliksutun] = metinChar[yer];
                                    _anliksatir++;
                                    _anliksutun++;
                                    yer++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            _anliksatir--;
                        }


                        else if (_anliksatir == satirsayisi - 1)
                        {
                            for (int c = 0; c < satirsayisi - 1; c++)
                            {
                                if (_anliksutun != metinChar.Length)
                                {
                                    _anliksatir--;
                                    zigzagmatris[_anliksatir, _anliksutun] = metinChar[yer];
                                    _anliksutun++;
                                    yer++;
                                }
                                else
                                {
                                    break;
                                }

                            }
                            _anliksatir++;
                        }

                        else if (_anliksatir == 1)
                        {
                            for (int d = 0; d < satirsayisi - 1; d++)
                            {
                                if (_anliksutun != metinChar.Length)
                                {
                                    zigzagmatris[_anliksatir, _anliksutun] = metinChar[yer];
                                    _anliksatir++;
                                    yer++;
                                    _anliksutun++;
                                }
                                else
                                {
                                    break;
                                }
                            }
                            _anliksatir--;
                        }



                    }

                    int index = 0;

                    for (int x = 0; x < satirsayisi; x++)
                    {
                        for (int y = 0; y < sutunsayisi; y++)
                        {
                            char karakter = zigzagmatris[x, y];


                            if (char.IsUpper(karakter))
                            {
                                karakter = char.ToLower(karakter);
                            }

                            if (alfabe.Contains(karakter))
                            {
                                sifrelenmisMetin[index] = karakter;
                                index++;
                            }

                        }
                    }

                    string sifreliMesaj = new string(sifrelenmisMetin);
                    zigzagrichtxt2.Text = sifreliMesaj;
                }
            }


            catch (FormatException)
            {
                MessageBox.Show("dasdasdsa");
            }
        }

        private void Zigzag_Load(object sender, EventArgs e)
        {

        }

        private void btnzigzagcozumle_Click(object sender, EventArgs e)
        {
            try
            {
                if (zigzagrichtxt1.Text == "")
                {
                    MessageBox.Show("Şifreli metin girmediniz. Lütfen şifreli metin giriniz.");
                    zigzagrichtxt1.Text = string.Empty;
                }
                else
                {
                    string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                    char[] alfabechar = alfabe.ToCharArray();
                    string sifreliMetin = zigzagrichtxt1.Text;
                    char[] sifreliMetinChar = sifreliMetin.ToCharArray();
                    int zigzagAnahtari = Convert.ToInt16(txtzigzaganahtar.Text);
                    int satirsayisi = zigzagAnahtari;
                    int sutunsayisi = sifreliMetinChar.Length;
                    char[,] zigzagmatris = new char[satirsayisi, sutunsayisi];

                    int index = 0;

                    
                    for (int satir = 0; satir < satirsayisi; satir++)
                    {
                        int _anliksatir = 0;
                        int _anliksutun = 0;
                        bool yukariGit = true;

                        for (int sutun = 0; sutun < sutunsayisi; sutun++)
                        {
                            if (satir == _anliksatir)
                            {
                                zigzagmatris[satir, sutun] = sifreliMetinChar[index];
                                index++;
                            }

                            if (yukariGit)
                            {
                                if (_anliksatir == satirsayisi - 1)
                                {
                                    yukariGit = false;
                                    _anliksatir--;
                                }
                                else
                                {
                                    _anliksatir++;
                                }
                            }
                            else
                            {
                                if (_anliksatir == 0)
                                {
                                    yukariGit = true;
                                    _anliksatir++;
                                }
                                else
                                {
                                    _anliksatir--;
                                }
                            }
                        }
                    }

                  
                    char[] cozulmusMetin = new char[sifreliMetinChar.Length];
                    int cozulmusIndex = 0;

                    for (int sutun = 0; sutun < sutunsayisi; sutun++)
                    {
                        for (int satir = 0; satir < satirsayisi; satir++)
                        {
                            if (zigzagmatris[satir, sutun] != '\0')
                            {
                                cozulmusMetin[cozulmusIndex] = zigzagmatris[satir, sutun];
                                cozulmusIndex++;
                            }
                        }
                    }

                    string cozulmusMesaj = new string(cozulmusMetin);
                    zigzagrichtxt2.Text = cozulmusMesaj;
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Geçerli bir anahtar değeri giriniz.");
            }
        }

        private void btnzigzaggeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}

