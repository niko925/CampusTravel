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
    public partial class AgentBookings : Form
    {
        public AgentBookings()
        {
            InitializeComponent();
        }

        private void CloseBut_Click(object sender, EventArgs e)
        {
            this.Close();
            //OpeningScreen.ActiveForm.Show();
        }

        private void AgentBookings_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            List<Agent> agentList;
            try
            {
                agentList = CampusDatabase.GetAgent();
                if (agentList.Count > 0)
                {
                    //MessageBox.Show("good", "OK");
                    for (int i = 0; i < agentList.Count; i++)
                    {
                        Agent agent = agentList[i];
                        listView1.Items.Add(agent.AgentName);
                        listView1.Items[i].SubItems.Add(agent.OfficeLocation);
                        listView1.Items[i].SubItems.Add(agent.NumSales.ToString());
                        listView1.Items[i].SubItems.Add(agent.TotalSales.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("There are no any agents.", "Alert");
                }
            }
            catch (Exception e1)
            { MessageBox.Show(e1.Message, e1.GetType().ToString()); }

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
