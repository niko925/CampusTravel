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
    public partial class SearchResults : Form
    {
        private List<Sale> saleList;
        public SearchResults(List<Sale> sales)
        {
            InitializeComponent();
            saleList = sales;
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = listView1.Items.IndexOf(listView1.SelectedItems[0]);

            //listView1.Items[i].SubItems[5].Text; 5 is sale Id;
            UpdateSale updateSaleForm = new UpdateSale(listView1.Items[i].SubItems[5].Text);
            updateSaleForm.Show();
            this.Close();
        }

        private void SearchResults_Load(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            try
            {
                if (saleList.Count > 0)
                {
                    //MessageBox.Show("good", "OK");
                    for (int i = 0; i < saleList.Count; i++)
                    {
                        Sale sale = saleList[i];
                        listView1.Items.Add(sale.SaleDate.ToShortDateString());
                        listView1.Items[i].SubItems.Add(sale.Amount.ToString());
                        listView1.Items[i].SubItems.Add(sale.DestinationName);
                        listView1.Items[i].SubItems.Add(sale.AgentName);
                        listView1.Items[i].SubItems.Add(sale.OfficeLocation);
                        listView1.Items[i].SubItems.Add(sale.SaleId.ToString());

                    }
                }
                else
                {
                    MessageBox.Show("There are no any sales.", "Alert");
                }
            }
            catch (Exception e1)
            { MessageBox.Show(e1.Message, e1.GetType().ToString()); }
        }

        private void butCloseWindow_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
