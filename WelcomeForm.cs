using Guna.UI2.WinForms;
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
    public partial class WelcomeForm : Form
    {
        public WelcomeForm()
        {
            InitializeComponent();
            this.BackColor = ColorTranslator.FromHtml("#E6F0F9");
        }



        private void wlcmePanl_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WelcomeForm_Load(object sender, EventArgs e)
        {
            wlcmePanl.Location = new Point(
            (this.ClientSize.Width - wlcmePanl.Width) / 2,
            (this.ClientSize.Height - wlcmePanl.Height) / 2
            );
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            StudentLogin stdlogin = new StudentLogin();
            stdlogin.Show();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            AdminLogin adminlogin = new AdminLogin();
            adminlogin.Show();
        }
    }
}
