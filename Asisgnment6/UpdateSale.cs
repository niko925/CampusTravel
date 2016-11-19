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
    public partial class UpdateSale : Form
    {
        private int saleId;
        public UpdateSale(string saleKey)
        {
            InitializeComponent();
            this.saleId = Convert.ToInt32(saleKey);
        }

        private void UpdateSale_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAMPUSDataSet8.AGENT' table. You can move, or remove it, as needed.
            this.aGENTTableAdapter1.Fill(this.cAMPUSDataSet8.AGENT);
            // TODO: This line of code loads data into the 'cAMPUSDataSet7.AGENT' table. You can move, or remove it, as needed.
            this.aGENTTableAdapter.Fill(this.cAMPUSDataSet7.AGENT);
            // TODO: This line of code loads data into the 'cAMPUSDataSet6.DESTINATION' table. You can move, or remove it, as needed.
            this.dESTINATIONTableAdapter.Fill(this.cAMPUSDataSet6.DESTINATION);
            Sale sale = CampusDatabase.GetSale(saleId);
            listView1.Items.Clear();
           
            try
            {
                //display the sale on listView1
                if (sale != null)
                {
                    listView1.Items.Add(sale.SaleDate.ToShortDateString());
                    listView1.Items[0].SubItems.Add(sale.Amount.ToString());
                    listView1.Items[0].SubItems.Add(sale.DestinationName);
                    listView1.Items[0].SubItems.Add(sale.AgentName);
                    listView1.Items[0].SubItems.Add(sale.OfficeLocation);
                    listView1.Items[0].SubItems.Add(sale.SaleId.ToString());
                    cbAgent.SelectedValue = sale.AgentKey;
                    cbDestinaiton.SelectedValue= sale.DestinationKey;
                }
                else
                {
                    MessageBox.Show("the sale ID is not exist.", "Alert");
                }
            }
            catch (Exception e1)
            { MessageBox.Show(e1.Message, e1.GetType().ToString()); }
            

            
            //show amount
            txtAmount.Text = sale.Amount.ToString();
            //show date
            labDate.Text = sale.SaleDate.ToLongDateString();
            //showdate
            monthCalendar1.SetDate(sale.SaleDate);

        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butUpdate_Click(object sender, EventArgs e)
        {
            CampusDatabase.UpdateSale(saleId,monthCalendar1.SelectionStart, Convert.ToInt32(cbAgent.SelectedValue), Convert.ToInt32(cbDestinaiton.SelectedValue), Convert.ToDecimal(txtAmount.Text));
            MessageBox.Show("the sale has been updated!", "Alert");
            this.Close();
        }

        private void butDelete_Click(object sender, EventArgs e)
        {
            //the saleId store in subitem[5] of listView1
            CampusDatabase.DeleteSale(Convert.ToInt32(listView1.Items[0].SubItems[5].Text));
            MessageBox.Show("the sale has been deleted!", "Alert");
            this.Close();

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
                    txtAmount.Text = "";
                }
                catch (FormatException)
                {
                    MessageBox.Show(txtAmount.Text + " is not a decimal number", "Alert");
                    txtAmount.Text = "";
                }
            }
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            //display the date you choise on the calendar
            labDate.Text = monthCalendar1.SelectionStart.ToLongDateString();
        }

        private void cbAgent_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
