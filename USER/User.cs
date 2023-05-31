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
    public partial class User : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=Grade_System;Integrated Security=True";
        public User()
        {
            InitializeComponent();
        }

        private void User_Load(object sender, EventArgs e)
        {
            cmbIdentity.SelectedIndex = 0;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSign_In_Click(object sender, EventArgs e)
        {
            if(txtUser.Text.Trim()==""|| txtPassWord.Text.Trim()=="")
            {
                MessageBox.Show("请输入用户名或密码!", "提示", 0);
            }
            else 
            {
                using(SqlConnection con=new SqlConnection(strConn)) 
                {
                    if(con.State==ConnectionState.Closed) 
                    {
                        con.Open();
                    }

                    try 
                    {
                        string sql1= "SELECT * FROM account WHERE Uname='" + this.txtUser.Text.Trim() + "'AND Upassword='" + this.txtPassWord.Text.Trim()+
                                      "'AND Uidentity='"+this.cmbIdentity.Text+"';";
                        SqlCommand cmd = new SqlCommand(sql1,con);
                        if (cmd.ExecuteScalar() != null)
                        {
                            Login_OK frmLogin = new Login_OK();
                            frmLogin.Owner = this;
                            frmLogin.StartPosition = FormStartPosition.CenterParent;
                            frmLogin.ShowDialog();
                        }
                        else 
                        {
                            string sql2 = "SELECT * FROM account WHERE Uname='" + this.txtUser.Text.Trim() + "';";
                            string sql3 = "SELECT * FROM account WHERE Upassword='" + this.txtPassWord.Text.Trim() + "';";
                            string sql4 = "SELECT * FROM account WHERE Uidentity='" + this.cmbIdentity.Text + "';";

                            cmd.CommandText = sql2;
                            if (cmd.ExecuteScalar() == null) 
                            {
                                MessageBox.Show("用户名错误!", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }

                            cmd.CommandText = sql3;
                            if(cmd.ExecuteScalar() == null) 
                            {
                                MessageBox.Show("密码错误!", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                            }

                            cmd.CommandText = sql4;
                            if(cmd.ExecuteScalar() == null) 
                            {
                                MessageBox.Show("职位错误!", "错误提示", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Register frmregister=new Register();
            frmregister.Owner = this;
            frmregister.StartPosition = FormStartPosition.CenterParent;
            frmregister.ShowDialog();
        }
    }
}
