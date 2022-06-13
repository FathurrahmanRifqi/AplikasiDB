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
    public partial class FormDashboard : Form
    {
        private readonly string vUser;
        private readonly string vRole;

        public FormDashboard()
        {
            InitializeComponent();
        }


        public FormDashboard(string vUser,string vRole)
        {
            InitializeComponent();
            this.vUser = vUser;
            this.vRole = vRole;
        }



        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = vUser;
        }
    }
}
