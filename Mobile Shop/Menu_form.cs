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
    public partial class Menu_form : Form
    {
        public Menu_form()
        {
            InitializeComponent();
         
        

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void masterFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void filesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void productMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {

        }

        private void purchaseMobileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }

        private void bankWithdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem17_Click(object sender, EventArgs e)
        {

        }

        private void notepadToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem19_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form lf = new login_form();
            lf.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            form_item f2 = new form_item();
            f2.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Menu_form_Load(object sender, EventArgs e)
        {
            panel1.BackColor = Color.FromArgb(130,Color.Black);
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {

        }

        private void systemExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {
         
        }

        private void toolStripContainer2_LeftToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void toolStripContainer2_TopToolStripPanel_Click(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
         
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            this.Hide();
            products_form pf = new products_form();
            pf.Show();
        }
    }
}
