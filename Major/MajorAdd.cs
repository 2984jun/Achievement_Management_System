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

namespace Achievement_Management_System.Major
{
    public partial class MajorAdd : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public string strSchema = "Add";

        public MajorAdd()
        {
            InitializeComponent();
        }

        private void MajorAdd_Load(object sender, EventArgs e)
        {
            this.StartPosition = FormStartPosition.CenterParent;
            btnOK.DialogResult = DialogResult.OK;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (strSchema == "Add") 
            {
                if (this.txtMajorId.Text.Trim() == "" || this.txtCleId.Text.Trim() == "" || this.txtMjrName.Text.Trim() == "" ||
                this.txtMjrNum.Text.Trim() == "" || this.txtMjrTtePeople.Text.Trim() == "" || this.txtMjrGLeader.Text.Trim() == "")
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
                            SqlCommand cmd = new SqlCommand("SELECT * FROM Major WHERE Major_id='" + this.txtMajorId.Text.Trim() + "' OR Cname='" + this.txtMjrName.Text.Trim() + "';", con);
                            if (cmd.ExecuteScalar() != null)
                            {
                                MessageBox.Show("专业ID或专业名称重复，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string sql = "INSERT INTO Major(Major_id,college_id,Cname,class_num,totle_people,Gleader)VALUES('" + this.txtMajorId.Text.Trim() + "','" + this.txtCleId.Text.Trim() +
                                    "','" + this.txtMjrName.Text.Trim() + "','" + this.txtMjrNum.Text.Trim() + "','" + this.txtMjrTtePeople.Text.Trim() + "','" +
                                    this.txtMjrGLeader.Text.Trim() + "');";

                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("添加专业信息成功！", "提示", MessageBoxButtons.OK);

                                this.txtMajorId.Clear();
                                this.txtCleId.Clear();
                                this.txtMjrName.Clear();
                                this.txtMjrNum.Clear();
                                this.txtMjrTtePeople.Clear();
                                this.txtMjrGLeader.Clear();
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

                if (this.txtMajorId.Text.Trim() == "" || this.txtCleId.Text.Trim() == "" || this.txtMjrName.Text.Trim() == "" ||
                this.txtMjrNum.Text.Trim() == "" || this.txtMjrTtePeople.Text.Trim() == "" || this.txtMjrGLeader.Text.Trim() == "")
                {
                    MessageBox.Show("请输入要修改专业的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
                            string sql = "UPDATE Major SET major_id='" + this.txtMajorId.Text.Trim() + "',college_id='" + this.txtCleId.Text.Trim() + "',Cname='" + this.txtMjrName.Text.Trim() +
                                       "',Class_num='" + this.txtMjrNum.Text.Trim() + "',totle_people='" + this.txtMjrTtePeople.Text.Trim() + "',Gleader='" + this.txtMjrGLeader.Text.Trim() +
                                       "' WHERE major_id='" + this.txtMajorId.Text.Trim() + "';";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("修改专业信息成功！", "提示", MessageBoxButtons.OK);

                            this.txtMajorId.Clear();
                            this.txtCleId.Clear();
                            this.txtMjrName.Clear();
                            this.txtMjrNum.Clear();
                            this.txtMjrTtePeople.Clear();
                            this.txtMjrGLeader.Clear();

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
