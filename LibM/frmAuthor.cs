using LibM.Contracts.Author;
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
    public partial class frmAuthor : Form
    {
        private readonly AuthorRepository authorRepository;
        public frmAuthor()
        {
            InitializeComponent();
            authorRepository = new AuthorRepository();
        }

        private void frmAuthor_Load(object sender, EventArgs e)
        {
            dgvAuthor.DataSource = new BindingList<AuthorViewDto>(authorRepository.GetAllAuthors());
        }
    }
}
