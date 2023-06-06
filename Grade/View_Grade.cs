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
                        string sql = "SELECT g.Grade_id AS 成绩编号, c.college_id AS 学院编号,ce.cue_name AS 课程,s.student_id AS 学号,s.Sname AS 姓名,g.cue_grade AS 成绩 FROM College c INNER JOIN Major m ON c.college_id=m.college_id " +
                                "INNER JOIN Class cs ON m.major_id=cs.major_id INNER JOIN student s ON cs.class_id=s.class_id INNER JOIN Grade g ON s.student_id=g.student_id " +
                                "INNER JOIN Course ce ON g.cue_id=ce.cue_id WHERE c.Sname='" + this.cmbCollege.Text + "';";
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        DataSet ds = new DataSet();
                        ds.Clear();
                        adp.Fill(ds, "Grade_college");
                        this.dgvGaeCle.DataSource = ds.Tables[0].DefaultView;
                    }else if (strSchema == "major") 
                    {
                        string sql = "SELECT g.Grade_id AS 成绩编号,m.major_id AS 专业编号,ce.cue_name AS 课程,s.student_id AS 学号,s.Sname AS 姓名,g.cue_grade AS 成绩 FROM Major m INNER JOIN Class cs ON m.major_id=cs.major_id " +
                                "INNER JOIN student s ON cs.class_id=s.class_id INNER JOIN Grade g ON s.student_id=g.student_id INNER JOIN Course ce ON g.cue_id=ce.cue_id "+
                                " WHERE m.Cname='" + this.cmbCollege.Text + "';";
                        SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                        DataSet ds = new DataSet();
                        ds.Clear();
                        adp.Fill(ds, "Grade_major");
                        this.dgvGaeCle.DataSource = ds.Tables[0].DefaultView;
                    }else if(strSchema == "class") 
                    {
                        string sql = "SELECT g.Grade_id AS 成绩编号,cs.class_id AS 班级编号,ce.cue_name AS 课程,s.student_id AS 学号,s.Sname AS 姓名,g.cue_grade AS 成绩 FROM Class cs  INNER JOIN student s " +
                        "ON cs.class_id=s.class_id INNER JOIN Grade g ON s.student_id=g.student_id INNER JOIN Course ce ON g.cue_id=ce.cue_id WHERE cs.class_name='" + this.cmbCollege.Text + "';";
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
            if(this.dgvGaeCle.CurrentCell!=null) 
            {
                Change_Grade_Information change_Grade_Information = new Change_Grade_Information();
                change_Grade_Information.strID = this.dgvGaeCle[1, this.dgvGaeCle.CurrentCell.RowIndex].Value.ToString();
                change_Grade_Information.strCueName= this.dgvGaeCle[2, this.dgvGaeCle.CurrentCell.RowIndex].Value.ToString();
                change_Grade_Information.strSdtID= this.dgvGaeCle[3, this.dgvGaeCle.CurrentCell.RowIndex].Value.ToString();
                change_Grade_Information.strSdtName= this.dgvGaeCle[4, this.dgvGaeCle.CurrentCell.RowIndex].Value.ToString(); 
                change_Grade_Information.strGrade= this.dgvGaeCle[5, this.dgvGaeCle.CurrentCell.RowIndex].Value.ToString();

                if (strSchema == "college")
                {
                    change_Grade_Information.strSchema = "college";
                }
                else if(strSchema == "major")
                {
                    change_Grade_Information.strSchema = "major";
                }
                else 
                {
                    change_Grade_Information.strSchema = "class";
                }

                 change_Grade_Information.StartPosition = FormStartPosition.CenterScreen; 
                 change_Grade_Information.ShowDialog();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                try
                {
                    if (this.dgvGaeCle.CurrentCell != null)
                    {
                        string sql = "DELETE Grade FROM Grade g INNER JOIN Course c ON g.cue_id=c.cue_id WHERE c.cue_name='" + this.dgvGaeCle[2, this.dgvGaeCle.CurrentCell.RowIndex].Value.ToString() +
                                    "' AND g.student_id='" + this.dgvGaeCle[3, this.dgvGaeCle.CurrentCell.RowIndex].Value.ToString() + "';";


                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("删除" + this.dgvGaeCle[4,this.dgvGaeCle.CurrentCell.RowIndex].Value.ToString().Trim()+"成绩成功!，请点击“开始查询”更新成绩信息!","提示",MessageBoxButtons.OK);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
