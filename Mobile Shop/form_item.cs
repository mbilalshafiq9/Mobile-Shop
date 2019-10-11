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
using Oracle.ManagedDataAccess.Client;
namespace Mobile_Shop
{
    public partial class form_item : Form
    {
        string spath = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Leosoft\Documents\Visual Studio 2015\Projects\Mobile Shop\mobileshop.accdb";
        OleDbConnection con;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter adapter;
        public form_item()
        {
            InitializeComponent();
        }

        private void operation(string query)
        {
            con = new OleDbConnection(spath);
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = query;
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Data has been Updated!", "information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void showdata()
        {

            con = new OleDbConnection(spath);
            con.Open();
            string Q = "Select fid,fcompany,fmodel from item";
            adapter = new OleDbDataAdapter(Q, con);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            dgvitem.DataSource = ds.Tables[0];
        }

        private void form_item_Load(object sender, EventArgs e)
        {
            showdata();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            string str="insert into item(fcompany,fmodel) values('"+ textcompany.Text + "','"+ textmodel.Text + "')";
            operation(str);
        }

        private void textcompany_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvitem_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
