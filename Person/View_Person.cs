using Achievement_Management_System.Class;
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

    public partial class View_Person : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public View_Person()
        {
            InitializeComponent();
        }
        private void View_Person_Load(object sender, EventArgs e)
        {
            showinf();
        }


        private void dgvPerson_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void showinf() 
        {
            using(SqlConnection con=new SqlConnection(strConn)) 
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                try
                {
                    string sql = "SELECT student_id AS 学号,Sname AS 姓名,gender AS 性别,age AS 年龄,adress AS 家庭地址,phone AS 电话号码,class_id AS 班级ID FROM student ORDER BY student_id ASC";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds, "person");
                    this.dgvPerson.DataSource = ds.Tables[0].DefaultView;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("错误：" + ex.Message, "提示错误", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(this.dgvPerson.CurrentCell != null) 
            {
                Change_Person_Information change_Person_Information = new Change_Person_Information();

                change_Person_Information.strSdtID = this.dgvPerson[0,this.dgvPerson.CurrentCell.RowIndex].Value.ToString();
                change_Person_Information.strSdtName= this.dgvPerson[1, this.dgvPerson.CurrentCell.RowIndex].Value.ToString();
                change_Person_Information.strGender= this.dgvPerson[2, this.dgvPerson.CurrentCell.RowIndex].Value.ToString();
                change_Person_Information.strAge= this.dgvPerson[3, this.dgvPerson.CurrentCell.RowIndex].Value.ToString();
                change_Person_Information.strAdress= this.dgvPerson[4, this.dgvPerson.CurrentCell.RowIndex].Value.ToString();
                change_Person_Information.strphone= this.dgvPerson[5, this.dgvPerson.CurrentCell.RowIndex].Value.ToString();
                change_Person_Information.strClass_ID= this.dgvPerson[6, this.dgvPerson.CurrentCell.RowIndex].Value.ToString();

                change_Person_Information.StartPosition = FormStartPosition.CenterScreen;
                change_Person_Information.ShowDialog();
                if(change_Person_Information.DialogResult == DialogResult.OK) 
                {
                    showinf();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                try
                {
                    if (this.dgvPerson.CurrentCell != null)
                    {
                        string sql = "SELECT * FROM student s INNER JOIN Grade g ON s.student_id=g.student_id WHERE s.student_id='" +
                                this.dgvPerson[0, this.dgvPerson.CurrentCell.RowIndex].Value.ToString().Trim() + "';";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("删除学生:" + this.dgvPerson[1, this.dgvPerson.CurrentCell.RowIndex].Value.ToString().Trim() + "失败,请先删除与此学生相关的成绩！", "错误提示",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            sql = "DELETE FROM student WHERE student_id='" + this.dgvPerson[0, this.dgvPerson.CurrentCell.RowIndex].Value.ToString().Trim() + "';";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除学生:" + this.dgvPerson[1, this.dgvPerson.CurrentCell.RowIndex].Value.ToString().Trim() + "成功!", "提示", MessageBoxButtons.OK);
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
            showinf();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
