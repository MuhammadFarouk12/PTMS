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
    public partial class RegisterForm : Form
    {
        public RegisterForm()
        {
            InitializeComponent();

            btnCancle.BackColor = ColorTranslator.FromHtml("#005B9C"); // Blue
            btnSignUP.BackColor = ColorTranslator.FromHtml("#005B9C");
            guna2Panel2.BackColor = ColorTranslator.FromHtml("#E6F0F9");
            this.BackColor = ColorTranslator.FromHtml("#E0E0E0");
        }
        public string ConnectionString = "Server=localhost;Database=OEAMS;Uid=root;pwd=himo7723**";

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnCancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSignUP_Click(object sender, EventArgs e)
        {

        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            guna2Panel2.Location = new Point(
(this.ClientSize.Width - guna2Panel2.Width) / 2,
(this.ClientSize.Height - guna2Panel2.Height) / 2
);
        }
    }
}
