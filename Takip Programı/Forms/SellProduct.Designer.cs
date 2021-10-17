
namespace Takip_Programı.Forms
{
    partial class SellProduct
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
            this.label1 = new System.Windows.Forms.Label();
            this.urun_cmbbox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.miktartxt = new System.Windows.Forms.TextBox();
            this.eklebtn = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ProductId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductTotalPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.satbtn = new System.Windows.Forms.Button();
            this.brmfyttxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tplmfyttxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.toplamtxt = new System.Windows.Forms.TextBox();
            this.silbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(60, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ürün : ";
            // 
            // urun_cmbbox
            // 
            this.urun_cmbbox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.urun_cmbbox.FormattingEnabled = true;
            this.urun_cmbbox.Location = new System.Drawing.Point(134, 39);
            this.urun_cmbbox.Name = "urun_cmbbox";
            this.urun_cmbbox.Size = new System.Drawing.Size(202, 33);
            this.urun_cmbbox.TabIndex = 1;
            this.urun_cmbbox.SelectedIndexChanged += new System.EventHandler(this.urun_cmbbox_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(395, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Miktar : ";
            // 
            // miktartxt
            // 
            this.miktartxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.miktartxt.Location = new System.Drawing.Point(481, 39);
            this.miktartxt.Name = "miktartxt";
            this.miktartxt.Size = new System.Drawing.Size(175, 33);
            this.miktartxt.TabIndex = 3;
            this.miktartxt.TextChanged += new System.EventHandler(this.miktartxt_TextChanged);
            // 
            // eklebtn
            // 
            this.eklebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.eklebtn.Location = new System.Drawing.Point(707, 38);
            this.eklebtn.Name = "eklebtn";
            this.eklebtn.Size = new System.Drawing.Size(132, 35);
            this.eklebtn.TabIndex = 4;
            this.eklebtn.Text = "EKLE (ENTER)";
            this.eklebtn.UseVisualStyleBackColor = true;
            this.eklebtn.Click += new System.EventHandler(this.eklebtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProductId,
            this.ProductName,
            this.ProductNumber,
            this.ProductPrice,
            this.ProductTotalPrice});
            this.dataGridView1.Location = new System.Drawing.Point(0, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(883, 312);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // ProductId
            // 
            this.ProductId.DataPropertyName = "ProductId";
            this.ProductId.HeaderText = "Id";
            this.ProductId.Name = "ProductId";
            this.ProductId.Visible = false;
            // 
            // ProductName
            // 
            this.ProductName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductName.DataPropertyName = "ProductName";
            this.ProductName.HeaderText = "ÜRÜN ADI";
            this.ProductName.Name = "ProductName";
            // 
            // ProductNumber
            // 
            this.ProductNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductNumber.DataPropertyName = "ProductNumber";
            this.ProductNumber.HeaderText = "ADET";
            this.ProductNumber.Name = "ProductNumber";
            // 
            // ProductPrice
            // 
            this.ProductPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductPrice.DataPropertyName = "ProductPrice";
            this.ProductPrice.HeaderText = "BİRİM FİYATI";
            this.ProductPrice.Name = "ProductPrice";
            // 
            // ProductTotalPrice
            // 
            this.ProductTotalPrice.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ProductTotalPrice.DataPropertyName = "ProductTotalPrice";
            this.ProductTotalPrice.HeaderText = "FİYAT";
            this.ProductTotalPrice.Name = "ProductTotalPrice";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 481);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Toplam Ücret :";
            // 
            // satbtn
            // 
            this.satbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.satbtn.Location = new System.Drawing.Point(707, 471);
            this.satbtn.Name = "satbtn";
            this.satbtn.Size = new System.Drawing.Size(132, 46);
            this.satbtn.TabIndex = 8;
            this.satbtn.Text = "SATIŞ (F1)";
            this.satbtn.UseVisualStyleBackColor = true;
            this.satbtn.Click += new System.EventHandler(this.satbtn_Click);
            // 
            // brmfyttxt
            // 
            this.brmfyttxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.brmfyttxt.Location = new System.Drawing.Point(134, 78);
            this.brmfyttxt.Name = "brmfyttxt";
            this.brmfyttxt.ReadOnly = true;
            this.brmfyttxt.Size = new System.Drawing.Size(175, 33);
            this.brmfyttxt.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Birim Fiyatı : ";
            // 
            // tplmfyttxt
            // 
            this.tplmfyttxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tplmfyttxt.Location = new System.Drawing.Point(481, 81);
            this.tplmfyttxt.Name = "tplmfyttxt";
            this.tplmfyttxt.ReadOnly = true;
            this.tplmfyttxt.Size = new System.Drawing.Size(175, 33);
            this.tplmfyttxt.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(344, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 25);
            this.label5.TabIndex = 11;
            this.label5.Text = "Toplam Fiyat : ";
            // 
            // toplamtxt
            // 
            this.toplamtxt.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.toplamtxt.ForeColor = System.Drawing.Color.Red;
            this.toplamtxt.Location = new System.Drawing.Point(173, 482);
            this.toplamtxt.Name = "toplamtxt";
            this.toplamtxt.ReadOnly = true;
            this.toplamtxt.Size = new System.Drawing.Size(136, 33);
            this.toplamtxt.TabIndex = 13;
            // 
            // silbtn
            // 
            this.silbtn.Enabled = false;
            this.silbtn.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.silbtn.Location = new System.Drawing.Point(707, 79);
            this.silbtn.Name = "silbtn";
            this.silbtn.Size = new System.Drawing.Size(132, 35);
            this.silbtn.TabIndex = 14;
            this.silbtn.Text = "Sil (DEL)";
            this.silbtn.UseVisualStyleBackColor = true;
            this.silbtn.Click += new System.EventHandler(this.silbtn_Click);
            // 
            // SellProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 543);
            this.Controls.Add(this.silbtn);
            this.Controls.Add(this.toplamtxt);
            this.Controls.Add(this.tplmfyttxt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.brmfyttxt);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.satbtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.eklebtn);
            this.Controls.Add(this.miktartxt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.urun_cmbbox);
            this.Controls.Add(this.label1);
            this.Name = "SellProduct";
            this.Text = "SellProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox urun_cmbbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox miktartxt;
        private System.Windows.Forms.Button eklebtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button satbtn;
        private System.Windows.Forms.TextBox brmfyttxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tplmfyttxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox toplamtxt;
        private System.Windows.Forms.Button silbtn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductId;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProductTotalPrice;
    }
}