using LibM.Contracts.Employee;
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

namespace LibM.EmployeeManagement
{
    public partial class frmNewEmployeeData : Form
    {
        private readonly EmployeeRepository employeeRepository;
        public frmNewEmployeeData()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            var result = employeeRepository.CreateNewEmployee(new NewEmployeeDto
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Phone = txtPhone.Text
            });
            if (result)
            {
                MessageBox.Show("İşlem Başarılı, Yeni Çalışan kaydı oluşturuldu.", "Başarılı", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("İşlem Başarılı olmamıştır. Lütfen Tekrar Deneyiniz.", "Başarısız İşlem", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtPhone.Clear();

        }
    }
}
