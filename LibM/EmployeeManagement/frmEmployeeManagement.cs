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

namespace LibM
{
    public partial class frmEmployeeManagement : Form
    {
        private readonly EmployeeRepository employeeRepository;
        public frmEmployeeManagement()
        {
            InitializeComponent();
            employeeRepository = new EmployeeRepository();
        }

        private void frmEmployeeManagement_Load(object sender, EventArgs e)
        {
            dgvEmployeeManagement.DataSource = new BindingList<EmployeeViewDto>(employeeRepository.GetAllEmployees());
        }
    }
}
