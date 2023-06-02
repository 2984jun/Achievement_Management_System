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

namespace Achievement_Management_System.College
{
    public partial class View_College : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public View_College()
        {
            InitializeComponent();
        }

        private void View_College_Load(object sender, EventArgs e)
        {
            showinf();
        }

        private void showinf() 
        {
            using (SqlConnection con = new SqlConnection(strConn))
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                };

                try
                {
                    string sql = "SELECT College_id AS 学院编号,Sname AS 学院名称,major_amount AS 专业数量,totle_people AS 学院总人数,Dean AS 院长 FROM College ORDER BY College_id";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds, "College");
                    this.dgv_College.DataSource = ds.Tables[0].DefaultView;
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
            if(this.dgv_College.CurrentCell!= null) 
            {
                Change_College_Information change_College_Information = new Change_College_Information();
                change_College_Information.strCollegeId = this.dgv_College[0,this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim();
                change_College_Information.strSname= this.dgv_College[1, this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim();
                change_College_Information.strMajor_Amount= this.dgv_College[2, this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim();
                change_College_Information.strTotle_People= this.dgv_College[3, this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim();
                change_College_Information.strDean= this.dgv_College[4, this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim();

                change_College_Information.StartPosition = FormStartPosition.CenterScreen;
                change_College_Information.ShowDialog();
                if (change_College_Information.DialogResult == DialogResult.OK)
                {
                    showinf();
                }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            using(SqlConnection con=new SqlConnection(strConn)) 
            {
                if (con.State == ConnectionState.Closed) 
                {
                    con.Open();
                };

                try 
                {
                    if (this.dgv_College.CurrentCell != null)
                    {
                        string sql = "SELECT * FROM College s INNER JOIN College c ON s.college_id=c.college_id WHERE s.college_id='" +
                                this.dgv_College[0, this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim() + "';";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("删除" + this.dgv_College[1, this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim() + "失败,请先删除与此学院相关的专业！", "错误提示",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            sql = "DELETE FROM School WHERE college_id='" + this.dgv_College[0, this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim() + "';";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除"+ this.dgv_College[1, this.dgv_College.CurrentCell.RowIndex].Value.ToString().Trim()+"成功!","提示",MessageBoxButtons.OK);
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
