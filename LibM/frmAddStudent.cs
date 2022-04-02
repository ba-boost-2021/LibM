using LibM.Contracts.Student;
using LibM.Data.Entities.Enums;
using LibM.Services.Repositories;
using System.Data;

namespace LibM
{
    public partial class frmAddStudent : Form
    {
        private readonly StudentRepository studentRepository;
        public frmAddStudent()
        {
            InitializeComponent();
            studentRepository = new StudentRepository();
        }

        private void frmAddStudent_Load(object sender, EventArgs e)
        {
            cmbGender.DataSource = Enum.GetValues(typeof(Gender)).Cast<Gender>();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!CheckNullValues())
            {
                return;
            }
            var selectedGender = Gender.Male;
            if(cmbGender.SelectedIndex == 1)
            {
                selectedGender = Gender.Female;
            }
            if(cmbGender.SelectedIndex == 3)
            {
                selectedGender = Gender.NotSpecified;
            }
            var student = new StudentViewDto
            {
                FirstName = txtFirstname.Text,
                LastName = txtLastName.Text,
                Grade = txtGrade.Text,
                BirthDate = dtpBirthdate.Value,
                Id = new Guid(),
                Gender = selectedGender
            };

            var result = studentRepository.AddStudents(student);

            if(result == false)
            {
                MessageBox.Show("Hata");
                return;
            }
            MessageBox.Show("Başarılı");
            this.DialogResult = DialogResult.OK;
            this.Close();
                
        }

        private bool CheckNullValues()
        {
            if(cmbGender.SelectedItem == null)
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtFirstname.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtLastName.Text))
            {
                return false;
            }
            if (String.IsNullOrEmpty(txtGrade.Text))
            {
                return false;
            }
            return true;
        }
    }
}