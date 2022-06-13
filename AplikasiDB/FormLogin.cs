using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiDB
{
    public partial class FormLogin : Form
    {

        private readonly DBTAEntities _TA;

        public FormLogin()
        {
            InitializeComponent();
            _TA = new DBTAEntities();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vUser = textBox1.Text.Trim().ToLower();
            string vPassword = textBox2.Text.Trim();

            var resultMHS = _TA.tbl_mhs.FirstOrDefault(q => q.email.Trim().ToLower() == vUser);
            // Dosen and Mahasiswa Login
            if (resultMHS == null)
            {
                // dosen login
                var resultDosen = _TA.tbl_dosen.FirstOrDefault(q => q.nip.Trim().ToLower() == vUser);

                if (resultDosen == null) {
                    MessageBox.Show("Username tidak di temukan !");
                }
                else
                {
                    if (resultDosen.password.Trim() == vPassword)
                    {
                        MessageBox.Show("Login Berhasil :)");
                    }
                    else
                    {
                        MessageBox.Show("Login Gagal !, periksa username dan password anda");
                    }

                }
            }
            else
            {
                // mahasiswa login
                if (resultMHS.password.Trim() == vPassword)
                {
                    MessageBox.Show("Login Berhasil :)");
                    var formDashboard = new FormDashboard(vUser,"MHS");
                    this.Hide();
                    formDashboard.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Login Gagal !, periksa username dan password anda") ;
                }

            }
        }
    }
}
