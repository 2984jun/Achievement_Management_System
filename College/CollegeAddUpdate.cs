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

namespace Achievement_Management_System.College
{
    public partial class CollegeAddUpdate : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public string strSchema = "Add";
        public bool strlblID=false;
        public CollegeAddUpdate()
        {
            InitializeComponent();
        }

        private void CollegeAdd_Load(object sender, EventArgs e)
        {
            btnOK.DialogResult=DialogResult.OK;
            this.lblCleID.Visible = strlblID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (strSchema == "Add") 
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
                            SqlCommand cmd = new SqlCommand("SELECT * FROM College WHERE college_id='" + this.txtCollegeId.Text.Trim() + "' OR Sname='" + this.txtCollegeName.Text.Trim() + "';", con);
                            if (cmd.ExecuteScalar() != null)
                            {
                                MessageBox.Show("学院ID或学院名称重复，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string sql = "INSERT INTO College(college_id,Sname,major_amount,totle_people,Dean)VALUES('" + this.txtCollegeId.Text.Trim() + "','" + this.txtCollegeName.Text.Trim() +
                                    "','" + this.txtMajorNumber.Text.Trim() + "','" + this.txtClePpleTotle.Text.Trim() + "','" + this.txtDean.Text.Trim() + "');";

                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("添加学院信息成功！", "提示", MessageBoxButtons.OK);

                                this.txtCollegeId.Clear();
                                this.txtCollegeName.Clear();
                                this.txtMajorNumber.Clear();
                                this.txtDean.Clear();
                                this.txtClePpleTotle.Clear();

                                
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
            else 
            {
                
                if (this.txtCollegeName.Text.Trim() == "" || this.txtMajorNumber.Text.Trim() == "" ||
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

                            string sql = "UPDATE College SET Sname='" + this.txtCollegeName.Text.Trim() + "',major_amount='" + this.txtMajorNumber.Text.Trim() + "',totle_people='" + this.txtClePpleTotle.Text.Trim() + 
                                        "',Dean='" + this.txtDean.Text.Trim() +"' WHERE College_id='" + this.lblCleID.Text.Trim() + "';";

                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("修改学院信息成功！", "提示", MessageBoxButtons.OK);

                            this.txtCollegeId.Clear();
                            this.txtCollegeName.Clear();
                            this.txtMajorNumber.Clear();
                            this.txtDean.Clear();
                            this.txtClePpleTotle.Clear();

                            strSchema = "Add";

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
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
