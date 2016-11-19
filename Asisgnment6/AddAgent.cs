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
    public partial class AddAgent : Form
    {
        public AddAgent()
        {
            InitializeComponent();
        }

        private void AddAgent_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'cAMPUSDataSet.OFFICE' table. You can move, or remove it, as needed.
            this.oFFICETableAdapter.Fill(this.cAMPUSDataSet.OFFICE);
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

        private void bSubmit_Click(object sender, EventArgs e)
        {
            CampusDatabase.AddAgent(txtAgentName.Text, Convert.ToInt32(cbOfficeLocation.SelectedValue));
            //cannot convert from object to int 
            //cbOfficeLocation.SelectedValuea is an object data type;
            //CampusDatabase.AddAgent(txtAgentName.Text, cbOfficeLocation.SelectedValue);
            txtAgentName.Clear();
            MessageBox.Show("Agent Added!", "Alert");
            //refresh form1
            this.AddAgent_Load(this, null);
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
            //OpeningScreen.ActiveForm.Hide();
           
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
