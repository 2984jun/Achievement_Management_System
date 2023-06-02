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
    public partial class Change_Class_Information : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public string strClsID = "";
        public string strClsName = "";
        public string strMjrID = "";
        public string strTteNum = "";
        public string strHeadTea = "";

        public Change_Class_Information()
        {
            InitializeComponent();
        }

        private void Change_Class_Information_Load(object sender, EventArgs e)
        {
            this.txtClsId.Text = strClsID;
            this.txtClsName.Text = strClsName;
            this.txtMjrId.Text = strMjrID;
            this.txtClsNum.Text = strTteNum;
            this.txtHeadTea.Text = strHeadTea;
        }

        private void btnOK_Click(object sender, EventArgs e)
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
                        string sql = "UPDATE Class SET class_id='" + this.txtClsId.Text.Trim() + "',Class_name='" + this.txtClsName.Text.Trim() + "',Major_id='" + this.txtMjrId.Text.Trim() +
                                    "',totle_student='" + this.txtClsNum.Text.Trim() + "',Head_teacher='" + this.txtHeadTea.Text.Trim() + "' WHERE class_id='"+this.txtClsId.Text.Trim()+"';";
                        SqlCommand cmd = new SqlCommand(sql, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("修改班级信息成功！","提示",MessageBoxButtons.OK);

                        this.txtClsId.Clear();
                        this.txtClsName.Clear();
                        this.txtMjrId.Clear();
                        this.txtClsNum.Clear();
                        this.txtHeadTea.Clear();

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
