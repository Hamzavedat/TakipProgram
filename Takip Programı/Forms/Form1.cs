using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takip_Programı.Forms;
using Takip_Programı.Models;

namespace Takip_Programı
{
    public partial class Form1 : Form
    {
        private Form activeForm;
        private Form newform { get; set; }

        public Form1()
        {
            InitializeComponent();
            this.CenterToScreen();
        }
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            //  ActiveButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(childForm);
            this.panel2.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            //labelTitle.Text = childForm.Text;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // this.MaximumSize = this.Size;
              this.MinimumSize = new Size(this.Size.Width-100, 350);
            timer1.Start();
            //ustPanel.Visible = false;
        }

        private void musteriBtn_Click(object sender, EventArgs e)
        {
            psatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            pompaBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            depoBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            kksatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            stokBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            ayarlarBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            musteriBtn.BackColor = ColorTranslator.FromHtml("#3DB2FF");
            //            OpenChildForm(new Form_Clients(), sender);
            if (newform != null)
            {
                newform.Close();
            }
            newform = new Form_Clients();
            newform.ShowDialog();
        }

        private void psatisBtn_Click(object sender, EventArgs e)
        {
            musteriBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            pompaBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            depoBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            kksatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            stokBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            ayarlarBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            psatisBtn.BackColor = ColorTranslator.FromHtml("#66DE93");
        }

        private void pompaBtn_Click(object sender, EventArgs e)
        {
            musteriBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            psatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            depoBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            kksatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            stokBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            ayarlarBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            pompaBtn.BackColor = ColorTranslator.FromHtml("#FFF47D");
            if (newform != null)
            {
                newform.Close();
            }
            newform = new Form_Pomp();
            newform.ShowDialog();
        }

        private void depoBtn_Click(object sender, EventArgs e)
        {
            musteriBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            psatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            pompaBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            kksatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            stokBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            ayarlarBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            depoBtn.BackColor = ColorTranslator.FromHtml("#FFE6E6");
        }

        private void kksatisBtn_Click(object sender, EventArgs e)
        {
            musteriBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            psatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            pompaBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            depoBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            stokBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            ayarlarBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            kksatisBtn.BackColor = ColorTranslator.FromHtml("#F3F2C9");
        }

        private void stokBtn_Click(object sender, EventArgs e)
        {
            musteriBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            psatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            pompaBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            depoBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            kksatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            ayarlarBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            stokBtn.BackColor = ColorTranslator.FromHtml("#B2B1B9");
        }

        private void ayarlarBtn_Click(object sender, EventArgs e)
        {
            musteriBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            psatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            pompaBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            depoBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            kksatisBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            stokBtn.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            ayarlarBtn.BackColor = ColorTranslator.FromHtml("#B5EAEA");
            if (newform != null)
            {
                newform.Close();
            }
            newform = new Form_Settings();
            newform.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var culture = CultureInfo.GetCultureInfo("tr-TR");
            var date = DateTime.Now.ToString("dd.MM.yyyy", culture);
            var hour = DateTime.Now.ToString("HH:mm:ss", culture);
            label1.Text = "Tarih: " + date +"\nSaat: " + hour;
        }

        /*   private void button1_Click(object sender, EventArgs e)
           {
               this.Hide();
               Sale f2 = new Sale(); //this is the change, code for redirect  
               f2.ShowDialog();
           }*/
    }
}
