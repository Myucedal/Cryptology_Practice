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
    public partial class Permutasyon : Form
    {
        public Permutasyon()
        {
            InitializeComponent();
        }

        private void btnpermutasyonsifrele_Click(object sender, EventArgs e)
        {
            try
            {

                if (permutasyonrichtxt1.Text == "")
                {
                    MessageBox.Show("Herhangi bir metin girmediniz. Lütfen metin giriniz.");
                    permutasyonrichtxt2.Text = string.Empty;
                    return;
                }
                else
                {
                    // string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                    // char[] alfabeDizi = alfabe.ToCharArray();
                    string metin = permutasyonrichtxt1.Text;
                    char[] metinChar = metin.ToCharArray();

                    int[] permutasyonAnahtari = { 1, 3, 4, 0, 2 }; //  anahtar değeri = { 3, 0 , 4, 1, 2}
                    while (metinChar.Length % 5 != 0)
                    {

                        Array.Resize(ref metinChar, metinChar.Length + 1);
                        metinChar[metinChar.Length - 1] = 'z'; // 'z' karakterini ekliyoruz
                    }

                    char[] sifrelenmisMetin = new char[metinChar.Length];

                    for (int i = 0; i < metinChar.Length; i += 5)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            int yerimiz = permutasyonAnahtari[j];
                            char karakter = metinChar[i + j];
                            sifrelenmisMetin[i + yerimiz] = karakter;
                        }
                    }

                    string sifreliMesaj = new string(sifrelenmisMetin);
                    permutasyonrichtxt2.Text = sifreliMesaj;
                    if (sifreliMesaj == permutasyonrichtxt1.Text)
                    {
                        MessageBox.Show("Sayısal değerlerde herhangi bir şifrelendirme işlemi yapılmamaktadır.Bilginize...");
                        permutasyonrichtxt2.Text = sifreliMesaj;
                    }
                    else

                        permutasyonrichtxt2.Text = sifreliMesaj;


                }


            }
            catch
            {
                MessageBox.Show("Bir anahtar değeri girmeniz gerekmekte.");
            }

        }

        private void btnpermutasyongeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnpermutasyoncozumle_Click(object sender, EventArgs e)
        {
            try
            {

                if (permutasyonrichtxt1.Text == "")
                {
                    MessageBox.Show("Herhangi bir metin girmediniz. Lütfen metin giriniz.");
                    permutasyonrichtxt2.Text = string.Empty;
                    return;
                }
                else
                {
                    // string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                    // char[] alfabeDizi = alfabe.ToCharArray();
                    string metin = permutasyonrichtxt1.Text;
                    char[] metinChar = metin.ToCharArray();

                    int[] permutasyonAnahtari = { 3, 0, 4, 1, 2 };
                    // { 1, 3, 4, 0, 2 }' in tersi
                    while (metinChar.Length % 5 != 0)
                    {

                        Array.Resize(ref metinChar, metinChar.Length + 1);
                        metinChar[metinChar.Length - 1] = 'z'; // 'z' karakterini ekliyoruz
                    }

                    char[] sifrelenmisMetin = new char[metinChar.Length];

                    for (int i = 0; i < metinChar.Length; i += 5)
                    {
                        for (int j = 0; j < 5; j++)
                        {
                            int yerimiz = permutasyonAnahtari[j];
                            char karakter = metinChar[i + j];
                            sifrelenmisMetin[i + yerimiz] = karakter;
                        }
                    }

                    string sifreliMesaj = new string(sifrelenmisMetin);
                    permutasyonrichtxt2.Text = sifreliMesaj;
                    if (sifreliMesaj == permutasyonrichtxt1.Text)
                    {
                        MessageBox.Show("Sayısal değerlerde herhangi bir şifrelendirme işlemi yapılmamaktadır.Bilginize...");
                        permutasyonrichtxt2.Text = sifreliMesaj;
                    }
                    else

                        permutasyonrichtxt2.Text = sifreliMesaj;


                }


            }
            catch
            {
                MessageBox.Show("Bir anahtar değeri girmeniz gerekmekte.");
            }

        }
    }
}

