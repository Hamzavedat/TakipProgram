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
        ObservableCollection<ProductDefine> ProductDefine { get; set; }
        ObservableCollection<PumpDefine> PumpDefine { get; set; }
        private int SelectedPumpId { get; set; }
        private int SelectedProductId { get; set; }
        public Form_Settings()
        {
            InitializeComponent();
            LoadTheme();
            this.CenterToScreen();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResizeRedraw = false;
            ProductDefine = new ObservableCollection<ProductDefine>(context.ProductDefine.ToList());
            dataGridView.DataSource = ProductDefine;
            PumpDefine = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
            PumpGridView.DataSource = PumpDefine;
            yakitTurComBox.DataSource = context.ProductDefine.ToList();
            yakitTurComBox.DisplayMember = "Name";
            yakitTurComBox.ValueMember = "Id";
            yakitTurComBox.SelectedIndex = -1;
        }
        private void LoadTheme()
        {
            yeniBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            kayitBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            silBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            vazgecBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            pompakayitbtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            pompaduzenlebtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            pompasilbtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            pompavazgecbtn.BackColor = ColorTranslator.FromHtml("#5F939A");
        }
        private void yeniBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(urunNameTxtBox.Text))
            {
                MessageBox.Show("Ürün Adı Boş Bırakılamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(urunTurTxtBox.Text))
            {
                MessageBox.Show("Ürün Tipi Boş Bırakılamaz!");
                return;
            }
            #region texts null check
        /*    if (string.IsNullOrWhiteSpace(miktarTxtBox.Text))
            {
                MessageBox.Show("Ürün Miktarı Boş Bırakılamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(alisFiyatTxtBox.Text))
            {
                MessageBox.Show("Ürün Alış Fiyatı Boş Bırakılamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(satisFiyatTxtBox.Text))
            {
                MessageBox.Show("Ürün Satış Fiyatı Boş Bırakılamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(alisTutarTxtBox.Text))
            {
                MessageBox.Show("Ürün Alış Tutarı Boş Bırakılamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(satisTutarTxtBox.Text))
            {
                MessageBox.Show("Ürün Satış Tutarı Boş Bırakılamaz!");
                return;
            }*/
            #endregion
            var data = new ProductDefine()
            {
                Name = urunNameTxtBox.Text,
                Type = urunTurTxtBox.Text
            };
            try
            {
                try
                {
                    
                    data.Amount = Convert.ToDouble(miktarTxtBox.Text.Replace('.',','));
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrWhiteSpace(miktarTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen miktara sadece rakam giriniz!");
                        return;
                    }
                 
                }
                try
                {
                    data.BuyPrice = Convert.ToDouble(alisFiyatTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {
                   
                    if (!string.IsNullOrWhiteSpace(alisFiyatTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen alış fiyatına sadece rakam giriniz!");
                        return;
                    }
                }
                try
                {
                    data.SellPrice = Convert.ToDouble(satisFiyatTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {
                   
                    if (!string.IsNullOrWhiteSpace(satisFiyatTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen satış fiyatına sadece rakam giriniz!");
                        return;
                    }
                }
                try
                {
                    data.BuyAmount = Convert.ToDouble(alisTutarTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {
                  
                    if (!string.IsNullOrWhiteSpace(alisTutarTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen alış tutarına sadece rakam giriniz!");
                        return;
                    }
                }
                try
                {
                    data.SellAmount = Convert.ToDouble(satisTutarTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {
                  
                    if (!string.IsNullOrWhiteSpace(satisTutarTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen satış tutarına sadece rakam giriniz!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu tekrar deneyiniz!");
                return;
            }
         
            context.ProductDefine.Add(data);
            context.SaveChanges();
            ProductDefine = new ObservableCollection<ProductDefine>(context.ProductDefine.ToList());
            dataGridView.DataSource = ProductDefine;
            urunNameTxtBox.Text = null;
            idTxtBox.Text = null;
            urunTurTxtBox.Text = null;
            miktarTxtBox.Text = null;
            alisFiyatTxtBox.Text = null;
            satisFiyatTxtBox.Text = null;
            alisTutarTxtBox.Text = null;
            satisTutarTxtBox.Text = null;
        }
        private void silBtn_Click(object sender, EventArgs e)
        {
            var Warehouse = context.ProductDefine.FirstOrDefault(i => i.Id == Convert.ToInt16(idTxtBox.Text));
            context.ProductDefine.Remove(Warehouse);
            context.SaveChanges();
            ProductDefine = new ObservableCollection<ProductDefine>(context.ProductDefine.ToList());
            dataGridView.DataSource = ProductDefine;
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
            yeniBtn.Enabled = true;
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(urunNameTxtBox.Text))
            {
                MessageBox.Show("Ürün Adı Boş Bırakılamaz!");
                return;
            }
            if (string.IsNullOrWhiteSpace(urunTurTxtBox.Text))
            {
                MessageBox.Show("Ürün Tipi Boş Bırakılamaz!");
                return;
            }          
            var data = new ProductDefine()
            {
                Id = Convert.ToInt16(idTxtBox.Text),
                Name = urunNameTxtBox.Text,
                Type = urunTurTxtBox.Text
            };
            try
            {
                try
                {

                    data.Amount = Convert.ToDouble(miktarTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrWhiteSpace(miktarTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen miktara sadece rakam giriniz!");
                        return;
                    }

                }
                try
                {
                    data.BuyPrice = Convert.ToDouble(alisFiyatTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {

                    if (!string.IsNullOrWhiteSpace(alisFiyatTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen alış fiyatına sadece rakam giriniz!");
                        return;
                    }
                }
                try
                {
                    data.SellPrice = Convert.ToDouble(satisFiyatTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {

                    if (!string.IsNullOrWhiteSpace(satisFiyatTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen satış fiyatına sadece rakam giriniz!");
                        return;
                    }
                }
                try
                {
                    data.BuyAmount = Convert.ToDouble(alisTutarTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {

                    if (!string.IsNullOrWhiteSpace(alisTutarTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen alış tutarına sadece rakam giriniz!");
                        return;
                    }
                }
                try
                {
                    data.SellAmount = Convert.ToDouble(satisTutarTxtBox.Text.Replace('.', ','));
                }
                catch (Exception ex)
                {

                    if (!string.IsNullOrWhiteSpace(satisTutarTxtBox.Text))
                    {
                        MessageBox.Show("Lütfen satış tutarına sadece rakam giriniz!");
                        return;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu tekrar deneyiniz!");
                return;
            }

            context.ProductDefine.AsNoTracking();
            var current = context.ProductDefine.FirstOrDefault(i => i.Id == Convert.ToInt16(idTxtBox.Text));
            context.Entry(current).CurrentValues.SetValues(data);
            context.SaveChanges();
            ProductDefine = new ObservableCollection<ProductDefine>(context.ProductDefine.ToList());
            dataGridView.DataSource = ProductDefine;
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
            yeniBtn.Enabled = true;
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
            yeniBtn.Enabled = true;
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
                yeniBtn.Enabled = false;
            }
        }
        private void pompakayitbtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PompaAdıText.Text))
            {
                MessageBox.Show("Pompa İsmi Boş Geçilemez!");
                return;
            }
            var newpomp = new PumpDefine
            {
                Name = PompaAdıText.Text
            };
            try
            {
                if (!string.IsNullOrWhiteSpace(PompaEskiSayacText.Text))
                {
                    try
                    {
                        newpomp.LastCounter = Convert.ToDouble(PompaEskiSayacText.Text.Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Eski Sayaç İçin Sadece Rakam Giriniz!");
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(PompaYeniSayacText.Text))
                {
                    try
                    {
                        newpomp.NewCounter = Convert.ToDouble(PompaYeniSayacText.Text.Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Yeni Sayaç İçin Sadece Rakam Giriniz!");
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(PompaFarkText.Text))
                {
                    try
                    {
                        newpomp.Gap = Convert.ToDouble(PompaFarkText.Text.Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Fark İçin Sadece Rakam Giriniz!");
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(PompaTutarText.Text))
                {
                    try
                    {
                        newpomp.Total = Convert.ToDouble(PompaTutarText.Text.Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Tutar İçin Sadece Rakam Giriniz!");
                        return;
                    }
                }
                context.PumpDefine.Add(newpomp);
                context.SaveChanges();
                PumpDefine = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
                PumpGridView.DataSource = PumpDefine;
                PompaTutarText.Text = null;
                PompaEskiSayacText.Text = null;
                PompaYeniSayacText.Text = null;
                PompaAdıText.Text = null;
                PompaFarkText.Text = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir Hata Meydana Geldi!\nTekrar Deneyiniz");
                return;
            }
        }

        private void pompaduzenlebtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PompaAdıText.Text))
            {
                MessageBox.Show("Pompa İsmi Boş Geçilemez!");
                return;
            }
            var newpomp = new PumpDefine
            {
                Name = PompaAdıText.Text
            };
            try
            {
                if (!string.IsNullOrWhiteSpace(PompaEskiSayacText.Text))
                {
                    try
                    {
                        newpomp.LastCounter = Convert.ToDouble(PompaEskiSayacText.Text.Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Eski Sayaç İçin Sadece Rakam Giriniz!");
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(PompaYeniSayacText.Text))
                {
                    try
                    {
                        newpomp.NewCounter = Convert.ToDouble(PompaYeniSayacText.Text.Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Yeni Sayaç İçin Sadece Rakam Giriniz!");
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(PompaFarkText.Text))
                {
                    try
                    {
                        newpomp.Gap = Convert.ToDouble(PompaFarkText.Text.Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Fark İçin Sadece Rakam Giriniz!");
                        return;
                    }
                }
                if (!string.IsNullOrWhiteSpace(PompaTutarText.Text))
                {
                    try
                    {
                        newpomp.Total = Convert.ToDouble(PompaTutarText.Text.Replace(".", ","));
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Lütfen Tutar İçin Sadece Rakam Giriniz!");
                        return;
                    }
                }
                context.PumpDefine.AsNoTracking();
                var current = context.PumpDefine.FirstOrDefault(i => i.ID == SelectedPumpId);
                newpomp.ID = SelectedPumpId;
                context.Entry(current).CurrentValues.SetValues(newpomp);
                context.SaveChanges();
                PumpDefine = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
                PumpGridView.DataSource = PumpDefine;
                PompaTutarText.Text = null;
                PompaEskiSayacText.Text = null;
                PompaYeniSayacText.Text = null;
                PompaAdıText.Text = null;
                PompaFarkText.Text = null;
                pompaduzenlebtn.Enabled = false;
                pompavazgecbtn.Enabled = false;
                pompasilbtn.Enabled = false;
                pompakayitbtn.Enabled = true;

            }
            catch (Exception ex)
            {
                var message = ex.Message;
                MessageBox.Show(message, "HATA");
                return;
            }
        }

        private void pompavazgecbtn_Click(object sender, EventArgs e)
        {
            PompaTutarText.Text = null;
            PompaEskiSayacText.Text = null;
            PompaYeniSayacText.Text = null;
            PompaAdıText.Text = null;
            PompaFarkText.Text = null;
            pompaduzenlebtn.Enabled = false;
            pompavazgecbtn.Enabled = false;
            pompasilbtn.Enabled = false;
            pompakayitbtn.Enabled = true;

        }

        private void pompasilbtn_Click(object sender, EventArgs e)
        {
            var current = context.PumpDefine.FirstOrDefault(i => i.ID == SelectedPumpId);
            context.PumpDefine.Remove(current);
            context.SaveChanges();
            PumpDefine = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
            PumpGridView.DataSource = PumpDefine;
            PompaTutarText.Text = null;
            PompaEskiSayacText.Text = null;
            PompaYeniSayacText.Text = null;
            PompaAdıText.Text = null;
            PompaFarkText.Text = null;
            pompaduzenlebtn.Enabled = false;
            pompavazgecbtn.Enabled = false;
            pompasilbtn.Enabled = false;
            pompakayitbtn.Enabled = true;

        }

        private void PumpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PumpGridView.Rows[e.RowIndex];
                SelectedPumpId = Convert.ToInt16(row.Cells[0].Value.ToString());
                PompaAdıText.Text = row.Cells[1].Value.ToString();
                PompaEskiSayacText.Text = row.Cells[2].Value.ToString();
                PompaYeniSayacText.Text = row.Cells[3].Value.ToString();
                PompaFarkText.Text = row.Cells[4].Value.ToString();
                PompaTutarText.Text = row.Cells[5].Value.ToString();
                pompaduzenlebtn.Enabled = true;
                pompasilbtn.Enabled = true;
                pompavazgecbtn.Enabled = true;
                pompakayitbtn.Enabled = false;
            }
        }

        private void DepoYeniBtn_Click(object sender, EventArgs e)
        {

        }

        private void DepoDuzenleBtn_Click(object sender, EventArgs e)
        {

        }

        private void DepoVazgecBtn_Click(object sender, EventArgs e)
        {

        }

        private void DepoSilBtn_Click(object sender, EventArgs e)
        {

        }

        private void yakitTurComBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex != -1)
            {
                SelectedProductId = (int)(sender as ComboBox).SelectedValue;
            }
            else
            {
                SelectedProductId = new int();
            }
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedProductId = new int();
            SelectedPumpId = new int();
        }
    }
}
