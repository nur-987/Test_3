using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Courier
{
    class PackageManager
    {
        private List<Package> PackagesPresent = new List<Package>();

        public void Receive(int id, params string[] allparams)
        {
            #region METHOD 1
            Package package = new Package(id,allparams[0],allparams[1],allparams[2]);
            //package class private "set"
            //constructor in package class
            #endregion

            #region METHOD 2
            //Package package = new Package(id, allparams string[] allparams)
            //{
            //    TrackingId = id,
            //    SenderName = allparams[0],
            //    ReceiverName = allparams[1],
            //    Address = allparams[2]
            //};

            //when the prop in Package clss is get set. 
            //no constrctor to set the props. 
            //use this approach
            #endregion


            PackagesPresent.Add(package);
        }
        public void Dispatch(int id)
        {
            var pkg = PackagesPresent.First(x => x.TrackingId == id);
            if (pkg != null)
            {
                PackagesPresent.Remove(pkg);
            }
            else
            {
                Console.WriteLine("item not available");
            }
        }

        public void DisplayAll()
        {
            int count = PackagesPresent.Count();
            Console.WriteLine("Total of: " +count + " packages");

            foreach(Package item in PackagesPresent)
            {
                Console.WriteLine(item.TrackingId);
                Console.WriteLine(item.Address);
                Console.WriteLine(item.SenderName);
                Console.WriteLine(item.ReceiverName);

            }
        }
    }
}
