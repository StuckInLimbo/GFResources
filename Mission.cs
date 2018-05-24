using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Mission
    {
        /* Mission.cs
         * Creates Logistic objects to represent every possible chapter and episode
         * Encorages reuse of code so I dont have to have the values every time I create a Mission based off
         * the dropdowns in Form.cs
         */
        
        //Enumeration for the different kinds of drops
        //Stopped using them after a while because its different from how enum is used in c++
        public enum Drop_ids
        {
            NO_DROP = 0,
            TDOLL_CONTRACT,
            EQUPIPMENT_CONTRACT,
            INSTANT_CONSTUCTION,
            INSTANT_REPAIR,
            TOKEN
        };

        public static Drop emptyDrop;
        public static Drop tDoll;
        public static Drop equip;
        public static Drop construct;
        public static Drop repair;
        public static Drop token;
        //Empty mission is a holder to refer to rather than null, so we dont get NullPtrEx
        public Logistic emptyMission;
        //Chapter 0
        public Logistic c0e1;
        public Logistic c0e2;
        public Logistic c0e3;
        public Logistic c0e4;
        //Chapter 1
        public Logistic c1e1;
        public Logistic c1e2;
        public Logistic c1e3;
        public Logistic c1e4;
        //Chapter 2
        public Logistic c2e1;
        public Logistic c2e2;
        public Logistic c2e3;
        public Logistic c2e4;
        //Chapter 3
        public Logistic c3e1;
        public Logistic c3e2;
        public Logistic c3e3;
        public Logistic c3e4;
        //Chapter 4
        public Logistic c4e1;
        public Logistic c4e2;
        public Logistic c4e3;
        public Logistic c4e4;
        //Chapter 5
        public Logistic c5e1;
        public Logistic c5e2;
        public Logistic c5e3;
        public Logistic c5e4;
        //Chapter 6
        public Logistic c6e1;
        public Logistic c6e2;
        public Logistic c6e3;
        public Logistic c6e4;
        //Chapter 7
        public Logistic c7e1;
        public Logistic c7e2;
        public Logistic c7e3;
        public Logistic c7e4;
        //Chapter 8
        public Logistic c8e1;
        public Logistic c8e2;
        public Logistic c8e3;
        public Logistic c8e4;
        //Chapter 9
        public Logistic c9e1;
        public Logistic c9e2;
        public Logistic c9e3;
        public Logistic c9e4;
        //Chapter 10
        public Logistic c10e1;
        public Logistic c10e2;
        public Logistic c10e3;
        public Logistic c10e4;

        //Mission contructor
        //Called from Form.cs, sets up all the Logistic objects, no parameters as we dont need them
        public Mission()
        {
            emptyDrop = new Drop("", (int)Drop_ids.NO_DROP);
            tDoll = new Drop("T-Doll Contact", (int)Drop_ids.TDOLL_CONTRACT);
            equip = new Drop("Equipment Contract", (int)Drop_ids.EQUPIPMENT_CONTRACT);
            construct = new Drop("Instant Construction", (int)Drop_ids.INSTANT_CONSTUCTION);
            repair = new Drop("Instant Repair", (int)Drop_ids.INSTANT_REPAIR);
            token = new Drop("Token", (int)Drop_ids.TOKEN);
            //White = tdoll, Blue = equipment, Orange = construct, Green = repair, Dot = token 
            emptyMission = new Logistic(0, 0, 0, 0, 0);
            //Chapter 0
            c0e1 = new Logistic(0, 145, 145, 0, 50, 2, construct, repair);
            c0e2 = new Logistic(550, 0, 0, 350, 180, 1, tDoll);
            c0e3 = new Logistic(900, 900, 900, 250, 720, 2, equip, repair);
            c0e4 = new Logistic(0, 1200, 800, 750, 1440, 1, token);
            //Chapter 1
            c1e1 = new Logistic(10, 30, 15, 0, 15);
            c1e2 = new Logistic(0, 40, 60, 0, 30);
            c1e3 = new Logistic(30, 0, 30, 10, 60, 1, repair);
            c1e4 = new Logistic(160, 160, 0, 0, 120, 1, tDoll);
            //Chapter 2
            c2e1 = new Logistic(100, 0, 0, 30, 40);
            c2e2 = new Logistic(60, 200, 80, 0, 90, 1, repair);
            c2e3 = new Logistic(10, 10, 10, 230, 240, 2, construct, repair);
            c2e4 = new Logistic(0, 250, 600, 60, 360, 1, tDoll);
            //Chapter 3
            c3e1 = new Logistic(50, 0, 75, 0, 20);
            c3e2 = new Logistic(0, 120, 70, 30, 45);
            c3e3 = new Logistic(0, 300, 0, 0, 90, 2, construct, repair);
            c3e4 = new Logistic(0, 0, 300, 300, 300, 2, tDoll, equip);
            //Chapter 4
            c4e1 = new Logistic(0, 185, 185, 0, 60, 1, equip);
            c4e2 = new Logistic(0, 0, 0, 210, 120, 1, construct);
            c4e3 = new Logistic(800, 550, 0, 0, 360, 2, tDoll, repair);
            c4e4 = new Logistic(400, 400, 400, 0, 480, 1, construct);
            //Chapter 5
            c5e1 = new Logistic(0, 0, 100, 45, 30);
            c5e2 = new Logistic(0, 600, 300, 0, 150, 1, repair);
            c5e3 = new Logistic(800, 400, 400, 0, 240, 1, equip);
            c5e4 = new Logistic(100, 0, 0, 700, 400, 1, tDoll);
            //Chapter 6
            c6e1 = new Logistic(300, 300, 0, 100, 120);
            c6e2 = new Logistic(0, 200, 550, 100, 180, 2, construct, equip);
            c6e3 = new Logistic(0, 0, 200, 500, 300, 1, equip);
            c6e4 = new Logistic(800, 800, 800, 0, 720, 1, token);
            //Chapter 7
            c7e1 = new Logistic(650, 0, 650, 0, 150);
            c7e2 = new Logistic(0, 650, 0, 300, 240, 2, construct, repair);
            c7e3 = new Logistic(900, 600, 600, 0, 330, 1, equip);
            c7e4 = new Logistic(250, 250, 250, 600, 480, 1, construct);
            //Chapter 8
            c8e1 = new Logistic(150, 150, 150, 0, 60, 1, equip);
            c8e2 = new Logistic(0, 0, 0, 450, 180, 1, repair);
            c8e3 = new Logistic(400, 600, 800, 0, 360, 2, construct, repair);
            c8e4 = new Logistic(1500, 400, 400, 100, 540, 1, tDoll);
            //Chapter 9
            c9e1 = new Logistic(0, 0, 100, 50, 30);
            c9e2 = new Logistic(180, 0, 180, 100, 90, 1, construct);
            c9e3 = new Logistic(750, 750, 0, 0, 270, 1, tDoll);
            c9e4 = new Logistic(500, 900, 900, 0, 420, 1, equip);
            //Chapter 10
            c10e1 = new Logistic(140, 200, 0, 0, 40);
            c10e2 = new Logistic(0, 240, 180, 0, 100, 2, tDoll, construct);
            c10e3 = new Logistic(0, 480, 480, 300, 320, 2, construct, repair);
            c10e4 = new Logistic(660, 660, 660, 360, 600, 1, equip);
        }
    }
}
