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
    public partial class DatabaseTable : Form
    {
        public DatabaseTable()
        {
            InitializeComponent();
        }

        private void DatabaseTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAMPUSDataSet5.SALES' table. You can move, or remove it, as needed.
            this.sALESTableAdapter.Fill(this.cAMPUSDataSet5.SALES);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
