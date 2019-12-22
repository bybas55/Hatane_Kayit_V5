namespace HastaneKayit
{
    partial class ParolamiUnuttum
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ParolamiUnuttum));
            this.button1 = new System.Windows.Forms.Button();
            this.maskedtxtTC = new System.Windows.Forms.MaskedTextBox();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button1.Location = new System.Drawing.Point(-78, 178);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // maskedtxtTC
            // 
            this.maskedtxtTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.maskedtxtTC.Location = new System.Drawing.Point(202, 22);
            this.maskedtxtTC.Mask = "00000000000";
            this.maskedtxtTC.Name = "maskedtxtTC";
            this.maskedtxtTC.Size = new System.Drawing.Size(113, 22);
            this.maskedtxtTC.TabIndex = 4;
            this.maskedtxtTC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.maskedtxtTC_KeyPress);
            // 
            // btnGonder
            // 
            this.btnGonder.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnGonder.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGonder.Location = new System.Drawing.Point(202, 60);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(113, 31);
            this.btnGonder.TabIndex = 8;
            this.btnGonder.Text = "SEND";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(29, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 32);
            this.label1.TabIndex = 9;
            this.label1.Text = "Please select the reminder method from above\r\nClick the submit button after filli" +
    "ng in the fields.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(57, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(139, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Number ( T.C. ) :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // ParolamiUnuttum
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.CancelButton = this.button1;
            this.ClientSize = new System.Drawing.Size(409, 163);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.maskedtxtTC);
            this.Controls.Add(this.btnGonder);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(425, 202);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(425, 202);
            this.Name = "ParolamiUnuttum";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Password Reminder";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ParolamiUnuttum_FormClosed);
            this.Load += new System.EventHandler(this.ParolamiUnuttum_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox maskedtxtTC;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}