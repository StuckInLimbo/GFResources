using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Logistic
    {
        private static Drop emptyDrop = new Drop("", 0);
        private int manpower;
        private int ammunition;
        private int rations;
        private int parts;
        private float time;
        private int numOfDrops;
        private Drop drop1;
        private Drop drop2;

        private void Set(int manp, int ammo, int ration, int part, float timetaken, int numDrops, Drop d1, Drop d2)
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

        public Logistic(int manp, int ammo, int ration, int part, float timetaken)
        {
            Set(manp, ammo, ration, part, timetaken, 0, emptyDrop, emptyDrop);
        }

        public Logistic(int manp, int ammo, int ration, int part, float timetaken, int numDrops, Drop d1)
        {
            Set(manp, ammo, ration, part, timetaken, numDrops, d1, emptyDrop);
        }

        public Logistic(int manp, int ammo, int ration, int part, float timetaken, int numDrops, Drop d1, Drop d2)
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

        public float GetTime()
        {
            return time;
        }

        public void SetTime(float t)
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
