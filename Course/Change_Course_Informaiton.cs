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
    public partial class Change_Course_Informaiton : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public string strCueID = "";
        public string strCueName = "";
        public string strCueNum = "";
        public string strCueTeacher = "";

        public Change_Course_Informaiton()
        {
            InitializeComponent();
        }

        private void Change_Course_Informaiton_Load(object sender, EventArgs e)
        {
            this.txtCueID.Text = strCueID;
            this.txtCueName.Text = strCueName;
            this.txtCueNum.Text = strCueNum;
            this.txtTeacher.Text = strCueTeacher;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtCueID.Text.Trim() == "" || this.txtCueName.Text.Trim() == "" || this.txtCueNum.Text.Trim() == "" || this.txtTeacher.Text.Trim() == "")
            {
                MessageBox.Show("请输入要修改课程的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        string sql = "UPDATE Course SET cue_id='" + this.txtCueID.Text.Trim() + "',cue_name='" + this.txtCueName.Text.Trim() +
                                    "',cue_number='" + this.txtCueNum.Text.Trim() + "',teacher='" + this.txtTeacher.Text.Trim() + "' WHERE cue_id='"+this.txtCueID.Text.Trim()+"';";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改课程信息成功！", "提示", MessageBoxButtons.OK);


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
    }
}
