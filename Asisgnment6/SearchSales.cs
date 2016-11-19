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
    public partial class SearchSales : Form
    {
        public SearchSales()
        {
            InitializeComponent();
        }

        private void SearchSales_Load(object sender, EventArgs e)
        {
            cbAgent.Items.Clear();
            cbDestination.Items.Clear();
            List<Agent> agentList = CampusDatabase.GetAgent();
            List<Destination> destinationList = CampusDatabase.GetDestination();
            try
            {
                if (agentList.Count > 0)
                {
                    agentList.Insert(0, new Asisgnment6.Agent() { AgentID = 0, AgentName = "All Agents" });
                    cbAgent.DataSource = agentList;
                    cbAgent.DisplayMember = "AgentName";
                    cbAgent.ValueMember = "AgentId";
                }
                else
                    MessageBox.Show("There are no agents", "Alert");
                if (destinationList.Count > 0)
                {
                    destinationList.Insert(0, new Asisgnment6.Destination() { DestinationId = 0, DestinationName = "All Destinations" });
                    cbDestination.DataSource = destinationList;
                    cbDestination.DisplayMember = "DestinationName";
                    cbDestination.ValueMember = "DestinationId";
                }
                else
                    MessageBox.Show("There are no Destinations", "Alert");

            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.Message, e1.GetType().ToString());
            }
          

        }

        private void cbDestination_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void butClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butSearch_Click(object sender, EventArgs e)
        {

            List<Sale> sales = CampusDatabase.GetSale(Convert.ToInt32(cbAgent.SelectedValue), Convert.ToInt32(cbDestination.SelectedValue),textBox1.Text,textBox2.Text);
            SearchResults resultForm = new SearchResults(sales);
            resultForm.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                try
                {

                    Convert.ToDecimal(textBox1.Text);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The number is too big.", "Alert");
                }
                catch (FormatException)
                {
                    MessageBox.Show(textBox1.Text + " is not a decimal number", "Alert");
                    textBox1.Clear();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (textBox2.Text != "")
            {

                try
                {

                    Convert.ToDecimal(textBox2.Text);
                }
                catch (OverflowException)
                {
                    MessageBox.Show("The number is too big.", "Alert");
                }
                catch (FormatException)
                {
                    MessageBox.Show(textBox2.Text + " is not a decimal number", "Alert");
                    textBox2.Clear();
                }
            }
        }
    }
}
