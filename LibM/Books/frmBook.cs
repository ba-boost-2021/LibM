using LibM.Contracts.Books;
using LibM.Services.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibM.Books
{
    public partial class frmBook : Form
    {
        private readonly BookRepository bookRepository;
        public frmBook()
        {
            InitializeComponent();
            bookRepository = new BookRepository();
        }

        private void frmBook_Load(object sender, EventArgs e)
        {
            dgvBooksInformation.DataSource = new BindingList<BookViewDto>(bookRepository.GetAllBooks());
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frmBook = new frmAddBooks();  
            
            frmBook.ShowDialog();

            dgvBooksInformation.DataSource = null;
            dgvBooksInformation.DataSource = new BindingList<BookViewDto>(bookRepository.GetAllBooks());
        }
    }
}
