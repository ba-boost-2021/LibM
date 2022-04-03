using BilgeAdam.Tekrar.Data.Services.Abstractions;
using BilgeAdam.Tekrar.Data.Services.Concretes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BilgeAdam.Tekrar
{
    public partial class frmNewProduct : Form
    {
        private readonly IDbService service;
        public frmNewProduct()
        {
            InitializeComponent();
            service = new DapperService();
            //service = new AdoNetService();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var result = service.AddNewProduct(txtProductName.Text,Convert.ToDecimal(txtPrice.Text));
            if (result)
            {
                MessageBox.Show("Başarılı");
                return;
            }
            MessageBox.Show("Başarısız");
        }
    }
}
