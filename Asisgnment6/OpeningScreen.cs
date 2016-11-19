using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Asisgnment6
{
    public partial class OpeningScreen : Form
    {
        public OpeningScreen()
        {
            InitializeComponent();
        }

        private void OpeningScreen_Load(object sender, EventArgs e)
        {
 
        }

        private void AddAgentBut_Click(object sender, EventArgs e)
        {
            //this.Hide();
            AddAgent aaf = new AddAgent();
            aaf.Show();
            
        }

        private void AddSaleBut_Click(object sender, EventArgs e)
        {
            AddSale addSaleForm = new AddSale();
            addSaleForm.Show();
        }

        private void SearchSaleBut_Click(object sender, EventArgs e)
        {
            SearchSales searchSalesForm = new SearchSales();
            searchSalesForm.Show();
             
        }

        private void bookingBut_Click(object sender, EventArgs e)
        {
            AgentBookings ab = new AgentBookings();
            ab.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void databaseTable_Click(object sender, EventArgs e)
        {
            DatabaseTable dataTable = new DatabaseTable();
            dataTable.Show();

        }



        private void pathPageBut_Click(object sender, EventArgs e)
        {
            

            DatabasePathForm dpf = new DatabasePathForm();

            dpf.Show();
            
        }

        private void pathPageBut_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void pathPageBut_MouseDown(object sender, MouseEventArgs e)
        {
            Color temp = pathPageBut.BackColor;
            pathPageBut.BackColor = pathPageBut.ForeColor;
            pathPageBut.ForeColor = temp;
        }

        private void pathPageBut_Mouseup(object sender, MouseEventArgs e)
        {
            Color temp = pathPageBut.BackColor;
            pathPageBut.BackColor = pathPageBut.ForeColor;
            pathPageBut.ForeColor = temp;
        }
    }
}
