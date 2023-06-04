using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achievement_Management_System.USER
{
    public partial class Login_OK : Form
    {
        public Login_OK()
        {
            InitializeComponent();
        }

        private void Login_OK_Load(object sender, EventArgs e)
        {

            this.StartPosition = FormStartPosition.CenterScreen;

        }

        private void btnLoginIn_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.Owner = this;
            user.StartPosition = FormStartPosition.CenterScreen;
            user.ShowDialog();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
