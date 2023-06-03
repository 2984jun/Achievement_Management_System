using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Achievement_Management_System.Grade
{
    public partial class View_Grade : Form
    {

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public string strSchema = "";

        public View_Grade()
        {
            InitializeComponent();
        }

        private void dgvGaeCle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Grade_College_Load(object sender, EventArgs e)
        {
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                try
                {
                    if (strSchema == "college") 
                    {
                        string sql = "SELECT c.college_id AS 学院编号,ce.cue_name AS 课程,s.student_id AS 学号,s.Sname AS 姓名,cue_grade AS 成绩 FROM College c INNER JOIN Major m ON c.college_id=m.college_id " +
                                "INNER JOIN Class cs ON m.major_id=cs.major_id INNER JOIN student s ON cs.class_id=s.class_id INNER JOIN Grade g ON s.student_id=g.student_id " +
                                "INNER JOIN Course ce ON g.cue_id=ce.cue_id WHERE c.Sname='" + this.cmbCollege.Text + "';";
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        DataSet ds = new DataSet();
                        ds.Clear();
                        adp.Fill(ds, "Grade_college");
                        this.dgvGaeCle.DataSource = ds.Tables[0].DefaultView;
                    }else if (strSchema == "major") 
                    {
                        string sql = "SELECT m.major_id AS 专业编号,ce.cue_name AS 课程,s.student_id AS 学号,s.Sname AS 姓名,cue_grade AS 成绩 FROM Major m INNER JOIN Class cs ON m.major_id=cs.major_id " +
                        "INNER JOIN student s ON cs.class_id=s.class_id INNER JOIN Grade g ON s.student_id=g.student_id INNER JOIN Course ce ON g.cue_id=ce.cue_id WHERE m.Cname='" + this.cmbCollege.Text + "';";
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        DataSet ds = new DataSet();
                        ds.Clear();
                        adp.Fill(ds, "Grade_major");
                        this.dgvGaeCle.DataSource = ds.Tables[0].DefaultView;
                    }else if(strSchema == "class") 
                    {
                        string sql = "SELECT cs.class_id AS 班级编号,ce.cue_name AS 课程,s.student_id AS 学号,s.Sname AS 姓名,cue_grade AS 成绩 FROM Class cs  INNER JOIN student s " +
                        "ON cs.class_id=s.class_id INNER JOIN Grade g ON s.student_id=g.student_id " + "INNER JOIN Course ce ON g.cue_id=ce.cue_id WHERE cs.class_name='" + this.cmbCollege.Text + "';";
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        DataSet ds = new DataSet();
                        ds.Clear();
                        adp.Fill(ds, "Grade_class");
                        this.dgvGaeCle.DataSource = ds.Tables[0].DefaultView;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "提示错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                finally
                {
                    if (con.State == ConnectionState.Open)
                    {
                        con.Close();
                        con.Dispose();
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }
    }
}
