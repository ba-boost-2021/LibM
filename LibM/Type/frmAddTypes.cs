using LibM.Contracts.NewTypes;
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
    public partial class frmAddTypes : Form
    {
        private readonly TypesRepository typesRepository;
        public frmAddTypes()
        {
            InitializeComponent();
            typesRepository = new TypesRepository();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = typesRepository.CreateNewTypes(new NewAddTypesViewDto
            {
                Name = txtBookTypes.Text,
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

