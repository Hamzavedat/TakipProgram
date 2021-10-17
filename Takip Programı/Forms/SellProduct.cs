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
    public partial class SellProduct : Form
    {
        TakipProgramiContext context = new TakipProgramiContext();
        private ObservableCollection<SaleModel> SaleProductList { get; set; }
        public int SelectedProductId { get; private set; }
        private double TotalPrice { get; set; }
        public int SelectedIndexGrid { get; private set; }

        public SellProduct()
        {
            InitializeComponent();
            this.CenterToScreen();
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
        }

        private void eklebtn_Click(object sender, EventArgs e)
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

        private void satbtn_Click(object sender, EventArgs e)
        {
            if (SaleProductList.Count>0)
            {

                DialogResult dialogResult = MessageBox.Show( $"Toplam Ücret {toplamtxt.Text}. Onaylıyor Musunuz?","Uyarı", MessageBoxButtons.YesNo);
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
                    Close();
                }
                else if (dialogResult == DialogResult.No)
                {

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
                SelectedProductId = new int() ;
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
                    miktartxt.Text = "";
                    
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
            
            DialogResult dialogResult = MessageBox.Show( "Seçili Öge Silinecek Emin Misiniz?", "Uyarı", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                TotalPrice -= SaleProductList[SelectedIndexGrid].ProductTotalPrice;
                toplamtxt.Text = TotalPrice.ToString() + " ₺";
                SaleProductList.RemoveAt(SelectedIndexGrid);
                var list = new ObservableCollection<SaleModel>(SaleProductList);
                dataGridView1.DataSource = list;
                silbtn.Enabled = false;
            }
            else if (dialogResult == DialogResult.No)
            {
                
            }
        }
    }
}
