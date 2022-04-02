using LibM.Contracts;
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

namespace LibM
{
    public partial class frmNewTransaction : Form
    {
        private readonly TypesRepository typesRepository;
        private readonly AuthorRepository authorRepository;
        private readonly BookRepository bookRepository;
        public frmNewTransaction()
        {
            InitializeComponent();
            typesRepository = new TypesRepository();
            authorRepository = new AuthorRepository();
            bookRepository = new BookRepository();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = typesRepository.GetTypesAsOptions();
            cmbAuthor.DataSource = authorRepository.GetAuthorsAsOptions();

            cmbType.DisplayMember = nameof(OptionDto.Label);
            cmbAuthor.DisplayMember = nameof(OptionDto.Label);
            cmbBook.DisplayMember = nameof(OptionDto.Label);
        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            var dto = new BooksListOptionDto()
            {
                AuthorId = ((OptionDto)cmbAuthor.SelectedItem)?.Code,
                 TypeId = ((OptionDto)cmbType.SelectedItem)?.Code
            };
            var result = bookRepository.GetBooksByOptionsAsOptions(dto);
            cmbBook.DataSource = result.Count == 0 ? null : result;
        }
    }
}
