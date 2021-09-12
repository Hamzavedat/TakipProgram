using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

        ObservableCollection<Customer> customers { get; set; }
        public Form_Clients()
        {
            InitializeComponent();
            LoadTheme();
            this.CenterToParent();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResizeRedraw = false;
            customers = new ObservableCollection<Customer>( context.Customer.ToList());
            dataGridView.DataSource = customers;
           /* for (int i = 0; i < customers.Count(); i++)
            {
                
                var datagrid = new DataGridViewRow();
                datagrid.Cells.Add(new DataGridViewCellCollection { Value = customers[i].Id.ToString()});
                datagrid.Cells[0].Value = customers[i].Id.ToString();
                datagrid.Cells[1].Value = customers[i].Name.ToString();
                datagrid.Cells[2].Value = customers[i].Surname.ToString();
                datagrid.Cells[3].Value = customers[i].Risk.ToString();
                datagrid.Cells[4].Value = customers[i].ChangeText.ToString();
                datagrid.Cells[5].Value = customers[i].Position.ToString();
                datagrid.Cells[6].Value = customers[i].Phone.ToString();
                datagrid.Cells[7].Value = customers[i].MobilePhone.ToString();
                datagrid.Cells[8].Value = customers[i].VergiDairesi.ToString();
                datagrid.Cells[9].Value = customers[i].VergiNo.ToString();
                datagrid.Cells[10].Value = customers[i].Adress.ToString();
                dataGridView.Rows.Add(datagrid);
            }*/
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
            var data = new Customer()
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
            context.Customer.Add(data);
            context.SaveChanges();
            customers = new ObservableCollection<Customer>(context.Customer.ToList());
            dataGridView.DataSource = customers;
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            var custo = context.Customer.FirstOrDefault(i => i.Id == Convert.ToInt16(idTxtBox.Text));
            context.Customer.Remove(custo);
            context.SaveChanges();
            customers = new ObservableCollection<Customer>(context.Customer.ToList());
            dataGridView.DataSource = customers;
            adTxtBox.Text = null;
            idTxtBox.Text = null;
            soyadTxtBox.Text = null;
            riskTxtBox.Text = null;
            fiyatComboBox.Text = null;
            mevkiTxtBox.Text = null;
            telTxtBox.Text = null;
            cepTelTxtBox.Text = null;
            vergiDaireTxtBox.Text = null;
            vergiNoTxtBox.Text = null;
            adresTxtBox.Text = null;
            kayitBtn.Enabled = false;
            vazgecBtn.Enabled = false;
            silBtn.Enabled = false;
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            var customer = new Customer()
            {
                Id = Convert.ToInt16(idTxtBox.Text),
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
            context.Customer.AsNoTracking();
            var current = context.Customer.FirstOrDefault(i => i.Id == Convert.ToInt16(idTxtBox.Text));
            context.Entry(current).CurrentValues.SetValues(customer);
            context.SaveChanges();
            customers = new ObservableCollection<Customer>(context.Customer.ToList());
            dataGridView.DataSource = customers;
            adTxtBox.Text = null;
            idTxtBox.Text = null;
            soyadTxtBox.Text = null;
            riskTxtBox.Text = null;
            fiyatComboBox.Text = null;
            mevkiTxtBox.Text = null;
            telTxtBox.Text = null;
            cepTelTxtBox.Text = null;
            vergiDaireTxtBox.Text = null;
            vergiNoTxtBox.Text = null;
            adresTxtBox.Text = null;
            kayitBtn.Enabled = false;
            vazgecBtn.Enabled = false;
            silBtn.Enabled = false;
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            adTxtBox.Text = null;
            idTxtBox.Text = null;
            soyadTxtBox.Text = null;
            riskTxtBox.Text = null;
            fiyatComboBox.Text = null;
            mevkiTxtBox.Text = null;
            telTxtBox.Text = null;
            cepTelTxtBox.Text = null;
            vergiDaireTxtBox.Text = null;
            vergiNoTxtBox.Text = null;
            adresTxtBox.Text = null;
            kayitBtn.Enabled = false;
            vazgecBtn.Enabled = false;
            silBtn.Enabled = false;
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex>=0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                adTxtBox.Text = row.Cells[1].Value.ToString();
                soyadTxtBox.Text = row.Cells[2].Value.ToString();
                riskTxtBox.Text = row.Cells[3].Value.ToString();
                fiyatComboBox.SelectedIndex = Convert.ToInt32(row.Cells[4].Value.ToString());
                mevkiTxtBox.Text = row.Cells[5].Value.ToString();
                telTxtBox.Text = row.Cells[6].Value.ToString();
                cepTelTxtBox.Text = row.Cells[7].Value.ToString();
                vergiDaireTxtBox.Text = row.Cells[8].Value.ToString();
                vergiNoTxtBox.Text = row.Cells[9].Value.ToString();
                adresTxtBox.Text = row.Cells[10].Value.ToString();
                idTxtBox.Text = row.Cells[0].Value.ToString();
                kayitBtn.Enabled = true;
                vazgecBtn.Enabled = true;
                silBtn.Enabled = true;
            }
        }
       
    }
}
