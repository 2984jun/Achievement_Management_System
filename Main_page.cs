using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Achievement_Management_System.USER;

namespace Achievement_Management_System
{
    public partial class Main_page : Form
    {
        public Main_page()
        {
            InitializeComponent();
        }

        private void 用户登录ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            User frmSignIn = new User();
            frmSignIn.Owner = this;
            frmSignIn.StartPosition = FormStartPosition.CenterParent;
            frmSignIn.ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Now_Time.Text = "时间为：" + DateTime.Now.ToString();
        }

    }
}
