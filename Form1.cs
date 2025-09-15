using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            Application.Run(new LoginForm());
        }
        public string ConnectionString = "Server=localhost;Database=OEAMS;Uid=root;pwd=1234567890";

        public bool CheckPassword(int id, string password)
        {
            using (MySqlConnection connection = new MySqlConnection(ConnectionString))
            {
                using (MySqlCommand checkPass = new MySqlCommand("select password from student where std_id = @std_id", connection))
                {
                    checkPass.Parameters.AddWithValue("@std_id", id);
                    connection.Open();
                    object result = checkPass.ExecuteScalar();
                    return result != null && result.ToString() == password;
                }
            }
        }




        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           
        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {

        }

        private void Logo_Click(object sender, EventArgs e)
        {
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
