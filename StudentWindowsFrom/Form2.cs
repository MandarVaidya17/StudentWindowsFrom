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
        private DataSet GetAllEmployees()
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
                ds = GetAllEmployees();
                // create new row to add record
                DataRow row = ds.Tables["stud"].NewRow();
                row["name"] = txtStudName.Text;
                row["age"] = txtStudAge.Text;
                row["email"] = txtEmail.Text;
                //attach row to the emp table
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
            try
            {
                ds = GetAllEmployees();
                DataRow row = ds.Tables["stud"].Rows.Find(txtStudID.Text);
                if (row != null)
                {
                    row["name"] = txtStudName.Text;
                    row["age"] = txtStudAge.Text;
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
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                ds = GetAllEmployees();
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
        private void btnShowList_Click(object sender, EventArgs e)
        {
            ds = GetAllEmployees();
            dataGridView1.DataSource = ds.Tables["stud"];
        }
    }
}
