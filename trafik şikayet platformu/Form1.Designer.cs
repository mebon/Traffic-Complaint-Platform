namespace trafik_şikayet_platformu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnl_form = new System.Windows.Forms.Panel();
            this.pnl_buton = new System.Windows.Forms.Panel();
            this.pb_amblem = new System.Windows.Forms.PictureBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.btn_hakkımızda = new System.Windows.Forms.Button();
            this.btn_hata = new System.Windows.Forms.Button();
            this.btn_ihbar = new System.Windows.Forms.Button();
            this.pnl_buton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_amblem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_form
            // 
            this.pnl_form.BackColor = System.Drawing.Color.Transparent;
            this.pnl_form.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_form.Location = new System.Drawing.Point(189, -2);
            this.pnl_form.Name = "pnl_form";
            this.pnl_form.Size = new System.Drawing.Size(516, 535);
            this.pnl_form.TabIndex = 1;
            // 
            // pnl_buton
            // 
            this.pnl_buton.BackColor = System.Drawing.Color.Transparent;
            this.pnl_buton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnl_buton.Controls.Add(this.pb_amblem);
            this.pnl_buton.Controls.Add(this.btn_cikis);
            this.pnl_buton.Controls.Add(this.btn_hakkımızda);
            this.pnl_buton.Controls.Add(this.btn_hata);
            this.pnl_buton.Controls.Add(this.btn_ihbar);
            this.pnl_buton.Location = new System.Drawing.Point(-1, -2);
            this.pnl_buton.Name = "pnl_buton";
            this.pnl_buton.Size = new System.Drawing.Size(193, 542);
            this.pnl_buton.TabIndex = 0;
            // 
            // pb_amblem
            // 
            this.pb_amblem.Image = ((System.Drawing.Image)(resources.GetObject("pb_amblem.Image")));
            this.pb_amblem.Location = new System.Drawing.Point(7, 3);
            this.pb_amblem.Name = "pb_amblem";
            this.pb_amblem.Size = new System.Drawing.Size(177, 96);
            this.pb_amblem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_amblem.TabIndex = 4;
            this.pb_amblem.TabStop = false;
            // 
            // btn_cikis
            // 
            this.btn_cikis.BackgroundImage = global::trafik_şikayet_platformu.Properties.Resources.desktop__the_red_room_by_leisms_d36zqv81;
            this.btn_cikis.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_cikis.Location = new System.Drawing.Point(7, 416);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(168, 61);
            this.btn_cikis.TabIndex = 3;
            this.btn_cikis.Text = "ÇIKIŞ";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // btn_hakkımızda
            // 
            this.btn_hakkımızda.BackgroundImage = global::trafik_şikayet_platformu.Properties.Resources.desktop__the_red_room_by_leisms_d36zqv81;
            this.btn_hakkımızda.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hakkımızda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hakkımızda.Location = new System.Drawing.Point(7, 320);
            this.btn_hakkımızda.Name = "btn_hakkımızda";
            this.btn_hakkımızda.Size = new System.Drawing.Size(168, 61);
            this.btn_hakkımızda.TabIndex = 2;
            this.btn_hakkımızda.Text = "HAKKIMIZDA";
            this.btn_hakkımızda.UseVisualStyleBackColor = true;
            // 
            // btn_hata
            // 
            this.btn_hata.BackgroundImage = global::trafik_şikayet_platformu.Properties.Resources.desktop__the_red_room_by_leisms_d36zqv81;
            this.btn_hata.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_hata.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_hata.Location = new System.Drawing.Point(7, 204);
            this.btn_hata.Name = "btn_hata";
            this.btn_hata.Size = new System.Drawing.Size(168, 61);
            this.btn_hata.TabIndex = 1;
            this.btn_hata.Text = "HATA BİLDİRİN";
            this.btn_hata.UseVisualStyleBackColor = true;
            this.btn_hata.Click += new System.EventHandler(this.btn_hata_Click);
            // 
            // btn_ihbar
            // 
            this.btn_ihbar.BackgroundImage = global::trafik_şikayet_platformu.Properties.Resources.desktop__the_red_room_by_leisms_d36zqv81;
            this.btn_ihbar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_ihbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ihbar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ihbar.Location = new System.Drawing.Point(7, 105);
            this.btn_ihbar.Name = "btn_ihbar";
            this.btn_ihbar.Size = new System.Drawing.Size(168, 61);
            this.btn_ihbar.TabIndex = 0;
            this.btn_ihbar.Text = "İHBAR EDİN";
            this.btn_ihbar.UseVisualStyleBackColor = true;
            this.btn_ihbar.Click += new System.EventHandler(this.btn_ihbar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::trafik_şikayet_platformu.Properties.Resources.desktop__the_red_room_by_leisms_d36zqv811;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(703, 533);
            this.Controls.Add(this.pnl_form);
            this.Controls.Add(this.pnl_buton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TRAFİK ŞİKAYET PLATFORMU";
            this.pnl_buton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_amblem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_buton;
        private System.Windows.Forms.PictureBox pb_amblem;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.Button btn_hakkımızda;
        private System.Windows.Forms.Button btn_hata;
        private System.Windows.Forms.Button btn_ihbar;
        private System.Windows.Forms.Panel pnl_form;
    }
}

