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
            this.KeyPreview = true;
            this.CenterToScreen();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResizeRedraw = false;
            var customers = context.Customer.OrderBy(x => x.Id).ToList();
         
            nameComboBox.DataSource = customers;
            nameComboBox.DisplayMember = "NameAndSurname";
            nameComboBox.SelectedIndex = -1;
            this.KeyDown += Form_Cari_KeyDown;
        }

        private void Form_Cari_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    satisBtn_Click(satisBtn, new EventArgs());
                    break;
                case Keys.F2:
                    alisBtn_Click(alisBtn, new EventArgs());
                    break;
                case Keys.F3:
                    tahsilatBtn_Click(tahsilatBtn, new EventArgs());
                    break;
                case Keys.F4:
                    odemeBtn_Click(odemeBtn, new EventArgs());
                    break;
                default:
                    break;
            }
        }

        private void LoadTheme()
        {
            satisBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            alisBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            odemeBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            tahsilatBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
        }

        private void nameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = (ComboBox)sender;
            if (item.SelectedIndex == -1)
            {
                mevkiTxtBox.Text = string.Empty;
                adresTxtBox.Text = string.Empty;
                SelectedId = string.Empty;
                cepTelTxtBox.Text = string.Empty;
                riskTxtBox.Text = string.Empty;
                vergiDaireTxtBox.Text = string.Empty;
                vergiNoTxtBox.Text = string.Empty;
                fiyatComboBox.SelectedIndex = -1;
                return;
            }
            
            var data = context.Customer.OrderBy(x => x.Id).ToList()[item.SelectedIndex];
            mevkiTxtBox.Text = data.Position;
            adresTxtBox.Text = data.Adress;
            SelectedId = data.Id.ToString();
            cepTelTxtBox.Text = data.MobilePhone;
            riskTxtBox.Text = data.Risk.ToString();
            vergiDaireTxtBox.Text = data.VergiDairesi;
            vergiNoTxtBox.Text = data.VergiNo;
            fiyatComboBox.SelectedIndex = data.Change;
            satisBtn.Enabled = true;
            alisBtn.Enabled = true;
            tahsilatBtn.Enabled = true;
            odemeBtn.Enabled = true;
        }

        private void satisBtn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled)
            {

            }
        }

        private void alisBtn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled)
            {

            }
        }

        private void tahsilatBtn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled)
            {

            }
        }

        private void odemeBtn_Click(object sender, EventArgs e)
        {
            if ((sender as Button).Enabled)
            {

            }
        }
    }
}
