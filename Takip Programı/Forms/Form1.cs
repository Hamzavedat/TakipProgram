using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takip_Programı.Models;

namespace Takip_Programı
{
    public partial class Form1 : Form
    {
        private List<Customer> customers { get; set; }
        public Form1()
        {
            InitializeComponent();
            customers = new List<Customer>();
            for (int i = 0; i < 30; i++)
            {
                customers.Add(new Customer { ID = i, Name = "İsim "+i.ToString(), SurName = "Soy İsim "+i.ToString(), Change = true, MobilePhone = "05555555555", Phone = "1234567890", Risk = "500000", Position="Merkez"  });

            }
            foreach (var item in customers)
            {
                ListViewItem itemlist = new ListViewItem(item.Name);
                itemlist.SubItems.Add(item.SurName);
                itemlist.SubItems.Add(item.Risk);
                itemlist.SubItems.Add(item.ChangeText);
                itemlist.SubItems.Add(item.Position);
                itemlist.SubItems.Add(item.Phone);
                itemlist.SubItems.Add(item.MobilePhone);
                itemlist.SubItems.Add(item.VergiDairesi);
                itemlist.SubItems.Add(item.VergiNo);
                itemlist.Name = item.ID.ToString();
                listView1.Items.Add(itemlist);
            }
            
        }

        private void ListView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var obj = sender as ListView;
            var data = obj.FocusedItem;
            var customer = customers.FirstOrDefault(x=>x.ID.ToString() == data.Name);
            textBox1.Text = customer.Name;
            textBox2.Text = customer.SurName;
            textBox3.Text = customer.Risk;
            textBox5.Text = customer.Position;
            textBox4.Text = customer.Phone;
            textBox8.Text = customer.MobilePhone;
            textBox7.Text = customer.VergiDairesi;
            textBox6.Text = customer.VergiNo;
            textBox9.Text = customer.Adress;
            textBox9.Text = customer.Adress;
            comboBox1.SelectedIndex = customer.Change?0:1;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            button1.BackColor = ColorTranslator.FromHtml("#3F51B5");
            this.MaximumSize = this.Size;
            this.MinimumSize = this.Size;
            
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
            
            TabPage1.Visible = true;
          
            
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
            TabPage1.Visible = false;
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
            TabPage1.Visible = false;

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
            TabPage1.Visible = false;
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
            TabPage1.Visible = false;
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
            TabPage1.Visible = false;
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
            TabPage1.Visible = false;
        }







        /*   private void button1_Click(object sender, EventArgs e)
           {
               this.Hide();
               Sale f2 = new Sale(); //this is the change, code for redirect  
               f2.ShowDialog();
           }*/
    }
}
