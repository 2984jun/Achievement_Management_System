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
    public partial class Change_Major_Information : Form
    {

        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog=Grade_System;Integrated Security=True";

        public string strMjrID = "";
        public string strCleID = "";
        public string strMname = "";
        public string strClsNum = "";
        public string strTotPle = "";
        public string strLeader = "";

        public Change_Major_Information()
        {
            InitializeComponent();
        }

        private void Change_Major_Information_Load(object sender, EventArgs e)
        {
            this.txtCleId.Text = strCleID;
            this.txtMajorId.Text = strMjrID;
            this.txtMjrName.Text = strMname;
            this.txtMjrNum.Text = strClsNum;
            this.txtMjrTtePeople.Text = strTotPle;
            this.txtMjrGLeader.Text = strLeader;

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (this.txtMajorId.Text.Trim() == "" || this.txtCleId.Text.Trim() == "" || this.txtMjrName.Text.Trim() == "" ||
                this.txtMjrNum.Text.Trim() == "" || this.txtMjrTtePeople.Text.Trim() == "" || this.txtMjrGLeader.Text.Trim() == "")
            {
                MessageBox.Show("请输入要修改专业的完整信息!", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            else 
            {
                using(SqlConnection con=new SqlConnection(strConn)) 
                {
                    if(con.State==ConnectionState.Closed) 
                    {
                        con.Open();
                    };

                    try 
                    {
                        string sql = "UPDATE Major SET major_id='" + this.txtMajorId.Text.Trim() + "',college_id='" + this.txtCleId.Text.Trim() + "',Cname='" + this.txtMjrName.Text.Trim() +
                                   "',Class_num='" + this.txtMjrNum.Text.Trim() + "',totle_people='" + this.txtMjrTtePeople.Text.Trim() + "',Gleader='" + this.txtMjrGLeader.Text.Trim() +
                                   "' WHERE major_id='" + this.txtMajorId.Text.Trim() + "';";
                        SqlCommand cmd = new SqlCommand(sql,con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改专业信息成功！","提示",MessageBoxButtons.OK);

                        this.txtMajorId.Clear();
                        this.txtCleId.Clear();
                        this.txtMjrName.Clear();
                        this.txtMjrNum.Clear();
                        this.txtMjrTtePeople.Clear();
                        this.txtMjrGLeader.Clear();

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
