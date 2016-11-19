using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Asisgnment6
{
    public partial class DatabasePathForm : Form
    {
        public DatabasePathForm()
        {
            InitializeComponent();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            CampusDatabase.Path = txtPath.Text;
            MessageBox.Show("the new path update!", "Alert");
        }

        private void txtPath_TextChanged(object sender, EventArgs e)
        {

        }

        private void lPath_Click(object sender, EventArgs e)
        {

        }

        private void DatabasePathForm_Load(object sender, EventArgs e)
        {
            lPath.Text = System.IO.Directory.GetCurrentDirectory();
            txtPath.Text = CampusDatabase.Path;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
