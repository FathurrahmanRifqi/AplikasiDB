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
    public partial class FormProfile : Form
    {

        private readonly DBTAEntities _TA;

        public FormProfile()
        {
            InitializeComponent();
            _TA = new DBTAEntities();
        }


        private void cekPasswordLama()
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string vEmail = "fathurrahman.rifqi@poltekssn.ac.id";
            string vPassLama = textBox1.Text;
            string vPassBaru = textBox2.Text;
            string vPassKonfirm = textBox3.Text;

            var Pass = _TA.tbl_mhs.FirstOrDefault(q => q.password == vPassLama);

            if(Pass == null)
            {
                MessageBox.Show("Password lama salah !");
            }
            else
            {
                if (vPassKonfirm.Equals(vPassBaru))
                {
                    MessageBox.Show("Konfirmasi password salah !");
                }
                else
                {
                    MessageBox.Show("Password berhasil di ubah !");
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
