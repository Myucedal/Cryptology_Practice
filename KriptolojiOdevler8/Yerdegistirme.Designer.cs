namespace KriptolojiOdevler8
{
    partial class Yerdegistirme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Yerdegistirme));
            panel1 = new Panel();
            label1 = new Label();
            btnyerdegistirmecozumle = new Button();
            btnyerdegistirmesifrele = new Button();
            yerdegistirmerichtxt1 = new RichTextBox();
            panel2 = new Panel();
            btnyerdegistirmegeri = new Button();
            yerdegistirmerichtxt2 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnyerdegistirmecozumle);
            panel1.Controls.Add(btnyerdegistirmesifrele);
            panel1.Controls.Add(yerdegistirmerichtxt1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 400);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(102, 38);
            label1.Name = "label1";
            label1.Size = new Size(286, 25);
            label1.TabIndex = 4;
            label1.Text = "YER DEĞİŞTİRME ALGORİTMASI";
            // 
            // btnyerdegistirmecozumle
            // 
            btnyerdegistirmecozumle.Location = new Point(68, 340);
            btnyerdegistirmecozumle.Margin = new Padding(3, 2, 3, 2);
            btnyerdegistirmecozumle.Name = "btnyerdegistirmecozumle";
            btnyerdegistirmecozumle.Size = new Size(374, 35);
            btnyerdegistirmecozumle.TabIndex = 2;
            btnyerdegistirmecozumle.Text = "Şifreli Metni Çözümleyin";
            btnyerdegistirmecozumle.UseVisualStyleBackColor = true;
            btnyerdegistirmecozumle.Click += btnyerdegistirmecozumle_Click;
            // 
            // btnyerdegistirmesifrele
            // 
            btnyerdegistirmesifrele.Location = new Point(68, 286);
            btnyerdegistirmesifrele.Margin = new Padding(3, 2, 3, 2);
            btnyerdegistirmesifrele.Name = "btnyerdegistirmesifrele";
            btnyerdegistirmesifrele.Size = new Size(374, 35);
            btnyerdegistirmesifrele.TabIndex = 1;
            btnyerdegistirmesifrele.Text = "Oluşturduğunuz Metni Şifrelendirin ";
            btnyerdegistirmesifrele.UseVisualStyleBackColor = true;
            btnyerdegistirmesifrele.Click += btnyerdegistirmesifrele_Click;
            // 
            // yerdegistirmerichtxt1
            // 
            yerdegistirmerichtxt1.Location = new Point(68, 94);
            yerdegistirmerichtxt1.Margin = new Padding(3, 2, 3, 2);
            yerdegistirmerichtxt1.Name = "yerdegistirmerichtxt1";
            yerdegistirmerichtxt1.Size = new Size(374, 182);
            yerdegistirmerichtxt1.TabIndex = 0;
            yerdegistirmerichtxt1.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(btnyerdegistirmegeri);
            panel2.Controls.Add(yerdegistirmerichtxt2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(527, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 400);
            panel2.TabIndex = 12;
            // 
            // btnyerdegistirmegeri
            // 
            btnyerdegistirmegeri.BackColor = Color.Peru;
            btnyerdegistirmegeri.BackgroundImage = (Image)resources.GetObject("btnyerdegistirmegeri.BackgroundImage");
            btnyerdegistirmegeri.BackgroundImageLayout = ImageLayout.Zoom;
            btnyerdegistirmegeri.FlatStyle = FlatStyle.Flat;
            btnyerdegistirmegeri.Location = new Point(421, 329);
            btnyerdegistirmegeri.Margin = new Padding(3, 2, 3, 2);
            btnyerdegistirmegeri.Name = "btnyerdegistirmegeri";
            btnyerdegistirmegeri.Size = new Size(94, 57);
            btnyerdegistirmegeri.TabIndex = 7;
            btnyerdegistirmegeri.UseVisualStyleBackColor = false;
            btnyerdegistirmegeri.Click += btnyerdegistirmegeri_Click;
            // 
            // yerdegistirmerichtxt2
            // 
            yerdegistirmerichtxt2.Location = new Point(74, 94);
            yerdegistirmerichtxt2.Margin = new Padding(3, 2, 3, 2);
            yerdegistirmerichtxt2.Name = "yerdegistirmerichtxt2";
            yerdegistirmerichtxt2.Size = new Size(374, 182);
            yerdegistirmerichtxt2.TabIndex = 1;
            yerdegistirmerichtxt2.Text = "";
            // 
            // Yerdegistirme
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1056, 400);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Yerdegistirme";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Yerdegistirme";
            Load += Yerdegistirme_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnyerdegistirmecozumle;
        private Button btnyerdegistirmesifrele;
        private RichTextBox yerdegistirmerichtxt1;
        private Panel panel2;
        private Button btnyerdegistirmegeri;
        private RichTextBox yerdegistirmerichtxt2;
    }
}