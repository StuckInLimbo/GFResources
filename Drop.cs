using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Drop
    {
        /// <summary>
        /// Handles potential reward information for Logistics.
        /// </summary>

        public String Name { get; set; }
        public int ID { get; set; }

        public Drop(String n, int idNum)
        {
            Name = n;
            ID = idNum;
        }

        //For Debugging reasons, shows details in the debugger
        public override string ToString()
        {
            return "Name: " + Name + ", ID: " + ID;
        }
    }
}
