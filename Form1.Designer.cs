namespace Araba_Hiz_Kontrol_Events
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.HizArttir = new System.Windows.Forms.Button();
            this.HizDusur = new System.Windows.Forms.Button();
            this.lblHiz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // HizArttir
            // 
            this.HizArttir.Location = new System.Drawing.Point(455, 336);
            this.HizArttir.Name = "HizArttir";
            this.HizArttir.Size = new System.Drawing.Size(333, 70);
            this.HizArttir.TabIndex = 0;
            this.HizArttir.Text = "Hız Arttır(Gaz)";
            this.HizArttir.UseVisualStyleBackColor = true;
            this.HizArttir.Click += new System.EventHandler(this.HizArttir_Click);
            this.HizArttir.MouseEnter += new System.EventHandler(this.HizArttir_MouseEnter);
            this.HizArttir.MouseLeave += new System.EventHandler(this.HizArttir_MouseLeave);
            // 
            // HizDusur
            // 
            this.HizDusur.Location = new System.Drawing.Point(36, 336);
            this.HizDusur.Name = "HizDusur";
            this.HizDusur.Size = new System.Drawing.Size(362, 70);
            this.HizDusur.TabIndex = 1;
            this.HizDusur.Text = "Hız Düşür(Fren)";
            this.HizDusur.UseVisualStyleBackColor = true;
            this.HizDusur.Click += new System.EventHandler(this.HizDusur_Click);
            // 
            // lblHiz
            // 
            this.lblHiz.BackColor = System.Drawing.Color.Green;
            this.lblHiz.Font = new System.Drawing.Font("Bernard MT Condensed", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHiz.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHiz.Location = new System.Drawing.Point(216, 85);
            this.lblHiz.Name = "lblHiz";
            this.lblHiz.Size = new System.Drawing.Size(328, 222);
            this.lblHiz.TabIndex = 2;
            this.lblHiz.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblHiz);
            this.Controls.Add(this.HizDusur);
            this.Controls.Add(this.HizArttir);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button HizArttir;
        private System.Windows.Forms.Button HizDusur;
        private System.Windows.Forms.Label lblHiz;
    }
}

