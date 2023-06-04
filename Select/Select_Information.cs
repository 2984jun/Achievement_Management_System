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

namespace Achievement_Management_System.Select
{
    public partial class Select_Information : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public Select_Information()
        {
            InitializeComponent();
        }

        private void Select_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strConn)) 
            {
                if(con.State==ConnectionState.Closed) 
                {
                    con.Open();
                };

                try 
                {
                    string sql = "SELECT s.student_id AS 学号,s.Sname AS 姓名,s.gender AS 性别,s.age AS 年龄,s.adress AS 家庭地址,s.phone AS 联系电话,c.Sname AS 所在学院,m.Cname AS 所在专业," +
                            "cs.Class_name AS 所在班级,(SELECT COUNT(*) FROM Course INNER JOIN Grade ON Course.cue_id=Grade.cue_id WHERE Grade.student_name='"+this.txtName.Text.Trim()+"') AS 所修课程数量" +
                           " FROM College c INNER JOIN Major m ON c.college_id=m.college_id INNER JOIN Class cs ON m.major_id=cs.major_id INNER JOIN student s ON cs.class_id=s.class_id " +
                           "WHERE s.Sname='" + this.txtName.Text.Trim() + "';";
                    SqlCommand cmd =new SqlCommand(sql,con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    if(!dr.Read()) 
                    {
                        MessageBox.Show("学校没有该学生！","提示",MessageBoxButtons.OK);
                    }
                    dr.Close();

                    SqlDataAdapter da = new SqlDataAdapter(sql,con);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    da.Fill(ds, "Select");
                    this.dgvSelect.DataSource = ds.Tables[0].DefaultView;

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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
