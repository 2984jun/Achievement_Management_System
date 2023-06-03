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
    public partial class CourseAdd : Form
    {

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public CourseAdd()
        {
            InitializeComponent();
        }

        private void CourseAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtCueID.Text.Trim() == "" || this.txtCueName.Text.Trim() == "" || this.txtCueNum.Text.Trim() == "" || this.txtTeacher.Text.Trim()=="")
            {
                MessageBox.Show("请输入要添加专业的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        SqlCommand cmd = new SqlCommand("SELECT * FROM Course WHERE cue_id='" + this.txtCueID.Text.Trim() + "' OR cue_name='" + this.txtCueName.Text.Trim() + "';", con);
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("课程ID或课程名称重复，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string sql = "INSERT INTO Course(cue_id,cue_name,cue_number,teacher)VALUES('" + this.txtCueID.Text.Trim() + "','" + this.txtCueName.Text.Trim() +
                                "','" + this.txtCueNum.Text.Trim() + "','" + this.txtTeacher.Text.Trim() +  "');";

                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("添加课程信息成功！", "提示", MessageBoxButtons.OK);

                            this.txtCueID.Clear();
                            this.txtCueName.Clear();
                            this.txtCueNum.Clear();
                            this.txtTeacher.Clear();

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
