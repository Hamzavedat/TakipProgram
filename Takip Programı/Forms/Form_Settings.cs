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
        ObservableCollection<WareHouse> WareHouseDefine { get; set; }
        private int? SelectedWareHouseId { get; set; }
        private int? SelectedProductId { get; set; }
        public Form_Settings()
        {
            InitializeComponent();
            LoadTheme();
            this.CenterToScreen();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResizeRedraw = false;

            // Product Data Source
            ProductDefine = new ObservableCollection<ProductDefine>(context.ProductDefine.ToList());
            dataGridView.DataSource = ProductDefine;


            // Warehouse Data Source
            WareHouseDefine = new ObservableCollection<WareHouse>(context.WareHouseDefine.ToList());
            depoGridView.DataSource = WareHouseDefine.Select(c =>
                new
                {
                    WareHouseName = c.WareHouseName,
                    WareHouseVolume = c.WareHouseVolume,
                    WareHouseStock = c.WareHouseStock,
                    Id = c.Id,
                    SellPrice = c.ProductDefine.SellPrice,
                    ProductDefine = c.ProductDefine.Type
                }).ToList();

            // Pump Data Source
            PumpDefine = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
            PumpGridView.DataSource = PumpDefine.Select(c =>
                new
                {
                    Id = c.Id,
                    PumpName = c.PumpName,
                    InitialCounter = c.InitialCounter,
                    pompaSatisFiyati = c.WareHouse.ProductDefine.SellPrice,
                    WareHouse = c.WareHouse.WareHouseName
                }).ToList();

            // Product Data Source in Warehouse
            yakitTurComBox.DataSource = context.ProductDefine.ToList();
            yakitTurComBox.DisplayMember = "Type";
            yakitTurComBox.ValueMember = "Id";
            yakitTurComBox.SelectedIndex = -1;

            // Warehouse Data Source in Pump
            depoComboBox.DataSource = context.WareHouseDefine.ToList();
            depoComboBox.DisplayMember = "WareHouseName";
            depoComboBox.ValueMember = "Id";
            depoComboBox.SelectedIndex = -1;
        }

        // Theme Functions
        private void LoadTheme()
        {
            //Product Buttons
            yeniBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            kayitBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            silBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            vazgecBtn.BackColor = ColorTranslator.FromHtml("#5F939A");

            //Warehouse Buttons
            DepoYeniBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            DepoDuzenleBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            DepoVazgecBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            DepoSilBtn.BackColor = ColorTranslator.FromHtml("#5F939A");

            //Pump Buttons
            pompakayitbtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            pompaduzenlebtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            pompasilbtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            pompavazgecbtn.BackColor = ColorTranslator.FromHtml("#5F939A");
        }



        //Products Functions
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

            var data = new ProductDefine()
            {
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



        //Warehouse Functions
        private void DepoYeniBtn_Click(object sender, EventArgs e)
        {
            var productId = SelectedProductId;
            if (productId == null || productId == 0)
            {
                MessageBox.Show("Lütfen Yakıt ve Yağ Türünü Seçiniz!");
                return;
            }
            if (string.IsNullOrEmpty(depoAdiTxtBox.Text))
            {
                MessageBox.Show("Lütfen Depo Adını Giriniz!");
                return;
            }
            else
            {
                try
                {
                    try
                    {
                        var convertTry = Convert.ToInt32(DepoStokTxtBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lütfen Depo Hacmine Sadece Sayı Giriniz!");
                        return;
                    }
                    try
                    {
                        var convertTry = Convert.ToInt32(DepoHacmiTxtBox.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Lütfen Depo Stokuna Sadece Sayı Giriniz!");
                        return;
                    }
                    var product = context.ProductDefine.FirstOrDefault(i => i.Id == productId);
                    var warehouse = new WareHouse()
                    {
                        ProductDefine = product,
                        WareHouseName = depoAdiTxtBox.Text,
                        WareHouseStock = Convert.ToInt32(DepoStokTxtBox.Text),
                        WareHouseVolume = Convert.ToInt32(DepoHacmiTxtBox.Text),
                    };
                    context.WareHouseDefine.Add(warehouse);
                    context.SaveChanges();
                    WareHouseDefine = new ObservableCollection<WareHouse>(context.WareHouseDefine.ToList());
                    depoGridView.DataSource = WareHouseDefine.Select(c =>
                        new
                        {
                            WareHouseName = c.WareHouseName,
                            WareHouseVolume = c.WareHouseVolume,
                            WareHouseStock = c.WareHouseStock,
                            Id = c.Id,
                            SellPrice = c.ProductDefine.SellPrice,
                            ProductDefine = c.ProductDefine.Type
                        }).ToList();
                    depoIdTextBox.Text = null;
                    yakitTurComBox.Text = null;
                    depoAdiTxtBox.Text = null;
                    DepoHacmiTxtBox.Text = null;
                    DepoStokTxtBox.Text = null;
                    DepoDuzenleBtn.Enabled = false;
                    DepoVazgecBtn.Enabled = false;
                    DepoSilBtn.Enabled = false;
                    DepoYeniBtn.Enabled = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                    return;
                }
                
            }

        }
        private void DepoDuzenleBtn_Click(object sender, EventArgs e)
        {
            var productId = SelectedProductId;
            var currentWare = context.WareHouseDefine.FirstOrDefault(i=>i.Id==Convert.ToInt32(depoIdTextBox.Text));
            if (currentWare != null)
            {
                if (productId == null || productId == 0)
                {
                    MessageBox.Show("Lütfen Yakıt ve Yağ Türünü Seçiniz!");
                    return;
                }
                if (string.IsNullOrEmpty(depoAdiTxtBox.Text))
                {
                    MessageBox.Show("Lütfen Depo Adını Giriniz!");
                    return;
                }
                else
                {
                    try
                    {
                        try
                        {
                            var convertTry = Convert.ToInt32(DepoStokTxtBox.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lütfen Depo Hacmine Sadece Sayı Giriniz!");
                            return;
                        }
                        try
                        {
                            var convertTry = Convert.ToInt32(DepoHacmiTxtBox.Text);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Lütfen Depo Stokuna Sadece Sayı Giriniz!");
                            return;
                        }
                        var product = context.ProductDefine.FirstOrDefault(i => i.Id == productId);
                        var warehouse = new WareHouse()
                        {
                            ProductDefine = product,
                            WareHouseName = depoAdiTxtBox.Text,
                            WareHouseStock = Convert.ToInt32(DepoStokTxtBox.Text),
                            WareHouseVolume = Convert.ToInt32(DepoHacmiTxtBox.Text),
                        };
                        currentWare.ProductDefine = product;
                        currentWare.WareHouseName = warehouse.WareHouseName;
                        currentWare.WareHouseStock = warehouse.WareHouseStock;
                        currentWare.WareHouseVolume = warehouse.WareHouseVolume;
                        context.SaveChanges();
                        WareHouseDefine = new ObservableCollection<WareHouse>(context.WareHouseDefine.ToList());
                        depoGridView.DataSource = WareHouseDefine.Select(c =>
                            new
                            {
                                WareHouseName = c.WareHouseName,
                                WareHouseVolume = c.WareHouseVolume,
                                WareHouseStock = c.WareHouseStock,
                                Id = c.Id,
                                SellPrice = c.ProductDefine.SellPrice,
                                ProductDefine = c.ProductDefine.Type
                            }).ToList();
                        depoIdTextBox.Text = null;
                        yakitTurComBox.Text = null;
                        depoAdiTxtBox.Text = null;
                        DepoHacmiTxtBox.Text = null;
                        DepoStokTxtBox.Text = null;
                        DepoDuzenleBtn.Enabled = false;
                        DepoVazgecBtn.Enabled = false;
                        DepoSilBtn.Enabled = false;
                        DepoYeniBtn.Enabled = true;
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                return;
            }
            
        }
        private void DepoVazgecBtn_Click(object sender, EventArgs e)
        {
            depoIdTextBox.Text = null;
            yakitTurComBox.Text = null;
            depoAdiTxtBox.Text = null;
            DepoHacmiTxtBox.Text = null;
            DepoStokTxtBox.Text = null;
            DepoDuzenleBtn.Enabled = false;
            DepoVazgecBtn.Enabled = false;
            DepoSilBtn.Enabled = false;
            DepoYeniBtn.Enabled = true;
        }
        private void DepoSilBtn_Click(object sender, EventArgs e)
        {
            var currentWare = context.WareHouseDefine.FirstOrDefault(i => i.Id == Convert.ToInt32(depoIdTextBox.Text));
            if (currentWare != null)
            {
                context.WareHouseDefine.Remove(currentWare);
                context.SaveChanges();
                WareHouseDefine = new ObservableCollection<WareHouse>(context.WareHouseDefine.ToList());
                depoGridView.DataSource = WareHouseDefine.Select(c =>
                    new
                    {
                        WareHouseName = c.WareHouseName,
                        WareHouseVolume = c.WareHouseVolume,
                        WareHouseStock = c.WareHouseStock,
                        Id = c.Id,
                        SellPrice = c.ProductDefine.SellPrice,
                        ProductDefine = c.ProductDefine.Type
                    }).ToList();
                depoIdTextBox.Text = null;
                yakitTurComBox.Text = null;
                depoAdiTxtBox.Text = null;
                DepoHacmiTxtBox.Text = null;
                DepoStokTxtBox.Text = null;
                DepoDuzenleBtn.Enabled = false;
                DepoVazgecBtn.Enabled = false;
                DepoSilBtn.Enabled = false;
                DepoYeniBtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                return;
            }
           
        }
        private void depoGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.depoGridView.Rows[e.RowIndex];
                depoIdTextBox.Text = row.Cells[3].Value.ToString();
                yakitTurComBox.Text = row.Cells[5].Value.ToString();
                depoAdiTxtBox.Text = row.Cells[0].Value.ToString();
                DepoHacmiTxtBox.Text = row.Cells[2].Value.ToString();
                DepoStokTxtBox.Text = row.Cells[1].Value.ToString();
                DepoDuzenleBtn.Enabled = true;
                DepoVazgecBtn.Enabled = true;
                DepoSilBtn.Enabled = true;
                DepoYeniBtn.Enabled = false;
            }
        }

        // Selected Product Id in Warehouse
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



        //Pump Functions
        private void pompakayitbtn_Click(object sender, EventArgs e)
        {
            var wareId = SelectedWareHouseId;
            if (wareId == null || wareId == 0)
            {
                MessageBox.Show("Lütfen Yakıt ve Yağ Türünü Seçiniz!");
                return;
            }
            if (string.IsNullOrEmpty(pompaName.Text))
            {
                MessageBox.Show("Lütfen Pompa Adını Giriniz!");
                return;
            }
            else
            {
                try
                {
                    var initialCounter = Convert.ToDouble(baslangicSayac.Text.Replace('.', ','));
                    var ware = context.WareHouseDefine.FirstOrDefault(i => i.Id == wareId);
                    var pump = new PumpDefine()
                    {
                        PumpName = pompaName.Text,
                        InitialCounter = Convert.ToDouble(baslangicSayac.Text.Replace('.', ',')),
                        WareHouse = ware
                    };
                    context.PumpDefine.Add(pump);
                    context.SaveChanges();
                    PumpDefine = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
                    PumpGridView.DataSource = PumpDefine.Select(c =>
                        new
                        {
                            Id = c.Id,
                            PumpName = c.PumpName,
                            InitialCounter = c.InitialCounter,
                            pompaSatisFiyati = c.WareHouse.ProductDefine.SellPrice,
                            WareHouse = c.WareHouse.WareHouseName,
                            Counter = c.Counter
                        }).ToList();
                    pumpIdTextBox.Text = null;
                    depoComboBox.Text = null;
                    pompaName.Text = null;
                    baslangicSayac.Text = null;
                    satisFiyatTxtBox.Text = null;
                }
                catch (Exception ex)
                {
                    if (!string.IsNullOrWhiteSpace(baslangicSayac.Text))
                    {
                        MessageBox.Show("Lütfen başlangıç sayaç no'ya sadece sayı giriniz!");
                        return;
                    }

                }                
            }
        }
        private void pompaduzenlebtn_Click(object sender, EventArgs e)
        {
            var pumpDefine = context.PumpDefine.FirstOrDefault(i => i.Id == Convert.ToInt32(pumpIdTextBox.Text));
            var wareId = SelectedWareHouseId;
            if (wareId == null || wareId == 0)
            {
                MessageBox.Show("Lütfen Yakıt ve Yağ Türünü Seçiniz!");
                return;
            }
            if (string.IsNullOrEmpty(pompaName.Text))
            {
                MessageBox.Show("Lütfen Pompa Adını Giriniz!");
                return;
            }
            if (pumpDefine != null)
            {
                try
                {
                    var initialCounter = Convert.ToDouble(baslangicSayac.Text.Replace('.', ','));
                    var ware = context.WareHouseDefine.FirstOrDefault(i => i.Id == wareId);
                    var pump = new PumpDefine()
                    {
                        Id = Convert.ToInt32(pumpIdTextBox.Text),
                        PumpName = pompaName.Text,
                        WareHouse = ware, 
                        Counter = pumpDefine.Counter
                    };
                    try
                    {
                        pump.InitialCounter = Convert.ToDouble(baslangicSayac.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(baslangicSayac.Text))
                        {
                            MessageBox.Show("Lütfen tutara sadece sayı giriniz!");
                            return;
                        }
                    }
                    pumpDefine.PumpName = pump.PumpName;
                    pumpDefine.InitialCounter = pump.InitialCounter;
                    pumpDefine.WareHouse = pump.WareHouse; 
                    context.SaveChanges();
                    PumpDefine = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
                    PumpGridView.DataSource = PumpDefine.Select(c =>
                        new
                        {
                            Id = c.Id,
                            PumpName = c.PumpName,
                            InitialCounter = c.InitialCounter,
                            pompaSatisFiyati = c.WareHouse.ProductDefine.SellPrice,
                            WareHouse = c.WareHouse.WareHouseName
                        }).ToList();
                    pumpIdTextBox.Text = null;
                    depoComboBox.Text = null;
                    pompaName.Text = null;
                    baslangicSayac.Text = null;
                    satisFiyatTxtBox.Text = null;
                    pompasilbtn.Enabled = false;
                    pompaduzenlebtn.Enabled = false;
                    pompavazgecbtn.Enabled = false;
                    pompakayitbtn.Enabled = true;
                }
                catch (Exception ex)
                {
                    var a = ex;
                    MessageBox.Show(ex.Message);
                    if (!string.IsNullOrWhiteSpace(baslangicSayac.Text))
                    {
                        MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                        return;
                    }

                }
            }
            else
            {
                MessageBox.Show("Lütfen Boş değerler girmeyiniz!");
                return;
            }
        }
        private void pompavazgecbtn_Click(object sender, EventArgs e)
        {
            pumpIdTextBox.Text = null;
            depoComboBox.Text = null;
            pompaName.Text = null;
            baslangicSayac.Text = null;
            satisFiyatTxtBox.Text = null;
            pompasilbtn.Enabled = false;
            pompaduzenlebtn.Enabled = false;
            pompavazgecbtn.Enabled = false;
            pompakayitbtn.Enabled = true;
        }
        private void pompasilbtn_Click(object sender, EventArgs e)
        {
            var pumpDefine = context.PumpDefine.FirstOrDefault(i => i.Id == Convert.ToInt32(pumpIdTextBox.Text));
            if (pumpDefine != null)
            {
                context.PumpDefine.Remove(pumpDefine);
                context.SaveChanges();
                PumpDefine = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
                PumpGridView.DataSource = PumpDefine.Select(c =>
                    new
                    {
                        Id = c.Id,
                        PumpName = c.PumpName,
                        InitialCounter = c.InitialCounter,
                        pompaSatisFiyati = c.WareHouse.ProductDefine.SellPrice,
                        WareHouse = c.WareHouse.WareHouseName
                    }).ToList();
                pumpIdTextBox.Text = null;
                depoComboBox.Text = null;
                pompaName.Text = null;
                baslangicSayac.Text = null;
                satisFiyatTxtBox.Text = null;
                pompasilbtn.Enabled = false;
                pompaduzenlebtn.Enabled = false;
                pompavazgecbtn.Enabled = false;
                pompakayitbtn.Enabled = true;
            }
            else
            {
                MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                return;
            }

        }
        private void PumpGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.PumpGridView.Rows[e.RowIndex];
                pumpIdTextBox.Text = row.Cells[1].Value.ToString();
                depoComboBox.Text = row.Cells[5].Value.ToString();
                pompaName.Text = row.Cells[2].Value.ToString();
                baslangicSayac.Text = row.Cells[3].Value.ToString();
                pompasilbtn.Enabled = true;
                pompaduzenlebtn.Enabled = true;
                pompavazgecbtn.Enabled = true;
                pompakayitbtn.Enabled = false;
            }
        }

        // Selected Warehouse Id in Pump
        private void depoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex != -1)
            {
                SelectedWareHouseId = (int)(sender as ComboBox).SelectedValue;
            }
            else
            {
                SelectedWareHouseId = new int();
            }
        }
        


        //Tab Functions
        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Product Data Source in Warehouse
            yakitTurComBox.DataSource = context.ProductDefine.ToList();
            yakitTurComBox.DisplayMember = "Type";
            yakitTurComBox.ValueMember = "Id";
            yakitTurComBox.SelectedIndex = -1;

            // Warehouse Data Source in Pump
            depoComboBox.DataSource = context.WareHouseDefine.ToList();
            depoComboBox.DisplayMember = "WareHouseName";
            depoComboBox.ValueMember = "Id";
            depoComboBox.SelectedIndex = -1;

            SelectedProductId = new int();
            SelectedWareHouseId = new int();
        }

    }
}
