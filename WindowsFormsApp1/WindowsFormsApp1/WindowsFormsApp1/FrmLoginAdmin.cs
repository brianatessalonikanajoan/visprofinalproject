using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    public partial class FrmLoginAdmin : Form
    {
        private MySqlConnection koneksi;
        private MySqlDataAdapter adapter;
        private MySqlCommand perintah;
        private DataSet ds = new DataSet();
        private string alamat, query;
        public FrmLoginAdmin()
        {
            alamat = "server=localhost; database=db_perpustakaan; username=root; password=;";
            koneksi = new MySqlConnection(alamat);
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                query = string.Format("select * from tbl_admin where username_admin = '{0}'", txtUsernameAdmin.Text);
                ds.Clear();
                koneksi.Open();
                perintah = new MySqlCommand(query, koneksi);
                adapter = new MySqlDataAdapter(perintah);
                perintah.ExecuteNonQuery();
                adapter.Fill(ds);
                koneksi.Close();
                if (ds.Tables[0].Rows.Count > 0)
                {
                    foreach (DataRow kolom in ds.Tables[0].Rows)
                    {
                        string sandi;
                        sandi = kolom["pass_admin"].ToString();
                        if (sandi == txtPasswordAdmin.Text)
                        {
                            FrmMain frmMain = new FrmMain();
                            frmMain.Show();
                            this.Hide();
                        }
                        else
                        {
                            MessageBox.Show("Salah password, input kembali");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Masukkan username yang benar");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
