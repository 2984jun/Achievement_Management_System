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
using Achievement_Management_System.Class;
using Achievement_Management_System.College;
using Achievement_Management_System.Course;
using Achievement_Management_System.Grade;
using Achievement_Management_System.Major;
using Achievement_Management_System.Person;
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
            view_College.Show();
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
            view_Major.Show();
        }

        private void 添加班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ClassAdd classAdd = new ClassAdd();
            classAdd.Owner = this;
            classAdd.StartPosition = FormStartPosition.CenterScreen;
            classAdd.ShowDialog();
        }

        private void 查看班级情况ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Class view_Class = new View_Class();
            view_Class.Owner = this;
            view_Class.StartPosition = FormStartPosition.CenterScreen;
            view_Class.Show();
        }

        private void 添加个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            personAdd personAdd= new personAdd();
            personAdd.Owner = this;
            personAdd.StartPosition = FormStartPosition.CenterScreen;
            personAdd.ShowDialog();
        }

        private void 查看个人信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Person view_Person = new View_Person();
            view_Person.Owner = this;
            view_Person.StartPosition = FormStartPosition.CenterScreen;
            view_Person.Show();
        }

        private void 添加课程ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CourseAdd courseAdd= new CourseAdd();
            courseAdd.Owner = this;
            courseAdd.StartPosition = FormStartPosition.CenterScreen;
            courseAdd.ShowDialog();
        }

        private void 查看课程信息ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            View_Course view_Course = new View_Course();
            view_Course.Owner = this;
            view_Course.StartPosition = FormStartPosition.CenterScreen;
            view_Course.Show();
        }

        private void 添加学生成绩ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GradeAdd gradeAdd= new GradeAdd();
            gradeAdd.Owner = this;
            gradeAdd.StartPosition = FormStartPosition.CenterScreen;
            gradeAdd.ShowDialog();
        }

        private void 成绩学院ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grade_College grade_College = new Grade_College();

            grade_College.strSchema = "college";

            string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

            using (SqlConnection con = new SqlConnection(strConn))
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                SqlCommand cmd = new SqlCommand("SELECT Sname FROM College", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                grade_College.cmbCollege.DisplayMember = "Sname";
                grade_College.cmbCollege.ValueMember = "college_id";
                grade_College.cmbCollege.DataSource = ds.Tables[0].DefaultView;
            }
            grade_College.Owner = this;
            grade_College.StartPosition = FormStartPosition.CenterScreen;
            grade_College.Show();
        }

        private void 成绩专业ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grade_College grade_College = new Grade_College();

            string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";
            
            grade_College.strSchema = "major";

            using (SqlConnection con = new SqlConnection(strConn))
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                SqlCommand cmd = new SqlCommand("SELECT Cname FROM Major", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                grade_College.cmbCollege.DisplayMember = "Cname";
                grade_College.cmbCollege.ValueMember = "major_id";
                grade_College.cmbCollege.DataSource = ds.Tables[0].DefaultView;
            }
            grade_College.Owner = this;
            grade_College.StartPosition = FormStartPosition.CenterScreen;
            grade_College.Show();
        }

        private void 成绩班级ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Grade_College grade_College = new Grade_College();

            string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

            grade_College.strSchema = "class";

            using (SqlConnection con = new SqlConnection(strConn))
            {

                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                SqlCommand cmd = new SqlCommand("SELECT Class_name FROM Class", con);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                da.Fill(ds);

                grade_College.cmbCollege.DisplayMember = "class_name";
                grade_College.cmbCollege.ValueMember = "class_id";
                grade_College.cmbCollege.DataSource = ds.Tables[0].DefaultView;
            }
            grade_College.Owner = this;
            grade_College.StartPosition = FormStartPosition.CenterScreen;
            grade_College.Show();
        }
    }
}
