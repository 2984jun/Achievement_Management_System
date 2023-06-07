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

namespace Achievement_Management_System.Class
{
    public partial class ClassAddUpdate : Form
    {

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public string strSchema = "Add";
        public bool strlblClassID=false;
        public ClassAddUpdate()
        {
            InitializeComponent();
        }

        private void ClassAdd_Load(object sender, EventArgs e)
        {
            btnOK.DialogResult=DialogResult.OK;
            this.lblClsID.Visible = strlblClassID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (strSchema == "Add") 
            {
                if (this.txtClsId.Text.Trim() == "" || this.txtClsName.Text.Trim() == "" || this.txtMjrId.Text.Trim() == "" ||
                this.txtClsNum.Text.Trim() == "" || this.txtHeadTea.Text.Trim() == "")
                {
                    MessageBox.Show("请输入要添加班级的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                                SqlCommand cmd = new SqlCommand("SELECT * FROM Class WHERE class_id='" + this.txtClsId.Text.Trim() + "' OR class_name='" + this.txtClsName.Text.Trim() + "';", con);
                            if (cmd.ExecuteScalar() != null)
                            {
                                MessageBox.Show("班级ID或班级名称重复，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else
                            {
                                string sql = "SELECT * FROM Major WHERE major_id='" + this.txtMjrId.Text.Trim() + "';";
                                cmd.CommandText = sql;
                                if (cmd.ExecuteScalar() == null)
                                {
                                    MessageBox.Show("不存在该专业，请重新输入专业编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                }
                                else
                                {
                                    sql = "INSERT INTO Class(class_id,class_name,major_id,totle_student,Head_teacher)VALUES('" + this.txtClsId.Text.Trim() + "','" + this.txtClsName.Text.Trim() +
                                    "','" + this.txtMjrId.Text.Trim() + "','" + this.txtClsNum.Text.Trim() + "','" + this.txtHeadTea.Text.Trim() + "');";

                                    cmd.CommandText = sql;
                                    cmd.ExecuteNonQuery();
                                    MessageBox.Show("添加班级信息成功！", "提示", MessageBoxButtons.OK);

                                    this.txtClsId.Clear();
                                    this.txtClsName.Clear();
                                    this.txtMjrId.Clear();
                                    this.txtClsNum.Clear();
                                    this.txtHeadTea.Clear();
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
                }
            }
            else 
            {
                if (this.txtClsName.Text.Trim() == "" || this.txtMjrId.Text.Trim() == "" ||
                this.txtClsNum.Text.Trim() == "" || this.txtHeadTea.Text.Trim() == "")
                {
                    MessageBox.Show("请输入要添加班级的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                            string sql = "SELECT * FROM Major WHERE major_id='" + this.txtMjrId.Text.Trim() + "';";
                            SqlCommand cmd = new SqlCommand(sql, con);
                            if (cmd.ExecuteScalar() == null)
                            {
                                MessageBox.Show("不存在该专业，请重新输入专业编号！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            else 
                            {
                                sql = "UPDATE Class SET Class_name='" + this.txtClsName.Text.Trim() + "',Major_id='" + this.txtMjrId.Text.Trim() +
                                        "',totle_student='" + this.txtClsNum.Text.Trim() + "',Head_teacher='" + this.txtHeadTea.Text.Trim() + "' WHERE class_id='" + this.lblClsID.Text.Trim() + "';";
                                cmd.CommandText = sql;
                                cmd.ExecuteNonQuery();
                                MessageBox.Show("修改班级信息成功！", "提示", MessageBoxButtons.OK);

                                this.txtClsId.Clear();
                                this.txtClsName.Clear();
                                this.txtMjrId.Clear();
                                this.txtClsNum.Clear();
                                this.txtHeadTea.Clear();

                                strSchema = "Add";
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
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
