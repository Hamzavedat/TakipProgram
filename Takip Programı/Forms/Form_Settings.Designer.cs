
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
            this.bilgilerimPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // bilgilerimPanel
            // 
            this.bilgilerimPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.bilgilerimPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.bilgilerimPanel.Location = new System.Drawing.Point(0, 0);
            this.bilgilerimPanel.Name = "bilgilerimPanel";
            this.bilgilerimPanel.Size = new System.Drawing.Size(800, 156);
            this.bilgilerimPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 294);
            this.panel1.TabIndex = 1;
            // 
            // Form_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bilgilerimPanel);
            this.Name = "Form_Settings";
            this.Text = "Form_Settings";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bilgilerimPanel;
        private System.Windows.Forms.Panel panel1;
    }
}