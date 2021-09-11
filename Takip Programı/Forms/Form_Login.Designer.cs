
namespace Takip_Programı.Forms
{
    partial class Form_Login
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.showBtn = new System.Windows.Forms.Button();
            this.hideBtn = new System.Windows.Forms.Button();
            this.girisBtn = new System.Windows.Forms.Button();
            this.passwordTxtBox = new System.Windows.Forms.TextBox();
            this.usernameTxtBox = new System.Windows.Forms.TextBox();
            this.sifreLbl = new System.Windows.Forms.Label();
            this.kullaniciLbl = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.AutoSize = true;
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.showBtn);
            this.panel3.Controls.Add(this.hideBtn);
            this.panel3.Controls.Add(this.girisBtn);
            this.panel3.Controls.Add(this.passwordTxtBox);
            this.panel3.Controls.Add(this.usernameTxtBox);
            this.panel3.Controls.Add(this.sifreLbl);
            this.panel3.Controls.Add(this.kullaniciLbl);
            this.panel3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panel3.Location = new System.Drawing.Point(12, 143);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(454, 170);
            this.panel3.TabIndex = 9;
            // 
            // showBtn
            // 
            this.showBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(231)))));
            this.showBtn.BackgroundImage = global::Takip_Programı.Properties.Resources.showBtn;
            this.showBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.showBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showBtn.Location = new System.Drawing.Point(345, 69);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(25, 25);
            this.showBtn.TabIndex = 7;
            this.showBtn.UseVisualStyleBackColor = false;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // hideBtn
            // 
            this.hideBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(231)))));
            this.hideBtn.BackgroundImage = global::Takip_Programı.Properties.Resources.hideBtn;
            this.hideBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.hideBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hideBtn.Location = new System.Drawing.Point(345, 69);
            this.hideBtn.Name = "hideBtn";
            this.hideBtn.Size = new System.Drawing.Size(25, 25);
            this.hideBtn.TabIndex = 6;
            this.hideBtn.UseVisualStyleBackColor = false;
            this.hideBtn.Click += new System.EventHandler(this.hideBtn_Click);
            // 
            // girisBtn
            // 
            this.girisBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.girisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(236)))), ((int)(((byte)(221)))));
            this.girisBtn.FlatAppearance.BorderSize = 0;
            this.girisBtn.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.girisBtn.Location = new System.Drawing.Point(237, 110);
            this.girisBtn.Name = "girisBtn";
            this.girisBtn.Size = new System.Drawing.Size(86, 35);
            this.girisBtn.TabIndex = 4;
            this.girisBtn.Text = "Giriş";
            this.girisBtn.UseVisualStyleBackColor = false;
            this.girisBtn.Click += new System.EventHandler(this.girisBtn_Click);
            // 
            // passwordTxtBox
            // 
            this.passwordTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.passwordTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(231)))));
            this.passwordTxtBox.Location = new System.Drawing.Point(220, 69);
            this.passwordTxtBox.Multiline = true;
            this.passwordTxtBox.Name = "passwordTxtBox";
            this.passwordTxtBox.PasswordChar = '*';
            this.passwordTxtBox.Size = new System.Drawing.Size(150, 25);
            this.passwordTxtBox.TabIndex = 3;
            // 
            // usernameTxtBox
            // 
            this.usernameTxtBox.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.usernameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(247)))), ((int)(((byte)(231)))));
            this.usernameTxtBox.Location = new System.Drawing.Point(220, 22);
            this.usernameTxtBox.Multiline = true;
            this.usernameTxtBox.Name = "usernameTxtBox";
            this.usernameTxtBox.Size = new System.Drawing.Size(150, 25);
            this.usernameTxtBox.TabIndex = 2;
            // 
            // sifreLbl
            // 
            this.sifreLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.sifreLbl.AutoSize = true;
            this.sifreLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sifreLbl.Location = new System.Drawing.Point(165, 72);
            this.sifreLbl.Name = "sifreLbl";
            this.sifreLbl.Size = new System.Drawing.Size(49, 22);
            this.sifreLbl.TabIndex = 1;
            this.sifreLbl.Text = "Şifre :";
            // 
            // kullaniciLbl
            // 
            this.kullaniciLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.kullaniciLbl.AutoSize = true;
            this.kullaniciLbl.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.kullaniciLbl.Location = new System.Drawing.Point(109, 25);
            this.kullaniciLbl.Name = "kullaniciLbl";
            this.kullaniciLbl.Size = new System.Drawing.Size(105, 22);
            this.kullaniciLbl.TabIndex = 0;
            this.kullaniciLbl.Text = "Kullanıcı Adı :";
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(245)))), ((int)(((byte)(245)))), ((int)(((byte)(239)))));
            this.BackgroundImage = global::Takip_Programı.Properties.Resources.Özarpalı_uzun;
            this.ClientSize = new System.Drawing.Size(484, 411);
            this.Controls.Add(this.panel3);
            this.MaximumSize = new System.Drawing.Size(500, 450);
            this.Name = "Form_Login";
            this.Text = "Kullanıcı Giriş";
            this.Load += new System.EventHandler(this.Form_Login_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button girisBtn;
        private System.Windows.Forms.TextBox passwordTxtBox;
        private System.Windows.Forms.TextBox usernameTxtBox;
        private System.Windows.Forms.Label sifreLbl;
        private System.Windows.Forms.Label kullaniciLbl;
        private System.Windows.Forms.Button hideBtn;
        private System.Windows.Forms.Button showBtn;
    }
}