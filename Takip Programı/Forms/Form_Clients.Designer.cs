﻿
namespace Takip_Programı.Forms
{
    partial class Form_Clients
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
            this.TabPage1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.musteriListView = new System.Windows.Forms.ListView();
            this.ADI = new System.Windows.Forms.ColumnHeader();
            this.SOYADI = new System.Windows.Forms.ColumnHeader();
            this.RISK = new System.Windows.Forms.ColumnHeader();
            this.FIAT = new System.Windows.Forms.ColumnHeader();
            this.MEVKI = new System.Windows.Forms.ColumnHeader();
            this.TEL = new System.Windows.Forms.ColumnHeader();
            this.CEPTEL = new System.Windows.Forms.ColumnHeader();
            this.VERGIDAIRE = new System.Windows.Forms.ColumnHeader();
            this.VERGINUMARA = new System.Windows.Forms.ColumnHeader();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adresTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vergiNoTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vergiDaireTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cepTelTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.fiyatComboBox = new System.Windows.Forms.ComboBox();
            this.telTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.mevkiTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.riskTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.soyadTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.adTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.vazgecBtn = new System.Windows.Forms.Button();
            this.TabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.TabPage1.Size = new System.Drawing.Size(1064, 626);
            this.TabPage1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.musteriListView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1064, 462);
            this.panel2.TabIndex = 29;
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
            this.CEPTEL,
            this.VERGIDAIRE,
            this.VERGINUMARA});
            this.musteriListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.musteriListView.ForeColor = System.Drawing.Color.White;
            this.musteriListView.FullRowSelect = true;
            this.musteriListView.GridLines = true;
            this.musteriListView.HideSelection = false;
            this.musteriListView.Location = new System.Drawing.Point(0, 0);
            this.musteriListView.Name = "musteriListView";
            this.musteriListView.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.musteriListView.Size = new System.Drawing.Size(1064, 462);
            this.musteriListView.TabIndex = 28;
            this.musteriListView.UseCompatibleStateImageBehavior = false;
            this.musteriListView.View = System.Windows.Forms.View.Details;
            this.musteriListView.SelectedIndexChanged += new System.EventHandler(this.musteriListView_SelectedIndexChanged_1);
            // 
            // ADI
            // 
            this.ADI.Name = "ADI";
            this.ADI.Text = "ADI";
            this.ADI.Width = 110;
            // 
            // SOYADI
            // 
            this.SOYADI.Name = "SOYADI";
            this.SOYADI.Text = "SOYADI";
            this.SOYADI.Width = 110;
            // 
            // RISK
            // 
            this.RISK.Name = "RISK";
            this.RISK.Text = "RİSK LİMİTİ";
            this.RISK.Width = 100;
            // 
            // FIAT
            // 
            this.FIAT.Name = "FIAT";
            this.FIAT.Text = "FİYAT DEĞİŞİKLİĞİ";
            this.FIAT.Width = 140;
            // 
            // MEVKI
            // 
            this.MEVKI.Name = "MEVKI";
            this.MEVKI.Text = "MEVKİSİ";
            this.MEVKI.Width = 100;
            // 
            // TEL
            // 
            this.TEL.Name = "TEL";
            this.TEL.Text = "TELEFON";
            this.TEL.Width = 120;
            // 
            // CEPTEL
            // 
            this.CEPTEL.Name = "CEPTEL";
            this.CEPTEL.Text = "CEP TELEFONU";
            this.CEPTEL.Width = 120;
            // 
            // VERGIDAIRE
            // 
            this.VERGIDAIRE.Name = "VERGIDAIRE";
            this.VERGIDAIRE.Text = "VERGİ DAİRESİ";
            this.VERGIDAIRE.Width = 130;
            // 
            // VERGINUMARA
            // 
            this.VERGINUMARA.Name = "VERGINUMARA";
            this.VERGINUMARA.Text = "VERGİ NUMARASI";
            this.VERGINUMARA.Width = 140;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(162)))), ((int)(((byte)(219)))), ((int)(((byte)(250)))));
            this.panel1.Controls.Add(this.adresTxtBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.vergiNoTxtBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.vergiDaireTxtBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cepTelTxtBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.fiyatComboBox);
            this.panel1.Controls.Add(this.telTxtBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.mevkiTxtBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.riskTxtBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.soyadTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.adTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.yeniBtn);
            this.panel1.Controls.Add(this.silBtn);
            this.panel1.Controls.Add(this.kayitBtn);
            this.panel1.Controls.Add(this.vazgecBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1064, 164);
            this.panel1.TabIndex = 28;
            // 
            // adresTxtBox
            // 
            this.adresTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.adresTxtBox.Location = new System.Drawing.Point(807, 13);
            this.adresTxtBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.adresTxtBox.Multiline = true;
            this.adresTxtBox.Name = "adresTxtBox";
            this.adresTxtBox.Size = new System.Drawing.Size(203, 77);
            this.adresTxtBox.TabIndex = 46;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(747, 40);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Adres :";
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
            this.label7.Location = new System.Drawing.Point(531, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Vergi No : ";
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
            this.label8.Location = new System.Drawing.Point(505, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Vergi Dairesi : ";
            // 
            // cepTelTxtBox
            // 
            this.cepTelTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cepTelTxtBox.Location = new System.Drawing.Point(605, 12);
            this.cepTelTxtBox.Name = "cepTelTxtBox";
            this.cepTelTxtBox.Size = new System.Drawing.Size(114, 23);
            this.cepTelTxtBox.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(537, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(71, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cep Tel : ";
            // 
            // fiyatComboBox
            // 
            this.fiyatComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fiyatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiyatComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fiyatComboBox.FormattingEnabled = true;
            this.fiyatComboBox.Items.AddRange(new object[] {
            "Etkilensin",
            "Etkilenmesin"});
            this.fiyatComboBox.Location = new System.Drawing.Point(368, 11);
            this.fiyatComboBox.Name = "fiyatComboBox";
            this.fiyatComboBox.Size = new System.Drawing.Size(114, 23);
            this.fiyatComboBox.TabIndex = 38;
            // 
            // telTxtBox
            // 
            this.telTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.telTxtBox.Location = new System.Drawing.Point(368, 68);
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
            this.label4.Location = new System.Drawing.Point(331, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Tel : ";
            // 
            // mevkiTxtBox
            // 
            this.mevkiTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mevkiTxtBox.Location = new System.Drawing.Point(368, 40);
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
            this.label5.Location = new System.Drawing.Point(301, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(74, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Mevkisi : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(250, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fiyat Değişikliği : ";
            // 
            // riskTxtBox
            // 
            this.riskTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.riskTxtBox.Location = new System.Drawing.Point(113, 68);
            this.riskTxtBox.Name = "riskTxtBox";
            this.riskTxtBox.Size = new System.Drawing.Size(114, 23);
            this.riskTxtBox.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(28, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Risk Limiti : ";
            // 
            // soyadTxtBox
            // 
            this.soyadTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.soyadTxtBox.Location = new System.Drawing.Point(113, 40);
            this.soyadTxtBox.Name = "soyadTxtBox";
            this.soyadTxtBox.Size = new System.Drawing.Size(114, 23);
            this.soyadTxtBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(50, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Soyadı : ";
            // 
            // adTxtBox
            // 
            this.adTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.adTxtBox.Location = new System.Drawing.Point(113, 12);
            this.adTxtBox.Name = "adTxtBox";
            this.adTxtBox.Size = new System.Drawing.Size(114, 23);
            this.adTxtBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(76, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Adı : ";
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
            this.yeniBtn.Click += new System.EventHandler(this.yeniBtn_Click);
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
            // Form_Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 626);
            this.Controls.Add(this.TabPage1);
            this.Name = "Form_Clients";
            this.Text = "Form_Clients";
            this.TabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Panel TabPage1;
        public System.Windows.Forms.Button silBtn;
        public System.Windows.Forms.Button vazgecBtn;
        public System.Windows.Forms.Button kayitBtn;
        public System.Windows.Forms.Button yeniBtn;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListView musteriListView;
        public System.Windows.Forms.ColumnHeader ADI;
        public System.Windows.Forms.ColumnHeader SOYADI;
        public System.Windows.Forms.ColumnHeader RISK;
        public System.Windows.Forms.ColumnHeader FIAT;
        public System.Windows.Forms.ColumnHeader MEVKI;
        public System.Windows.Forms.ColumnHeader TEL;
        public System.Windows.Forms.ColumnHeader CEPTEL;
        public System.Windows.Forms.ColumnHeader VERGIDAIRE;
        public System.Windows.Forms.ColumnHeader VERGINUMARA;
        public System.Windows.Forms.TextBox adresTxtBox;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox vergiNoTxtBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox vergiDaireTxtBox;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox cepTelTxtBox;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox fiyatComboBox;
        public System.Windows.Forms.TextBox telTxtBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox mevkiTxtBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox riskTxtBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox soyadTxtBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox adTxtBox;
        public System.Windows.Forms.Label label1;
    }
}