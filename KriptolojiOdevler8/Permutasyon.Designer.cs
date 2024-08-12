namespace KriptolojiOdevler8
{
    partial class Permutasyon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Permutasyon));
            panel1 = new Panel();
            label1 = new Label();
            btnpermutasyoncozumle = new Button();
            btnpermutasyonsifrele = new Button();
            permutasyonrichtxt1 = new RichTextBox();
            panel2 = new Panel();
            btnpermutasyongeri = new Button();
            permutasyonrichtxt2 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnpermutasyoncozumle);
            panel1.Controls.Add(btnpermutasyonsifrele);
            panel1.Controls.Add(permutasyonrichtxt1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 402);
            panel1.TabIndex = 11;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(116, 44);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 4;
            label1.Text = "PERMÜTASYON ALGORİTMASI";
            // 
            // btnpermutasyoncozumle
            // 
            btnpermutasyoncozumle.Location = new Point(68, 340);
            btnpermutasyoncozumle.Margin = new Padding(3, 2, 3, 2);
            btnpermutasyoncozumle.Name = "btnpermutasyoncozumle";
            btnpermutasyoncozumle.Size = new Size(374, 35);
            btnpermutasyoncozumle.TabIndex = 2;
            btnpermutasyoncozumle.Text = "Şifreli Metni Çözümleyin";
            btnpermutasyoncozumle.UseVisualStyleBackColor = true;
            btnpermutasyoncozumle.Click += btnpermutasyoncozumle_Click;
            // 
            // btnpermutasyonsifrele
            // 
            btnpermutasyonsifrele.Location = new Point(68, 286);
            btnpermutasyonsifrele.Margin = new Padding(3, 2, 3, 2);
            btnpermutasyonsifrele.Name = "btnpermutasyonsifrele";
            btnpermutasyonsifrele.Size = new Size(374, 35);
            btnpermutasyonsifrele.TabIndex = 1;
            btnpermutasyonsifrele.Text = "Oluşturduğunuz Metni Şifrelendirin ";
            btnpermutasyonsifrele.UseVisualStyleBackColor = true;
            btnpermutasyonsifrele.Click += btnpermutasyonsifrele_Click;
            // 
            // permutasyonrichtxt1
            // 
            permutasyonrichtxt1.Location = new Point(68, 94);
            permutasyonrichtxt1.Margin = new Padding(3, 2, 3, 2);
            permutasyonrichtxt1.Name = "permutasyonrichtxt1";
            permutasyonrichtxt1.Size = new Size(374, 182);
            permutasyonrichtxt1.TabIndex = 0;
            permutasyonrichtxt1.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(btnpermutasyongeri);
            panel2.Controls.Add(permutasyonrichtxt2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(527, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 402);
            panel2.TabIndex = 12;
            // 
            // btnpermutasyongeri
            // 
            btnpermutasyongeri.BackColor = Color.Peru;
            btnpermutasyongeri.BackgroundImage = (Image)resources.GetObject("btnpermutasyongeri.BackgroundImage");
            btnpermutasyongeri.BackgroundImageLayout = ImageLayout.Zoom;
            btnpermutasyongeri.FlatStyle = FlatStyle.Flat;
            btnpermutasyongeri.Location = new Point(421, 329);
            btnpermutasyongeri.Margin = new Padding(3, 2, 3, 2);
            btnpermutasyongeri.Name = "btnpermutasyongeri";
            btnpermutasyongeri.Size = new Size(94, 57);
            btnpermutasyongeri.TabIndex = 7;
            btnpermutasyongeri.UseVisualStyleBackColor = false;
            btnpermutasyongeri.Click += btnpermutasyongeri_Click;
            // 
            // permutasyonrichtxt2
            // 
            permutasyonrichtxt2.Location = new Point(74, 94);
            permutasyonrichtxt2.Margin = new Padding(3, 2, 3, 2);
            permutasyonrichtxt2.Name = "permutasyonrichtxt2";
            permutasyonrichtxt2.Size = new Size(374, 182);
            permutasyonrichtxt2.TabIndex = 1;
            permutasyonrichtxt2.Text = "";
            // 
            // Permutasyon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 402);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Permutasyon";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Permutasyon";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnpermutasyoncozumle;
        private Button btnpermutasyonsifrele;
        private RichTextBox permutasyonrichtxt1;
        private Panel panel2;
        private Button btnpermutasyongeri;
        private RichTextBox permutasyonrichtxt2;
    }
}