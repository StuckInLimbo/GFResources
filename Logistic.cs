using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Logistic
    {
        /* Logistic.cs
         * Class to handle storing all Mission info in nice, convinent objects
         */

        //emptyDrop is set for Logistics with no Drops, so we dont get NullPtr
        private static Drop emptyDrop = new Drop("", 0);
        private int manpower;
        private int ammunition;
        private int rations;
        private int parts;
        private double time;
        private int numOfDrops;
        private Drop drop1;
        private Drop drop2;


        //Set method to assign all values, called from contstructor
        private void Set(int manp, int ammo, int ration, int part, double timetaken, int numDrops, Drop d1, Drop d2)
        {
            manpower = manp;
            ammunition = ammo;
            rations = ration;
            parts = part;
            time = timetaken;
            numOfDrops = numDrops;
            drop1 = d1;
            drop2 = d2;
        }

        //Contructors
        //Constructor with no drops
        public Logistic(int manp, int ammo, int ration, int part, double timetaken)
        {
            Set(manp, ammo, ration, part, timetaken, 0, emptyDrop, emptyDrop);
        }

        //Constructor with 1 drop
        public Logistic(int manp, int ammo, int ration, int part, double timetaken, int numDrops, Drop d1)
        {
            Set(manp, ammo, ration, part, timetaken, numDrops, d1, emptyDrop);
        }

        //Constructor with 2 drops
        public Logistic(int manp, int ammo, int ration, int part, double timetaken, int numDrops, Drop d1, Drop d2)
        {
            Set(manp, ammo, ration, part, timetaken, numDrops, d1, d2);
        }

        //Getters and setters
        public int GetManpower()
        {
            return manpower;
        }

        public void SetManpower(int manp)
        {
            manpower = manp;
        }

        public int GetAmmo()
        {
            return ammunition;
        }

        public void SetAmmo(int ammo)
        {
            ammunition = ammo;
        }

        public int GetRations()
        {
            return rations;
        }

        public void SetRations(int food)
        {
            rations = food;
        }

        public int GetParts()
        {
            return parts;
        }

        public void SetParts(int part)
        {
            parts = part;
        }

        public double GetTime()
        {
            return time;
        }

        public void SetTime(double t)
        {
            time = t;
        }

        public int GetNumOfDrops()
        {
            return numOfDrops;
        }

        public void SetNumOfDrops(int n)
        {
            numOfDrops = n;
        }

        public Drop GetDrop(int num)
        {
            if (num == 1)
                return drop1;
            else if (num == 2)
                return drop2;
            else
                return emptyDrop;
        }

        public void SetDrop(int num, Drop d)
        {
            if (num == 1)
                drop1 = d;
            else if (num == 2)
                drop2 = d;
        }
    }
}
