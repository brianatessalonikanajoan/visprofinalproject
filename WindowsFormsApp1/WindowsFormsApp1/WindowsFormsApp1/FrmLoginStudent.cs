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
    public partial class FrmLoginStudent : Form
    {
        public FrmLoginStudent()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            FrmHome frmHome = new FrmHome();
            frmHome.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsernameStudent.Text == "student" && txtPasswordStudent.Text == "student")
            {
                FrmStudentMain frmStudent = new FrmStudentMain();
                frmStudent.Show();
                this.Hide();
            }
        }
    }
}
