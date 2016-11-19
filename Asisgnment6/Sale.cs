using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asisgnment6
{
    public class Sale
    {
        private int saleId;
        private DateTime saleDate;
        private decimal amount;
        private int agentKey;
        private string agentName;
        private int destinationKey;
        private int officeKey;
        private string destinationName;
        private string officeLocation;

        public Sale()
        {

        }
        //1
        public int SaleId {
            get { return saleId; }
            set { saleId = value; }
        }
        //2
        public int AgentKey
        {
            get { return agentKey; }
            set { agentKey = value; }
        }
        //3
        public int OfficKey
        {
            get { return officeKey; }
            set { officeKey = value; }
        }
        //4
        public int DestinationKey
        {
            get { return destinationKey; }
            set { destinationKey = value; }

        }
        //5
        public string AgentName
        {
            get { return agentName; }
            set { agentName = value; }

        }
        //6
        public string OfficeLocation
        {
            get { return officeLocation; }
            set { officeLocation = value; }
        }
        //7
        public string DestinationName
        {
            get { return destinationName; }
            set { destinationName = value; }
        }
        //8
        public decimal Amount
        {
            get { return amount; }
            set { amount = value; }
        }
        //9
        public DateTime SaleDate
        {
            get { return saleDate; }
            set { saleDate = value; }
        }
    }
}
