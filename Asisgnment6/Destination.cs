using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Asisgnment6
{
    public class Destination
    {
        private string destinationName;
        private int destinationId;

        public int DestinationId
                   
        {
            get { return destinationId; }
            set { destinationId = value; }
        }

        public string DestinationName
        {
            get { return destinationName; }
            set { destinationName = value; }
        }
    }
}
