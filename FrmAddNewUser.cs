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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void picUrl_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void pnInfoInput_SizeChanged(object sender, EventArgs e)
        {
            //pnInfoInput.Width = 1000;
        }

        private void tableLayoutPanel1_SizeChanged(object sender, EventArgs e)
        {
            if (tableLayoutPanel1.ColumnStyles.Count > 0)
            {
                // Option A: Set a fixed width in pixels (e.g., 200px)
                tableLayoutPanel1.ColumnStyles[0].SizeType = SizeType.Percent;
                tableLayoutPanel1.ColumnStyles[0].Width = 30;
                pnPicture.Width += 15;
                pnPicture.Width += 10;
            }
        }

    }
}
