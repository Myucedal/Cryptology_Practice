namespace KriptolojiOdevler8
{
    partial class RotaAlgoritmasi
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RotaAlgoritmasi));
            panel1 = new Panel();
            txtrotaanahtar = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnrotacozumle = new Button();
            btnrotasifrele = new Button();
            rotarichtxt1 = new RichTextBox();
            panel2 = new Panel();
            btnrotageri = new Button();
            rotarichtxt2 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(txtrotaanahtar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnrotacozumle);
            panel1.Controls.Add(btnrotasifrele);
            panel1.Controls.Add(rotarichtxt1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 402);
            panel1.TabIndex = 11;
            // 
            // txtrotaanahtar
            // 
            txtrotaanahtar.Location = new Point(297, 64);
            txtrotaanahtar.Margin = new Padding(3, 2, 3, 2);
            txtrotaanahtar.Name = "txtrotaanahtar";
            txtrotaanahtar.Size = new Size(99, 23);
            txtrotaanahtar.TabIndex = 11;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(99, 66);
            label3.Name = "label3";
            label3.Size = new Size(151, 15);
            label3.TabIndex = 10;
            label3.Text = "Öncelikle bir anahtar giriniz";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(146, 19);
            label1.Name = "label1";
            label1.Size = new Size(190, 25);
            label1.TabIndex = 4;
            label1.Text = "ROTA ALGORİTMASI";
            // 
            // btnrotacozumle
            // 
            btnrotacozumle.Location = new Point(68, 340);
            btnrotacozumle.Margin = new Padding(3, 2, 3, 2);
            btnrotacozumle.Name = "btnrotacozumle";
            btnrotacozumle.Size = new Size(374, 35);
            btnrotacozumle.TabIndex = 2;
            btnrotacozumle.Text = "Şifreli Metni Çözümleyin";
            btnrotacozumle.UseVisualStyleBackColor = true;
            btnrotacozumle.Click += btnrotacozumle_Click;
            // 
            // btnrotasifrele
            // 
            btnrotasifrele.Location = new Point(68, 286);
            btnrotasifrele.Margin = new Padding(3, 2, 3, 2);
            btnrotasifrele.Name = "btnrotasifrele";
            btnrotasifrele.Size = new Size(374, 35);
            btnrotasifrele.TabIndex = 1;
            btnrotasifrele.Text = "Oluşturduğunuz Metni Şifrelendirin ";
            btnrotasifrele.UseVisualStyleBackColor = true;
            btnrotasifrele.Click += btnrotasifrele_Click_1;
            // 
            // rotarichtxt1
            // 
            rotarichtxt1.Location = new Point(68, 94);
            rotarichtxt1.Margin = new Padding(3, 2, 3, 2);
            rotarichtxt1.Name = "rotarichtxt1";
            rotarichtxt1.Size = new Size(374, 182);
            rotarichtxt1.TabIndex = 0;
            rotarichtxt1.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(btnrotageri);
            panel2.Controls.Add(rotarichtxt2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(527, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 402);
            panel2.TabIndex = 12;
            // 
            // btnrotageri
            // 
            btnrotageri.BackColor = Color.Peru;
            btnrotageri.BackgroundImage = (Image)resources.GetObject("btnrotageri.BackgroundImage");
            btnrotageri.BackgroundImageLayout = ImageLayout.Zoom;
            btnrotageri.FlatStyle = FlatStyle.Flat;
            btnrotageri.Location = new Point(421, 329);
            btnrotageri.Margin = new Padding(3, 2, 3, 2);
            btnrotageri.Name = "btnrotageri";
            btnrotageri.Size = new Size(94, 57);
            btnrotageri.TabIndex = 7;
            btnrotageri.UseVisualStyleBackColor = false;
            btnrotageri.Click += btnrotageri_Click;
            // 
            // rotarichtxt2
            // 
            rotarichtxt2.Location = new Point(74, 94);
            rotarichtxt2.Margin = new Padding(3, 2, 3, 2);
            rotarichtxt2.Name = "rotarichtxt2";
            rotarichtxt2.Size = new Size(374, 182);
            rotarichtxt2.TabIndex = 1;
            rotarichtxt2.Text = "";
            // 
            // RotaAlgoritmasi
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 402);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "RotaAlgoritmasi";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "RotaAlgoritmasi";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtrotaanahtar;
        private Label label3;
        private Label label1;
        private Button btnrotacozumle;
        private Button btnrotasifrele;
        private RichTextBox rotarichtxt1;
        private Panel panel2;
        private Button btnrotageri;
        private RichTextBox rotarichtxt2;
    }
}