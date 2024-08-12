namespace KriptolojiOdevler8
{
    partial class Vigenere
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vigenere));
            richTextBox1 = new RichTextBox();
            panel1 = new Panel();
            txtvigenereanahtar = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnvigenerecozumle = new Button();
            btnvigeneresifrele = new Button();
            vigenererichtxt1 = new RichTextBox();
            panel2 = new Panel();
            btnvigeneregeri = new Button();
            vigenererichtxt2 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(57, 64);
            richTextBox1.Margin = new Padding(3, 2, 3, 2);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(374, 182);
            richTextBox1.TabIndex = 1;
            richTextBox1.Text = "";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(txtvigenereanahtar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnvigenerecozumle);
            panel1.Controls.Add(btnvigeneresifrele);
            panel1.Controls.Add(vigenererichtxt1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 406);
            panel1.TabIndex = 10;
            // 
            // txtvigenereanahtar
            // 
            txtvigenereanahtar.Location = new Point(297, 64);
            txtvigenereanahtar.Margin = new Padding(3, 2, 3, 2);
            txtvigenereanahtar.Name = "txtvigenereanahtar";
            txtvigenereanahtar.Size = new Size(99, 23);
            txtvigenereanahtar.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 66);
            label3.Name = "label3";
            label3.Size = new Size(189, 15);
            label3.TabIndex = 10;
            label3.Text = "Öncelikle bir anahtar kelime giriniz";
            label3.Click += label3_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(127, 19);
            label1.Name = "label1";
            label1.Size = new Size(228, 25);
            label1.TabIndex = 4;
            label1.Text = "VİGENERE ALGORİTMASI";
            // 
            // btnvigenerecozumle
            // 
            btnvigenerecozumle.Location = new Point(68, 340);
            btnvigenerecozumle.Margin = new Padding(3, 2, 3, 2);
            btnvigenerecozumle.Name = "btnvigenerecozumle";
            btnvigenerecozumle.Size = new Size(374, 35);
            btnvigenerecozumle.TabIndex = 2;
            btnvigenerecozumle.Text = "Şifreli Metni Çözümleyin";
            btnvigenerecozumle.UseVisualStyleBackColor = true;
            btnvigenerecozumle.Click += btnvigenerecozumle_Click;
            // 
            // btnvigeneresifrele
            // 
            btnvigeneresifrele.Location = new Point(68, 286);
            btnvigeneresifrele.Margin = new Padding(3, 2, 3, 2);
            btnvigeneresifrele.Name = "btnvigeneresifrele";
            btnvigeneresifrele.Size = new Size(374, 35);
            btnvigeneresifrele.TabIndex = 1;
            btnvigeneresifrele.Text = "Oluşturduğunuz Metni Şifrelendirin ";
            btnvigeneresifrele.UseVisualStyleBackColor = true;
            btnvigeneresifrele.Click += btnvigeneresifrele_Click_1;
            // 
            // vigenererichtxt1
            // 
            vigenererichtxt1.Location = new Point(68, 94);
            vigenererichtxt1.Margin = new Padding(3, 2, 3, 2);
            vigenererichtxt1.Name = "vigenererichtxt1";
            vigenererichtxt1.Size = new Size(374, 182);
            vigenererichtxt1.TabIndex = 0;
            vigenererichtxt1.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(btnvigeneregeri);
            panel2.Controls.Add(vigenererichtxt2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(527, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 406);
            panel2.TabIndex = 11;
            // 
            // btnvigeneregeri
            // 
            btnvigeneregeri.BackColor = Color.Peru;
            btnvigeneregeri.BackgroundImage = (Image)resources.GetObject("btnvigeneregeri.BackgroundImage");
            btnvigeneregeri.BackgroundImageLayout = ImageLayout.Zoom;
            btnvigeneregeri.FlatStyle = FlatStyle.Flat;
            btnvigeneregeri.Location = new Point(421, 329);
            btnvigeneregeri.Margin = new Padding(3, 2, 3, 2);
            btnvigeneregeri.Name = "btnvigeneregeri";
            btnvigeneregeri.Size = new Size(94, 57);
            btnvigeneregeri.TabIndex = 7;
            btnvigeneregeri.UseVisualStyleBackColor = false;
            btnvigeneregeri.Click += btnvigeneregeri_Click;
            // 
            // vigenererichtxt2
            // 
            vigenererichtxt2.Location = new Point(74, 94);
            vigenererichtxt2.Margin = new Padding(3, 2, 3, 2);
            vigenererichtxt2.Name = "vigenererichtxt2";
            vigenererichtxt2.Size = new Size(374, 182);
            vigenererichtxt2.TabIndex = 1;
            vigenererichtxt2.Text = "";
            // 
            // Vigenere
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1053, 406);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(richTextBox1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Vigenere";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Vigenere";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox richTextBox1;
        private Button btnvigenerecozumle;
        private Button btnvigeneresifrele;
        private Panel panel1;
        private Label label1;
        private Button btnszrcozumle;
        
        private RichTextBox vigenererichtxt1;
        private Panel panel2;
        private Button btnvigeneregeri;
        private RichTextBox vigenererichtxt2;
        private TextBox txtvigenereanahtar;
        private Label label3;
    }
}