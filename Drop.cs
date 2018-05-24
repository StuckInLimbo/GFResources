using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Drop
    {
        /* Drop.cs
         * Class to handle storage of potential reward information
         * Called typically using Drop("Name of Drop", IDNUM);
         */

        private String name;
        private int id;
        //Drops can have hours, for when we're calculation potential drops/h
        private double hours;

        public Drop(String n, int idNum)
        {
            name = n;
            id = idNum;
            hours = 0;
        }

        public Drop(String n, int idNum, double h)
        {
            name = n;
            id = idNum;
            hours = h;
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

        public double GetHours()
        {
            return hours;
        }
    }
}
