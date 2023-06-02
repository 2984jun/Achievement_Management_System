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

namespace Achievement_Management_System.USER
{
    public partial class Register : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";
        public Register()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Register_Click(object sender, EventArgs e)
        {
            if(this.txtName.Text.Trim()==""||this.txtPassword.Text.Trim()==""||this.cmbPosition.Text=="") 
            {
                MessageBox.Show("请输入完整信息!", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }
            else
            {
                using(SqlConnection con=new SqlConnection(strConn)) 
                {
                    if (con.State == ConnectionState.Closed)
                    {
                        con.Open();
                    };

                    try 
                    {
                        SqlCommand cmd =new SqlCommand("SELECT * FROM account WHERE Uname='"+this.txtName.Text.Trim()+"';",con);
                        if (cmd.ExecuteScalar() != null)
                        {
                            MessageBox.Show("用户名重复，请重新输入！", "提示",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
                        }
                        else 
                        {
                            string sql = "INSERT INTO account(Uname,Upassword,Uidentity)VALUES('" + this.txtName.Text.Trim() + "','" + this.txtPassword.Text.Trim()
                                                                                            + "','" + this.cmbPosition.Text + "');";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("注册用户成功！", "提示",MessageBoxButtons.OKCancel);
                            this.txtName.Clear();
                            this.txtPassword.Clear();
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

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }
    }
}
