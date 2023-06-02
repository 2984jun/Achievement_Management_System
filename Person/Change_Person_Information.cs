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
    public partial class Change_Person_Information : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public string strSdtID = "";
        public string strSdtName = "";
        public string strGender = "";
        public string strAge = "";
        public string strAdress = "";
        public string strphone = "";
        public string strClass_ID = "";

        public Change_Person_Information()
        {
            InitializeComponent();
        }

        private void Change_Person_Information_Load(object sender, EventArgs e)
        {
            this.cmbGender.Items.Add("男");
            this.cmbGender.Items.Add("女");

            this.txtSdtId.Text = strSdtID;
            this.txtSdtName.Text = strSdtName;
            this.cmbGender.Text = strGender;
            this.txtAge.Text = strAge;
            this.txtAdress.Text = strAdress;
            this.txtPhone.Text = strphone;
            this.txtClassId.Text = strClass_ID;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtSdtId.Text.Trim() == "" || this.txtSdtName.Text.Trim() == "" || this.cmbGender.Text == "" || this.txtAge.Text.Trim() == "" ||
                this.txtAdress.Text.Trim() == "" || this.txtPhone.Text.Trim() == "" || this.txtClassId.Text.Trim() == "")
            {
                MessageBox.Show("请输入要修改的个人的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                        string sql = "UPDATE student SET student_id='" + this.txtSdtId.Text.Trim() + "',Sname='" + this.txtSdtName.Text.Trim() + "',gender='" + this.cmbGender.Text +
                            "',age='" + this.txtAge.Text.Trim()+"',adress='"+this.txtAdress.Text.Trim() + "',class_id='" + this.txtClassId.Text.Trim() + "',phone='" + 
                            this.txtPhone.Text.Trim() +"' WHERE student_id='" + this.txtSdtId.Text.Trim() + "';";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改个人信息成功！", "提示", MessageBoxButtons.OK);

                        this.txtSdtId.Clear();
                        this.txtSdtName.Clear();
                        this.txtAge.Clear();
                        this.txtAdress.Clear();
                        this.txtPhone.Clear();
                        this.txtClassId.Clear();
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
