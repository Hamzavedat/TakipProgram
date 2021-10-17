using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Takip_Programı.Models;

namespace Takip_Programı.Forms
{
    public partial class Form_Pomp : Form
    {
        TakipProgramiContext context = new TakipProgramiContext();
        ObservableCollection<PumpFormModel> PumpFormModel { get; set; }
        ObservableCollection<ProductDefine> ProductDefine { get; set; }
        ObservableCollection<WareHouse> WareHouse { get; set; }
        ObservableCollection<PumpDefine> PumpDefines { get; set; }
        private int? SelectedPumpDefineId;
        public Form_Pomp()
        {
            InitializeComponent();
            LoadTheme();
            this.CenterToScreen();
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;
            this.ResizeRedraw = false;

            ProductDefine = new ObservableCollection<ProductDefine>(context.ProductDefine.ToList());
            WareHouse = new ObservableCollection<WareHouse>(context.WareHouseDefine.ToList());
            PumpDefines = new ObservableCollection<PumpDefine>(context.PumpDefine.ToList());
            // Warehouse Data Source
            PumpFormModel = new ObservableCollection<PumpFormModel>(context.PumpFormModel.ToList());
            dataGridView.DataSource = PumpFormModel.Select(c =>
                new
                {
                    Id = c.Id,
                    WorkDate = c.WorkDate,
                    PersonName = c.PersonName,
                    FirstCounter = c.FirstCounter,
                    LastCounter = c.LastCounter,
                    Difference = c.Difference,
                    Price = c.Price,
                    Amount = c.Amount,
                    PumpDefine = c.PumpDefine,
                    PumpNames = c.PumpDefine.PumpName
                }).ToList();

            // PumpDefine Data Source in PumpFormModel
            pompaComboBox.DataSource = context.PumpDefine.ToList();
            pompaComboBox.DisplayMember = "PumpName";
            pompaComboBox.ValueMember = "Id";
            pompaComboBox.SelectedIndex = -1;

            // DateComboBox Ayarları
            List<string> dateList = new List<string>();
            for (int i = 0; i < 8; i++)
            {
                dateList.Add(DateTime.Now.AddDays(i).ToString("dd.MM.yyyy"));
            }
            dateComboBox.DataSource = dateList;
        }

        // Theme Functions
        private void LoadTheme()
        {
            yeniBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            kayitBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            silBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            vazgecBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
        }

        private void yeniBtn_Click(object sender, EventArgs e)
        {
            var pumpDef = context.PumpDefine.FirstOrDefault(i => i.Id == Convert.ToInt32(SelectedPumpDefineId));
            if (pumpDef != null)
            {
                try
                {
                    var pumpModel = new PumpFormModel()
                    {
                        PersonName = personNameTextBox.Text,
                        WorkDate = dateComboBox.Text,
                        Price = pumpDef.WareHouse.ProductDefine.SellPrice,
                        PumpDefine = pumpDef
                    };
                    try
                    {
                        pumpModel.FirstCounter = Convert.ToDouble(firstCounterTxtBox.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(firstCounterTxtBox.Text))
                        {
                            MessageBox.Show("Lütfen ilk sayaca sadece sayı giriniz!");
                            return;
                        }
                    }
                    try
                    {
                        pumpModel.LastCounter = Convert.ToDouble(lastCounterTxtBox.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(lastCounterTxtBox.Text))
                        {
                            MessageBox.Show("Lütfen son sayaca sadece sayı giriniz!");
                            return;
                        }
                    }
                    try
                    {
                        pumpModel.Amount = Convert.ToDouble(amountTxtBox.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(lastCounterTxtBox.Text))
                        {
                            MessageBox.Show("Lütfen tutara sadece sayı giriniz!");
                            return;
                        }
                    }
                    try
                    {
                        pumpModel.Difference = Convert.ToDouble(diffrenceTxtBox.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(lastCounterTxtBox.Text))
                        {
                            MessageBox.Show("Lütfen farka sadece sayı giriniz!");
                            return;
                        }
                    }
                    context.PumpFormModel.Add(pumpModel);
                    context.SaveChanges();
                    var oldpump = pumpDef;
                    pumpDef.Counter = pumpModel.LastCounter;
                    context.PumpDefine.AsNoTracking();
                    context.Entry(oldpump).CurrentValues.SetValues(pumpDef);
                    context.SaveChanges();
                    PumpFormModel = new ObservableCollection<PumpFormModel>(context.PumpFormModel.ToList());
                    dataGridView.DataSource = PumpFormModel.Select(c =>
                        new
                        {
                            Id = c.Id,
                            WorkDate = c.WorkDate,
                            PersonName = c.PersonName,
                            FirstCounter = c.FirstCounter,
                            LastCounter = c.LastCounter,
                            Difference = c.Difference,
                            Price = c.PumpDefine.WareHouse.ProductDefine.SellPrice,
                            Amount = c.Amount,
                            PumpDefine = c.PumpDefine,
                            PumpNames = c.PumpDefine.PumpName
                        }).ToList();
                    idTextBox.Text = null;
                    pompaComboBox.Text = null;
                    dateComboBox.Text = null;
                    personNameTextBox.Text = null;
                    firstCounterTxtBox.Text = null;
                    lastCounterTxtBox.Text = null;
                    amountTxtBox.Text = null;
                    diffrenceTxtBox.Text = null;
                    yeniBtn.Enabled = true;
                    kayitBtn.Enabled = false;
                    silBtn.Enabled = false;
                    vazgecBtn.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Pompa Adını Giriniz!");
            }
        }

        private void kayitBtn_Click(object sender, EventArgs e)
        {
            var pumpDef = context.PumpDefine.FirstOrDefault(i => i.Id == Convert.ToInt32(SelectedPumpDefineId));
            var pumpform = context.PumpFormModel.FirstOrDefault(i => i.Id == Convert.ToInt32(idTextBox.Text));
            if (pumpDef != null)
            {
                try
                {
                    var pumpModel = new PumpFormModel()
                    {
                        PersonName = personNameTextBox.Text,
                        WorkDate = dateComboBox.Text,
                        Price = pumpDef.WareHouse.ProductDefine.SellPrice,
                        PumpDefine = pumpDef,
                        Id = Convert.ToInt32(idTextBox.Text)
                    };
                    try
                    {
                        pumpModel.FirstCounter = Convert.ToDouble(firstCounterTxtBox.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(firstCounterTxtBox.Text))
                        {
                            MessageBox.Show("Lütfen ilk sayaca sadece sayı giriniz!");
                            return;
                        }
                    }
                    try
                    {
                        pumpModel.LastCounter = Convert.ToDouble(lastCounterTxtBox.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(lastCounterTxtBox.Text))
                        {
                            MessageBox.Show("Lütfen son sayaca sadece sayı giriniz!");
                            return;
                        }
                    }
                    try
                    {
                        pumpModel.Amount = Convert.ToDouble(amountTxtBox.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(amountTxtBox.Text))
                        {
                            MessageBox.Show("Lütfen tutara sadece sayı giriniz!");
                            return;
                        }
                    }
                    try
                    {
                        pumpModel.Difference = Convert.ToDouble(diffrenceTxtBox.Text.Replace('.', ','));
                    }
                    catch (Exception)
                    {
                        if (!string.IsNullOrWhiteSpace(diffrenceTxtBox.Text))
                        {
                            MessageBox.Show("Lütfen farka sadece sayı giriniz!");
                            return;
                        }
                    }
                    
        
                    context.PumpFormModel.AsNoTracking();
                    pumpform.FirstCounter = pumpModel.FirstCounter;
                    pumpform.LastCounter = pumpModel.LastCounter;
                    pumpform.Amount = pumpModel.Amount;
                    pumpform.Difference= pumpModel.Difference;
                    pumpform.PersonName= pumpModel.PersonName;
                    pumpform.PumpDefine= pumpModel.PumpDefine;
                    pumpform.WorkDate= pumpModel.WorkDate;
                    context.SaveChanges();
                    PumpFormModel = new ObservableCollection<PumpFormModel>(context.PumpFormModel.ToList());
                    dataGridView.DataSource = PumpFormModel.Select(c =>
                        new
                        {
                            Id = c.Id,
                            WorkDate = c.WorkDate,
                            PersonName = c.PersonName,
                            FirstCounter = c.FirstCounter,
                            LastCounter = c.LastCounter,
                            Difference = c.Difference,
                            Price = c.PumpDefine.WareHouse.ProductDefine.SellPrice,
                            Amount = c.Amount,
                            PumpDefine = c.PumpDefine,
                            PumpNames = c.PumpDefine.PumpName
                        }).ToList();
                    idTextBox.Text = null;
                    pompaComboBox.Text = null;
                    dateComboBox.Text = null;
                    personNameTextBox.Text = null;
                    firstCounterTxtBox.Text = null;
                    lastCounterTxtBox.Text = null;
                    amountTxtBox.Text = null;
                    diffrenceTxtBox.Text = null;
                    yeniBtn.Enabled = true;
                    kayitBtn.Enabled = false;
                    silBtn.Enabled = false;
                    vazgecBtn.Enabled = false;
                }
                catch (Exception)
                {
                    MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Pompa Adını Giriniz!");
            }
        }

        private void vazgecBtn_Click(object sender, EventArgs e)
        {
            idTextBox.Text = null;
            pompaComboBox.Text = null;
            dateComboBox.Text = null;
            personNameTextBox.Text = null;
            firstCounterTxtBox.Text = null;
            lastCounterTxtBox.Text = null;
            amountTxtBox.Text = null;
            diffrenceTxtBox.Text = null;
            yeniBtn.Enabled = true;
            kayitBtn.Enabled = false;
            silBtn.Enabled = false;
            vazgecBtn.Enabled = false;
        }

        private void silBtn_Click(object sender, EventArgs e)
        {
            context.PumpFormModel.Remove(context.PumpFormModel.FirstOrDefault(i=>i.Id==Convert.ToInt32(idTextBox.Text)));
            context.SaveChanges();
            PumpFormModel = new ObservableCollection<PumpFormModel>(context.PumpFormModel.ToList());
            dataGridView.DataSource = PumpFormModel.Select(c =>
                     new
                     {
                         Id = c.Id,
                         WorkDate = c.WorkDate,
                         PersonName = c.PersonName,
                         FirstCounter = c.FirstCounter,
                         LastCounter = c.LastCounter,
                         Difference = c.Difference,
                         Price = c.PumpDefine.WareHouse.ProductDefine.SellPrice,
                         Amount = c.Amount,
                         PumpDefine = c.PumpDefine,
                         PumpNames = c.PumpDefine.PumpName
                     }).ToList();
            idTextBox.Text = null;
            pompaComboBox.Text = null;
            dateComboBox.Text = null;
            personNameTextBox.Text = null;
            firstCounterTxtBox.Text = null;
            lastCounterTxtBox.Text = null;
            amountTxtBox.Text = null;
            diffrenceTxtBox.Text = null;
            yeniBtn.Enabled = true;
            kayitBtn.Enabled = false;
            silBtn.Enabled = false;
            vazgecBtn.Enabled = false;
        }
        private void pompaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex != -1)
            {
                SelectedPumpDefineId = (int)(sender as ComboBox).SelectedValue;
            }
            else
            {
                SelectedPumpDefineId = new int();
            }
            var pumpDef = context.PumpDefine.FirstOrDefault(i => i.Id == Convert.ToInt32(SelectedPumpDefineId));
            if (pumpDef != null)
            {

                if (firstCounterTxtBox.Text == "")
                {
                    firstCounterTxtBox.Text = pumpDef.Counter.ToString();
                }
           
            if (lastCounterTxtBox.Text != "" && firstCounterTxtBox.Text != "")
            {
                
                if (pumpDef != null)
                {
                    var first = new double();
                    var last = new double();
                    try
                    {

                        try
                        {
                            first = Convert.ToDouble(lastCounterTxtBox.Text.Replace('.', ','));
                        }
                        catch (Exception)
                        {
                            if (!string.IsNullOrWhiteSpace(lastCounterTxtBox.Text))
                            {
                                MessageBox.Show("Lütfen ilk sayaca sadece sayı giriniz!");
                                return;
                            }
                        }
                        try
                        {
                            last = Convert.ToDouble(firstCounterTxtBox.Text.Replace('.', ','));
                        }
                        catch (Exception)
                        {
                            if (!string.IsNullOrWhiteSpace(firstCounterTxtBox.Text))
                            {
                                MessageBox.Show("Lütfen son sayaca sadece sayı giriniz!");
                                return;
                            }
                        }
                        var difference = Math.Abs(first - last);
                        diffrenceTxtBox.Text = difference.ToString();
                        amountTxtBox.Text = (difference * pumpDef.WareHouse.ProductDefine.SellPrice).ToString();
                        
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                        return;
                    }
                }
                }
            }
        }

        private void firstCounterTxtBox_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataGridView.Rows[e.RowIndex];
                idTextBox.Text = row.Cells[0].Value.ToString();
                pompaComboBox.Text = row.Cells[9].Value.ToString();
                lastCounterTxtBox.Text = row.Cells[4].Value.ToString();
                firstCounterTxtBox.Text = row.Cells[3].Value.ToString();
                dateComboBox.Text = row.Cells[1].Value.ToString();
                personNameTextBox.Text = row.Cells[2].Value.ToString();                
                diffrenceTxtBox.Text = row.Cells[5].Value.ToString();
                amountTxtBox.Text = row.Cells[7].Value.ToString();
                kayitBtn.Enabled = true;
                vazgecBtn.Enabled = true;
                silBtn.Enabled = true;
                yeniBtn.Enabled = false;
            }
        }

        private void lastCounterTxtBox_TextChanged(object sender, EventArgs e)
        {
            var pumpDef = context.PumpDefine.FirstOrDefault(i => i.Id == Convert.ToInt32(SelectedPumpDefineId));
            if (pumpDef != null)
            {
                if (firstCounterTxtBox.Text != "" && lastCounterTxtBox.Text != "")
                {
                    var first = new double();
                    var last = new double();
                    try
                    {

                        try
                        {
                            first = Convert.ToDouble(firstCounterTxtBox.Text.Replace('.', ','));
                        }
                        catch (Exception)
                        {
                            if (!string.IsNullOrWhiteSpace(firstCounterTxtBox.Text))
                            {
                                MessageBox.Show("Lütfen ilk sayaca sadece sayı giriniz!");
                                return;
                            }
                        }
                        try
                        {
                            last = Convert.ToDouble(lastCounterTxtBox.Text.Replace('.', ','));
                        }
                        catch (Exception)
                        {
                            if (!string.IsNullOrWhiteSpace(lastCounterTxtBox.Text))
                            {
                                MessageBox.Show("Lütfen son sayaca sadece sayı giriniz!");
                                return;
                            }
                        }
                        var difference = Math.Abs(last - first);
                        diffrenceTxtBox.Text = difference.ToString();
                        amountTxtBox.Text = (difference * pumpDef.WareHouse.ProductDefine.SellPrice).ToString();
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("Birşeyler ters gitti. Lütfen daha sonra tekrar deneyiniz!");
                        return;
                    }
                }
            }
        }
    }
}
