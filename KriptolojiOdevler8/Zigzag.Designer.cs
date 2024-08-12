namespace KriptolojiOdevler8
{
    partial class Zigzag
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Zigzag));
            panel1 = new Panel();
            txtzigzaganahtar = new TextBox();
            label3 = new Label();
            label1 = new Label();
            btnzigzagcozumle = new Button();
            btnzigzagsifrele = new Button();
            zigzagrichtxt1 = new RichTextBox();
            panel2 = new Panel();
            btnzigzaggeri = new Button();
            zigzagrichtxt2 = new RichTextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Beige;
            panel1.Controls.Add(txtzigzaganahtar);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnzigzagcozumle);
            panel1.Controls.Add(btnzigzagsifrele);
            panel1.Controls.Add(zigzagrichtxt1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 402);
            panel1.TabIndex = 12;
            // 
            // txtzigzaganahtar
            // 
            txtzigzaganahtar.Location = new Point(297, 64);
            txtzigzaganahtar.Margin = new Padding(3, 2, 3, 2);
            txtzigzaganahtar.Name = "txtzigzaganahtar";
            txtzigzaganahtar.Size = new Size(99, 23);
            txtzigzaganahtar.TabIndex = 11;
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
            label1.Size = new Size(207, 25);
            label1.TabIndex = 4;
            label1.Text = "ZİGZAG ALGORİTMASI";
            // 
            // btnzigzagcozumle
            // 
            btnzigzagcozumle.Location = new Point(68, 340);
            btnzigzagcozumle.Margin = new Padding(3, 2, 3, 2);
            btnzigzagcozumle.Name = "btnzigzagcozumle";
            btnzigzagcozumle.Size = new Size(374, 35);
            btnzigzagcozumle.TabIndex = 2;
            btnzigzagcozumle.Text = "Şifreli Metni Çözümleyin";
            btnzigzagcozumle.UseVisualStyleBackColor = true;
            btnzigzagcozumle.Click += btnzigzagcozumle_Click;
            // 
            // btnzigzagsifrele
            // 
            btnzigzagsifrele.Location = new Point(68, 286);
            btnzigzagsifrele.Margin = new Padding(3, 2, 3, 2);
            btnzigzagsifrele.Name = "btnzigzagsifrele";
            btnzigzagsifrele.Size = new Size(374, 35);
            btnzigzagsifrele.TabIndex = 1;
            btnzigzagsifrele.Text = "Oluşturduğunuz Metni Şifrelendirin ";
            btnzigzagsifrele.UseVisualStyleBackColor = true;
            btnzigzagsifrele.Click += btnzigzagsifrele_Click;
            // 
            // zigzagrichtxt1
            // 
            zigzagrichtxt1.Location = new Point(68, 94);
            zigzagrichtxt1.Margin = new Padding(3, 2, 3, 2);
            zigzagrichtxt1.Name = "zigzagrichtxt1";
            zigzagrichtxt1.Size = new Size(374, 182);
            zigzagrichtxt1.TabIndex = 0;
            zigzagrichtxt1.Text = "";
            // 
            // panel2
            // 
            panel2.BackColor = Color.Peru;
            panel2.Controls.Add(btnzigzaggeri);
            panel2.Controls.Add(zigzagrichtxt2);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(527, 0);
            panel2.Margin = new Padding(3, 2, 3, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 402);
            panel2.TabIndex = 13;
            // 
            // btnzigzaggeri
            // 
            btnzigzaggeri.BackColor = Color.Peru;
            btnzigzaggeri.BackgroundImage = (Image)resources.GetObject("btnzigzaggeri.BackgroundImage");
            btnzigzaggeri.BackgroundImageLayout = ImageLayout.Zoom;
            btnzigzaggeri.FlatStyle = FlatStyle.Flat;
            btnzigzaggeri.Location = new Point(421, 329);
            btnzigzaggeri.Margin = new Padding(3, 2, 3, 2);
            btnzigzaggeri.Name = "btnzigzaggeri";
            btnzigzaggeri.Size = new Size(94, 57);
            btnzigzaggeri.TabIndex = 7;
            btnzigzaggeri.UseVisualStyleBackColor = false;
            btnzigzaggeri.Click += btnzigzaggeri_Click;
            // 
            // zigzagrichtxt2
            // 
            zigzagrichtxt2.Location = new Point(74, 94);
            zigzagrichtxt2.Margin = new Padding(3, 2, 3, 2);
            zigzagrichtxt2.Name = "zigzagrichtxt2";
            zigzagrichtxt2.Size = new Size(374, 182);
            zigzagrichtxt2.TabIndex = 1;
            zigzagrichtxt2.Text = "";
            // 
            // Zigzag
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1052, 402);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Zigzag";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Zigzag";
            Load += Zigzag_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private TextBox txtzigzaganahtar;
        private Label label3;
        private Label label1;
        private Button btnzigzagcozumle;
        private Button btnzigzagsifrele;
        private RichTextBox zigzagrichtxt1;
        private Panel panel2;
        private Button btnzigzaggeri;
        private RichTextBox zigzagrichtxt2;
    }
}