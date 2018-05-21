using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Drop
    {
        public enum drop_ids
        {
            NO_DROP = 0,
            TDOLL_CONTRACT,
            EQUPIPMENT_CONTRACT,
            INSTANT_CONSTUCTION,
            INSTANT_REPAIR,
            TOKEN
        };

        private String name;
        private int id;

        public Drop(String n, int idNum)
        {
            name = n;
            id = idNum;
        }

        public String GetName()
        {
            return name;
        }

        public void SetName(String n)
        {
            name = n;
        }

        public int GetID()
        {
            return id;
        }

        public void SetID(int i)
        {
            id = i;
        }
    }
}
