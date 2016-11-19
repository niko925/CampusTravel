using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asisgnment6
{
    public class Agent
    {
        private int agentID;
        private string agentName;
        private int officeKey;
        private int officeID;
        private string officeLocation;
        private int numSales;
        private decimal totalSales;
        
        public int AgentID
        {
            get { return agentID; }
            set { agentID = value; }
        }
        public string AgentName
        {
            get { return agentName; }
            set { agentName = value; }
        }
        public int OfficeKey
        {
            get { return officeKey; }
            set { officeKey = value; }

        }
        public int OfficeID
        {
            get { return officeID; }
            set { officeID = value; }

        }
        public string OfficeLocation
        {
            get { return officeLocation; }
            set { officeLocation = value; }
        }
        public int NumSales
        {
            get { return numSales; }
            set { numSales = value; }
        }
        public decimal TotalSales
        {
            get { return totalSales; }
            set { totalSales = value; }
        }
        
    }
}
