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
            LoadTheme();
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
                musteriListView.Items.Add(itemlist);
            }
        }

        private void LoadTheme()
        {
            yeniBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            kayitBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            silBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            vazgecBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
        }

        private void yeniBtn_Click(object sender, EventArgs e)
        {

        }

        private void musteriListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var obj = sender as ListView;
            var data = obj.FocusedItem;
            var customer = customers.FirstOrDefault(x => x.ID.ToString() == data.Name);
            adTxtBox.Text = customer.Name;
            soyadTxtBox.Text = customer.SurName;
            riskTxtBox.Text = customer.Risk;
            mevkiTxtBox.Text = customer.Position;
            telTxtBox.Text = customer.Phone;
            cepTelTxtBox.Text = customer.MobilePhone;
            vergiDaireTxtBox.Text = customer.VergiDairesi;
            vergiNoTxtBox.Text = customer.VergiNo;
            adresTxtBox.Text = customer.Adress;
            adresTxtBox.Text = customer.Adress;
            fiyatComboBox.SelectedIndex = customer.Change ? 0 : 1;

        }
    }
}
