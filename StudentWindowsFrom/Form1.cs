using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentWindowsFrom
{
    public partial class Form1 : Form
        
    
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Form1()
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


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtStudID_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "insert into student values(@id,@name,@age,@email)";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtStudID.Text);
                cmd.Parameters.AddWithValue("@name", txtStudName.Text);
                cmd.Parameters.AddWithValue("@age", txtStudAge.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record INserted");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("NOt inserted");

                ClearFeilds();
            }
            finally { con.Close(); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "update student set studname=@name,studage=@age,email=@email where studid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@name", txtStudName.Text);
                cmd.Parameters.AddWithValue("@age", txtStudAge.Text);
                cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@id", txtStudID.Text);

                con.Open();
                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record updated");
                    ClearFeilds();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { con.Close(); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "delete from student where studid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtStudID.Text);
                con.Open();

                int result = cmd.ExecuteNonQuery();
                if (result >= 1)
                {
                    MessageBox.Show("Record deleted");
                    ClearFeilds();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student where studid=@id";
                cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@id", txtStudID.Text);
                con.Open();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        txtStudName.Text = dr["name"].ToString();
                        txtStudAge.Text = dr["age"].ToString();
                        txtEmail.Text = dr["salary"].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Record not found");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string qry = "select * from student";
                cmd = new SqlCommand(qry, con);
                con.Open();
                dr = cmd.ExecuteReader();

                DataTable table = new DataTable();
                table.Load(dr);
                dataGridView1.DataSource = table;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}
