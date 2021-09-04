using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            button1.BackColor = ColorTranslator.FromHtml("#3F51B5");
           // this.MaximumSize = this.Size;
          //  this.MinimumSize = this.Size;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button3.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button4.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button5.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button6.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button7.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button1.BackColor = ColorTranslator.FromHtml("#3F51B5");
            OpenChildForm(new Form_Clients(),sender);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button3.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button4.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button5.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button6.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button7.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button2.BackColor = ColorTranslator.FromHtml("#009688");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button4.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button5.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button6.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button7.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button3.BackColor = ColorTranslator.FromHtml("#FF5722");
            OpenChildForm(new Form_Pomp(), sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button3.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button5.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button6.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button7.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button4.BackColor = ColorTranslator.FromHtml("#607D8B");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button3.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button4.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button6.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button7.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button5.BackColor = ColorTranslator.FromHtml("#FF9800");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button3.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button4.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button5.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button7.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button6.BackColor = ColorTranslator.FromHtml("#9C27B0");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button1.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button2.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button3.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button4.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button5.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button6.BackColor = System.Drawing.Color.FromArgb(51, 51, 76);
            button7.BackColor = ColorTranslator.FromHtml("#2196F3");
        }







        /*   private void button1_Click(object sender, EventArgs e)
           {
               this.Hide();
               Sale f2 = new Sale(); //this is the change, code for redirect  
               f2.ShowDialog();
           }*/
    }
}
