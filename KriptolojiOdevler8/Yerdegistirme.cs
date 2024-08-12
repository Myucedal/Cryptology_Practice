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
    public partial class Yerdegistirme : Form
    {
        public Yerdegistirme()
        {
            InitializeComponent();
        }

        private void Yerdegistirme_Load(object sender, EventArgs e)
        {

        }

        private void btnyerdegistirmesifrele_Click(object sender, EventArgs e)
        {
            try
            {

                if (yerdegistirmerichtxt1.Text == "")
                {
                    MessageBox.Show("Herhangi bir metin girmediniz. Lütfen metin giriniz.");
                    yerdegistirmerichtxt2.Text = string.Empty;
                }
                else
                {
                    string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                    string yerDegistirmeAnahtari = "esdğnüaymçtşiuphzrdıbkgjcvföl";
                    string metin = yerdegistirmerichtxt1.Text;
                    char[] anahtaralfabe = yerDegistirmeAnahtari.ToCharArray();
                    char[] alfabeDizi = alfabe.ToCharArray();
                    char[] metinChar = metin.ToCharArray();
                    
                    


                    for (int i = 0; i < metinChar.Length; i++)
                    {
                        char karakter = metinChar[i];

                        if (char.IsUpper(karakter))
                        {
                            karakter = char.ToLower(karakter);
                        }

                        if (alfabe.Contains(karakter))
                        {
                            int indis = Array.IndexOf(alfabeDizi, karakter);
                            metinChar[i] = anahtaralfabe[indis];    
                        }
                    }

                    string sifreliMesaj = new string(metinChar);
                    if (sifreliMesaj == yerdegistirmerichtxt1.Text)
                    {
                        MessageBox.Show("Sayısal değerlerde herhangi bir şifrelendirme işlemi yapılmamaktadır.Bilginize...");
                        yerdegistirmerichtxt2.Text = sifreliMesaj;
                    }
                    else

                        yerdegistirmerichtxt2.Text = sifreliMesaj;


                }
            }
            catch
            {
                MessageBox.Show("Bir anahtar değeri girmeniz gerekmekte.");
            }
        }
    

        private void btnyerdegistirmecozumle_Click(object sender, EventArgs e)
        {
            try
            {

                if (yerdegistirmerichtxt1.Text == "")
                {
                    MessageBox.Show("Herhangi bir metin girmediniz. Lütfen metin giriniz.");
                    yerdegistirmerichtxt2.Text = string.Empty;
                }
                else
                {
                    string alfabe = "abcçdefgğhıijklmnoöprsştuüvyz";
                    string yerDegistirmeAnahtari = "esdğnüaymçtşiuphzrdıbkgjcvföl";
                    string metin = yerdegistirmerichtxt1.Text;
                    char[] anahtaralfabe = yerDegistirmeAnahtari.ToCharArray();
                    char[] alfabeDizi = alfabe.ToCharArray();
                    char[] metinChar = metin.ToCharArray();




                    for (int i = 0; i < metinChar.Length; i++)
                    {
                        char karakter = metinChar[i];

                        if (char.IsUpper(karakter))
                        {
                            karakter = char.ToLower(karakter);
                        }

                        if (yerDegistirmeAnahtari.Contains(karakter))
                        {
                            int indis = Array.IndexOf(anahtaralfabe, karakter);
                            metinChar[i] = alfabe[indis];
                        }
                    }

                    string sifreliMesaj = new string(metinChar);
                    if (sifreliMesaj == yerdegistirmerichtxt1.Text)
                    {
                        MessageBox.Show("Sayısal değerlerde herhangi bir şifrelendirme işlemi yapılmamaktadır.Bilginize...");
                        yerdegistirmerichtxt2.Text = sifreliMesaj;
                    }
                    else

                        yerdegistirmerichtxt2.Text = sifreliMesaj;


                }
            }
            catch
            {
                MessageBox.Show("Bir anahtar değeri girmeniz gerekmekte.");
            }
        }

        private void btnyerdegistirmegeri_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
