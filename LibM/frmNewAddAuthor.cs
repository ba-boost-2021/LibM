using LibM.Contracts.NewAddAuthor;
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
    public partial class frmNewAddAuthor : Form
    {
        private readonly AuthorRepository authorRepository;
        public frmNewAddAuthor()
        {
            InitializeComponent();
            authorRepository = new AuthorRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = authorRepository.CreateNewAuthor (new NewAddAuthorViewDto
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
               
            });
            if (result)
            {
                MessageBox.Show("İşlem Başarılı.", "Başarılı", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Tekrar Deneyiniz.", "Başarısız İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

