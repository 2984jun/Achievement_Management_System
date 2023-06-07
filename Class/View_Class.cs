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
    public partial class View_Class : Form
    {
        public static string strConn = "Data Source=DESKTOP-SK9ALMG;Initial Catalog = Management_System; Integrated Security = True";

        public View_Class()
        {
            InitializeComponent();
        }

        private void View_Class_Load(object sender, EventArgs e)
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
                    string sql = "SELECT class_id AS 班级编号,Class_name AS 班级名称,major_id AS 专业编号,totle_student AS 班级人数,Head_teacher AS 班主任 FROM Class ORDER BY class_id ASC";
                    SqlDataAdapter adp = new SqlDataAdapter(sql, con);
                    DataSet ds = new DataSet();
                    ds.Clear();
                    adp.Fill(ds, "class");
                    this.dgvClass.DataSource = ds.Tables[0].DefaultView;
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
            if(this.dgvClass.CurrentCell != null)
            {
                ClassAddUpdate classAddUpdate = new ClassAddUpdate();
                classAddUpdate.Text = "                         修改班级信息";

                classAddUpdate.lblClsID.Text= this.dgvClass[0, this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim();
                classAddUpdate.txtClsName.Text= this.dgvClass[1,this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim();
                classAddUpdate.txtMjrId.Text= this.dgvClass[2, this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim();
                classAddUpdate.txtClsNum.Text= this.dgvClass[3, this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim();
                classAddUpdate.txtHeadTea.Text= this.dgvClass[4, this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim();
                classAddUpdate.strSchema = "Update";

                classAddUpdate.strlblClassID = true;
                classAddUpdate.txtClsId.Visible = false;

                classAddUpdate.StartPosition = FormStartPosition.CenterScreen;
                classAddUpdate.ShowDialog();
                if(classAddUpdate.DialogResult == DialogResult.OK) 
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
                    if (this.dgvClass.CurrentCell != null)
                    {
                        string sql = "SELECT * FROM Class c INNER JOIN student s ON c.class_id=s.class_id WHERE c.class_id='" +
                                this.dgvClass[0, this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim() + "';";

                        SqlCommand cmd = new SqlCommand(sql, con);
                        SqlDataReader dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            MessageBox.Show("删除" + this.dgvClass[0, this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim() + "失败,请先删除与此班级相关的学生！", "错误提示",
                                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            dr.Close();
                            sql = "DELETE FROM Class WHERE class_id='" + this.dgvClass[0, this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim() + "';";
                            cmd.CommandText = sql;
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("删除" + this.dgvClass[1, this.dgvClass.CurrentCell.RowIndex].Value.ToString().Trim() + "成功!", "提示", MessageBoxButtons.OK);
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

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            showinf();
        }
    }
}
