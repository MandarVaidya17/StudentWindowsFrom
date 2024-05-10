using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentWindowsFrom
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtusername.Text == "admin" && txtPass.Text == "admin")
            {
                MessageBox.Show("Login success");
                MDI mdi = new MDI();
                mdi.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("login fail");
            }
        }

    }
}
