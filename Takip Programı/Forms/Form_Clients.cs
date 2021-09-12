using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
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
        TakipProgramiContext context = new TakipProgramiContext();
        public Form_Clients()
        {
            InitializeComponent();
            LoadTheme();
            this.CenterToParent();

            var customers = context.Customer.ToList();
            foreach (var item in customers)
            {
                ListViewItem itemlist = new ListViewItem(item.Name);
                itemlist.SubItems.Add(item.Surname);
                itemlist.SubItems.Add(item.Risk);
                itemlist.SubItems.Add(item.ChangeText);
                itemlist.SubItems.Add(item.Position);
                itemlist.SubItems.Add(item.Phone);
                itemlist.SubItems.Add(item.MobilePhone);
                itemlist.SubItems.Add(item.VergiDairesi);
                itemlist.SubItems.Add(item.VergiNo);
                itemlist.Name = item.Id.ToString();
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
            var customer = new Customer()
            {
                Name = adTxtBox.Text,
                Surname = soyadTxtBox.Text,
                Risk = riskTxtBox.Text,
                Change = fiyatComboBox.Text == "Etkilensin" ? 1 : 0,
                Position = mevkiTxtBox.Text,
                Phone = telTxtBox.Text,
                MobilePhone = cepTelTxtBox.Text,
                VergiDairesi = vergiDaireTxtBox.Text,
                VergiNo = vergiNoTxtBox.Text,
                Adress = adresTxtBox.Text
            };
            context.Customer.Add(customer);
            context.SaveChanges();
        }

        private void musteriListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var custo = context.Customer.ToList();
            var obj = sender as ListView;
            var data = obj.FocusedItem;
            var customer = custo.FirstOrDefault(x => x.Id.ToString() == data.Name);
            adTxtBox.Text = customer.Name;
            soyadTxtBox.Text = customer.Surname;
            riskTxtBox.Text = customer.Risk;
            mevkiTxtBox.Text = customer.Position;
            telTxtBox.Text = customer.Phone;
            cepTelTxtBox.Text = customer.MobilePhone;
            vergiDaireTxtBox.Text = customer.VergiDairesi;
            vergiNoTxtBox.Text = customer.VergiNo;
            adresTxtBox.Text = customer.Adress;

        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            var obj = sender as ListView;
            var data = obj.FocusedItem;
            var custo = context.Customer.FirstOrDefault(i => i.Id.ToString() == data.Name);
            context.Customer.Remove(custo);
            context.SaveChanges();

        }
    }
}
