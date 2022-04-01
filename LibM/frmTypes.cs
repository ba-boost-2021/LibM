using LibM.Services.Repositories;

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