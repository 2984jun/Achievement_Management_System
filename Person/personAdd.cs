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

namespace Achievement_Management_System.Person
{
    public partial class personAdd : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public personAdd()
        {
            InitializeComponent();
        }

        private void personAdd_Load(object sender, EventArgs e)
        {
            
            cmbGender.Items.Add("男");
            cmbGender.Items.Add("女");
            cmbGender.SelectedIndex = 0;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtSdtId.Text.Trim() == "" || this.txtSdtName.Text.Trim() == "" || this.cmbGender.Text=="" || this.txtAge.Text.Trim()==""||
                this.txtAdress.Text.Trim()=="" || this.txtPhone.Text.Trim()=="" || this.txtClassId.Text.Trim() == "") 
            {
                MessageBox.Show("请输入要添加个人的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                using(SqlConnection con = new SqlConnection(strConn)) 
                {
                    if (con.State == ConnectionState.Closed) 
                    {
                        con.Open();
                    };

                    try 
                    {
                        SqlCommand cmd = new SqlCommand("SELECT * FROM student WHERE student_id='" + this.txtSdtId.Text.Trim() + "';",con);
                        if (cmd.ExecuteScalar() != null) 
                        {
                            MessageBox.Show("个人信息学号重复，请重新输入！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else 
                        {
                            string sql = "INSERT INTO student(student_id,Sname,gender,age,adress,phone,class_id)VALUES('" + this.txtSdtId.Text.Trim() + "','" + 
                                        this.txtSdtName.Text.Trim() + "','" +this.cmbGender.Text + "','" + this.txtAge.Text.Trim() + "','" + 
                                        this.txtAdress.Text.Trim() + "','" + this.txtPhone.Text.Trim() + "','" + this.txtClassId.Text.Trim() + "');";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("添加个人信息成功！", "提示", MessageBoxButtons.OK);

                            this.txtSdtId.Clear();
                            this.txtSdtName.Clear();
                            this.txtAge.Clear();
                            this.txtAdress.Clear();
                            this.txtPhone.Clear();
                            this.txtClassId.Clear();                        
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
