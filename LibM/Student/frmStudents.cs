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
    public partial class frmStudents : Form
    {
        private readonly StudentRepository studentRepository;
        public frmStudents()
        {
            InitializeComponent();
            studentRepository = new StudentRepository();
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            dgvStudents.DataSource = studentRepository.GetAllStudent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addStudent = new frmAddStudent();
           var result =  addStudent.ShowDialog();
            if(result == DialogResult.OK)
            {
                dgvStudents.DataSource = null;
                dgvStudents.DataSource = studentRepository.GetAllStudent();
            }
        }
    }
}
