namespace HastaneKayit
{
    partial class AlinanRandevular
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AlinanRandevular));
            this.columnHeaderSaat = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeaderNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderKlinikAdii = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderDoktorAdi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderTarih = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // columnHeaderSaat
            // 
            this.columnHeaderSaat.Text = "Hour";
            this.columnHeaderSaat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderSaat.Width = 79;
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderNo,
            this.columnHeaderKlinikAdii,
            this.columnHeaderDoktorAdi,
            this.columnHeaderTarih,
            this.columnHeaderSaat,
            this.columnHeaderid});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.Location = new System.Drawing.Point(-2, 0);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(939, 200);
            this.listView1.TabIndex = 2;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderNo
            // 
            this.columnHeaderNo.Text = "No";
            this.columnHeaderNo.Width = 42;
            // 
            // columnHeaderKlinikAdii
            // 
            this.columnHeaderKlinikAdii.Text = "Clinical Name";
            this.columnHeaderKlinikAdii.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderKlinikAdii.Width = 335;
            // 
            // columnHeaderDoktorAdi
            // 
            this.columnHeaderDoktorAdi.Text = "Doctor";
            this.columnHeaderDoktorAdi.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderDoktorAdi.Width = 234;
            // 
            // columnHeaderTarih
            // 
            this.columnHeaderTarih.Text = "Date";
            this.columnHeaderTarih.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.columnHeaderTarih.Width = 122;
            // 
            // columnHeaderid
            // 
            this.columnHeaderid.Text = "A. Code";
            this.columnHeaderid.Width = 72;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(736, 211);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(187, 39);
            this.button1.TabIndex = 3;
            this.button1.Text = "Cancel Appointment";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(296, 322);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // AlinanRandevular
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.button2;
            this.ClientSize = new System.Drawing.Size(935, 258);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(951, 297);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(951, 297);
            this.Name = "AlinanRandevular";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Appointments";
            this.Load += new System.EventHandler(this.AlinanRandevular_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ColumnHeader columnHeaderSaat;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeaderNo;
        private System.Windows.Forms.ColumnHeader columnHeaderKlinikAdii;
        private System.Windows.Forms.ColumnHeader columnHeaderDoktorAdi;
        private System.Windows.Forms.ColumnHeader columnHeaderTarih;
        private System.Windows.Forms.ColumnHeader columnHeaderid;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}