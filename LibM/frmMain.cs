using LibM.Contracts.Transaction;
using LibM.Services.Repositories;
using System.ComponentModel;

namespace LibM
{
    public partial class frmMain : Form
    {
        private readonly TransactionRepository transactionRepository;
        public frmMain()
        {
            InitializeComponent();
            transactionRepository = new TransactionRepository();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            dgvTransactions.DataSource = new BindingList<TransactionViewDto>(transactionRepository.GetAllTransaction());
        }

        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frmBook = new Books.frmBook();
            frmBook.ShowDialog();
            
        }
    }
}