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

namespace Achievement_Management_System.College
{
    public partial class Change_College_Information : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=Grade_System;Integrated Security=True";

        public string strCollegeId = "";
        public string strSname = "";
        public string strMajor_Amount = "";
        public string strTotle_People = "";
        public string strDean = "";

        public Change_College_Information()
        {
            InitializeComponent();
        }

        private void Change_College_Information_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterScreen;

            this.txtCollegeId.Text = strCollegeId;
            this.txtCollegeName.Text = strSname;
            this.txtMajorNumber.Text = strMajor_Amount;
            this.txtClePpleTotle.Text = strTotle_People;
            this.txtDean.Text = strDean;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtCollegeId.Text.Trim() == "" || this.txtCollegeName.Text.Trim() == "" || this.txtMajorNumber.Text.Trim() == "" ||
                this.txtClePpleTotle.Text.Trim() == "" || this.txtDean.Text.Trim() == "")
            {
                MessageBox.Show("请输入学院的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        /*
                        SqlCommand cmd = new SqlCommand("SELECT * FROM School WHERE college_id='" + this.txtCollegeId.Text.Trim() + "' OR Sname='" + this.txtCollegeName.Text.Trim() + "';", con);
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("学院ID或学院名称重复，请重新输入！", "提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string sql = "UPDATE School SET College_id='" + this.txtCollegeId.Text.Trim() + "',Sname='" + this.txtCollegeName.Text.Trim() +
                                "',major_amount='" + this.txtMajorNumber.Text.Trim() + "',totle_people='" + this.txtClePpleTotle.Text.Trim() + "',Dean='" + this.txtDean.Text.Trim() + "');";

                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("修改学院信息成功！", "提示", MessageBoxButtons.OK);

                            this.txtCollegeId.Clear();
                            this.txtCollegeName.Clear();
                            this.txtMajorNumber.Clear();
                            this.txtDean.Clear();
                            this.txtClePpleTotle.Clear();
                        }
                        */
                        
                        string sql = "UPDATE School SET College_id='" + this.txtCollegeId.Text.Trim() + "',Sname='" + this.txtCollegeName.Text.Trim() +
                                "',major_amount='" + this.txtMajorNumber.Text.Trim() + "',totle_people='" + this.txtClePpleTotle.Text.Trim() + "',Dean='" + this.txtDean.Text.Trim() 
                                + "'WHERE College_id='"+this.txtCollegeId.Text.Trim()+"';";

                        SqlCommand cmd = new SqlCommand(sql,con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改学院信息成功！", "提示", MessageBoxButtons.OK);

                        this.txtCollegeId.Clear();
                        this.txtCollegeName.Clear();
                        this.txtMajorNumber.Clear();
                        this.txtDean.Clear();
                        this.txtClePpleTotle.Clear();

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
