using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Shop
{
    public partial class products_form : Form
    {
        public products_form()
        {
            InitializeComponent();
        }

        private void products_form_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            add_product ap = new add_product();
            ap.Show();

        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu_form mf = new Menu_form();
            mf.Show();
        }
    }
}
