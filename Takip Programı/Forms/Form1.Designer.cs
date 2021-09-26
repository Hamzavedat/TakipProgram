
using System.Drawing;

namespace Takip_Programı
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
            this.components = new System.ComponentModel.Container();
            this.ustPanel = new System.Windows.Forms.Panel();
            this.ayarlarBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.stokBtn = new System.Windows.Forms.Button();
            this.kksatisBtn = new System.Windows.Forms.Button();
            this.depoBtn = new System.Windows.Forms.Button();
            this.pompaBtn = new System.Windows.Forms.Button();
            this.psatisBtn = new System.Windows.Forms.Button();
            this.musteriBtn = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.cariBtn = new System.Windows.Forms.Button();
            this.ustPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ustPanel
            // 
            this.ustPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.ustPanel.Controls.Add(this.cariBtn);
            this.ustPanel.Controls.Add(this.ayarlarBtn);
            this.ustPanel.Controls.Add(this.label1);
            this.ustPanel.Controls.Add(this.stokBtn);
            this.ustPanel.Controls.Add(this.kksatisBtn);
            this.ustPanel.Controls.Add(this.depoBtn);
            this.ustPanel.Controls.Add(this.pompaBtn);
            this.ustPanel.Controls.Add(this.psatisBtn);
            this.ustPanel.Controls.Add(this.musteriBtn);
            this.ustPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ustPanel.Location = new System.Drawing.Point(0, 0);
            this.ustPanel.Name = "ustPanel";
            this.ustPanel.Size = new System.Drawing.Size(1064, 52);
            this.ustPanel.TabIndex = 0;
            // 
            // ayarlarBtn
            // 
            this.ayarlarBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.ayarlarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ayarlarBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.ayarlarBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.ayarlarBtn.FlatAppearance.BorderSize = 0;
            this.ayarlarBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ayarlarBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ayarlarBtn.ForeColor = System.Drawing.Color.Black;
            this.ayarlarBtn.Image = global::Takip_Programı.Properties.Resources.settings;
            this.ayarlarBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ayarlarBtn.Location = new System.Drawing.Point(618, 0);
            this.ayarlarBtn.Name = "ayarlarBtn";
            this.ayarlarBtn.Size = new System.Drawing.Size(103, 52);
            this.ayarlarBtn.TabIndex = 6;
            this.ayarlarBtn.Text = "AYARLAR";
            this.ayarlarBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ayarlarBtn.UseVisualStyleBackColor = false;
            this.ayarlarBtn.Click += new System.EventHandler(this.ayarlarBtn_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(822, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 26);
            this.label1.TabIndex = 7;
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // stokBtn
            // 
            this.stokBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.stokBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.stokBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.stokBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.stokBtn.FlatAppearance.BorderSize = 0;
            this.stokBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stokBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stokBtn.ForeColor = System.Drawing.Color.Black;
            this.stokBtn.Image = global::Takip_Programı.Properties.Resources.storage;
            this.stokBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.stokBtn.Location = new System.Drawing.Point(515, 0);
            this.stokBtn.Name = "stokBtn";
            this.stokBtn.Size = new System.Drawing.Size(103, 52);
            this.stokBtn.TabIndex = 5;
            this.stokBtn.Text = "STOK";
            this.stokBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.stokBtn.UseVisualStyleBackColor = false;
            this.stokBtn.Click += new System.EventHandler(this.stokBtn_Click);
            // 
            // kksatisBtn
            // 
            this.kksatisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.kksatisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.kksatisBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.kksatisBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.kksatisBtn.FlatAppearance.BorderSize = 0;
            this.kksatisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kksatisBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kksatisBtn.ForeColor = System.Drawing.Color.Black;
            this.kksatisBtn.Image = global::Takip_Programı.Properties.Resources.credit_card;
            this.kksatisBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.kksatisBtn.Location = new System.Drawing.Point(412, 0);
            this.kksatisBtn.Name = "kksatisBtn";
            this.kksatisBtn.Size = new System.Drawing.Size(103, 52);
            this.kksatisBtn.TabIndex = 4;
            this.kksatisBtn.Text = "K.K. SATIŞ";
            this.kksatisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.kksatisBtn.UseVisualStyleBackColor = false;
            this.kksatisBtn.Click += new System.EventHandler(this.kksatisBtn_Click);
            // 
            // depoBtn
            // 
            this.depoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.depoBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.depoBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.depoBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.depoBtn.FlatAppearance.BorderSize = 0;
            this.depoBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.depoBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.depoBtn.ForeColor = System.Drawing.Color.Black;
            this.depoBtn.Image = global::Takip_Programı.Properties.Resources.oil_tanker;
            this.depoBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.depoBtn.Location = new System.Drawing.Point(309, 0);
            this.depoBtn.Name = "depoBtn";
            this.depoBtn.Size = new System.Drawing.Size(103, 52);
            this.depoBtn.TabIndex = 3;
            this.depoBtn.Text = "DEPO";
            this.depoBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.depoBtn.UseVisualStyleBackColor = false;
            this.depoBtn.Click += new System.EventHandler(this.depoBtn_Click);
            // 
            // pompaBtn
            // 
            this.pompaBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.pompaBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pompaBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.pompaBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.pompaBtn.FlatAppearance.BorderSize = 0;
            this.pompaBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pompaBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pompaBtn.ForeColor = System.Drawing.Color.Black;
            this.pompaBtn.Image = global::Takip_Programı.Properties.Resources.gas_pump;
            this.pompaBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.pompaBtn.Location = new System.Drawing.Point(206, 0);
            this.pompaBtn.Name = "pompaBtn";
            this.pompaBtn.Size = new System.Drawing.Size(103, 52);
            this.pompaBtn.TabIndex = 2;
            this.pompaBtn.Text = "POMPA";
            this.pompaBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pompaBtn.UseVisualStyleBackColor = false;
            this.pompaBtn.Click += new System.EventHandler(this.pompaBtn_Click);
            // 
            // psatisBtn
            // 
            this.psatisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.psatisBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.psatisBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.psatisBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.psatisBtn.FlatAppearance.BorderSize = 0;
            this.psatisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.psatisBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.psatisBtn.ForeColor = System.Drawing.Color.Black;
            this.psatisBtn.Image = global::Takip_Programı.Properties.Resources.coins;
            this.psatisBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.psatisBtn.Location = new System.Drawing.Point(103, 0);
            this.psatisBtn.Name = "psatisBtn";
            this.psatisBtn.Size = new System.Drawing.Size(103, 52);
            this.psatisBtn.TabIndex = 1;
            this.psatisBtn.Text = "P. SATIŞ";
            this.psatisBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.psatisBtn.UseVisualStyleBackColor = false;
            this.psatisBtn.Click += new System.EventHandler(this.psatisBtn_Click);
            // 
            // musteriBtn
            // 
            this.musteriBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.musteriBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.musteriBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.musteriBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.musteriBtn.FlatAppearance.BorderSize = 0;
            this.musteriBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.musteriBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.musteriBtn.ForeColor = System.Drawing.Color.Black;
            this.musteriBtn.Image = global::Takip_Programı.Properties.Resources.clients;
            this.musteriBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.musteriBtn.Location = new System.Drawing.Point(0, 0);
            this.musteriBtn.Name = "musteriBtn";
            this.musteriBtn.Size = new System.Drawing.Size(103, 52);
            this.musteriBtn.TabIndex = 0;
            this.musteriBtn.Text = "MÜŞTERİLER";
            this.musteriBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.musteriBtn.UseVisualStyleBackColor = false;
            this.musteriBtn.Click += new System.EventHandler(this.musteriBtn_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.AutoSize = true;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 52);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 574);
            this.panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::Takip_Programı.Properties.Resources.Özarpalı;
            this.pictureBox1.Location = new System.Drawing.Point(336, 62);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(500, 500);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // cariBtn
            // 
            this.cariBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.cariBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cariBtn.Cursor = System.Windows.Forms.Cursors.Default;
            this.cariBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.cariBtn.FlatAppearance.BorderSize = 0;
            this.cariBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cariBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cariBtn.ForeColor = System.Drawing.Color.Black;
            this.cariBtn.Image = global::Takip_Programı.Properties.Resources.wallet;
            this.cariBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.cariBtn.Location = new System.Drawing.Point(721, 0);
            this.cariBtn.Name = "cariBtn";
            this.cariBtn.Size = new System.Drawing.Size(103, 52);
            this.cariBtn.TabIndex = 8;
            this.cariBtn.Text = "CARİ İŞ";
            this.cariBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.cariBtn.UseVisualStyleBackColor = false;
            this.cariBtn.Click += new System.EventHandler(this.cariBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1064, 626);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.ustPanel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "TAKİP PROGRAMI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ustPanel.ResumeLayout(false);
            this.ustPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

    

        #endregion

        private System.Windows.Forms.Panel ustPanel;
        private System.Windows.Forms.Button musteriBtn;
        private System.Windows.Forms.Button psatisBtn;
        private System.Windows.Forms.Button ayarlarBtn;
        private System.Windows.Forms.Button stokBtn;
        private System.Windows.Forms.Button kksatisBtn;
        private System.Windows.Forms.Button depoBtn;
        private System.Windows.Forms.Button pompaBtn;
        private System.Windows.Forms.ColumnHeader RİSKLİMİTİ;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button cariBtn;
    }
}

