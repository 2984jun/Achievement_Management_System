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
    public partial class View_Major : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public View_Major()
        {
            InitializeComponent();
        }

        private void View_Major_Load(object sender, EventArgs e)
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
                    string sql = "SELECT Major_id AS 专业编号,college_id AS 学院编号,Cname AS 专业名称,Class_num AS 班级数量,totle_people AS 专业总人数,Gleader AS 专业组长 " +
                                 "FROM Major ORDER BY Major_id";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds, "Major");
                    this.dgvMajor.DataSource = ds.Tables[0].DefaultView;
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
            if (this.dgvMajor.CurrentCell != null) 
            {
                /*
                Change_Major_Information change_Major_Information = new Change_Major_Information();
                change_Major_Information.strMjrID= this.dgvMajor[0, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                change_Major_Information.strCleID= this.dgvMajor[1, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                change_Major_Information.strMname= this.dgvMajor[2, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                change_Major_Information.strClsNum= this.dgvMajor[3, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                change_Major_Information.strTotPle= this.dgvMajor[4, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                change_Major_Information.strLeader= this.dgvMajor[5, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();

                change_Major_Information.StartPosition=FormStartPosition.CenterScreen;
                change_Major_Information.ShowDialog();
                */

                MajorAddUpdate majorAdd=new MajorAddUpdate();
                majorAdd.Text = "                                   修改专业";

                majorAdd.txtMajorId.Text = this.dgvMajor[0, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                majorAdd.txtCleId.Text= this.dgvMajor[1, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                majorAdd.txtMjrName.Text= this.dgvMajor[2, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                majorAdd.txtMjrNum.Text= this.dgvMajor[3, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                majorAdd.txtMjrTtePeople.Text= this.dgvMajor[4, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();
                majorAdd.txtMjrGLeader.Text= this.dgvMajor[5, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim();

                majorAdd.strSchema = "Update";

                majorAdd.Owner = this;
                majorAdd.StartPosition=FormStartPosition.CenterScreen;               
                majorAdd.ShowDialog();

                if (majorAdd.DialogResult == DialogResult.OK) 
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
                    if (this.dgvMajor.CurrentCell != null)
                    {
                        string sql = "SELECT * FROM Major m INNER JOIN Class c ON m.Major_id=c.Major_id WHERE m.Major_id='" +
                                this.dgvMajor[0, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim() + "';";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("删除" + this.dgvMajor[2,this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim() + "专业失败,请先删除与此专业相关的班级！", "错误提示",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            sql = "DELETE FROM Major WHERE Major_id='" + this.dgvMajor[0, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim() + "';";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除" + this.dgvMajor[2, this.dgvMajor.CurrentCell.RowIndex].Value.ToString().Trim() + "专业成功!", "提示", MessageBoxButtons.OK);
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
