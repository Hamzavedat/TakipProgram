
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Takip_Programı.Forms
{
    partial class Form_Settings
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.TabPage1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.turColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisFiyatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisFiyatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alisTutarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satisTutarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.miktarTxtBox = new System.Windows.Forms.TextBox();
            this.satisTutarTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.alisTutarTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.satisFiyatTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.alisFiyatTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.urunTurTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.urunNameTxtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.yeniBtn = new System.Windows.Forms.Button();
            this.silBtn = new System.Windows.Forms.Button();
            this.kayitBtn = new System.Windows.Forms.Button();
            this.vazgecBtn = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pompasilbtn = new System.Windows.Forms.Button();
            this.pompavazgecbtn = new System.Windows.Forms.Button();
            this.pompaduzenlebtn = new System.Windows.Forms.Button();
            this.pompakayitbtn = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.PompaTutarText = new System.Windows.Forms.TextBox();
            this.PompaFarkText = new System.Windows.Forms.TextBox();
            this.PompaYeniSayacText = new System.Windows.Forms.TextBox();
            this.PompaEskiSayacText = new System.Windows.Forms.TextBox();
            this.PompaAdıText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PumpGridView = new System.Windows.Forms.DataGridView();
            this.PompaNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PompaLastCounterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PompaNewCounterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PompaGapColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PompaTotalColunn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.tabPage7 = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PumpGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Controls.Add(this.tabPage7);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("Palatino Linotype", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tabControl1.HotTrack = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(20, 15);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(903, 637);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.TabPage1);
            this.tabPage2.Location = new System.Drawing.Point(4, 51);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(895, 582);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ürün Tanımları";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // TabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TabPage1.Controls.Add(this.panel2);
            this.TabPage1.Controls.Add(this.panel1);
            this.TabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPage1.Location = new System.Drawing.Point(3, 3);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(889, 576);
            this.TabPage1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(889, 412);
            this.panel2.TabIndex = 29;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idColumn,
            this.urunColumn,
            this.turColumn,
            this.miktarColumn,
            this.alisFiyatColumn,
            this.satisFiyatColumn,
            this.alisTutarColumn,
            this.satisTutarColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(889, 412);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "Id";
            this.idColumn.HeaderText = "ID";
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            // 
            // urunColumn
            // 
            this.urunColumn.DataPropertyName = "Name";
            this.urunColumn.FillWeight = 120F;
            this.urunColumn.HeaderText = "ÜRÜN ADI";
            this.urunColumn.Name = "urunColumn";
            this.urunColumn.ReadOnly = true;
            this.urunColumn.Width = 120;
            // 
            // turColumn
            // 
            this.turColumn.DataPropertyName = "Type";
            this.turColumn.FillWeight = 120F;
            this.turColumn.HeaderText = "ÜRÜN TÜRÜ";
            this.turColumn.Name = "turColumn";
            this.turColumn.ReadOnly = true;
            this.turColumn.Width = 120;
            // 
            // miktarColumn
            // 
            this.miktarColumn.DataPropertyName = "Amount";
            this.miktarColumn.HeaderText = "MİKTAR";
            this.miktarColumn.Name = "miktarColumn";
            this.miktarColumn.ReadOnly = true;
            // 
            // alisFiyatColumn
            // 
            this.alisFiyatColumn.DataPropertyName = "BuyPrice";
            this.alisFiyatColumn.FillWeight = 120F;
            this.alisFiyatColumn.HeaderText = "ALIŞ FİYATI";
            this.alisFiyatColumn.Name = "alisFiyatColumn";
            this.alisFiyatColumn.ReadOnly = true;
            this.alisFiyatColumn.Width = 120;
            // 
            // satisFiyatColumn
            // 
            this.satisFiyatColumn.DataPropertyName = "SellPrice";
            this.satisFiyatColumn.FillWeight = 125F;
            this.satisFiyatColumn.HeaderText = "SATIŞ FİYATI";
            this.satisFiyatColumn.Name = "satisFiyatColumn";
            this.satisFiyatColumn.ReadOnly = true;
            this.satisFiyatColumn.Width = 125;
            // 
            // alisTutarColumn
            // 
            this.alisTutarColumn.DataPropertyName = "BuyAmount";
            this.alisTutarColumn.FillWeight = 125F;
            this.alisTutarColumn.HeaderText = "ALIŞ TUTARI";
            this.alisTutarColumn.Name = "alisTutarColumn";
            this.alisTutarColumn.ReadOnly = true;
            this.alisTutarColumn.Width = 125;
            // 
            // satisTutarColumn
            // 
            this.satisTutarColumn.DataPropertyName = "SellAmount";
            this.satisTutarColumn.FillWeight = 135F;
            this.satisTutarColumn.HeaderText = "SATIŞ TUTARI";
            this.satisTutarColumn.Name = "satisTutarColumn";
            this.satisTutarColumn.ReadOnly = true;
            this.satisTutarColumn.Width = 135;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel1.Controls.Add(this.idTxtBox);
            this.panel1.Controls.Add(this.miktarTxtBox);
            this.panel1.Controls.Add(this.satisTutarTxtBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.alisTutarTxtBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.satisFiyatTxtBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.alisFiyatTxtBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.urunTurTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.urunNameTxtBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.yeniBtn);
            this.panel1.Controls.Add(this.silBtn);
            this.panel1.Controls.Add(this.kayitBtn);
            this.panel1.Controls.Add(this.vazgecBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(889, 164);
            this.panel1.TabIndex = 28;
            // 
            // idTxtBox
            // 
            this.idTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.idTxtBox.Location = new System.Drawing.Point(605, 71);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(114, 25);
            this.idTxtBox.TabIndex = 46;
            this.idTxtBox.Visible = false;
            // 
            // miktarTxtBox
            // 
            this.miktarTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.miktarTxtBox.Location = new System.Drawing.Point(368, 12);
            this.miktarTxtBox.Name = "miktarTxtBox";
            this.miktarTxtBox.Size = new System.Drawing.Size(114, 25);
            this.miktarTxtBox.TabIndex = 45;
            // 
            // satisTutarTxtBox
            // 
            this.satisTutarTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.satisTutarTxtBox.Location = new System.Drawing.Point(605, 40);
            this.satisTutarTxtBox.Name = "satisTutarTxtBox";
            this.satisTutarTxtBox.Size = new System.Drawing.Size(114, 25);
            this.satisTutarTxtBox.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(507, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Satış Tutarı : ";
            // 
            // alisTutarTxtBox
            // 
            this.alisTutarTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.alisTutarTxtBox.Location = new System.Drawing.Point(605, 12);
            this.alisTutarTxtBox.Name = "alisTutarTxtBox";
            this.alisTutarTxtBox.Size = new System.Drawing.Size(114, 25);
            this.alisTutarTxtBox.TabIndex = 40;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label9.Location = new System.Drawing.Point(513, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Alış Tutarı : ";
            // 
            // satisFiyatTxtBox
            // 
            this.satisFiyatTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.satisFiyatTxtBox.Location = new System.Drawing.Point(368, 68);
            this.satisFiyatTxtBox.Name = "satisFiyatTxtBox";
            this.satisFiyatTxtBox.Size = new System.Drawing.Size(114, 25);
            this.satisFiyatTxtBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(270, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Satış Fiyatı : ";
            // 
            // alisFiyatTxtBox
            // 
            this.alisFiyatTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.alisFiyatTxtBox.Location = new System.Drawing.Point(368, 40);
            this.alisFiyatTxtBox.Name = "alisFiyatTxtBox";
            this.alisFiyatTxtBox.Size = new System.Drawing.Size(114, 25);
            this.alisFiyatTxtBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(276, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Alış Fiyatı : ";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(295, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Miktar : ";
            // 
            // urunTurTxtBox
            // 
            this.urunTurTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.urunTurTxtBox.Location = new System.Drawing.Point(113, 40);
            this.urunTurTxtBox.Name = "urunTurTxtBox";
            this.urunTurTxtBox.Size = new System.Drawing.Size(114, 25);
            this.urunTurTxtBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(22, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Ürün Türü : ";
            // 
            // urunNameTxtBox
            // 
            this.urunNameTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.urunNameTxtBox.Location = new System.Drawing.Point(113, 12);
            this.urunNameTxtBox.Name = "urunNameTxtBox";
            this.urunNameTxtBox.Size = new System.Drawing.Size(114, 25);
            this.urunNameTxtBox.TabIndex = 28;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(32, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Ürün Adı : ";
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
            this.silBtn.Enabled = false;
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
            this.silBtn.Click += new System.EventHandler(this.silBtn_Click);
            // 
            // kayitBtn
            // 
            this.kayitBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.kayitBtn.Enabled = false;
            this.kayitBtn.FlatAppearance.BorderSize = 0;
            this.kayitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.kayitBtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kayitBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.kayitBtn.Location = new System.Drawing.Point(246, 114);
            this.kayitBtn.Name = "kayitBtn";
            this.kayitBtn.Size = new System.Drawing.Size(125, 35);
            this.kayitBtn.TabIndex = 24;
            this.kayitBtn.Text = "Düzenle";
            this.kayitBtn.UseVisualStyleBackColor = false;
            this.kayitBtn.Click += new System.EventHandler(this.kayitBtn_Click);
            // 
            // vazgecBtn
            // 
            this.vazgecBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.vazgecBtn.Enabled = false;
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
            this.vazgecBtn.Click += new System.EventHandler(this.vazgecBtn_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 51);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(895, 582);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Depo Tanımları";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 51);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(895, 582);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Pompa Tanımları";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(234)))), ((int)(((byte)(234)))));
            this.panel3.Controls.Add(this.pompasilbtn);
            this.panel3.Controls.Add(this.pompavazgecbtn);
            this.panel3.Controls.Add(this.pompaduzenlebtn);
            this.panel3.Controls.Add(this.pompakayitbtn);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.PompaTutarText);
            this.panel3.Controls.Add(this.PompaFarkText);
            this.panel3.Controls.Add(this.PompaYeniSayacText);
            this.panel3.Controls.Add(this.PompaEskiSayacText);
            this.panel3.Controls.Add(this.PompaAdıText);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.PumpGridView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(889, 576);
            this.panel3.TabIndex = 0;
            // 
            // pompasilbtn
            // 
            this.pompasilbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pompasilbtn.Enabled = false;
            this.pompasilbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pompasilbtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pompasilbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.pompasilbtn.Location = new System.Drawing.Point(584, 96);
            this.pompasilbtn.Name = "pompasilbtn";
            this.pompasilbtn.Size = new System.Drawing.Size(125, 35);
            this.pompasilbtn.TabIndex = 14;
            this.pompasilbtn.Text = "Sil";
            this.pompasilbtn.UseVisualStyleBackColor = false;
            this.pompasilbtn.Click += new System.EventHandler(this.pompasilbtn_Click);
            // 
            // pompavazgecbtn
            // 
            this.pompavazgecbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pompavazgecbtn.Enabled = false;
            this.pompavazgecbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pompavazgecbtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pompavazgecbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.pompavazgecbtn.Location = new System.Drawing.Point(410, 96);
            this.pompavazgecbtn.Name = "pompavazgecbtn";
            this.pompavazgecbtn.Size = new System.Drawing.Size(125, 35);
            this.pompavazgecbtn.TabIndex = 13;
            this.pompavazgecbtn.Text = "Vazgeç";
            this.pompavazgecbtn.UseVisualStyleBackColor = false;
            this.pompavazgecbtn.Click += new System.EventHandler(this.pompavazgecbtn_Click);
            // 
            // pompaduzenlebtn
            // 
            this.pompaduzenlebtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pompaduzenlebtn.Enabled = false;
            this.pompaduzenlebtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pompaduzenlebtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pompaduzenlebtn.ForeColor = System.Drawing.SystemColors.Control;
            this.pompaduzenlebtn.Location = new System.Drawing.Point(236, 96);
            this.pompaduzenlebtn.Name = "pompaduzenlebtn";
            this.pompaduzenlebtn.Size = new System.Drawing.Size(125, 35);
            this.pompaduzenlebtn.TabIndex = 12;
            this.pompaduzenlebtn.Text = "Düzenle";
            this.pompaduzenlebtn.UseVisualStyleBackColor = false;
            this.pompaduzenlebtn.Click += new System.EventHandler(this.pompaduzenlebtn_Click);
            // 
            // pompakayitbtn
            // 
            this.pompakayitbtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pompakayitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pompakayitbtn.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.pompakayitbtn.ForeColor = System.Drawing.SystemColors.Control;
            this.pompakayitbtn.Location = new System.Drawing.Point(65, 96);
            this.pompakayitbtn.Name = "pompakayitbtn";
            this.pompakayitbtn.Size = new System.Drawing.Size(125, 35);
            this.pompakayitbtn.TabIndex = 11;
            this.pompakayitbtn.Text = "Yeni Kayıt";
            this.pompakayitbtn.UseVisualStyleBackColor = false;
            this.pompakayitbtn.Click += new System.EventHandler(this.pompakayitbtn_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(603, 54);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(48, 20);
            this.label12.TabIndex = 10;
            this.label12.Text = "Tutar:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(608, 23);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 20);
            this.label11.TabIndex = 9;
            this.label11.Text = "Fark:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label10.Location = new System.Drawing.Point(346, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 8;
            this.label10.Text = "Yeni Sayaç:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(346, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 20);
            this.label7.TabIndex = 7;
            this.label7.Text = "Eski Sayaç:";
            // 
            // PompaTutarText
            // 
            this.PompaTutarText.Location = new System.Drawing.Point(657, 53);
            this.PompaTutarText.Name = "PompaTutarText";
            this.PompaTutarText.Size = new System.Drawing.Size(100, 25);
            this.PompaTutarText.TabIndex = 6;
            // 
            // PompaFarkText
            // 
            this.PompaFarkText.Location = new System.Drawing.Point(657, 22);
            this.PompaFarkText.Name = "PompaFarkText";
            this.PompaFarkText.Size = new System.Drawing.Size(100, 25);
            this.PompaFarkText.TabIndex = 5;
            // 
            // PompaYeniSayacText
            // 
            this.PompaYeniSayacText.Location = new System.Drawing.Point(435, 52);
            this.PompaYeniSayacText.Name = "PompaYeniSayacText";
            this.PompaYeniSayacText.Size = new System.Drawing.Size(100, 25);
            this.PompaYeniSayacText.TabIndex = 4;
            // 
            // PompaEskiSayacText
            // 
            this.PompaEskiSayacText.Location = new System.Drawing.Point(435, 21);
            this.PompaEskiSayacText.Name = "PompaEskiSayacText";
            this.PompaEskiSayacText.Size = new System.Drawing.Size(100, 25);
            this.PompaEskiSayacText.TabIndex = 3;
            // 
            // PompaAdıText
            // 
            this.PompaAdıText.Location = new System.Drawing.Point(135, 21);
            this.PompaAdıText.Name = "PompaAdıText";
            this.PompaAdıText.Size = new System.Drawing.Size(146, 25);
            this.PompaAdıText.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(42, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pompa Adı:";
            // 
            // PumpGridView
            // 
            this.PumpGridView.BackgroundColor = System.Drawing.Color.White;
            this.PumpGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PumpGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PompaNameColumn,
            this.Id,
            this.PompaLastCounterColumn,
            this.PompaNewCounterColumn,
            this.PompaGapColumn,
            this.PompaTotalColunn});
            this.PumpGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PumpGridView.Location = new System.Drawing.Point(0, 150);
            this.PumpGridView.Name = "PumpGridView";
            this.PumpGridView.RowTemplate.Height = 25;
            this.PumpGridView.Size = new System.Drawing.Size(889, 426);
            this.PumpGridView.TabIndex = 0;
            this.PumpGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.PumpGridView_CellClick);
            // 
            // PompaNameColumn
            // 
            this.PompaNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PompaNameColumn.DataPropertyName = "Name";
            this.PompaNameColumn.HeaderText = "Pompa Adı";
            this.PompaNameColumn.Name = "PompaNameColumn";
            // 
            // Id
            // 
            this.Id.DataPropertyName = "ID";
            this.Id.HeaderText = "id";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // PompaLastCounterColumn
            // 
            this.PompaLastCounterColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PompaLastCounterColumn.DataPropertyName = "LastCounter";
            this.PompaLastCounterColumn.HeaderText = "Eski Sayaç";
            this.PompaLastCounterColumn.Name = "PompaLastCounterColumn";
            // 
            // PompaNewCounterColumn
            // 
            this.PompaNewCounterColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PompaNewCounterColumn.DataPropertyName = "NewCounter";
            this.PompaNewCounterColumn.HeaderText = "Yeni Sayaç";
            this.PompaNewCounterColumn.Name = "PompaNewCounterColumn";
            // 
            // PompaGapColumn
            // 
            this.PompaGapColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PompaGapColumn.DataPropertyName = "Gap";
            this.PompaGapColumn.HeaderText = "Fark";
            this.PompaGapColumn.Name = "PompaGapColumn";
            // 
            // PompaTotalColunn
            // 
            this.PompaTotalColunn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PompaTotalColunn.DataPropertyName = "Total";
            this.PompaTotalColunn.HeaderText = "Tutar";
            this.PompaTotalColunn.Name = "PompaTotalColunn";
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 51);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(895, 582);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Personel Tanımları";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 51);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(895, 582);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Kullanıcılar";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // tabPage7
            // 
            this.tabPage7.Location = new System.Drawing.Point(4, 51);
            this.tabPage7.Name = "tabPage7";
            this.tabPage7.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage7.Size = new System.Drawing.Size(895, 582);
            this.tabPage7.TabIndex = 6;
            this.tabPage7.Text = "Veri Yolu";
            this.tabPage7.UseVisualStyleBackColor = true;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 637);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form_Settings";
            this.Text = "Form_Settings";
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.TabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PumpGridView)).EndInit();
            this.ResumeLayout(false);

        }



        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        public Panel TabPage1;
        public Panel panel2;
        public Panel panel1;
        public TextBox satisTutarTxtBox;
        public Label label8;
        public TextBox alisTutarTxtBox;
        public Label label9;
        public TextBox satisFiyatTxtBox;
        public Label label4;
        public TextBox alisFiyatTxtBox;
        public Label label5;
        public Label label6;
        public TextBox urunTurTxtBox;
        public Label label2;
        public TextBox urunNameTxtBox;
        public Label label1;
        public Button yeniBtn;
        public Button silBtn;
        public Button kayitBtn;
        public Button vazgecBtn;
        public TextBox miktarTxtBox;
        private DataGridView dataGridView;
        public TextBox idTxtBox;
        private DataGridViewTextBoxColumn idColumn;
        private DataGridViewTextBoxColumn urunColumn;
        private DataGridViewTextBoxColumn turColumn;
        private DataGridViewTextBoxColumn miktarColumn;
        private DataGridViewTextBoxColumn alisFiyatColumn;
        private DataGridViewTextBoxColumn satisFiyatColumn;
        private DataGridViewTextBoxColumn alisTutarColumn;
        private DataGridViewTextBoxColumn satisTutarColumn;
        private Panel panel3;
        private Label label7;
        private TextBox PompaTutarText;
        private TextBox PompaFarkText;
        private TextBox PompaYeniSayacText;
        private TextBox PompaEskiSayacText;
        private TextBox PompaAdıText;
        private Label label3;
        private DataGridView PumpGridView;
        private TabPage tabPage7;
        private Label label12;
        private Label label11;
        private Label label10;
        public Button pompakayitbtn;
        public Button pompasilbtn;
        public Button pompavazgecbtn;
        public Button pompaduzenlebtn;
        private DataGridViewTextBoxColumn PompaNameColumn;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn PompaLastCounterColumn;
        private DataGridViewTextBoxColumn PompaNewCounterColumn;
        private DataGridViewTextBoxColumn PompaGapColumn;
        private DataGridViewTextBoxColumn PompaTotalColunn;
    }
}