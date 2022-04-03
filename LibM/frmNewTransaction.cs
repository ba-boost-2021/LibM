using LibM.Contracts;
using LibM.Contracts.Books;
using LibM.Contracts.Transaction;
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

namespace LibM
{
    public partial class frmNewTransaction : Form
    {
        private readonly TypesRepository typesRepository;
        private readonly AuthorRepository authorRepository;
        private readonly BookRepository bookRepository;
        private readonly StudentRepository studentRepository;
        private readonly TransactionRepository transactionRepository;
        public frmNewTransaction()
        {
            InitializeComponent();
            typesRepository = new TypesRepository();
            authorRepository = new AuthorRepository();
            bookRepository = new BookRepository();
            studentRepository = new StudentRepository();
            transactionRepository = new TransactionRepository();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            lstTypes.DataSource = typesRepository.GetTypesAsOptions();
            lstStudents.DataSource = studentRepository.GetStudentsAsOptions();
        }

        private void lstAuthors_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dto = new BooksListOptionDto()
            {
                AuthorId = ((OptionDto)lstAuthors.SelectedItem)?.Code,
                 TypeId = ((OptionDto)lstTypes.SelectedItem)?.Code
            };
            var result = bookRepository.GetBooksByOptionsAsOptions(dto);
            lstBooks.Items.Clear();
            lstBooks.Items.AddRange(result.ToArray());
        }

        private void lstTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            var type = lstTypes.SelectedItem as OptionDto;
            var result = authorRepository.GetAuthorsByType(type.Code);
            lstAuthors.Items.Clear();
            lstAuthors.Items.AddRange(result.ToArray());
        }

        private void txtSerach_TextChanged(object sender, EventArgs e)
        {
            lstStudents.DataSource = null;
            lstStudents.DataSource = studentRepository.GetStudentsAsOptions(txtSerach.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!IsValid())
            {
                return;
            }
            var dto = new NewTransactionDto()
            {
                BookId = ((OptionDto)lstBooks.SelectedItem).Code,
                StudentId = ((OptionDto)lstStudents.SelectedItem).Code,
            };
            var result = transactionRepository.AddNewTransaction(dto);
            this.Close();
        }

        private bool IsValid()
        {
            if (lstStudents.SelectedItems.Count == 0)
            {
                return false;
            }
            if (lstTypes.SelectedItems.Count == 0)
            {
                return false;
            }
            if (lstBooks.SelectedItems.Count == 0)
            {
                return false;
            }
            if (lstStudents.SelectedItems.Count == 0)
            {
                return false;
            }
            return true;
        }
    }
}
