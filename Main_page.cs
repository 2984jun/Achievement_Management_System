using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Achievement_Management_System.College;
using Achievement_Management_System.Major;
using Achievement_Management_System.USER;

namespace Achievement_Management_System
{
    public partial class Main_page : Form
    {
        public Main_page()
        {
            InitializeComponent();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Now_Time.Text = "时间为：" + DateTime.Now.ToString();
        }

        private void 学院管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 添加学院ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CollegeAdd collegeAdd = new CollegeAdd();
            collegeAdd.Owner = this;
            collegeAdd.StartPosition = FormStartPosition.CenterScreen;
            collegeAdd.ShowDialog();
        }

        private void 查看学院情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_College view_College = new View_College();
            view_College.Owner = this;
            view_College.StartPosition = FormStartPosition.CenterScreen;
            view_College.ShowDialog();
        }

        private void 添加专业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MajorAdd majorAdd = new MajorAdd();
            majorAdd.Owner = this;
            majorAdd.StartPosition = FormStartPosition.CenterScreen;
            majorAdd.ShowDialog();
        }

        private void 查看专业情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Major view_Major = new View_Major();
            view_Major.Owner = this;
            view_Major.StartPosition = FormStartPosition.CenterScreen;
            view_Major.ShowDialog();
        }
    }
}
