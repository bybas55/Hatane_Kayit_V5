namespace HastaneKayit
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnParolamiUnuttum = new System.Windows.Forms.Button();
            this.btnYeniUye = new System.Windows.Forms.Button();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.maskedtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGiris
            // 
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.Image = ((System.Drawing.Image)(resources.GetObject("btnGiris.Image")));
            this.btnGiris.Location = new System.Drawing.Point(276, 130);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(106, 40);
            this.btnGiris.TabIndex = 14;
            this.btnGiris.Text = "  Sıng In";
            this.btnGiris.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnParolamiUnuttum
            // 
            this.btnParolamiUnuttum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnParolamiUnuttum.Image = ((System.Drawing.Image)(resources.GetObject("btnParolamiUnuttum.Image")));
            this.btnParolamiUnuttum.Location = new System.Drawing.Point(136, 130);
            this.btnParolamiUnuttum.Name = "btnParolamiUnuttum";
            this.btnParolamiUnuttum.Size = new System.Drawing.Size(120, 40);
            this.btnParolamiUnuttum.TabIndex = 16;
            this.btnParolamiUnuttum.Text = "Forget The Password\r\n";
            this.btnParolamiUnuttum.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnParolamiUnuttum.UseVisualStyleBackColor = true;
            this.btnParolamiUnuttum.Click += new System.EventHandler(this.btnParolamiUnuttum_Click);
            // 
            // btnYeniUye
            // 
            this.btnYeniUye.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniUye.Image = ((System.Drawing.Image)(resources.GetObject("btnYeniUye.Image")));
            this.btnYeniUye.Location = new System.Drawing.Point(17, 130);
            this.btnYeniUye.Name = "btnYeniUye";
            this.btnYeniUye.Size = new System.Drawing.Size(100, 40);
            this.btnYeniUye.TabIndex = 15;
            this.btnYeniUye.Text = " Sing Up";
            this.btnYeniUye.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnYeniUye.UseVisualStyleBackColor = true;
            this.btnYeniUye.Click += new System.EventHandler(this.btnYeniUye_Click);
            // 
            // txtParola
            // 
            this.txtParola.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtParola.Location = new System.Drawing.Point(226, 74);
            this.txtParola.MaxLength = 11;
            this.txtParola.Name = "txtParola";
            this.txtParola.PasswordChar = '●';
            this.txtParola.Size = new System.Drawing.Size(156, 35);
            this.txtParola.TabIndex = 13;
            this.txtParola.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtParola_KeyPress);
            // 
            // maskedtxtTC
            // 
            this.maskedtxtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtxtTC.Location = new System.Drawing.Point(226, 14);
            this.maskedtxtTC.Mask = "00000000000";
            this.maskedtxtTC.Name = "maskedtxtTC";
            this.maskedtxtTC.Size = new System.Drawing.Size(156, 35);
            this.maskedtxtTC.TabIndex = 12;
            this.maskedtxtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedtxtTC_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(122, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Password :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Lavender;
            this.label3.Location = new System.Drawing.Point(54, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(164, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "ID Number ( T.C. ) :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(61, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(354, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "HOSPITAL APPOINTMENT CENTER";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(112, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "T. C. MINISTRY OF HEALTH";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGiris);
            this.groupBox1.Controls.Add(this.btnParolamiUnuttum);
            this.groupBox1.Controls.Add(this.btnYeniUye);
            this.groupBox1.Controls.Add(this.txtParola);
            this.groupBox1.Controls.Add(this.maskedtxtTC);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(33, 100);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 195);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(473, 307);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "                                   <-- HOSPITAL APPOINTMENT CENTER -->           " +
    "                 ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnParolamiUnuttum;
        private System.Windows.Forms.Button btnYeniUye;
        private System.Windows.Forms.TextBox txtParola;
        public System.Windows.Forms.MaskedTextBox maskedtxtTC;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

