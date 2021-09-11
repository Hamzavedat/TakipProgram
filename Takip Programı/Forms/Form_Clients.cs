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
        private List<Customer> customers { get; set; }

        public Form_Clients()
        {
            InitializeComponent();
            LoadTheme();
            this.CenterToParent();

            string query = "SELECT * FROM Customers ";
            SQLiteConnection con = new SQLiteConnection("Data source=TakipProgramıDb.db;Version=3;");
            con.Open();
            SQLiteCommand command = new SQLiteCommand(query, con);
            SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

            customers = new List<Customer>();

            for (int i = 0; i < 30; i++)
            {
                customers.Add(new Customer { ID = i, Name = "İsim " + i.ToString(), SurName = "Soy İsim " + i.ToString(), Change = 1, MobilePhone = "05555555555", Phone = "1234567890", Risk = "500000", Position = "Merkez" });

            }
            foreach (var item in customers)
            {
                ListViewItem itemlist = new ListViewItem(item.Name);
                itemlist.SubItems.Add(item.SurName);
                itemlist.SubItems.Add(item.Risk);
                itemlist.SubItems.Add(item.ChangeText);
                itemlist.SubItems.Add(item.Position);
                itemlist.SubItems.Add(item.Phone);
                itemlist.SubItems.Add(item.MobilePhone);
                itemlist.SubItems.Add(item.VergiDairesi);
                itemlist.SubItems.Add(item.VergiNo);
                itemlist.Name = item.ID.ToString();
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
            string query = "INSERT INTO Customers(Name,Surname,Risk,Change,Position,Phone,MobilePhone,VergiDairesi,VergiNo,Adress) VALUES(@name,@surname,@risk,@change,@position,@phone,@mobile,@vergiD,@vergiN,@adress)";
            SQLiteConnection con = new SQLiteConnection("Data source=TakipProgramıDb.db;Version=3;");
            con.Open();
            var command = new SQLiteCommand(con);
            command.CommandText = query;
            command.Parameters.AddWithValue("@name", adTxtBox.Text);
            command.Parameters.AddWithValue("@surname", soyadTxtBox.Text);
            command.Parameters.AddWithValue("@risk", riskTxtBox.Text);
            command.Parameters.AddWithValue("@change", fiyatComboBox.Text == "Etkilensin" ? 1 : 0);
            command.Parameters.AddWithValue("@position", mevkiTxtBox.Text);
            command.Parameters.AddWithValue("@phone", telTxtBox.Text);
            command.Parameters.AddWithValue("@mobile", cepTelTxtBox.Text);
            command.Parameters.AddWithValue("@vergiD", vergiDaireTxtBox.Text);
            command.Parameters.AddWithValue("@vergiN", vergiNoTxtBox.Text);
            command.Parameters.AddWithValue("@adress", adresTxtBox.Text);
            command.ExecuteNonQuery();
        }

        private void musteriListView_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            var obj = sender as ListView;
            var data = obj.FocusedItem;
            var customer = customers.FirstOrDefault(x => x.ID.ToString() == data.Name);
            adTxtBox.Text = customer.Name;
            soyadTxtBox.Text = customer.SurName;
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
            string query = "DELETE * FROM Customers WHERE Id = @id";
            SQLiteConnection con = new SQLiteConnection("Data source=TakipProgramıDb.db;Version=3;");
            con.Open();
            var command = new SQLiteCommand(con);
            command.CommandText = query;
            command.Parameters.AddWithValue("@id", adTxtBox.Text);
            command.ExecuteNonQuery();
        }
    }
}
