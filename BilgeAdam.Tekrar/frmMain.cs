using BilgeAdam.Tekrar.Data.Services.Abstractions;
using BilgeAdam.Tekrar.Data.Services.Concretes;

namespace BilgeAdam.Tekrar
{
    public partial class frmMain : Form
    {
        private readonly IDbService service;

        public frmMain()
        {
            InitializeComponent();
            //service = new AdoNetService();
            //service = new DapperService();
            service = new EFService();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgvProducts.DataSource = service.GetAllProducts();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            var frmNewProduct = new frmNewProduct();
            frmNewProduct.ShowDialog();
        }
    }
}