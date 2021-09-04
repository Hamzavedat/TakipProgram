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

namespace Takip_Programı.Forms
{
    public partial class Form_Clients : Form
    {
        private List<Customer> customers { get; set; }

        public Form_Clients()
        {
            InitializeComponent();
            customers = new List<Customer>();

            for (int i = 0; i < 30; i++)
            {
                customers.Add(new Customer { ID = i, Name = "İsim " + i.ToString(), SurName = "Soy İsim " + i.ToString(), Change = true, MobilePhone = "05555555555", Phone = "1234567890", Risk = "500000", Position = "Merkez" });

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

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void ListView1_SelectedIndexChanged(object sender, System.EventArgs e)
        {
            var obj = sender as ListView;
            var data = obj.FocusedItem;
            var customer = customers.FirstOrDefault(x => x.ID.ToString() == data.Name);
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
            comboBox1.SelectedIndex = customer.Change ? 0 : 1;
        }
    }
}
