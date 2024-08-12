namespace KriptolojiOdevler8
{
    partial class DortKareMatrisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DortKareMatrisForm));
            panel2 = new Panel();
            btnkaregeri = new Button();
            karerichtxt2 = new RichTextBox();
            karerichtxt1 = new RichTextBox();
            btnkaresifrele = new Button();
            btnkarecozumle = new Button();
            label1 = new Label();
            panel1 = new Panel();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(btnkaregeri);
            panel2.Controls.Add(karerichtxt2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(527, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 402);
            panel2.TabIndex = 15;
            // 
            // btnkaregeri
            // 
            btnkaregeri.BackColor = Color.Peru;
            btnkaregeri.BackgroundImage = (Image)resources.GetObject("btnkaregeri.BackgroundImage");
            btnkaregeri.BackgroundImageLayout = ImageLayout.Zoom;
            btnkaregeri.FlatStyle = FlatStyle.Flat;
            btnkaregeri.Location = new Point(421, 329);
            btnkaregeri.Margin = new Padding(3, 2, 3, 2);
            btnkaregeri.Name = "btnkaregeri";
            btnkaregeri.Size = new Size(94, 57);
            btnkaregeri.TabIndex = 7;
            btnkaregeri.UseVisualStyleBackColor = false;
            // 
            // karerichtxt2
            // 
            karerichtxt2.Location = new Point(74, 94);
            karerichtxt2.Margin = new Padding(3, 2, 3, 2);
            karerichtxt2.Name = "karerichtxt2";
            karerichtxt2.Size = new Size(374, 182);
            karerichtxt2.TabIndex = 1;
            karerichtxt2.Text = "";
            // 
            // karerichtxt1
            // 
            karerichtxt1.Location = new Point(68, 94);
            karerichtxt1.Margin = new Padding(3, 2, 3, 2);
            karerichtxt1.Name = "karerichtxt1";
            karerichtxt1.Size = new Size(374, 182);
            karerichtxt1.TabIndex = 0;
            karerichtxt1.Text = "";
            // 
            // btnkaresifrele
            // 
            btnkaresifrele.Location = new Point(68, 286);
            btnkaresifrele.Margin = new Padding(3, 2, 3, 2);
            btnkaresifrele.Name = "btnkaresifrele";
            btnkaresifrele.Size = new Size(374, 35);
            btnkaresifrele.TabIndex = 1;
            btnkaresifrele.Text = "Oluşturduğunuz Metni Şifrelendirin ";
            btnkaresifrele.UseVisualStyleBackColor = true;
            btnkaresifrele.Click += btnkaresifrele_Click;
            // 
            // btnkarecozumle
            // 
            btnkarecozumle.Location = new Point(68, 340);
            btnkarecozumle.Margin = new Padding(3, 2, 3, 2);
            btnkarecozumle.Name = "btnkarecozumle";
            btnkarecozumle.Size = new Size(374, 35);
            btnkarecozumle.TabIndex = 2;
            btnkarecozumle.Text = "Şifreli Metni Çözümleyin";
            btnkarecozumle.UseVisualStyleBackColor = true;
            btnkarecozumle.Click += btnkarecozumle_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            label1.ForeColor = Color.Olive;
            label1.Location = new Point(99, 19);
            label1.Name = "label1";
            label1.Size = new Size(276, 25);
            label1.TabIndex = 4;
            label1.Text = "4 KARE MATRİS ALGORİTMASI";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnkarecozumle);
            panel1.Controls.Add(btnkaresifrele);
            panel1.Controls.Add(karerichtxt1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 402);
            panel1.TabIndex = 14;
            // 
            // DortKareMatrisForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 402);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DortKareMatrisForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "DortKareMatrisForm";
            panel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Button btnkaregeri;
        private RichTextBox karerichtxt2;
        private RichTextBox karerichtxt1;
        private Button btnkaresifrele;
        private Button btnkarecozumle;
        private Label label1;
        private Panel panel1;
    }
}