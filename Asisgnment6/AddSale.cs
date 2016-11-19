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
    public partial class AddSale : Form
    {
        public AddSale()
        {
            InitializeComponent();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bSubmit_Click(object sender, EventArgs e)
        {
            CampusDatabase.AddSale(monthCalendar1.SelectionStart, Convert.ToInt32(cbAgent.SelectedValue), Convert.ToInt32(cbDestinaiton.SelectedValue), Convert.ToDecimal(txtAmount.Text));
            txtAmount.Clear();
            MessageBox.Show("New Sale Added!", "Alert");
        }

        private void AddSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAMPUSDataSet3.AGENT' table. You can move, or remove it, as needed.
            this.aGENTTableAdapter1.Fill(this.cAMPUSDataSet3.AGENT);
            // TODO: This line of code loads data into the 'cAMPUSDataSet2.DESTINATION' table. You can move, or remove it, as needed.
            this.dESTINATIONTableAdapter.Fill(this.cAMPUSDataSet2.DESTINATION);
            // TODO: This line of code loads data into the 'cAMPUSDataSet1.AGENT' table. You can move, or remove it, as needed.
            this.aGENTTableAdapter.Fill(this.cAMPUSDataSet1.AGENT);
            //display the date you choise on the calendar
            labDate.Text = monthCalendar1.SelectionStart.ToLongDateString();

        }


        //run when the date on the calendar change
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            
            //display the date you choise on the calendar
            labDate.Text = monthCalendar1.SelectionStart.ToLongDateString();
            
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtAmount_TextChanged(object sender, EventArgs e)
        {
            if (txtAmount.Text != "")
            {
                
                try
                {
                    
                    Convert.ToDecimal(txtAmount.Text);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The number is too big.", "Alert");
                }
                catch (FormatException)
                {
                    MessageBox.Show(txtAmount.Text + " is not a decimal number", "Alert");
                    txtAmount.Clear();
                }
            }
        }

        private void cbAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbDestinaiton_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
