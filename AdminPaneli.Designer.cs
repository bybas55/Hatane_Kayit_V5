namespace HastaneKayit
{
    partial class AdminPaneli
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminPaneli));
            this.panel2 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnBanla = new System.Windows.Forms.Button();
            this.btnUyeSil = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnDoktorBilgileri = new System.Windows.Forms.Button();
            this.pnlDoktorEkle = new System.Windows.Forms.Panel();
            this.btnDoktorIptal = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DoktorEkleTamam = new System.Windows.Forms.Button();
            this.txtDoktorParola = new System.Windows.Forms.TextBox();
            this.txtDoktorKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtDoktorEkle = new System.Windows.Forms.TextBox();
            this.pnlKlinikEkle = new System.Windows.Forms.Panel();
            this.btnKlinikİptal = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlKlinikEkleTamam = new System.Windows.Forms.Button();
            this.txtKlinikEkle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDoktorSil = new System.Windows.Forms.Button();
            this.btnDoktorEkle = new System.Windows.Forms.Button();
            this.btnKlinikSil = new System.Windows.Forms.Button();
            this.btnKlinikEkle = new System.Windows.Forms.Button();
            this.listBoxDoktor = new System.Windows.Forms.ListBox();
            this.listBoxKlinik = new System.Windows.Forms.ListBox();
            this.btnCikis = new System.Windows.Forms.PictureBox();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblSaat = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTarih = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUyeSayisi = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.pnlDoktorEkle.SuspendLayout();
            this.pnlKlinikEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.numericUpDown1);
            this.panel2.Controls.Add(this.btnBanla);
            this.panel2.Controls.Add(this.btnUyeSil);
            this.panel2.Controls.Add(this.listView1);
            this.panel2.Controls.Add(this.btnDoktorBilgileri);
            this.panel2.Controls.Add(this.pnlDoktorEkle);
            this.panel2.Controls.Add(this.pnlKlinikEkle);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnDoktorSil);
            this.panel2.Controls.Add(this.btnDoktorEkle);
            this.panel2.Controls.Add(this.btnKlinikSil);
            this.panel2.Controls.Add(this.btnKlinikEkle);
            this.panel2.Controls.Add(this.listBoxDoktor);
            this.panel2.Controls.Add(this.listBoxKlinik);
            this.panel2.Controls.Add(this.btnCikis);
            this.panel2.Location = new System.Drawing.Point(0, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(899, 373);
            this.panel2.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(770, 316);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(36, 20);
            this.numericUpDown1.TabIndex = 7;
            // 
            // btnBanla
            // 
            this.btnBanla.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnBanla.Location = new System.Drawing.Point(689, 310);
            this.btnBanla.Name = "btnBanla";
            this.btnBanla.Size = new System.Drawing.Size(75, 29);
            this.btnBanla.TabIndex = 6;
            this.btnBanla.Text = "Block";
            this.btnBanla.UseVisualStyleBackColor = true;
            this.btnBanla.Click += new System.EventHandler(this.btnBanla_Click);
            // 
            // btnUyeSil
            // 
            this.btnUyeSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnUyeSil.Location = new System.Drawing.Point(539, 310);
            this.btnUyeSil.Name = "btnUyeSil";
            this.btnUyeSil.Size = new System.Drawing.Size(144, 29);
            this.btnUyeSil.TabIndex = 5;
            this.btnUyeSil.Text = "Members Delete";
            this.btnUyeSil.UseVisualStyleBackColor = true;
            this.btnUyeSil.Click += new System.EventHandler(this.btnUyeSil_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(444, 27);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(452, 277);
            this.listView1.TabIndex = 56;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID Number ( T.C. ) ";
            this.columnHeader1.Width = 107;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Surname";
            this.columnHeader3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeader3.Width = 135;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Gender";
            this.columnHeader4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDoktorBilgileri
            // 
            this.btnDoktorBilgileri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorBilgileri.Location = new System.Drawing.Point(260, 154);
            this.btnDoktorBilgileri.Name = "btnDoktorBilgileri";
            this.btnDoktorBilgileri.Size = new System.Drawing.Size(31, 32);
            this.btnDoktorBilgileri.TabIndex = 2;
            this.btnDoktorBilgileri.Text = "O";
            this.btnDoktorBilgileri.UseVisualStyleBackColor = true;
            this.btnDoktorBilgileri.Click += new System.EventHandler(this.btnDoktorBilgileri_Click);
            // 
            // pnlDoktorEkle
            // 
            this.pnlDoktorEkle.Controls.Add(this.btnDoktorIptal);
            this.pnlDoktorEkle.Controls.Add(this.label5);
            this.pnlDoktorEkle.Controls.Add(this.label6);
            this.pnlDoktorEkle.Controls.Add(this.label4);
            this.pnlDoktorEkle.Controls.Add(this.DoktorEkleTamam);
            this.pnlDoktorEkle.Controls.Add(this.txtDoktorParola);
            this.pnlDoktorEkle.Controls.Add(this.txtDoktorKullaniciAdi);
            this.pnlDoktorEkle.Controls.Add(this.txtDoktorEkle);
            this.pnlDoktorEkle.Location = new System.Drawing.Point(17, 195);
            this.pnlDoktorEkle.Name = "pnlDoktorEkle";
            this.pnlDoktorEkle.Size = new System.Drawing.Size(397, 148);
            this.pnlDoktorEkle.TabIndex = 54;
            this.pnlDoktorEkle.Visible = false;
            // 
            // btnDoktorIptal
            // 
            this.btnDoktorIptal.Location = new System.Drawing.Point(233, 104);
            this.btnDoktorIptal.Name = "btnDoktorIptal";
            this.btnDoktorIptal.Size = new System.Drawing.Size(75, 31);
            this.btnDoktorIptal.TabIndex = 12;
            this.btnDoktorIptal.Text = "Cancel";
            this.btnDoktorIptal.UseVisualStyleBackColor = true;
            this.btnDoktorIptal.Click += new System.EventHandler(this.btnDoktorIptal_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.Ivory;
            this.label5.Location = new System.Drawing.Point(3, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 16);
            this.label5.TabIndex = 51;
            this.label5.Text = "Password :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.Ivory;
            this.label6.Location = new System.Drawing.Point(3, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(144, 16);
            this.label6.TabIndex = 51;
            this.label6.Text = "User Name / Code :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.Ivory;
            this.label4.Location = new System.Drawing.Point(3, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(202, 16);
            this.label4.TabIndex = 51;
            this.label4.Text = "Doctor Name and Surname :";
            // 
            // DoktorEkleTamam
            // 
            this.DoktorEkleTamam.Location = new System.Drawing.Point(310, 104);
            this.DoktorEkleTamam.Name = "DoktorEkleTamam";
            this.DoktorEkleTamam.Size = new System.Drawing.Size(75, 31);
            this.DoktorEkleTamam.TabIndex = 11;
            this.DoktorEkleTamam.Text = "Add";
            this.DoktorEkleTamam.UseVisualStyleBackColor = true;
            this.DoktorEkleTamam.Click += new System.EventHandler(this.DoktorEkleTamam_Click);
            // 
            // txtDoktorParola
            // 
            this.txtDoktorParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorParola.Location = new System.Drawing.Point(233, 71);
            this.txtDoktorParola.Name = "txtDoktorParola";
            this.txtDoktorParola.Size = new System.Drawing.Size(152, 26);
            this.txtDoktorParola.TabIndex = 10;
            // 
            // txtDoktorKullaniciAdi
            // 
            this.txtDoktorKullaniciAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorKullaniciAdi.Location = new System.Drawing.Point(233, 7);
            this.txtDoktorKullaniciAdi.Name = "txtDoktorKullaniciAdi";
            this.txtDoktorKullaniciAdi.Size = new System.Drawing.Size(152, 26);
            this.txtDoktorKullaniciAdi.TabIndex = 8;
            // 
            // txtDoktorEkle
            // 
            this.txtDoktorEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDoktorEkle.Location = new System.Drawing.Point(233, 39);
            this.txtDoktorEkle.Name = "txtDoktorEkle";
            this.txtDoktorEkle.Size = new System.Drawing.Size(152, 26);
            this.txtDoktorEkle.TabIndex = 9;
            // 
            // pnlKlinikEkle
            // 
            this.pnlKlinikEkle.Controls.Add(this.btnKlinikİptal);
            this.pnlKlinikEkle.Controls.Add(this.label3);
            this.pnlKlinikEkle.Controls.Add(this.pnlKlinikEkleTamam);
            this.pnlKlinikEkle.Controls.Add(this.txtKlinikEkle);
            this.pnlKlinikEkle.Location = new System.Drawing.Point(79, 196);
            this.pnlKlinikEkle.Name = "pnlKlinikEkle";
            this.pnlKlinikEkle.Size = new System.Drawing.Size(283, 72);
            this.pnlKlinikEkle.TabIndex = 54;
            this.pnlKlinikEkle.Visible = false;
            // 
            // btnKlinikİptal
            // 
            this.btnKlinikİptal.Location = new System.Drawing.Point(121, 37);
            this.btnKlinikİptal.Name = "btnKlinikİptal";
            this.btnKlinikİptal.Size = new System.Drawing.Size(75, 30);
            this.btnKlinikİptal.TabIndex = 15;
            this.btnKlinikİptal.Text = "Cancel";
            this.btnKlinikİptal.UseVisualStyleBackColor = true;
            this.btnKlinikİptal.Click += new System.EventHandler(this.btnKlinikİptal_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 16);
            this.label3.TabIndex = 51;
            this.label3.Text = "Clinical Name :";
            // 
            // pnlKlinikEkleTamam
            // 
            this.pnlKlinikEkleTamam.Location = new System.Drawing.Point(198, 36);
            this.pnlKlinikEkleTamam.Name = "pnlKlinikEkleTamam";
            this.pnlKlinikEkleTamam.Size = new System.Drawing.Size(75, 31);
            this.pnlKlinikEkleTamam.TabIndex = 14;
            this.pnlKlinikEkleTamam.Text = "Add";
            this.pnlKlinikEkleTamam.UseVisualStyleBackColor = true;
            this.pnlKlinikEkleTamam.Click += new System.EventHandler(this.pnlKlinikEkleTamam_Click);
            // 
            // txtKlinikEkle
            // 
            this.txtKlinikEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtKlinikEkle.Location = new System.Drawing.Point(121, 4);
            this.txtKlinikEkle.Name = "txtKlinikEkle";
            this.txtKlinikEkle.Size = new System.Drawing.Size(152, 26);
            this.txtKlinikEkle.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Ivory;
            this.label2.Location = new System.Drawing.Point(294, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Doctors";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Ivory;
            this.label1.Location = new System.Drawing.Point(76, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 16);
            this.label1.TabIndex = 51;
            this.label1.Text = "Clinics";
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorSil.Location = new System.Drawing.Point(337, 154);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(31, 32);
            this.btnDoktorSil.TabIndex = 4;
            this.btnDoktorSil.Text = "X";
            this.btnDoktorSil.UseVisualStyleBackColor = true;
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDoktorEkle.Location = new System.Drawing.Point(297, 154);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(31, 32);
            this.btnDoktorEkle.TabIndex = 3;
            this.btnDoktorEkle.Text = "+";
            this.btnDoktorEkle.UseVisualStyleBackColor = true;
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnKlinikSil
            // 
            this.btnKlinikSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlinikSil.Location = new System.Drawing.Point(118, 154);
            this.btnKlinikSil.Name = "btnKlinikSil";
            this.btnKlinikSil.Size = new System.Drawing.Size(31, 32);
            this.btnKlinikSil.TabIndex = 1;
            this.btnKlinikSil.Text = "X";
            this.btnKlinikSil.UseVisualStyleBackColor = true;
            this.btnKlinikSil.Click += new System.EventHandler(this.btnKlinikSil_Click);
            // 
            // btnKlinikEkle
            // 
            this.btnKlinikEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKlinikEkle.Location = new System.Drawing.Point(81, 154);
            this.btnKlinikEkle.Name = "btnKlinikEkle";
            this.btnKlinikEkle.Size = new System.Drawing.Size(31, 32);
            this.btnKlinikEkle.TabIndex = 0;
            this.btnKlinikEkle.Text = "+";
            this.btnKlinikEkle.UseVisualStyleBackColor = true;
            this.btnKlinikEkle.Click += new System.EventHandler(this.btnKlinikEkle_Click);
            // 
            // listBoxDoktor
            // 
            this.listBoxDoktor.FormattingEnabled = true;
            this.listBoxDoktor.Location = new System.Drawing.Point(229, 27);
            this.listBoxDoktor.Name = "listBoxDoktor";
            this.listBoxDoktor.Size = new System.Drawing.Size(195, 121);
            this.listBoxDoktor.TabIndex = 46;
            this.listBoxDoktor.SelectedIndexChanged += new System.EventHandler(this.listBoxDoktor_SelectedIndexChanged);
            // 
            // listBoxKlinik
            // 
            this.listBoxKlinik.FormattingEnabled = true;
            this.listBoxKlinik.Location = new System.Drawing.Point(6, 27);
            this.listBoxKlinik.Name = "listBoxKlinik";
            this.listBoxKlinik.Size = new System.Drawing.Size(217, 121);
            this.listBoxKlinik.TabIndex = 46;
            this.listBoxKlinik.SelectedIndexChanged += new System.EventHandler(this.listBoxKlinik_SelectedIndexChanged);
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(831, 310);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(65, 60);
            this.btnCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCikis.TabIndex = 45;
            this.btnCikis.TabStop = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // timerSaat
            // 
            this.timerSaat.Enabled = true;
            this.timerSaat.Interval = 10;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblSaat,
            this.toolStripStatusLabel1,
            this.lblTarih});
            this.statusStrip1.Location = new System.Drawing.Point(0, 376);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(899, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblSaat
            // 
            this.lblSaat.BackColor = System.Drawing.SystemColors.Control;
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSaat.Size = new System.Drawing.Size(118, 17);
            this.lblSaat.Text = "toolStripStatusLabel1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel1.Text = "/";
            // 
            // lblTarih
            // 
            this.lblTarih.BackColor = System.Drawing.SystemColors.Control;
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(118, 17);
            this.lblTarih.Text = "toolStripStatusLabel1";
            // 
            // lblUyeSayisi
            // 
            this.lblUyeSayisi.AutoSize = true;
            this.lblUyeSayisi.BackColor = System.Drawing.SystemColors.Control;
            this.lblUyeSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblUyeSayisi.ForeColor = System.Drawing.Color.Maroon;
            this.lblUyeSayisi.Location = new System.Drawing.Point(536, 379);
            this.lblUyeSayisi.Name = "lblUyeSayisi";
            this.lblUyeSayisi.Size = new System.Drawing.Size(52, 18);
            this.lblUyeSayisi.TabIndex = 3;
            this.lblUyeSayisi.Text = "label6";
            // 
            // AdminPaneli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(899, 398);
            this.Controls.Add(this.lblUyeSayisi);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(915, 437);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(915, 437);
            this.Name = "AdminPaneli";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminPaneli_FormClosed);
            this.Load += new System.EventHandler(this.AdminPaneli_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.pnlDoktorEkle.ResumeLayout(false);
            this.pnlDoktorEkle.PerformLayout();
            this.pnlKlinikEkle.ResumeLayout(false);
            this.pnlKlinikEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox btnCikis;
        private System.Windows.Forms.Timer timerSaat;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblSaat;
        private System.Windows.Forms.ToolStripStatusLabel lblTarih;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button btnDoktorSil;
        private System.Windows.Forms.Button btnDoktorEkle;
        private System.Windows.Forms.Button btnKlinikSil;
        private System.Windows.Forms.Button btnKlinikEkle;
        private System.Windows.Forms.ListBox listBoxDoktor;
        private System.Windows.Forms.ListBox listBoxKlinik;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pnlKlinikEkleTamam;
        private System.Windows.Forms.TextBox txtKlinikEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlKlinikEkle;
        private System.Windows.Forms.Panel pnlDoktorEkle;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button DoktorEkleTamam;
        private System.Windows.Forms.TextBox txtDoktorEkle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDoktorParola;
        private System.Windows.Forms.Button btnDoktorBilgileri;
        private System.Windows.Forms.Label lblUyeSayisi;
        private System.Windows.Forms.Button btnDoktorIptal;
        private System.Windows.Forms.Button btnKlinikİptal;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Button btnBanla;
        private System.Windows.Forms.Button btnUyeSil;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDoktorKullaniciAdi;
    }
}