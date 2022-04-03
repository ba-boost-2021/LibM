using LibM.Contracts;
using LibM.Contracts.Books;
using LibM.Data.Access;
using LibM.Data.Access.Managers;
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
    public partial class frmAddBooks : Form
    {
        private readonly TypesRepository typesRepository;
        private readonly AuthorRepository authorRepository;
        private readonly BookRepository bookRepository;
        
        public frmAddBooks()
        {
            InitializeComponent();
            typesRepository = new TypesRepository();  
            authorRepository = new AuthorRepository();
            bookRepository = new BookRepository();  
           
        }

        private void frmAddBooks_Load(object sender, EventArgs e)
        {
            cmbType.DataSource = typesRepository.GetTypesAsOptions();
            cmbAuthor.DataSource = authorRepository.GetAuthorsAsOptions();

            cmbType.DisplayMember = nameof(OptionDto.Label);
            cmbAuthor.DisplayMember = nameof(OptionDto.Label);

            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          

            var type = cmbType.SelectedItem;

            var book = new NewBookDto()
            { 
                 
                 Name= txtName.Text,
                  PageCount= Convert.ToInt32( txtPageCount.Text),
                   AuthorId = ((OptionDto)cmbAuthor.SelectedItem).Code,
                     TypeId = ((OptionDto)cmbType.SelectedItem).Code,

            };
            bookRepository.AddNewBook(book);
            
            this.Close();
        }
    }
}
