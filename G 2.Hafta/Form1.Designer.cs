
namespace G_2.Hafta
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
            this.topla = new System.Windows.Forms.Button();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.böl = new System.Windows.Forms.Button();
            this.çarp = new System.Windows.Forms.Button();
            this.çıkar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topla
            // 
            this.topla.Location = new System.Drawing.Point(163, 13);
            this.topla.Name = "topla";
            this.topla.Size = new System.Drawing.Size(75, 20);
            this.topla.TabIndex = 2;
            this.topla.Text = "Topla";
            this.topla.UseVisualStyleBackColor = true;
            this.topla.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(13, 13);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 0;
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(12, 111);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 6;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(13, 54);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 1;
            // 
            // böl
            // 
            this.böl.Location = new System.Drawing.Point(163, 129);
            this.böl.Name = "böl";
            this.böl.Size = new System.Drawing.Size(75, 23);
            this.böl.TabIndex = 5;
            this.böl.Text = "Böl";
            this.böl.UseVisualStyleBackColor = true;
            this.böl.Click += new System.EventHandler(this.böl_Click);
            // 
            // çarp
            // 
            this.çarp.Location = new System.Drawing.Point(163, 90);
            this.çarp.Name = "çarp";
            this.çarp.Size = new System.Drawing.Size(75, 23);
            this.çarp.TabIndex = 4;
            this.çarp.Text = "Çarp";
            this.çarp.UseVisualStyleBackColor = true;
            this.çarp.Click += new System.EventHandler(this.çarp_Click);
            // 
            // çıkar
            // 
            this.çıkar.Location = new System.Drawing.Point(163, 51);
            this.çıkar.Name = "çıkar";
            this.çıkar.Size = new System.Drawing.Size(75, 23);
            this.çıkar.TabIndex = 3;
            this.çıkar.Text = "Çıkart";
            this.çıkar.UseVisualStyleBackColor = true;
            this.çıkar.Click += new System.EventHandler(this.çıkar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(260, 174);
            this.Controls.Add(this.çıkar);
            this.Controls.Add(this.çarp);
            this.Controls.Add(this.böl);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.topla);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap Makinası";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button topla;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button böl;
        private System.Windows.Forms.Button çarp;
        private System.Windows.Forms.Button çıkar;
    }
}

