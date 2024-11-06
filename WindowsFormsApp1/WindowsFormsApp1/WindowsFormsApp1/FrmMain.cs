using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) 
            {
                FrmLoginAdmin frmLoginAdmin = new FrmLoginAdmin();
                frmLoginAdmin.Show();
                this.Hide();
            }

           
        }

        private void addNewBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddBooks frmAddBooks = new FrmAddBooks();
            frmAddBooks.Show();
            this.Hide();
        }

        private void viewBookToolStripMenuItem_Click(object sender, EventArgs e)
        { 
            FrmViewBook frmViewBook = new FrmViewBook();
            frmViewBook.Show();
            this.Hide();
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddStudent frmAddStudent = new FrmAddStudent();
            frmAddStudent.Show();
            this.Hide();
        }

        private void viewStudentInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStudentInformation frmStudentInformation = new FrmStudentInformation();
            frmStudentInformation.Show();
            this.Hide();
        }

        private void bookToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
