
namespace Takip_Programı.Forms
{
    partial class Form_Pomp
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
            this.musteriListView = new System.Windows.Forms.ListView();
            this.ADI = new System.Windows.Forms.ColumnHeader();
            this.SOYADI = new System.Windows.Forms.ColumnHeader();
            this.RISK = new System.Windows.Forms.ColumnHeader();
            this.FIAT = new System.Windows.Forms.ColumnHeader();
            this.MEVKI = new System.Windows.Forms.ColumnHeader();
            this.TEL = new System.Windows.Forms.ColumnHeader();
            this.CEPTEL = new System.Windows.Forms.ColumnHeader();
            this.vergiNoTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vergiDaireTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.pompaComboBox = new System.Windows.Forms.ComboBox();
            this.telTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mevkiTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.vazgecBtn = new System.Windows.Forms.Button();
            this.TabPage1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // musteriListView
            // 
            this.musteriListView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(78)))), ((int)(((byte)(99)))));
            this.musteriListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.musteriListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ADI,
            this.SOYADI,
            this.RISK,
            this.FIAT,
            this.MEVKI,
            this.TEL,
            this.CEPTEL});
            this.musteriListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musteriListView.ForeColor = System.Drawing.Color.White;
            this.musteriListView.FullRowSelect = true;
            this.musteriListView.GridLines = true;
            this.musteriListView.HideSelection = false;
            this.musteriListView.Location = new System.Drawing.Point(0, 0);
            this.musteriListView.Name = "musteriListView";
            this.musteriListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.musteriListView.Size = new System.Drawing.Size(754, 296);
            this.musteriListView.TabIndex = 28;
            this.musteriListView.UseCompatibleStateImageBehavior = false;
            this.musteriListView.View = System.Windows.Forms.View.Details;
            // 
            // ADI
            // 
            this.ADI.Name = "ADI";
            this.ADI.Text = "VARDİYA TARİHİ";
            this.ADI.Width = 110;
            // 
            // SOYADI
            // 
            this.SOYADI.Name = "SOYADI";
            this.SOYADI.Text = "PERSONEL ADI";
            this.SOYADI.Width = 110;
            // 
            // RISK
            // 
            this.RISK.Name = "RISK";
            this.RISK.Text = "İLK SAYAÇ";
            this.RISK.Width = 100;
            // 
            // FIAT
            // 
            this.FIAT.Name = "FIAT";
            this.FIAT.Text = "SON SAYAÇ";
            this.FIAT.Width = 140;
            // 
            // MEVKI
            // 
            this.MEVKI.Name = "MEVKI";
            this.MEVKI.Text = "FARK (LT)";
            this.MEVKI.Width = 100;
            // 
            // TEL
            // 
            this.TEL.Name = "TEL";
            this.TEL.Text = "FİYAT";
            this.TEL.Width = 120;
            // 
            // CEPTEL
            // 
            this.CEPTEL.Name = "CEPTEL";
            this.CEPTEL.Text = "TUTAR";
            this.CEPTEL.Width = 120;
            // 
            // vergiNoTxtBox
            // 
            this.vergiNoTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vergiNoTxtBox.Location = new System.Drawing.Point(605, 68);
            this.vergiNoTxtBox.Name = "vergiNoTxtBox";
            this.vergiNoTxtBox.Size = new System.Drawing.Size(114, 23);
            this.vergiNoTxtBox.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(543, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tutar : ";
            // 
            // vergiDaireTxtBox
            // 
            this.vergiDaireTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vergiDaireTxtBox.Location = new System.Drawing.Point(605, 40);
            this.vergiDaireTxtBox.Name = "vergiDaireTxtBox";
            this.vergiDaireTxtBox.Size = new System.Drawing.Size(114, 23);
            this.vergiDaireTxtBox.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(520, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Fark (Lt) : ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.vergiNoTxtBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.vergiDaireTxtBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pompaComboBox);
            this.panel1.Controls.Add(this.telTxtBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mevkiTxtBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.yeniBtn);
            this.panel1.Controls.Add(this.silBtn);
            this.panel1.Controls.Add(this.kayitBtn);
            this.panel1.Controls.Add(this.vazgecBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 164);
            this.panel1.TabIndex = 28;
            // 
            // comboBox2
            // 
            this.comboBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Etkilensin",
            "Etkilenmesin"});
            this.comboBox2.Location = new System.Drawing.Point(130, 72);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(114, 23);
            this.comboBox2.TabIndex = 48;
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Etkilensin",
            "Etkilenmesin"});
            this.comboBox1.Location = new System.Drawing.Point(130, 41);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(114, 23);
            this.comboBox1.TabIndex = 47;
            // 
            // pompaComboBox
            // 
            this.pompaComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.pompaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pompaComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pompaComboBox.FormattingEnabled = true;
            this.pompaComboBox.Items.AddRange(new object[] {
            "Etkilensin",
            "Etkilenmesin"});
            this.pompaComboBox.Location = new System.Drawing.Point(130, 12);
            this.pompaComboBox.Name = "pompaComboBox";
            this.pompaComboBox.Size = new System.Drawing.Size(114, 23);
            this.pompaComboBox.TabIndex = 38;
            // 
            // telTxtBox
            // 
            this.telTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.telTxtBox.Location = new System.Drawing.Point(377, 71);
            this.telTxtBox.Name = "telTxtBox";
            this.telTxtBox.Size = new System.Drawing.Size(114, 23);
            this.telTxtBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(284, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Yeni Sayaç : ";
            // 
            // mevkiTxtBox
            // 
            this.mevkiTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mevkiTxtBox.Location = new System.Drawing.Point(377, 40);
            this.mevkiTxtBox.Name = "mevkiTxtBox";
            this.mevkiTxtBox.Size = new System.Drawing.Size(114, 23);
            this.mevkiTxtBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(284, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Eski Sayaç :";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(23, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Personel Adı : ";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(13, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Vardiya Tarihi : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Pompa Seçiniz :";
            // 
            // yeniBtn
            // 
            this.yeniBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.yeniBtn.FlatAppearance.BorderSize = 0;
            this.yeniBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.yeniBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.yeniBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.yeniBtn.Location = new System.Drawing.Point(65, 114);
            this.yeniBtn.Name = "yeniBtn";
            this.yeniBtn.Size = new System.Drawing.Size(125, 35);
            this.yeniBtn.TabIndex = 22;
            this.yeniBtn.Text = "Yeni Kayıt";
            this.yeniBtn.UseVisualStyleBackColor = false;
            // 
            // silBtn
            // 
            this.silBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.silBtn.FlatAppearance.BorderSize = 0;
            this.silBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.silBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.silBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.silBtn.Location = new System.Drawing.Point(605, 114);
            this.silBtn.Name = "silBtn";
            this.silBtn.Size = new System.Drawing.Size(125, 35);
            this.silBtn.TabIndex = 26;
            this.silBtn.Text = "Sil";
            this.silBtn.UseVisualStyleBackColor = false;
            // 
            // kayitBtn
            // 
            this.kayitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.kayitBtn.FlatAppearance.BorderSize = 0;
            this.kayitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kayitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.kayitBtn.Location = new System.Drawing.Point(246, 114);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(125, 35);
            this.kayitBtn.TabIndex = 24;
            this.kayitBtn.Text = "Kaydet";
            this.kayitBtn.UseVisualStyleBackColor = false;
            // 
            // vazgecBtn
            // 
            this.vazgecBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.vazgecBtn.FlatAppearance.BorderSize = 0;
            this.vazgecBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.vazgecBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vazgecBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.vazgecBtn.Location = new System.Drawing.Point(427, 114);
            this.vazgecBtn.Name = "vazgecBtn";
            this.vazgecBtn.Size = new System.Drawing.Size(125, 35);
            this.vazgecBtn.TabIndex = 25;
            this.vazgecBtn.Text = "Vazgeç";
            this.vazgecBtn.UseVisualStyleBackColor = false;
            // 
            // TabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TabPage1.Controls.Add(this.panel2);
            this.TabPage1.Controls.Add(this.panel1);
            this.TabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPage1.Location = new System.Drawing.Point(0, 0);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(754, 460);
            this.TabPage1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.musteriListView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(754, 296);
            this.panel2.TabIndex = 29;
            // 
            // Form_Pomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 460);
            this.Controls.Add(this.TabPage1);
            this.Name = "Form_Pomp";
            this.Text = "Form_Pomp";
            this.Load += new System.EventHandler(this.Form_Pomp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListView musteriListView;
        public System.Windows.Forms.ColumnHeader VARDIYA;
        public System.Windows.Forms.ColumnHeader PERSONEL;
        public System.Windows.Forms.ColumnHeader ILKSYC;
        public System.Windows.Forms.ColumnHeader SONSYC;
        public System.Windows.Forms.ColumnHeader FARK;
        public System.Windows.Forms.ColumnHeader FIYAT;
        public System.Windows.Forms.ColumnHeader TUTAR;
        public System.Windows.Forms.TextBox vergiNoTxtBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox vergiDaireTxtBox;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox comboBox2;
        public System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.ComboBox pompaComboBox;
        public System.Windows.Forms.TextBox telTxtBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox mevkiTxtBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button yeniBtn;
        public System.Windows.Forms.Button silBtn;
        public System.Windows.Forms.Button kayitBtn;
        public System.Windows.Forms.Button vazgecBtn;
        public System.Windows.Forms.Panel TabPage1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ColumnHeader ADI;
        public System.Windows.Forms.ColumnHeader SOYADI;
        public System.Windows.Forms.ColumnHeader RISK;
        public System.Windows.Forms.ColumnHeader FIAT;
        public System.Windows.Forms.ColumnHeader MEVKI;
        public System.Windows.Forms.ColumnHeader TEL;
        public System.Windows.Forms.ColumnHeader CEPTEL;
    }
}