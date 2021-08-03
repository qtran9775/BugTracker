using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace BugTracker
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=userData.mdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

        private void register_Click(object sender, EventArgs e)
        {
            con.Open();
            string login = "SELECT * FROM userData WHERE userName= '" + txtUserName.Text + "' and password= '" + txtpassword.Text + "'";
            cmd = new OleDbCommand(login, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if(dr.Read() == true)
            {
                new DashBoard().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Text = "";
                txtpassword.Text = "";
                txtUserName.Focus();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtUserName.Text = "";
            txtpassword.Text = "";
            txtUserName.Focus();
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (showPassword.Checked)
            {
                txtpassword.PasswordChar = '\0';
            }
            else
            {
                txtpassword.PasswordChar = '*';
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            new RegistrationForm().Show();
            this.Hide();
        }
    }
}
