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

namespace Achievement_Management_System.Course
{
    public partial class View_Course : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public View_Course()
        {
            InitializeComponent();
        }

        private void View_Course_Load(object sender, EventArgs e)
        {
            showinf();
        }

        private void showinf() 
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                try
                {
                    string sql = "SELECT cue_id AS 课程编号,cue_name AS 课程名称,cue_number AS 选课人数,teacher AS 授课老师 FROM Course ORDER BY cue_id";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds, "Course");
                    this.dgvCourse.DataSource = ds.Tables[0].DefaultView;
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
            if (this.dgvCourse.CurrentCell != null) 
            {

                CourseAddUpdate courseAddUpdate = new CourseAddUpdate();
                courseAddUpdate.Text = "                           修改课程信息";

                courseAddUpdate.lblCueID.Text = this.dgvCourse[0, this.dgvCourse.CurrentCell.RowIndex].Value.ToString();
                courseAddUpdate.txtCueName.Text= this.dgvCourse[1, this.dgvCourse.CurrentCell.RowIndex].Value.ToString();
                courseAddUpdate.txtCueNum.Text= this.dgvCourse[2, this.dgvCourse.CurrentCell.RowIndex].Value.ToString();
                courseAddUpdate.txtTeacher.Text= this.dgvCourse[3, this.dgvCourse.CurrentCell.RowIndex].Value.ToString();
                courseAddUpdate.strSchema = "Update";
                courseAddUpdate.strlblCueID = true;
                courseAddUpdate.txtCueID.Visible = false;

                courseAddUpdate.Owner = this;
                courseAddUpdate.StartPosition = FormStartPosition.CenterScreen;
                courseAddUpdate.ShowDialog();
                if (courseAddUpdate.DialogResult == DialogResult.OK) 
                {
                    showinf();
                }
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
                    if (this.dgvCourse.CurrentCell != null)
                    {
                        string sql = "SELECT * FROM Course c INNER JOIN Grade g ON c.cue_id=g.cue_id WHERE c.cue_id='" +
                                this.dgvCourse[0, this.dgvCourse.CurrentCell.RowIndex].Value.ToString().Trim() + "';";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("删除" + this.dgvCourse[1, this.dgvCourse.CurrentCell.RowIndex].Value.ToString().Trim() + "课程失败,请先删除与此课程相关的成绩！", "错误提示",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            sql = "DELETE FROM Course WHERE cue_id='" + this.dgvCourse[0, this.dgvCourse.CurrentCell.RowIndex].Value.ToString().Trim() + "';";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除课程:" + this.dgvCourse[1, this.dgvCourse.CurrentCell.RowIndex].Value.ToString().Trim() + "课程成功!", "提示", MessageBoxButtons.OK);
                        }
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
            showinf();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showinf();
        }
    }
}
