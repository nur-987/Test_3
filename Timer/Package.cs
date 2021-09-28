using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier
{
    class Package
    {
        public int TrackingId { get; private set; }
        public string SenderName { get; private set; }
        public string ReceiverName { get; private set; }
        public string Address { get; private set; }

        public Package(int Id, string sName, string rName, string add)
        {
            //constructor to set the private prop

            TrackingId = Id;
            SenderName = sName;
            ReceiverName = rName;
            Address = add;

        }
    }

}
