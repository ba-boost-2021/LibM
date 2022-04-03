using LibM.Contracts.Employee;
using LibM.EmployeeManagement;
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
    public partial class frmEmployeeDatas : Form
    {
        private readonly EmployeeRepository employeeRepository;
        public frmEmployeeDatas()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            dgvEmployeeManagement.DataSource = new BindingList<EmployeeViewDto>(employeeRepository.GetAllEmployees());
        }

        private void btnNewEmployee_Click(object sender, EventArgs e)
        {
            var frmNewEmployee = new frmNewEmployeeData();
            frmNewEmployee.ShowDialog();
        }
    }
}
