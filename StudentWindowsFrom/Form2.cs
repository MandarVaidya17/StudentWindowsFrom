using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFrom
{
    public partial class Form2 : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        SqlCommandBuilder scb;
        public Form2()
        {
            InitializeComponent();
            string constr = ConfigurationManager.ConnectionStrings["dbConnection"].ConnectionString;
            con = new SqlConnection(constr);

        }
        private void ClearFeilds()
        {
            txtStudID.Clear();
            txtStudName.Clear();
            txtStudAge.Clear();
            txtEmail.Clear();
        }
        private DataSet GetAllStudent()
        {
            string qry = "select * from student";
            da = new SqlDataAdapter(qry, con);
            
            da.MissingSchemaAction = MissingSchemaAction.AddWithKey;
            
            scb = new SqlCommandBuilder(da);
            ds = new DataSet();
            
            da.Fill(ds, "stud");
            return ds;

        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                
                DataRow row = ds.Tables["stud"].NewRow();
                row["studid"]=txtStudID.Text;
                row["studname"] = txtStudName.Text;
                row["studage"] = txtStudAge.Text;
                row["email"] = txtEmail.Text;
               
                ds.Tables["stud"].Rows.Add(row);
                int result = da.Update(ds.Tables["stud"]);
                if (result >= 1)
                {
                    MessageBox.Show("Record inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
           
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
           

        }

        private void btnShow_Click_1(object sender, EventArgs e)
        {
            ds = GetAllStudent();
            dataGridView1.DataSource = ds.Tables["stud"];
        }

        private void btnUpdate_Click_1(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].Rows.Find(txtStudID.Text);
                if (row != null)
                {
                    row["studname"] = txtStudName.Text;
                    row["studage"] = txtStudAge.Text;
                    row["email"] = txtEmail.Text;

                    int result = da.Update(ds.Tables["stud"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("record updated");
                        ClearFeilds();
                    }
                }
                else
                {
                    MessageBox.Show("record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].Rows.Find(txtStudID.Text);
                if (row != null)
                {
                    row.Delete();
                    int result = da.Update(ds.Tables["stud"]);
                    if (result >= 1)
                    {
                        MessageBox.Show("record deleted");
                        ClearFeilds();
                    }
                }
                else
                {
                    MessageBox.Show("record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click_1(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllStudent();
                DataRow row = ds.Tables["stud"].Rows.Find(txtStudID.Text);
                if (row != null)
                {
                    txtStudName.Text = row["studname"].ToString();
                    txtStudAge.Text = row["studage"].ToString();
                    txtEmail.Text = row["email"].ToString();
                }
                else
                {
                    MessageBox.Show("Record not inserted");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
