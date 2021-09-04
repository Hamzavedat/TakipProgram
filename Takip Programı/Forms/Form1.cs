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

        public Form1()
        {
            InitializeComponent();


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
            //  this.MinimumSize = this.Size;
            timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button3.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button4.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button5.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button6.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button7.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button1.BackColor = ColorTranslator.FromHtml("#3DB2FF");
            OpenChildForm(new Form_Clients(), sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button3.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button4.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button5.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button6.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button7.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button2.BackColor = ColorTranslator.FromHtml("#66DE93");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button2.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button4.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button5.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button6.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button7.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button3.BackColor = ColorTranslator.FromHtml("#FFF47D");
            OpenChildForm(new Form_Pomp(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button2.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button3.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button5.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button6.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button7.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button4.BackColor = ColorTranslator.FromHtml("#FFE6E6");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button2.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button3.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button4.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button6.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button7.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button5.BackColor = ColorTranslator.FromHtml("#F3F2C9");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button2.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button3.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button4.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button5.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button7.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button6.BackColor = ColorTranslator.FromHtml("#B2B1B9");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button2.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button3.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button4.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button5.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button6.BackColor = System.Drawing.Color.FromArgb(212, 236, 221);
            button7.BackColor = ColorTranslator.FromHtml("#B5EAEA");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            var culture = CultureInfo.GetCultureInfo("tr-TR");
            var date = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss", culture);
            label1.Text = "Tarih: " + date;
        }

        /*   private void button1_Click(object sender, EventArgs e)
           {
               this.Hide();
               Sale f2 = new Sale(); //this is the change, code for redirect  
               f2.ShowDialog();
           }*/
    }
}
