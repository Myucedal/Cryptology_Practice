using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KriptolojiOdevler8
{
    public partial class Vigenere : Form
    {
        public Vigenere()
        {
            InitializeComponent();
        }

        private void Vigenere_Load(object sender, EventArgs e)
        {

        }




        private void btnvigeneresifrele_Click_1(object sender, EventArgs e)
        {
            try
            {

                if (vigenererichtxt1.Text == "")
                {
                    MessageBox.Show("Herhangi bir metin girmediniz. Lütfen metin giriniz.");
                    vigenererichtxt2.Text = string.Empty;
                }
                else
                {
                    string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                    char[] alfabeDizi = alfabe.ToCharArray();
                    string metin = vigenererichtxt1.Text;
                    char[] metinChar = metin.ToCharArray();
                    string vigenereAnahtari = txtvigenereanahtar.Text;
                    char[] anahtarDizisi = vigenereAnahtari.ToCharArray();


                    for (int i = 0; i < metinChar.Length; i++)
                    {
                        char karakter = metinChar[i];
                        char anahtar = vigenereAnahtari[i % vigenereAnahtari.Length];
                        int indisanahtar = Array.IndexOf(alfabeDizi, anahtar);

                        if (char.IsUpper(karakter))
                        {
                            karakter = char.ToLower(karakter);
                        }

                        if (alfabe.Contains(karakter))
                        {
                            int indis = Array.IndexOf(alfabeDizi, karakter);
                            metinChar[i] = alfabeDizi[(indis + indisanahtar + 1) % 29];
                        }
                    }

                    string sifreliMesaj = new string(metinChar);
                    if (sifreliMesaj == vigenererichtxt1.Text)
                    {
                        MessageBox.Show("Sayısal değerlerde herhangi bir şifrelendirme işlemi yapılmamaktadır.Bilginize...");
                        vigenererichtxt2.Text = sifreliMesaj;
                    }
                    else

                        vigenererichtxt2.Text = sifreliMesaj;


                }
            }
            catch
            {
                MessageBox.Show("Bir anahtar değeri girmeniz gerekmekte.");
            }
        }

        private void btnvigenerecozumle_Click(object sender, EventArgs e)
        {

            try
            {
                if (vigenererichtxt1.Text == "")
                {
                    MessageBox.Show("Herhangi bir metin girmediniz. Lütfen metin giriniz.");
                    vigenererichtxt2.Text = string.Empty;
                }
                else
                {
                    string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                    char[] alfabeDizi = alfabe.ToCharArray();
                    string metin = vigenererichtxt1.Text;
                    char[] metinChar = metin.ToCharArray();
                    string vigenereAnahtari = txtvigenereanahtar.Text;
                    char[] anahtarDizisi = vigenereAnahtari.ToCharArray();

                    for (int i = 0; i < metinChar.Length; i++)
                    {
                        char karakter = metinChar[i];
                        char anahtar = vigenereAnahtari[i % vigenereAnahtari.Length];
                        int indisanahtar = Array.IndexOf(alfabeDizi, anahtar);

                        if (char.IsUpper(karakter))
                        {
                            karakter = char.ToLower(karakter);
                        }

                        if (alfabe.Contains(karakter))
                        {
                            int indis = Array.IndexOf(alfabeDizi, karakter);
                            metinChar[i] = alfabeDizi[(indis - indisanahtar + 28) % 29];
                        }
                    }

                    string sifreliMesaj = new string(metinChar);
                    if (sifreliMesaj == vigenererichtxt1.Text)
                    {
                        MessageBox.Show("Sayısal değerlerde herhangi bir çözümleme işlemi yapılmamaktadır." +
                            "Bilginize...");
                        vigenererichtxt2.Text = sifreliMesaj;
                    }
                    else
                    {

                        vigenererichtxt2.Text = sifreliMesaj;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Bir anahtar değeri girmeniz gerekmekte.");
            }
        }

        private void btnvigeneregeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}



