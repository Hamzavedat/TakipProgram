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
    public partial class Client_Sale : Form
    {
        TakipProgramiContext context = new TakipProgramiContext();
        private double pay;
        private string clientid;
        private int productid2;

        private ObservableCollection<SaleModel> SaleProductList { get; set; }
        public int SelectedProductId { get; private set; }
        private double TotalPrice { get; set; }
        public int SelectedIndexGrid { get; private set; }
        public Client_Sale(string ClientId)
        {
            InitializeComponent();
            this.CenterToScreen();
            clientid = ClientId;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResizeRedraw = false;
            SaleProductList = new ObservableCollection<SaleModel>();
            urun_cmbbox.DataSource = context.ProductDefine.ToList();
            urun_cmbbox.DisplayMember = "Name";
            urun_cmbbox.ValueMember = "Id";
            urun_cmbbox.SelectedIndex = -1;
            dataGridView1.DataSource = SaleProductList;
            TotalPrice = 0;
            this.KeyDown += Form_Sale_KeyDown;
       /*     var client = context.Customer.FirstOrDefault(x => x.Id == Convert.ToInt32(ClientId));
            totalborc.Text = client.TotalDebt.ToString() + " ₺";*/
        }

        private void Form_Sale_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Enter:
                    eklebtn_Click(eklebtn, new EventArgs());
                    break;
                case Keys.F1:
                    satbtn_Click(satbtn, new EventArgs());
                    break;
                case Keys.Delete:
                    silbtn_Click(silbtn, new EventArgs());
                    break;
                default:
                    break;
            }
        }

        private void eklebtn_Click(object sender, EventArgs e)
        {
            if (eklebtn.Enabled)
            {
                if (urun_cmbbox.SelectedIndex != -1)
                {
                    if (string.IsNullOrEmpty(miktartxt.Text) || miktartxt.Text == "")
                    {
                        MessageBox.Show("Miktar Giriniz");
                        return;
                    }
                    var sale = new SaleModel();
                    var product = context.ProductDefine.FirstOrDefault(i => i.Id == SelectedProductId);
                    sale.ProductId = product.Id;
                    sale.ProductName = product.Name;
                    sale.ProductPrice = product.SellPrice;

                    try
                    {

                        sale.ProductNumber = Convert.ToDouble(miktartxt.Text.Replace('.', ','));
                        sale.ProductTotalPrice = sale.ProductPrice * sale.ProductNumber;
                        SaleProductList.Add(sale);
                        var list = new ObservableCollection<SaleModel>(SaleProductList);
                        dataGridView1.DataSource = list;
                        brmfyttxt.Text = "";
                        miktartxt.Text = "";
                        tplmfyttxt.Text = "";
                        TotalPrice += sale.ProductTotalPrice;
                        toplamtxt.Text = TotalPrice.ToString() + " ₺";
                        productid2 = sale.ProductId;
                        eklebtn.Enabled = false;
                        var client = context.Customer.FirstOrDefault(x => x.Id == Convert.ToInt32(clientid));
                        if (!string.IsNullOrWhiteSpace(client.ProductDebtList))
                        {
                            var products = client.ProductDebtList.Split(";");
                            var productsNumber = client.PruductDebtNumberList.Split(";");
                            var isthere = false;
                            string newproducts = "";
                            string newproductsnumbers = "";
                            for (int i = 0; i < products.Length; i++)
                            {
                                if (products[i].Replace(" ", "") == productid2.ToString())
                                {
                                    isthere = true;
                                    totalborc.Text = (context.ProductDefine.FirstOrDefault(i => i.Id == productid2).SellPrice * Convert.ToDouble(productsNumber[i])).ToString() + " ₺";
                                }
                            }
                            if (!isthere)
                            {
                                totalborc.Text = "0 ₺";
                            }
                        }
                        else
                        {
                            totalborc.Text = "0 ₺";
                        }
                    }
                     
                    catch (Exception ex)
                    {

                        MessageBox.Show("Lütfen miktara sadece rakam giriniz!");
                        return;


                    }
                }
                else
                {
                    MessageBox.Show("Ürün Seçiniz", "Uyarı");
                }
            }
         
        }

        private void satbtn_Click(object sender, EventArgs e)
        {
            if (satbtn.Enabled)
            {
                if (SaleProductList.Count > 0)
                {

                    DialogResult dialogResult = MessageBox.Show($"Toplam Ücret {toplamtxt.Text}.\nAlınan ücret {payment.Text} Onaylıyor Musunuz?", "Uyarı", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        var depolist = context.WareHouseDefine.ToList();
                        foreach (var item in SaleProductList)
                        {
                            if ((depolist.Where(i => i.ProductDefine.Id == item.ProductId).ToList()).Count > 0)
                            {
                                var depo = depolist.FirstOrDefault(i => i.ProductDefine.Id == item.ProductId);
                                if (item.ProductNumber <= depo.WareHouseStock)
                                {
                                    depo.WareHouseStock -= item.ProductNumber;
                                }
                                else
                                {
                                    depo.WareHouseStock = 0;
                                }
                                context.SaveChanges();

                            }
                        }
                        var client = context.Customer.FirstOrDefault(x => x.Id == Convert.ToInt32(clientid));
                        if (!string.IsNullOrWhiteSpace(client.ProductDebtList))
                        {
                            var products = client.ProductDebtList.Split(";");
                            var productsNumber = client.PruductDebtNumberList.Split(";");
                            var isthere = false;
                            string newproducts = "";
                            string newproductsnumbers = "";
                            double newdebt= 0;
                            for (int i = 0; i < products.Length; i++)
                            {
                                if (!string.IsNullOrWhiteSpace(products[i]))
                                {

                                
                                if (products[i].Replace(" ", "") == productid2.ToString())
                                {
                                    if (Convert.ToDouble(kalanborc.Text.Replace("₺","")) != 0)
                                    {
                                        newproducts += products[i] + ";";
                                        newproductsnumbers += (Convert.ToDouble(kalanborc.Text.Replace("₺", "")) / context.ProductDefine.FirstOrDefault(x => x.Id == Convert.ToInt32(products[i])).SellPrice).ToString() + ";";
                                        newdebt += Convert.ToDouble(kalanborc.Text.Replace("₺", ""));

                                    }
                                }
                                else
                                {
                                    newproducts += products[i] + ";";
                                    newproductsnumbers += newproductsnumbers[i] + ";";
                                    newdebt += context.ProductDefine.FirstOrDefault(x => x.Id == Convert.ToInt32(products[i])).SellPrice * Convert.ToDouble(productsNumber[i]);
                                }
                                }
                            }
                            client.ProductDebtList = newproducts;
                            client.PruductDebtNumberList = newproductsnumbers;
                            client.TotalDebt = newdebt;
                            context.SaveChanges();
                        }
                        else
                        {
                            client.PruductDebtNumberList = (Convert.ToDouble(kalanborc.Text.Replace("₺",""))/context.ProductDefine.FirstOrDefault(i=>i.Id == productid2).SellPrice).ToString();
                            client.ProductDebtList = productid2.ToString();
                            client.TotalDebt = Convert.ToDouble(kalanborc.Text.Replace("₺", ""));
                            context.SaveChanges();
                        }

                        MessageBox.Show("İşlem Başarılı Bir Şekilde Gerçekleşti");
                        Close();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }
                }
                
            }

        }

        private void urun_cmbbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (urun_cmbbox.SelectedIndex != -1)
            {
                SelectedProductId = (int)(sender as ComboBox).SelectedValue;
                try
                {
                    double number = Convert.ToDouble(miktartxt.Text.Replace('.', ','));

                    if (urun_cmbbox.SelectedIndex != -1)
                    {
                        var product = context.ProductDefine.FirstOrDefault(i => i.Id == SelectedProductId);
                        brmfyttxt.Text = product.SellPrice.ToString() + " ₺";
                        tplmfyttxt.Text = (product.SellPrice * number).ToString() + " ₺";
                    }
                }
                catch (Exception ex)
                {

                    if (miktartxt.Text != "")
                    {
                        MessageBox.Show("Miktara Sadece Sayı Giriniz");
                        miktartxt.Text = "";
                    }
                }
            }
            else
            {
                SelectedProductId = new int();
            }
        }

        private void miktartxt_TextChanged(object sender, EventArgs e)
        {


            try
            {
                double number = Convert.ToDouble(miktartxt.Text.Replace('.', ','));

                if (urun_cmbbox.SelectedIndex != -1)
                {
                    var product = context.ProductDefine.FirstOrDefault(i => i.Id == SelectedProductId);
                    brmfyttxt.Text = product.SellPrice.ToString() + " ₺";
                    tplmfyttxt.Text = (product.SellPrice * number).ToString() + " ₺";
                }
                else
                {
                    brmfyttxt.Text = "";
                    tplmfyttxt.Text = "";
                }
            }
            catch (Exception ex)
            {
                tplmfyttxt.Text = "";

                if (miktartxt.Text != "")
                {
                    MessageBox.Show("Miktara Sadece Sayı Giriniz");
                    miktartxt.Text = miktartxt.Text.Substring(0,(miktartxt.Text.Length-1));

                }
            }

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {

                SelectedIndexGrid = e.RowIndex;


            }
            silbtn.Enabled = true;
        }

        private void silbtn_Click(object sender, EventArgs e)
        {
            if (silbtn.Enabled)
            {
                DialogResult dialogResult = MessageBox.Show("Seçili Öge Silinecek Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    TotalPrice -= SaleProductList[SelectedIndexGrid].ProductTotalPrice;
                    toplamtxt.Text = TotalPrice.ToString() + " ₺";
                    SaleProductList.RemoveAt(SelectedIndexGrid);
                    var list = new ObservableCollection<SaleModel>(SaleProductList);
                    dataGridView1.DataSource = list;
                    silbtn.Enabled = false;
                    eklebtn.Enabled = true;
                }
                else if (dialogResult == DialogResult.No)
                {

                }
            }
  
        }

        private void payment_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(toplamtxt.Text.Replace("₺","").Replace(" ","")))
            {
                try
                {
                    double tutar = Convert.ToDouble(toplamtxt.Text.Replace("₺", "").Replace('.', ','));
                    pay = Convert.ToDouble(payment.Text.Replace('.', ','));
                    kalanborc.Text = (Convert.ToDouble(totalborc.Text.Replace("₺","")) + tutar - pay).ToString() + " ₺";
                }
                catch (Exception ex)
                {


                    if (miktartxt.Text != "")
                    {
                        MessageBox.Show("Miktara Sadece Sayı Giriniz");
                        miktartxt.Text = miktartxt.Text.Substring(0, (miktartxt.Text.Length - 1));

                    }
                }
            }
       
        }
    }
}
