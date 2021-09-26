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
    public partial class Form_Cari : Form
    {
        TakipProgramiContext context = new TakipProgramiContext();
        private string SelectedId { get; set; }
        public Form_Cari()
        {
            InitializeComponent();
            LoadTheme();
            this.CenterToScreen();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResizeRedraw = false;
            var customers = context.Customer.OrderBy(x => x.Id).ToList();
            foreach (var item in customers)
            {
                nameComboBox.Items.Add(item.Name + " " + item.Surname);
                nameComboBox.Text = item.Id.ToString();
            }
        }
        private void LoadTheme()
        {
            yeniBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            kayitBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            silBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            vazgecBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item =  (ComboBox)sender;
            var data = context.Customer.OrderBy(x => x.Id).ToList()[item.SelectedIndex];
            mevkiTxtBox.Text = data.Position;
            adresTxtBox.Text = data.Adress;
            SelectedId = data.Id.ToString();
            cepTelTxtBox.Text = data.MobilePhone;
            riskTxtBox.Text = data.Risk;
            vergiDaireTxtBox.Text = data.VergiDairesi;
            vergiNoTxtBox.Text = data.VergiNo;
            fiyatComboBox.SelectedIndex = data.Change;
        }
    }
}
