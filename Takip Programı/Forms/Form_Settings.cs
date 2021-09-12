using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    public partial class Form_Settings : Form
    {
        TakipProgramiContext context = new TakipProgramiContext();

        ObservableCollection<WarehouseDefine> WarehouseDefine { get; set; }
        public Form_Settings()
        {
            InitializeComponent();
            LoadTheme();
            this.CenterToScreen();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResizeRedraw = false;
            WarehouseDefine = new ObservableCollection<WarehouseDefine>(context.WarehouseDefine.ToList());
            dataGridView.DataSource = WarehouseDefine;
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
            var data = new WarehouseDefine()
            {
                Name = urunNameTxtBox.Text,
                Type = urunTurTxtBox.Text,
                Amount = Convert.ToInt32(miktarTxtBox.Text),
                BuyPrice = Convert.ToInt32(alisFiyatTxtBox.Text),
                SellPrice = Convert.ToInt32(satisFiyatTxtBox.Text),
                BuyAmount = Convert.ToInt32(alisTutarTxtBox.Text),
                SellAmount = Convert.ToInt32(satisTutarTxtBox.Text),
            };
            context.WarehouseDefine.Add(data);
            context.SaveChanges();
            WarehouseDefine = new ObservableCollection<WarehouseDefine>(context.WarehouseDefine.ToList());
            dataGridView.DataSource = WarehouseDefine;
        }
        private void silBtn_Click(object sender, EventArgs e)
        {
            var Warehouse = context.WarehouseDefine.FirstOrDefault(i => i.Id == Convert.ToInt16(idTxtBox.Text));
            context.WarehouseDefine.Remove(Warehouse);
            context.SaveChanges();
            WarehouseDefine = new ObservableCollection<WarehouseDefine>(context.WarehouseDefine.ToList());
            dataGridView.DataSource = WarehouseDefine;
            urunNameTxtBox.Text = null;
            idTxtBox.Text = null;
            urunTurTxtBox.Text = null;
            miktarTxtBox.Text = null;
            alisFiyatTxtBox.Text = null;
            satisFiyatTxtBox.Text = null;
            alisTutarTxtBox.Text = null;
            satisTutarTxtBox.Text = null;
            kayitBtn.Enabled = false;
            vazgecBtn.Enabled = false;
            silBtn.Enabled = false;
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            var warehouse = new WarehouseDefine()
            {
                Id = Convert.ToInt16(idTxtBox.Text),
                Name = urunNameTxtBox.Text,
                Type = urunTurTxtBox.Text,
                Amount = Convert.ToInt32(miktarTxtBox.Text),
                BuyPrice = Convert.ToInt32(alisFiyatTxtBox.Text),
                SellPrice = Convert.ToInt32(satisFiyatTxtBox.Text),
                BuyAmount = Convert.ToInt32(alisTutarTxtBox.Text),
                SellAmount = Convert.ToInt32(satisTutarTxtBox.Text),
            };
            context.Customer.AsNoTracking();
            var current = context.WarehouseDefine.FirstOrDefault(i => i.Id == Convert.ToInt16(idTxtBox.Text));
            context.Entry(current).CurrentValues.SetValues(warehouse);
            context.SaveChanges();
            WarehouseDefine = new ObservableCollection<WarehouseDefine>(context.WarehouseDefine.ToList());
            dataGridView.DataSource = WarehouseDefine;
            urunNameTxtBox.Text = null;
            idTxtBox.Text = null;
            urunTurTxtBox.Text = null;
            miktarTxtBox.Text = null;
            alisFiyatTxtBox.Text = null;
            satisFiyatTxtBox.Text = null;
            alisTutarTxtBox.Text = null;
            satisTutarTxtBox.Text = null;
            kayitBtn.Enabled = false;
            vazgecBtn.Enabled = false;
            silBtn.Enabled = false;
        }
        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            urunNameTxtBox.Text = null;
            idTxtBox.Text = null;
            miktarTxtBox.Text = null;
            urunTurTxtBox.Text = null;
            alisFiyatTxtBox.Text = null;
            satisFiyatTxtBox.Text = null;
            alisTutarTxtBox.Text = null;
            satisTutarTxtBox.Text = null;
            kayitBtn.Enabled = false;
            vazgecBtn.Enabled = false;
            silBtn.Enabled = false;
        }
        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                idTxtBox.Text = row.Cells[0].Value.ToString();
                urunNameTxtBox.Text = row.Cells[1].Value.ToString();
                urunTurTxtBox.Text = row.Cells[2].Value.ToString();
                miktarTxtBox.Text = row.Cells[3].Value.ToString();
                alisFiyatTxtBox.Text = row.Cells[4].Value.ToString();
                satisFiyatTxtBox.Text = row.Cells[5].Value.ToString();
                alisTutarTxtBox.Text = row.Cells[6].Value.ToString();
                satisTutarTxtBox.Text = row.Cells[7].Value.ToString();                
                kayitBtn.Enabled = true;
                vazgecBtn.Enabled = true;
                silBtn.Enabled = true;
            }
        }

    }
}
