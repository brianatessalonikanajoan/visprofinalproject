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
    public partial class FrmAddStudent : Form
    {
        public FrmAddStudent()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            FrmMain frmMain = new FrmMain();
            frmMain.Show();
            this.Hide();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtStudentName.Clear();
            txtStudentID.Clear();
            txtFaculty.Clear();
            txtStudentSmster.Clear();
            txtStudentContact.Clear();

            //txtStudentEmail.text = "";

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            String name = txtStudentName.Text;
            String ID = txtStudentID.Text;
            String faculty = txtFaculty.Text;
            String smster = txtStudentSmster.Text;
            Int64 contact = Int64.Parse(txtStudentContact.Text);
        }
    }
}
