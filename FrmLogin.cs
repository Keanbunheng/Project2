using Project2.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Http.Headers;
using System.Net.Http.Json;
using System.Collections.Specialized;

namespace Project2
{
    public partial class FrmLogin : Form
    {
        DateTime current;
        DateTime stopDuration;
        short isFail = 0;
        FrmAddNewUser frm = new FrmAddNewUser();
        private static readonly HttpClient client = new HttpClient()
        {
            BaseAddress = new Uri("https://djangostudent-4ctn.onrender.com/api4c2/"),
        };
        public FrmLogin()
        {
            InitializeComponent();
        }
        private async void btnLogin_Click(object sender, EventArgs e)
        {

        }
        private void btnCancel_Click(object sender, EventArgs e) => this.Close();

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
