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

namespace WindowsFormsApp1
{
    public partial class FrmAddBooks : Form
    {
        public FrmAddBooks()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            String bname = txtBookName.Text;
            String bauthor = txtBookAuthor.Text;
            String bpublic = txtBookPublic.Text;
            String pdate = dateTimeBook.Text;
            Int64 price = Int64.Parse(txtBookPrice.Text);
            Int64 quantity = Int64.Parse(txtBookQuantity.Text);

           



        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }
    }
}
