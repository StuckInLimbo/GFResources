using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Logistic
    {
        /// <summary>
        /// Handles the storage of all data related to a Mission episode.
        /// </summary>

        //emptyDrop is set for Logistics with no Drops, so we dont get NullPtr
        private static Drop emptyDrop = Mission.emptyDrop;
        public int Manpower { get; set; }
        public int Ammunition { get; set; }
        public int Rations { get; set; }
        public int Parts { get; set; }
        public double Time { get; set; }
        public int NumOfDrops { get; set; }
        private Drop drop1;
        private Drop drop2;


        //Set method to assign all values, called from contstructor
        private void Set(int manp, int ammo, int ration, int part, double timetaken, int numDrops, Drop d1, Drop d2)
        {
            Manpower = manp;
            Ammunition = ammo;
            Rations = ration;
            Parts = part;
            Time = timetaken;
            NumOfDrops = numDrops;
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

        //For Debugging reasons, shows details in the debugger
        public override string ToString()
        {
            return "MP: " + Manpower + ", AMMO: " + Ammunition + ", MRE: " + Rations + ", PRT: " + Parts + ", TIME: " + Time;
        }
    }
}
