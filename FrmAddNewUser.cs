using Project2.Model;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Text.RegularExpressions;


namespace Project2
{
    public partial class FrmAddNewUser : Form
    {
        string specialChars = "!@#$%^&*()-=,./';][`";
        Student stu = new Student();
        List<string> hobbie = new List<string>();
        private static readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://djangostudent-4ctn.onrender.com/api4c2/"),
        };

        public FrmAddNewUser()
        {
            InitializeComponent();
        }
        private void FrmAddNewUser_Load(object sender, EventArgs e)
        {

        }

        void ClearColumn()
        {
          
        }
        void GetVariableValue()
        {
           
        }
        private async void btnUpdate_Click(object sender, EventArgs e)
        {
          
        }
        private async void button2_Click(object sender, EventArgs e)
        {
         
        }

        private async void btnAddNew_Click(object sender, EventArgs e)
        {
           
        }

        private async void dgvStudentListRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnClear_Click(object sender, EventArgs e)
        {

        }

        private void txtPhotoUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dgvStudentListRegister_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
