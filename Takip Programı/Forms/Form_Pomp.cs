using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Takip_Programı.Forms
{
    public partial class Form_Pomp : Form
    {
        public Form_Pomp()
        {
            InitializeComponent();
            this.CenterToParent();
        }
        private void Form_Pomp_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void LoadTheme()
        {
            yeniBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            kayitBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            silBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
            vazgecBtn.BackColor = ColorTranslator.FromHtml("#5F939A");
        }

        
    }
}
