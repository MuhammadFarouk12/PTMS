using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            btnLogin.BackColor = ColorTranslator.FromHtml("#005B9C"); // Blue
            btnCancle.BackColor = ColorTranslator.FromHtml("#005B9C");
            btnRegister.BackColor = ColorTranslator.FromHtml("#005B9C");
            guna2Panel2.BackColor = ColorTranslator.FromHtml("#E6F0F9");
            this.BackColor = ColorTranslator.FromHtml("#E0E0E0");

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

                    //This condition check if the student is stored it opened another form 
                    if (result != null && result.ToString() == password)
                    {
                        Form1 form1 = new Form1();
                        form1.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid ID or password.");
                    }
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to the Login Form!");
 
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtbFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void txb_phone_number_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void txtbLastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_Load_1(object sender, EventArgs e)
        {
            guna2Panel2.Location = new Point(
            (this.ClientSize.Width - guna2Panel2.Width) / 2,
            (this.ClientSize.Height - guna2Panel2.Height) / 2
            );
        }

        private void btnCancle_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void guna2Panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSignUP_Click_1(object sender, EventArgs e)
        {
            RegisterForm registerForm = new RegisterForm();
            registerForm.Show();
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {

        }
    }
}
