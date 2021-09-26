
namespace Takip_Programı.Forms
{
    partial class Form_Cari
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Change = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarihColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.islemTurColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.urunColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.miktarColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fiyatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.efiyatColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.verilenColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.alınanColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bakiyeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.aciklamaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.fiyatComboBox = new System.Windows.Forms.ComboBox();
            this.bakiyeTxtBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.idTxtBox = new System.Windows.Forms.TextBox();
            this.adresTxtBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.vergiNoTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.vergiDaireTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cepTelTxtBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.alinanTutarTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.verilenTutarTxtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.riskTxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mevkiTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.satisBtn = new System.Windows.Forms.Button();
            this.odemeBtn = new System.Windows.Forms.Button();
            this.alisBtn = new System.Windows.Forms.Button();
            this.tahsilatBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Change,
            this.tarihColumn,
            this.islemTurColumn,
            this.urunColumn,
            this.miktarColumn,
            this.fiyatColumn,
            this.efiyatColumn,
            this.verilenColumn,
            this.alınanColumn,
            this.bakiyeColumn,
            this.aciklamaColumn});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 200);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(1132, 333);
            this.dataGridView.TabIndex = 29;
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "ID";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Change
            // 
            this.Change.DataPropertyName = "Change";
            this.Change.HeaderText = "Change";
            this.Change.Name = "Change";
            this.Change.ReadOnly = true;
            this.Change.Visible = false;
            // 
            // tarihColumn
            // 
            this.tarihColumn.DataPropertyName = "Tarih";
            this.tarihColumn.HeaderText = "TARİH";
            this.tarihColumn.Name = "tarihColumn";
            this.tarihColumn.ReadOnly = true;
            // 
            // islemTurColumn
            // 
            this.islemTurColumn.DataPropertyName = "İslemTur";
            this.islemTurColumn.HeaderText = "İŞLEM TÜRÜ";
            this.islemTurColumn.Name = "islemTurColumn";
            this.islemTurColumn.ReadOnly = true;
            // 
            // urunColumn
            // 
            this.urunColumn.DataPropertyName = "UrunAdi";
            this.urunColumn.HeaderText = "ÜRÜN ADI";
            this.urunColumn.Name = "urunColumn";
            this.urunColumn.ReadOnly = true;
            // 
            // miktarColumn
            // 
            this.miktarColumn.DataPropertyName = "Miktar";
            this.miktarColumn.FillWeight = 125F;
            this.miktarColumn.HeaderText = "MİKTAR";
            this.miktarColumn.Name = "miktarColumn";
            this.miktarColumn.ReadOnly = true;
            this.miktarColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.miktarColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.miktarColumn.Width = 125;
            // 
            // fiyatColumn
            // 
            this.fiyatColumn.DataPropertyName = "Fiyat";
            this.fiyatColumn.HeaderText = "FİYAT";
            this.fiyatColumn.Name = "fiyatColumn";
            this.fiyatColumn.ReadOnly = true;
            this.fiyatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // efiyatColumn
            // 
            this.efiyatColumn.DataPropertyName = "EFiyat";
            this.efiyatColumn.HeaderText = "E. FİYAT";
            this.efiyatColumn.Name = "efiyatColumn";
            this.efiyatColumn.ReadOnly = true;
            this.efiyatColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // verilenColumn
            // 
            this.verilenColumn.DataPropertyName = "verilen";
            this.verilenColumn.FillWeight = 125F;
            this.verilenColumn.HeaderText = "VERİLEN";
            this.verilenColumn.Name = "verilenColumn";
            this.verilenColumn.ReadOnly = true;
            this.verilenColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.verilenColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.verilenColumn.Width = 125;
            // 
            // alınanColumn
            // 
            this.alınanColumn.DataPropertyName = "Alinan";
            this.alınanColumn.FillWeight = 125F;
            this.alınanColumn.HeaderText = "ALINAN";
            this.alınanColumn.Name = "alınanColumn";
            this.alınanColumn.ReadOnly = true;
            this.alınanColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.alınanColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.alınanColumn.Width = 125;
            // 
            // bakiyeColumn
            // 
            this.bakiyeColumn.DataPropertyName = "Bakiye";
            this.bakiyeColumn.FillWeight = 125F;
            this.bakiyeColumn.HeaderText = "BAKİYE";
            this.bakiyeColumn.Name = "bakiyeColumn";
            this.bakiyeColumn.ReadOnly = true;
            this.bakiyeColumn.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.bakiyeColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.bakiyeColumn.Width = 125;
            // 
            // aciklamaColumn
            // 
            this.aciklamaColumn.DataPropertyName = "Aciklama";
            this.aciklamaColumn.HeaderText = "AÇIKLAMA";
            this.aciklamaColumn.Name = "aciklamaColumn";
            this.aciklamaColumn.ReadOnly = true;
            this.aciklamaColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(253)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.fiyatComboBox);
            this.panel1.Controls.Add(this.bakiyeTxtBox);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.idTxtBox);
            this.panel1.Controls.Add(this.adresTxtBox);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.vergiNoTxtBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.vergiDaireTxtBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.cepTelTxtBox);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.nameComboBox);
            this.panel1.Controls.Add(this.alinanTutarTxtBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.verilenTutarTxtBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.riskTxtBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.mevkiTxtBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.satisBtn);
            this.panel1.Controls.Add(this.odemeBtn);
            this.panel1.Controls.Add(this.alisBtn);
            this.panel1.Controls.Add(this.tahsilatBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1132, 200);
            this.panel1.TabIndex = 30;
            // 
            // fiyatComboBox
            // 
            this.fiyatComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.fiyatComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fiyatComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.fiyatComboBox.FormattingEnabled = true;
            this.fiyatComboBox.Items.AddRange(new object[] {
            "Etkilenmesin",
            "Etkilensin"});
            this.fiyatComboBox.Location = new System.Drawing.Point(142, 69);
            this.fiyatComboBox.Name = "fiyatComboBox";
            this.fiyatComboBox.Size = new System.Drawing.Size(114, 23);
            this.fiyatComboBox.TabIndex = 50;
            // 
            // bakiyeTxtBox
            // 
            this.bakiyeTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.bakiyeTxtBox.Location = new System.Drawing.Point(497, 93);
            this.bakiyeTxtBox.Name = "bakiyeTxtBox";
            this.bakiyeTxtBox.Size = new System.Drawing.Size(114, 23);
            this.bakiyeTxtBox.TabIndex = 49;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label11.Location = new System.Drawing.Point(430, 93);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 20);
            this.label11.TabIndex = 48;
            this.label11.Text = "Bakiye :";
            // 
            // idTxtBox
            // 
            this.idTxtBox.Location = new System.Drawing.Point(1012, 12);
            this.idTxtBox.Name = "idTxtBox";
            this.idTxtBox.Size = new System.Drawing.Size(100, 23);
            this.idTxtBox.TabIndex = 47;
            this.idTxtBox.Visible = false;
            // 
            // adresTxtBox
            // 
            this.adresTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.adresTxtBox.Location = new System.Drawing.Point(810, 62);
            this.adresTxtBox.Margin = new System.Windows.Forms.Padding(3, 3, 20, 3);
            this.adresTxtBox.Multiline = true;
            this.adresTxtBox.Name = "adresTxtBox";
            this.adresTxtBox.Size = new System.Drawing.Size(203, 60);
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
            this.label10.Location = new System.Drawing.Point(748, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 20);
            this.label10.TabIndex = 45;
            this.label10.Text = "Adres :";
            // 
            // vergiNoTxtBox
            // 
            this.vergiNoTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vergiNoTxtBox.Location = new System.Drawing.Point(810, 36);
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
            this.label7.Location = new System.Drawing.Point(728, 35);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Vergi No :";
            // 
            // vergiDaireTxtBox
            // 
            this.vergiDaireTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.vergiDaireTxtBox.Location = new System.Drawing.Point(810, 7);
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
            this.label8.Location = new System.Drawing.Point(702, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Vergi Dairesi :";
            // 
            // cepTelTxtBox
            // 
            this.cepTelTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.cepTelTxtBox.Location = new System.Drawing.Point(497, 6);
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
            this.label9.Location = new System.Drawing.Point(424, 9);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 39;
            this.label9.Text = "Cep Tel :";
            // 
            // nameComboBox
            // 
            this.nameComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.nameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nameComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(142, 7);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(114, 23);
            this.nameComboBox.TabIndex = 38;
            this.nameComboBox.SelectedIndexChanged += new System.EventHandler(this.nameComboBox_SelectedIndexChanged);
            // 
            // alinanTutarTxtBox
            // 
            this.alinanTutarTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.alinanTutarTxtBox.Location = new System.Drawing.Point(497, 64);
            this.alinanTutarTxtBox.Name = "alinanTutarTxtBox";
            this.alinanTutarTxtBox.Size = new System.Drawing.Size(114, 23);
            this.alinanTutarTxtBox.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(337, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Toplam Alınan Tutar :";
            // 
            // verilenTutarTxtBox
            // 
            this.verilenTutarTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.verilenTutarTxtBox.Location = new System.Drawing.Point(497, 35);
            this.verilenTutarTxtBox.Name = "verilenTutarTxtBox";
            this.verilenTutarTxtBox.Size = new System.Drawing.Size(114, 23);
            this.verilenTutarTxtBox.TabIndex = 35;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(333, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(158, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Toplam Verilen Tutar :";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(9, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(127, 20);
            this.label6.TabIndex = 33;
            this.label6.Text = "Fiyat Değişikliği : ";
            // 
            // riskTxtBox
            // 
            this.riskTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.riskTxtBox.Location = new System.Drawing.Point(142, 99);
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
            this.label3.Location = new System.Drawing.Point(42, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 31;
            this.label3.Text = "Risk Limiti : ";
            // 
            // mevkiTxtBox
            // 
            this.mevkiTxtBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mevkiTxtBox.Location = new System.Drawing.Point(142, 40);
            this.mevkiTxtBox.Name = "mevkiTxtBox";
            this.mevkiTxtBox.Size = new System.Drawing.Size(114, 23);
            this.mevkiTxtBox.TabIndex = 30;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(62, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 29;
            this.label2.Text = "Mevkisi : ";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(23, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 27;
            this.label1.Text = "Adı ve Soyadı : ";
            // 
            // satisBtn
            // 
            this.satisBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.satisBtn.Enabled = false;
            this.satisBtn.FlatAppearance.BorderSize = 0;
            this.satisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.satisBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.satisBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.satisBtn.Location = new System.Drawing.Point(223, 141);
            this.satisBtn.Name = "satisBtn";
            this.satisBtn.Size = new System.Drawing.Size(125, 35);
            this.satisBtn.TabIndex = 22;
            this.satisBtn.Text = "SATIŞ (F1)";
            this.satisBtn.UseVisualStyleBackColor = false;
            this.satisBtn.Click += new System.EventHandler(this.satisBtn_Click);
            // 
            // odemeBtn
            // 
            this.odemeBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.odemeBtn.Enabled = false;
            this.odemeBtn.FlatAppearance.BorderSize = 0;
            this.odemeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odemeBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.odemeBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.odemeBtn.Location = new System.Drawing.Point(763, 141);
            this.odemeBtn.Name = "odemeBtn";
            this.odemeBtn.Size = new System.Drawing.Size(125, 35);
            this.odemeBtn.TabIndex = 26;
            this.odemeBtn.Text = "ÖDEME (F4)";
            this.odemeBtn.UseVisualStyleBackColor = false;
            this.odemeBtn.Click += new System.EventHandler(this.odemeBtn_Click);
            // 
            // alisBtn
            // 
            this.alisBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.alisBtn.Enabled = false;
            this.alisBtn.FlatAppearance.BorderSize = 0;
            this.alisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.alisBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.alisBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.alisBtn.Location = new System.Drawing.Point(404, 141);
            this.alisBtn.Name = "alisBtn";
            this.alisBtn.Size = new System.Drawing.Size(125, 35);
            this.alisBtn.TabIndex = 24;
            this.alisBtn.Text = "ALIŞ (F2)";
            this.alisBtn.UseVisualStyleBackColor = false;
            this.alisBtn.Click += new System.EventHandler(this.alisBtn_Click);
            // 
            // tahsilatBtn
            // 
            this.tahsilatBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.tahsilatBtn.Enabled = false;
            this.tahsilatBtn.FlatAppearance.BorderSize = 0;
            this.tahsilatBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tahsilatBtn.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tahsilatBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.tahsilatBtn.Location = new System.Drawing.Point(585, 141);
            this.tahsilatBtn.Name = "tahsilatBtn";
            this.tahsilatBtn.Size = new System.Drawing.Size(125, 35);
            this.tahsilatBtn.TabIndex = 25;
            this.tahsilatBtn.Text = "TAHSİLAT (F3)";
            this.tahsilatBtn.UseVisualStyleBackColor = false;
            this.tahsilatBtn.Click += new System.EventHandler(this.tahsilatBtn_Click);
            // 
            // Form_Cari
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 533);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Cari";
            this.Text = "Form_Cari";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox idTxtBox;
        public System.Windows.Forms.TextBox adresTxtBox;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox vergiNoTxtBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox vergiDaireTxtBox;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.TextBox cepTelTxtBox;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.ComboBox nameComboBox;
        public System.Windows.Forms.TextBox alinanTutarTxtBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox verilenTutarTxtBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox riskTxtBox;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox mevkiTxtBox;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button satisBtn;
        public System.Windows.Forms.Button odemeBtn;
        public System.Windows.Forms.Button alisBtn;
        public System.Windows.Forms.Button tahsilatBtn;
        public System.Windows.Forms.TextBox bakiyeTxtBox;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.ComboBox fiyatComboBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Change;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarihColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn islemTurColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn urunColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn miktarColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fiyatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn efiyatColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn verilenColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn alınanColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bakiyeColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn aciklamaColumn;
    }
}