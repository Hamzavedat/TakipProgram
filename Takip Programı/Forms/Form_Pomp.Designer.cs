
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
            this.amountTxtBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.diffrenceTxtBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.idTextBox = new System.Windows.Forms.TextBox();
            this.personNameTextBox = new System.Windows.Forms.TextBox();
            this.dateComboBox = new System.Windows.Forms.ComboBox();
            this.pompaComboBox = new System.Windows.Forms.ComboBox();
            this.lastCounterTxtBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.firstCounterTxtBox = new System.Windows.Forms.TextBox();
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PersonName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastCounter = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Difference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpDefine = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PumpNames = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.TabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // amountTxtBox
            // 
            this.amountTxtBox.BackColor = System.Drawing.Color.White;
            this.amountTxtBox.Location = new System.Drawing.Point(690, 69);
            this.amountTxtBox.Name = "amountTxtBox";
            this.amountTxtBox.Size = new System.Drawing.Size(142, 23);
            this.amountTxtBox.TabIndex = 44;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(628, 71);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 20);
            this.label7.TabIndex = 43;
            this.label7.Text = "Tutar : ";
            // 
            // diffrenceTxtBox
            // 
            this.diffrenceTxtBox.BackColor = System.Drawing.Color.White;
            this.diffrenceTxtBox.Location = new System.Drawing.Point(690, 41);
            this.diffrenceTxtBox.Name = "diffrenceTxtBox";
            this.diffrenceTxtBox.Size = new System.Drawing.Size(142, 23);
            this.diffrenceTxtBox.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(605, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 20);
            this.label8.TabIndex = 41;
            this.label8.Text = "Fark (Lt) : ";
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(253)))), ((int)(((byte)(176)))));
            this.panel1.Controls.Add(this.idTextBox);
            this.panel1.Controls.Add(this.personNameTextBox);
            this.panel1.Controls.Add(this.dateComboBox);
            this.panel1.Controls.Add(this.amountTxtBox);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.diffrenceTxtBox);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.pompaComboBox);
            this.panel1.Controls.Add(this.lastCounterTxtBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.firstCounterTxtBox);
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
            this.panel1.Size = new System.Drawing.Size(924, 164);
            this.panel1.TabIndex = 28;
            // 
            // idTextBox
            // 
            this.idTextBox.BackColor = System.Drawing.Color.White;
            this.idTextBox.Location = new System.Drawing.Point(690, 12);
            this.idTextBox.Name = "idTextBox";
            this.idTextBox.Size = new System.Drawing.Size(142, 23);
            this.idTextBox.TabIndex = 49;
            // 
            // personNameTextBox
            // 
            this.personNameTextBox.BackColor = System.Drawing.Color.White;
            this.personNameTextBox.Location = new System.Drawing.Point(130, 71);
            this.personNameTextBox.Name = "personNameTextBox";
            this.personNameTextBox.Size = new System.Drawing.Size(164, 23);
            this.personNameTextBox.TabIndex = 48;
            // 
            // dateComboBox
            // 
            this.dateComboBox.BackColor = System.Drawing.Color.White;
            this.dateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dateComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.dateComboBox.FormattingEnabled = true;
            this.dateComboBox.Location = new System.Drawing.Point(130, 41);
            this.dateComboBox.Name = "dateComboBox";
            this.dateComboBox.Size = new System.Drawing.Size(164, 23);
            this.dateComboBox.TabIndex = 47;
            // 
            // pompaComboBox
            // 
            this.pompaComboBox.BackColor = System.Drawing.Color.White;
            this.pompaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pompaComboBox.ForeColor = System.Drawing.SystemColors.Desktop;
            this.pompaComboBox.FormattingEnabled = true;
            this.pompaComboBox.Location = new System.Drawing.Point(130, 12);
            this.pompaComboBox.Name = "pompaComboBox";
            this.pompaComboBox.Size = new System.Drawing.Size(164, 23);
            this.pompaComboBox.TabIndex = 38;
            this.pompaComboBox.SelectedIndexChanged += new System.EventHandler(this.pompaComboBox_SelectedIndexChanged);
            // 
            // lastCounterTxtBox
            // 
            this.lastCounterTxtBox.BackColor = System.Drawing.Color.White;
            this.lastCounterTxtBox.Location = new System.Drawing.Point(427, 72);
            this.lastCounterTxtBox.Name = "lastCounterTxtBox";
            this.lastCounterTxtBox.Size = new System.Drawing.Size(142, 23);
            this.lastCounterTxtBox.TabIndex = 37;
            this.lastCounterTxtBox.TextChanged += new System.EventHandler(this.lastCounterTxtBox_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(334, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 36;
            this.label4.Text = "Yeni Sayaç : ";
            // 
            // firstCounterTxtBox
            // 
            this.firstCounterTxtBox.BackColor = System.Drawing.Color.White;
            this.firstCounterTxtBox.Location = new System.Drawing.Point(427, 41);
            this.firstCounterTxtBox.Name = "firstCounterTxtBox";
            this.firstCounterTxtBox.Size = new System.Drawing.Size(142, 23);
            this.firstCounterTxtBox.TabIndex = 35;
            this.firstCounterTxtBox.TextChanged += new System.EventHandler(this.firstCounterTxtBox_TextChanged);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(334, 40);
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
            // TabPage1
            // 
            this.TabPage1.AutoScroll = true;
            this.TabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(63)))), ((int)(((byte)(81)))), ((int)(((byte)(181)))));
            this.TabPage1.Controls.Add(this.panel2);
            this.TabPage1.Controls.Add(this.panel1);
            this.TabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TabPage1.Location = new System.Drawing.Point(0, 0);
            this.TabPage1.Name = "TabPage1";
            this.TabPage1.Size = new System.Drawing.Size(924, 586);
            this.TabPage1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.dataGridView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 164);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(924, 422);
            this.panel2.TabIndex = 29;
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.WorkDate,
            this.PersonName,
            this.FirstCounter,
            this.LastCounter,
            this.Difference,
            this.Price,
            this.Amount,
            this.PumpDefine,
            this.PumpNames});
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(924, 422);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "IdColumn";
            this.Id.Name = "Id";
            this.Id.Visible = false;
            // 
            // WorkDate
            // 
            this.WorkDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.WorkDate.DataPropertyName = "WorkDate";
            this.WorkDate.HeaderText = "Vardiya Tarihi";
            this.WorkDate.Name = "WorkDate";
            // 
            // PersonName
            // 
            this.PersonName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PersonName.DataPropertyName = "PersonName";
            this.PersonName.HeaderText = "Personel Adı";
            this.PersonName.Name = "PersonName";
            // 
            // FirstCounter
            // 
            this.FirstCounter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.FirstCounter.DataPropertyName = "FirstCounter";
            this.FirstCounter.HeaderText = "İlk Sayaç";
            this.FirstCounter.Name = "FirstCounter";
            // 
            // LastCounter
            // 
            this.LastCounter.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.LastCounter.DataPropertyName = "LastCounter";
            this.LastCounter.HeaderText = "Son Sayaç";
            this.LastCounter.Name = "LastCounter";
            // 
            // Difference
            // 
            this.Difference.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Difference.DataPropertyName = "Difference";
            this.Difference.HeaderText = "Fark (Lt)";
            this.Difference.Name = "Difference";
            // 
            // Price
            // 
            this.Price.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Price.DataPropertyName = "Price";
            this.Price.HeaderText = "Fiyat";
            this.Price.Name = "Price";
            // 
            // Amount
            // 
            this.Amount.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Amount.DataPropertyName = "Amount";
            this.Amount.HeaderText = "Tutar";
            this.Amount.Name = "Amount";
            // 
            // PumpDefine
            // 
            this.PumpDefine.DataPropertyName = "PumpDefine";
            this.PumpDefine.HeaderText = "PumpDefineColumn";
            this.PumpDefine.Name = "PumpDefine";
            this.PumpDefine.Visible = false;
            // 
            // PumpNames
            // 
            this.PumpNames.DataPropertyName = "PumpNames";
            this.PumpNames.HeaderText = "PumpNamesColumn";
            this.PumpNames.Name = "PumpNames";
            this.PumpNames.Visible = false;
            // 
            // Form_Pomp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 586);
            this.Controls.Add(this.TabPage1);
            this.Name = "Form_Pomp";
            this.Text = "Form_Pomp";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.TabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.ColumnHeader VARDIYA;
        public System.Windows.Forms.ColumnHeader PERSONEL;
        public System.Windows.Forms.ColumnHeader ILKSYC;
        public System.Windows.Forms.ColumnHeader SONSYC;
        public System.Windows.Forms.ColumnHeader FARK;
        public System.Windows.Forms.ColumnHeader FIYAT;
        public System.Windows.Forms.ColumnHeader TUTAR;
        public System.Windows.Forms.TextBox amountTxtBox;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox diffrenceTxtBox;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox dateComboBox;
        public System.Windows.Forms.ComboBox pompaComboBox;
        public System.Windows.Forms.TextBox lastCounterTxtBox;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox firstCounterTxtBox;
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
        private System.Windows.Forms.DataGridView dataGridView;
        public System.Windows.Forms.TextBox personNameTextBox;
        public System.Windows.Forms.TextBox idTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PersonName;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastCounter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Difference;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PumpDefine;
        private System.Windows.Forms.DataGridViewTextBoxColumn PumpNames;
    }
}