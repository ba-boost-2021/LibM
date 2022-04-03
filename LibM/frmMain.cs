using LibM.Contracts.Transaction;
using LibM.EmployeeManagement;
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
        private void studentManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmStudent = new frmStudents();
            frmStudent.ShowDialog();
        }
        private void typesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmType = new frmTypes();
            frmType.ShowDialog();
        }
        private void authorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmAuthor = new frmAuthor();
            frmAuthor.ShowDialog();
        }
        private void booksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            var frmBook = new Books.frmBook();
            frmBook.ShowDialog();
            
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmNewTransaction = new frmNewTransaction();
            frmNewTransaction.ShowDialog();
        }
        private void employeeDatasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmEmployeeDatas = new frmEmployeeDatas();
            frmEmployeeDatas.Show();
        }
    }
}