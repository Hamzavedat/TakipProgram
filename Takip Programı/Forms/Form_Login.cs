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

namespace Takip_Programı.Forms
{
    public partial class Form_Login : Form
    {
        public Form_Login()
        {
            InitializeComponent();
            this.CenterToScreen();

        }

        private void girisBtn_Click(object sender, EventArgs e)
        {

            if (usernameTxtBox.Text.Trim() == "" || passwordTxtBox.Text.Trim() == "")
            {
                MessageBox.Show("Lüften Değerleri Boş Girmeyiniz");
            }
            else
            {
                string query = "SELECT * FROM Users WHERE Username = @user AND Password = @password";
                SQLiteConnection con = new SQLiteConnection("Data source=TakipProgramıDb.db;Version=3;");
                con.Open();
                SQLiteCommand command = new SQLiteCommand(query, con);
                command.Parameters.AddWithValue("@user", usernameTxtBox.Text);
                command.Parameters.AddWithValue("@password", passwordTxtBox.Text);
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(command);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                if (dt.Rows.Count>0)
                {
                    MessageBox.Show("Sayın "+usernameTxtBox.Text+" Hoşgeldiniz.");
                    this.Hide();
                    Form1 f2 = new Form1(); //this is the change, code for redirect  
                    f2.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Maalesef Böyle Bir Kullanıcı Bulunamamaktadır.");
                }
                
            }
            
        }

        private void Form_Login_Load(object sender, EventArgs e)
        {
            this.MaximumSize = this.Size;
            this.MinimumSize = this.MaximumSize;
        }
    }
}
