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
namespace Mobile_Shop
{
    public partial class login_form : Form
    {
        string spath = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leosoft\Documents\Visual Studio 2015\Projects\Mobile Shop\mobileshop.accdb";
        OleDbConnection con;
        OleDbCommand cmd = new OleDbCommand();
    
        public login_form()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection(spath);
            con.Open();
            string Q = "Select * from users where username='" + uname_text.Text + "' And password='" + password_text.Text + "'";
            OleDbDataAdapter ds = new OleDbDataAdapter(Q, con);

            DataTable dt = new DataTable();
            dt = new DataTable();
            ds.Fill(dt);
            if ((uname_text.Text==String.Empty) || (password_text.Text == String.Empty))
            {
                MessageBox.Show("Please enter username and password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

      else  if (dt.Rows.Count > 0)
            {
                //then the result will get the name of the user and display it in the form using label control.
                MessageBox.Show("Login Successful!", "Congratulation!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                Menu_form mf = new Menu_form();
                mf.Show();

            }
            else
            {
                MessageBox.Show("Please enter a valid username and password!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

          
            }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (Show_Pass.Checked)
            {
                password_text.UseSystemPasswordChar = false;
            }
            else
            {
                password_text.UseSystemPasswordChar = true;
            }
        }

        private void password_text_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    }

