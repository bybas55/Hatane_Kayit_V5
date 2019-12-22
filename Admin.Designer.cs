namespace HastaneKayit
{
    partial class Admin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.btnHesap = new System.Windows.Forms.PictureBox();
            this.btnCikis = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerSaat = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.btnHesap)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHesap
            // 
            this.btnHesap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHesap.Image = ((System.Drawing.Image)(resources.GetObject("btnHesap.Image")));
            this.btnHesap.Location = new System.Drawing.Point(609, 288);
            this.btnHesap.Name = "btnHesap";
            this.btnHesap.Size = new System.Drawing.Size(65, 60);
            this.btnHesap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnHesap.TabIndex = 42;
            this.btnHesap.TabStop = false;
            this.btnHesap.Click += new System.EventHandler(this.btnHesap_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCikis.Image = ((System.Drawing.Image)(resources.GetObject("btnCikis.Image")));
            this.btnCikis.Location = new System.Drawing.Point(680, 288);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(65, 60);
            this.btnCikis.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnCikis.TabIndex = 41;
            this.btnCikis.TabStop = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label2.Location = new System.Drawing.Point(583, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 21);
            this.label2.TabIndex = 40;
            this.label2.Text = "01 Ocak 1999 Cumartesi";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGoldenrod;
            this.label1.Location = new System.Drawing.Point(640, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 38);
            this.label1.TabIndex = 39;
            this.label1.Text = "20:00:00";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // timerSaat
            // 
            this.timerSaat.Interval = 10;
            this.timerSaat.Tick += new System.EventHandler(this.timerSaat_Tick);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(787, 381);
            this.Controls.Add(this.btnHesap);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Admin";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Admin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Admin_FormClosed);
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btnHesap)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnCikis)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btnHesap;
        private System.Windows.Forms.PictureBox btnCikis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timerSaat;
    }
}