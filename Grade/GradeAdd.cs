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

namespace Achievement_Management_System.Grade
{
    public partial class GradeAdd : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public GradeAdd()
        {
            InitializeComponent();
        }
        private void GradeAdd_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (this.txtCueID.Text.Trim() == "" || this.txtGaeID.Text.Trim() == "" || this.txtSdtID.Text.Trim() == "" || this.txtCueGrade.Text.Trim() == "")
            {
                MessageBox.Show("请输入要添加成绩的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
                {
                using (SqlConnection con = new SqlConnection(strConn))
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    };

                    try
                    {
                        bool flag=true;

                        SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE student_id='" + this.txtSdtID.Text.Trim() + "';", con);
                        if (cmd.ExecuteScalar() == null)
                        {
                            MessageBox.Show("不存在该学生，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = false;
                        };

                        cmd.CommandText ="SELECT * FROM Grade WHERE Grade_id='" + this.txtGaeID.Text.Trim() + "';";
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("成绩编号已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = false;
                        };

                        cmd.CommandText = "SELECT * FROM Course WHERE cue_id='" + this.txtCueID.Text.Trim() + "';";
                        if (cmd.ExecuteScalar() == null)
                        {
                            MessageBox.Show("不存在该课程，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            flag = false;
                        };

                        string sql="SELECT * FROM Grade g INNER JOIN student s ON g.student_id=s.student_id WHERE s.student_id='" + this.txtSdtID.Text.Trim() + "' AND g.cue_id='" +
                                                        this.txtCueID.Text.Trim() + "';";                     

                        cmd.CommandText = sql;
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("该学生课程成绩已存在，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else if(flag)
                        {
                            sql = "INSERT INTO Grade(Grade_id,student_id,cue_id,cue_grade)VALUES('" + this.txtGaeID.Text.Trim() + "','" + this.txtSdtID.Text.Trim() 
                                 + "','" + this.txtCueID.Text.Trim() + "','" + this.txtCueGrade.Text.Trim() + "');";

                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("添加学生成绩信息成功！", "提示", MessageBoxButtons.OK);

                            this.txtCueID.Clear();
                            this.txtGaeID.Clear();
                            this.txtSdtID.Clear();
                            this.txtCueGrade.Clear();
                            
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtCueGrade_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
