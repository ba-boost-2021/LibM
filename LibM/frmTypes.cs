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
    public partial class frmTypes : Form
    {
        private readonly TypesRepository typesRepo;
        public frmTypes()
        {
            InitializeComponent();
            typesRepo = new TypesRepository();
        }

        private void frmTypes_Load(object sender, EventArgs e)
        {
            dgvTypes.DataSource = typesRepo.GetAllTypes();
        }
    }
}
