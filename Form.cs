using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFResources
{
    public partial class Form : System.Windows.Forms.Form
    {
        Mission missions;

        public Form()
        {
            InitializeComponent();
            reset();
            missions = new Mission();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //popup about menu
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            labelOutputDrops.Text = "";
            calcResources();
            calcLogistics();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reset();
        }


        private void calcResources()
        {
            int manpowerDifference = GetDifference((int)numManpower.Value, (int)numManpowerDesired.Value);
            int ammoDifference = GetDifference((int)numAmmo.Value, (int)numAmmoDesired.Value);
            int rationDifference = GetDifference((int)numRations.Value, (int)numRationsDesired.Value);
            int partDifference = GetDifference((int)numParts.Value, (int)numPartsDesired.Value);
            //Manp, ammo and rations are generated at 3 per 3min, parts are generated at 1 per 3min
            double manTime = (double)manpowerDifference / 60;
            manTime = Math.Round(manTime, 2, MidpointRounding.AwayFromZero);
            double ammoTime = (double)ammoDifference / 60;
            ammoTime = Math.Round(ammoTime, 2, MidpointRounding.AwayFromZero);
            double rationsTime = (double)rationDifference / 60;
            rationsTime = Math.Round(rationsTime, 2, MidpointRounding.AwayFromZero);
            double partTime = (double)partDifference / 20;
            partTime = Math.Round(partTime, 2, MidpointRounding.AwayFromZero);

            labelMaterials.Text = "ManP: " + manTime + " hours | Ammo: " + ammoTime + " hours | Rations: "
                + rationsTime + " hours | Parts: " + partTime + " hours";
        }

        private void calcLogistics()
        {
            //        0     1      2      3        4            5       6   7
            //data { man, ammo, rations, parts, (int)time , numOfDrops, d1, d2};
            int[] e1, e2, e3, e4;
            double manph = 0, ammoph = 0, rationsph = 0, partsph = 0;
            double hours = 0;
            int numDrops = 0;

            //Echelon 1
            e1 = calcE1();
            hours = e1[4];
            if(hours >= 60)
            {
                manph = manph + (e1[0] / (hours/60));
                ammoph = ammoph + (e1[1] / (hours / 60));
                rationsph = rationsph + (e1[2] / (hours / 60));
                partsph = partsph + (e1[3] / (hours / 60));
            }
            else if(hours < 60 && hours > 0)
            {
                double remainder = (60 / hours);
                manph = manph + (e1[0] * remainder);
                ammoph = ammoph + (e1[1] * remainder);
                rationsph = rationsph + (e1[2] * remainder);
                partsph = partsph + (e1[3] * remainder);
            }
            numDrops += e1[5];

            //Echelon 2
            e2 = calcE2();
            hours = e2[4];
            if (hours >= 60)
            {
                manph = manph + (e2[0] / (hours / 60));
                ammoph = ammoph + (e2[1] / (hours / 60));
                rationsph = rationsph + (e2[2] / (hours / 60));
                partsph = partsph + (e2[3] / (hours / 60));
            }
            else if (hours < 60 && hours > 0)
            {
                double remainder = (60 / hours);
                manph = manph + (e2[0] * remainder);
                ammoph = ammoph + (e2[1] * remainder);
                rationsph = rationsph + (e2[2] * remainder);
                partsph = partsph + (e2[3] * remainder);
            }
            numDrops += e2[5];

            //Echelon 3
            e3 = calcE3();
            hours = e3[4];
            if (hours >= 60)
            {
                manph = manph + (e3[0] / (hours / 60));
                ammoph = ammoph + (e3[1] / (hours / 60));
                rationsph = rationsph + (e3[2] / (hours / 60));
                partsph = partsph + (e3[3] / (hours / 60));
            }
            else if (hours < 60 && hours > 0)
            {
                double remainder = (60 / hours);
                manph = manph + (e3[0] * remainder);
                ammoph = ammoph + (e3[1] * remainder);
                rationsph = rationsph + (e3[2] * remainder);
                partsph = partsph + (e3[3] * remainder);
            }
            numDrops += e3[5];

            //Echelon 4
            e4 = calcE4();
            hours = e4[4];
            if (hours >= 60)
            {
                manph = manph + (e4[0] / (hours / 60));
                ammoph = ammoph + (e4[1] / (hours / 60));
                rationsph = rationsph + (e4[2] / (hours / 60));
                partsph = partsph + (e4[3] / (hours / 60));
            }
            else if (hours < 60 && hours > 0)
            {
                double remainder = (60 / hours);
                manph = manph + (e4[0] * remainder);
                ammoph = ammoph + (e4[1] * remainder);
                rationsph = rationsph + (e4[2] * remainder);
                partsph = partsph + (e4[3] * remainder);
            }
            numDrops += e4[5];

            //Totals
            manph = manph * (double)numHours.Value;
            manph = Math.Round(manph, 2, MidpointRounding.AwayFromZero);
            ammoph = ammoph * (double)numHours.Value;
            ammoph = Math.Round(ammoph, 2, MidpointRounding.AwayFromZero);
            rationsph = rationsph * (double)numHours.Value;
            rationsph = Math.Round(rationsph, 2, MidpointRounding.AwayFromZero);
            partsph = partsph * (double)numHours.Value;
            partsph = Math.Round(partsph, 2, MidpointRounding.AwayFromZero);
            labelOutput.Text = "ManP/h: " + manph + " | Ammo/h: " + ammoph 
                + " | Rations/h: " + rationsph + " | Parts/h: " + partsph;

            //Drops
            Drop[] drops = new Drop[numDrops];
            int tDoll = 0, equip = 0, repair = 0, construct = 0, token = 0;
            int tDollph = 0, equipph = 0, repairph = 0, constructph = 0, tokenph = 0;
            int count = 0;
            if(e1[5] > 0)
            {
                if(e1[5] == 1)
                {
                    drops[count] = GetDropFromID(e1[6], e1[4]);
                    count++;
                }
                else if(e1[5] == 2)
                {
                    drops[count] = GetDropFromID(e1[6], e1[4]);
                    count++;
                    drops[count] = GetDropFromID(e1[7], e1[4]);
                    count++;
                }
            }
            if(e2[5] > 0)
            {
                if (e2[5] == 1)
                {
                    drops[count] = GetDropFromID(e2[6], e2[4]);
                    count++;
                }
                else if (e2[5] == 2)
                {
                    drops[count] = GetDropFromID(e2[6], e2[4]);
                    count++;
                    drops[count] = GetDropFromID(e2[7], e2[4]);
                    count++;
                }
            }
            if(e3[5] > 0)
            {
                if (e3[5] == 1)
                {
                    drops[count] = GetDropFromID(e3[6], e3[4]);
                    count++;
                }
                else if (e3[5] == 2)
                {
                    drops[count] = GetDropFromID(e3[6], e3[4]);
                    count++;
                    drops[count] = GetDropFromID(e3[7], e3[4]);
                    count++;
                }
            }
            if(e4[5] > 0)
            {
                if (e4[5] == 1)
                {
                    drops[count] = GetDropFromID(e4[6], e4[4]);
                    count++;
                }
                else if (e4[5] == 2)
                {
                    drops[count] = GetDropFromID(e4[6], e4[4]);
                    count++;
                    drops[count] = GetDropFromID(e4[7], e4[4]);
                    count++;
                }
            }

            for(int i = 0; i < numDrops; i++)
            {
                switch(drops[i].GetID())
                {
                    case 0:
                        break;
                    case 1:
                        tDoll++;
                        tDollph = ((int)numHours.Value * 60) / (int)drops[i].GetHours();
                        break;
                    case 2:
                        equip++;
                        equipph = ((int)numHours.Value * 60) / (int)drops[i].GetHours();
                        break;
                    case 3:
                        repair++;
                        repairph = ((int)numHours.Value * 60) / (int)drops[i].GetHours();
                        break;
                    case 4:
                        construct++;
                        constructph = ((int)numHours.Value * 60) / (int)drops[i].GetHours();
                        break;
                    case 5:
                        token++;
                        tokenph = ((int)numHours.Value * 60) / (int)drops[i].GetHours();
                        break;
                }
            }
            labelOutputDrops.Text = "T-Doll Contracts: " + tDollph + " | Equipment Contracts: " + equipph
                + " | Instant Repair: " + repairph + " | Instant Construction: " + constructph + " | Tokens: " + tokenph;
        }

        private int[] calcE1()
        {
            Logistic logi = null;
            int man, ammo, rations, parts, drops;
            Drop d1, d2;
            double time, smalltime;
            labelE1Resources.Text = "";
            if (comboE1Chapter.SelectedIndex == 0)
            {
                switch (comboE1Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c0e1;
                        break;
                    case 1:
                        logi = missions.c0e2;
                        break;
                    case 2:
                        logi = missions.c0e3;
                        break;
                    case 3:
                        logi = missions.c0e4;
                        break;
                }
            }
            else if (comboE1Chapter.SelectedIndex == 1)
            {
                switch (comboE1Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c1e1;
                        break;
                    case 1:
                        logi = missions.c1e2;
                        break;
                    case 2:
                        logi = missions.c1e3;
                        break;
                    case 3:
                        logi = missions.c1e4;
                        break;
                }
            }
            else if (comboE1Chapter.SelectedIndex == 2)
            {
                switch (comboE1Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c2e1;
                        break;
                    case 1:
                        logi = missions.c2e2;
                        break;
                    case 2:
                        logi = missions.c2e3;
                        break;
                    case 3:
                        logi = missions.c2e4;
                        break;
                }
            }
            else if (comboE1Chapter.SelectedIndex == 3)
            {
                switch (comboE1Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c3e1;
                        break;
                    case 1:
                        logi = missions.c3e2;
                        break;
                    case 2:
                        logi = missions.c3e3;
                        break;
                    case 3:
                        logi = missions.c3e4;
                        break;
                }
            }
            else if (comboE1Chapter.SelectedIndex == 4)
            {
                switch (comboE1Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c4e1;
                        break;
                    case 1:
                        logi = missions.c4e2;
                        break;
                    case 2:
                        logi = missions.c4e3;
                        break;
                    case 3:
                        logi = missions.c4e4;
                        break;
                }
            }
            else if (comboE1Chapter.SelectedIndex == 5)
            {
                switch (comboE1Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c5e1;
                        break;
                    case 1:
                        logi = missions.c5e2;
                        break;
                    case 2:
                        logi = missions.c5e3;
                        break;
                    case 3:
                        logi = missions.c5e4;
                        break;
                }
            }
            else if (comboE1Chapter.SelectedIndex == 6)
            {
                switch (comboE1Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c6e1;
                        break;
                    case 1:
                        logi = missions.c6e2;
                        break;
                    case 2:
                        logi = missions.c6e3;
                        break;
                    case 3:
                        logi = missions.c6e4;
                        break;
                    default:
                        logi = null;
                        break;
                }
            }
            else
            {
                //fallback
                logi = missions.emptyMission;
            }
            //Resources
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = "";
            if (time >= 60)
            {
                smalltime = time / 60;
                sTime = "" + smalltime + "h";
            }
            else
            {
                sTime = "" + time + "min";
            }
            labelE1Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: " + rations + " | Parts: " + parts + " | Time: " + sTime;
            //Drops
            drops = logi.GetNumOfDrops();
            if(logi.GetNumOfDrops() == 1)
            {
                d1 = logi.GetDrop(1);
                d2 = new Drop("", 0);
                //labelOutputDrops.Text = labelOutputDrops.Text + " " + logi.GetDrop(1).GetName() + ", ";
            }
            else if (logi.GetNumOfDrops() == 2)
            {
                d1 = logi.GetDrop(1);
                d2 = logi.GetDrop(2);
                //labelOutputDrops.Text = labelOutputDrops.Text + d1.GetName() + ", ";
                //labelOutputDrops.Text = labelOutputDrops.Text + d2.GetName() + ", ";
            }
            else
            {
                d1 = new Drop("", 0);
                d2 = new Drop("", 0);
            }
            int[] data = new int[] { man, ammo, rations, parts, (int)time, drops, d1.GetID(), d2.GetID() };
            return data;
        }

        private int[] calcE2()
        {
            Logistic logi = null;
            int man, ammo, rations, parts, drops;
            Drop d1, d2;
            double time, smalltime;
            labelE3Resources.Text = "";
            if (comboE2Chapter.SelectedIndex == 0)
            {
                switch (comboE2Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c0e1;
                        break;
                    case 1:
                        logi = missions.c0e2;
                        break;
                    case 2:
                        logi = missions.c0e3;
                        break;
                    case 3:
                        logi = missions.c0e4;
                        break;
                }
            }
            else if (comboE2Chapter.SelectedIndex == 1)
            {
                switch (comboE2Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c1e1;
                        break;
                    case 1:
                        logi = missions.c1e2;
                        break;
                    case 2:
                        logi = missions.c1e3;
                        break;
                    case 3:
                        logi = missions.c1e4;
                        break;
                }
            }
            else if (comboE2Chapter.SelectedIndex == 2)
            {
                switch (comboE2Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c2e1;
                        break;
                    case 1:
                        logi = missions.c2e2;
                        break;
                    case 2:
                        logi = missions.c2e3;
                        break;
                    case 3:
                        logi = missions.c2e4;
                        break;
                }
            }
            else if (comboE2Chapter.SelectedIndex == 3)
            {
                switch (comboE2Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c3e1;
                        break;
                    case 1:
                        logi = missions.c3e2;
                        break;
                    case 2:
                        logi = missions.c3e3;
                        break;
                    case 3:
                        logi = missions.c3e4;
                        break;
                }
            }
            else if (comboE2Chapter.SelectedIndex == 4)
            {
                switch (comboE2Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c4e1;
                        break;
                    case 1:
                        logi = missions.c4e2;
                        break;
                    case 2:
                        logi = missions.c4e3;
                        break;
                    case 3:
                        logi = missions.c4e4;
                        break;
                }
            }
            else if (comboE2Chapter.SelectedIndex == 5)
            {
                switch (comboE2Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c5e1;
                        break;
                    case 1:
                        logi = missions.c5e2;
                        break;
                    case 2:
                        logi = missions.c5e3;
                        break;
                    case 3:
                        logi = missions.c5e4;
                        break;
                }
            }
            else if (comboE2Chapter.SelectedIndex == 6)
            {
                switch (comboE2Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c6e1;
                        break;
                    case 1:
                        logi = missions.c6e2;
                        break;
                    case 2:
                        logi = missions.c6e3;
                        break;
                    case 3:
                        logi = missions.c6e4;
                        break;
                    default:
                        logi = null;
                        break;
                }
            }
            else
            {
                //fallback
                logi = missions.emptyMission;
            }
            //Resources
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = "";
            if (time >= 60)
            {
                smalltime = time / 60;
                sTime = "" + smalltime + "h";
            }
            else
            {
                sTime = "" + time + "min";
            }
            labelE2Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: " + rations + " | Parts: " + parts + " | Time: " + sTime;
            //Drops
            drops = logi.GetNumOfDrops();
            if (logi.GetNumOfDrops() == 1)
            {
                d1 = logi.GetDrop(1);
                d2 = new Drop("", 0);
                //labelOutputDrops.Text = labelOutputDrops.Text + " " + logi.GetDrop(1).GetName() + ", ";
            }
            else if (logi.GetNumOfDrops() == 2)
            {
                d1 = logi.GetDrop(1);
                d2 = logi.GetDrop(2);
                //labelOutputDrops.Text = labelOutputDrops.Text + d1.GetName() + ", ";
                //labelOutputDrops.Text = labelOutputDrops.Text + d2.GetName() + ", ";
            }
            else
            {
                d1 = new Drop("", 0);
                d2 = new Drop("", 0);
            }
            int[] data = new int[] { man, ammo, rations, parts, (int)time, drops, d1.GetID(), d2.GetID() };
            return data;
        }

        private int[] calcE3()
        {
            Logistic logi = null;
            int man, ammo, rations, parts, drops;
            Drop d1, d2;
            double time, smalltime;
            labelE3Resources.Text = "";
            if (comboE3Chapter.SelectedIndex == 0)
            {
                switch (comboE3Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c0e1;
                        break;
                    case 1:
                        logi = missions.c0e2;
                        break;
                    case 2:
                        logi = missions.c0e3;
                        break;
                    case 3:
                        logi = missions.c0e4;
                        break;
                }
            }
            else if (comboE3Chapter.SelectedIndex == 1)
            {
                switch (comboE3Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c1e1;
                        break;
                    case 1:
                        logi = missions.c1e2;
                        break;
                    case 2:
                        logi = missions.c1e3;
                        break;
                    case 3:
                        logi = missions.c1e4;
                        break;
                }
            }
            else if (comboE3Chapter.SelectedIndex == 2)
            {
                switch (comboE3Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c2e1;
                        break;
                    case 1:
                        logi = missions.c2e2;
                        break;
                    case 2:
                        logi = missions.c2e3;
                        break;
                    case 3:
                        logi = missions.c2e4;
                        break;
                }
            }
            else if (comboE3Chapter.SelectedIndex == 3)
            {
                switch (comboE3Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c3e1;
                        break;
                    case 1:
                        logi = missions.c3e2;
                        break;
                    case 2:
                        logi = missions.c3e3;
                        break;
                    case 3:
                        logi = missions.c3e4;
                        break;
                }
            }
            else if (comboE3Chapter.SelectedIndex == 4)
            {
                switch (comboE3Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c4e1;
                        break;
                    case 1:
                        logi = missions.c4e2;
                        break;
                    case 2:
                        logi = missions.c4e3;
                        break;
                    case 3:
                        logi = missions.c4e4;
                        break;
                }
            }
            else if (comboE3Chapter.SelectedIndex == 5)
            {
                switch (comboE3Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c5e1;
                        break;
                    case 1:
                        logi = missions.c5e2;
                        break;
                    case 2:
                        logi = missions.c5e3;
                        break;
                    case 3:
                        logi = missions.c5e4;
                        break;
                }
            }
            else if (comboE3Chapter.SelectedIndex == 6)
            {
                switch (comboE3Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c6e1;
                        break;
                    case 1:
                        logi = missions.c6e2;
                        break;
                    case 2:
                        logi = missions.c6e3;
                        break;
                    case 3:
                        logi = missions.c6e4;
                        break;
                    default:
                        logi = null;
                        break;
                }
            }
            else
            {
                //fallback
                logi = missions.emptyMission;
            }
            //Resources
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = "";
            if (time >= 60)
            {
                smalltime = time / 60;
                sTime = "" + smalltime + "h";
            }
            else
            {
                sTime = "" + time + "min";
            }
            labelE3Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: " + rations + " | Parts: " + parts + " | Time: " + sTime;
            //Drops
            drops = logi.GetNumOfDrops();
            if (logi.GetNumOfDrops() == 1)
            {
                d1 = logi.GetDrop(1);
                d2 = new Drop("", 0);
                //labelOutputDrops.Text = labelOutputDrops.Text + " " + logi.GetDrop(1).GetName() + ", ";
            }
            else if (logi.GetNumOfDrops() == 2)
            {
                d1 = logi.GetDrop(1);
                d2 = logi.GetDrop(2);
                //labelOutputDrops.Text = labelOutputDrops.Text + d1.GetName() + ", ";
                //labelOutputDrops.Text = labelOutputDrops.Text + d2.GetName() + ", ";
            }
            else
            {
                d1 = new Drop("", 0);
                d2 = new Drop("", 0);
            }
            int[] data = new int[] { man, ammo, rations, parts, (int)time, drops, d1.GetID(), d2.GetID() };
            return data;
        }

        private int[] calcE4()
        {
            Logistic logi = null;
            int man, ammo, rations, parts, drops;
            Drop d1, d2;
            double time, smalltime;
            labelE4Resources.Text = "";
            if (comboE4Chapter.SelectedIndex == 0)
            {
                switch (comboE4Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c0e1;
                        break;
                    case 1:
                        logi = missions.c0e2;
                        break;
                    case 2:
                        logi = missions.c0e3;
                        break;
                    case 3:
                        logi = missions.c0e4;
                        break;
                }
            }
            else if (comboE4Chapter.SelectedIndex == 1)
            {
                switch (comboE4Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c1e1;
                        break;
                    case 1:
                        logi = missions.c1e2;
                        break;
                    case 2:
                        logi = missions.c1e3;
                        break;
                    case 3:
                        logi = missions.c1e4;
                        break;
                }
            }
            else if (comboE4Chapter.SelectedIndex == 2)
            {
                switch (comboE4Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c2e1;
                        break;
                    case 1:
                        logi = missions.c2e2;
                        break;
                    case 2:
                        logi = missions.c2e3;
                        break;
                    case 3:
                        logi = missions.c2e4;
                        break;
                }
            }
            else if (comboE4Chapter.SelectedIndex == 3)
            {
                switch (comboE4Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c3e1;
                        break;
                    case 1:
                        logi = missions.c3e2;
                        break;
                    case 2:
                        logi = missions.c3e3;
                        break;
                    case 3:
                        logi = missions.c3e4;
                        break;
                }
            }
            else if (comboE4Chapter.SelectedIndex == 4)
            {
                switch (comboE4Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c4e1;
                        break;
                    case 1:
                        logi = missions.c4e2;
                        break;
                    case 2:
                        logi = missions.c4e3;
                        break;
                    case 3:
                        logi = missions.c4e4;
                        break;
                }
            }
            else if (comboE4Chapter.SelectedIndex == 5)
            {
                switch (comboE4Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c5e1;
                        break;
                    case 1:
                        logi = missions.c5e2;
                        break;
                    case 2:
                        logi = missions.c5e3;
                        break;
                    case 3:
                        logi = missions.c5e4;
                        break;
                }
            }
            else if (comboE4Chapter.SelectedIndex == 6)
            {
                switch (comboE4Map.SelectedIndex)
                {
                    case 0:
                        logi = missions.c6e1;
                        break;
                    case 1:
                        logi = missions.c6e2;
                        break;
                    case 2:
                        logi = missions.c6e3;
                        break;
                    case 3:
                        logi = missions.c6e4;
                        break;
                    default:
                        logi = null;
                        break;
                }
            }
            else
            {
                //fallback
                logi = missions.emptyMission;
            }
            //Resources
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = "";
            if (time >= 60)
            {
                smalltime = time / 60;
                sTime = "" + smalltime + "h";
            }
            else
            {
                sTime = "" + time + "min";
            }
            labelE4Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: " + rations + " | Parts: " + parts + " | Time: " + sTime;
            //Drops
            drops = logi.GetNumOfDrops();
            if (logi.GetNumOfDrops() == 1)
            {
                d1 = logi.GetDrop(1);
                d2 = new Drop("", 0);
                //labelOutputDrops.Text = labelOutputDrops.Text + " " + logi.GetDrop(1).GetName() + ", ";
            }
            else if (logi.GetNumOfDrops() == 2)
            {
                d1 = logi.GetDrop(1);
                d2 = logi.GetDrop(2);
                //labelOutputDrops.Text = labelOutputDrops.Text + d1.GetName() + ", ";
                //labelOutputDrops.Text = labelOutputDrops.Text + d2.GetName() + ", ";
            }
            else
            {
                d1 = new Drop("", 0);
                d2 = new Drop("", 0);
            }
            int[] data = new int[] { man, ammo, rations, parts, (int)time, drops, d1.GetID(), d2.GetID() };
            return data;
        }

        private int GetDifference(int before, int after)
        {
            return after - before;
        }

        private void reset()
        {
            labelMaterials.Text = "";
            labelE1Resources.Text = "";
            labelE2Resources.Text = "";
            labelE3Resources.Text = "";
            labelE4Resources.Text = "";
            labelOutput.Text = "";
            labelOutputDrops.Text = "";
            numManpower.Value = 0;
            numAmmo.Value = 0;
            numRations.Value = 0;
            numParts.Value = 0;
            numManpowerDesired.Value = 0;
            numAmmoDesired.Value = 0;
            numRationsDesired.Value = 0;
            numPartsDesired.Value = 0;
        }

        private Drop GetDropFromID(int idNum)
        {
            switch(idNum)
            {
                case 0:
                    return new Drop("", 0);
                case 1:
                    return new Drop("T-Doll Contact", 1);
                case 2:
                    return new Drop("Equipment Contract", 2);
                case 3:
                    return new Drop("Instant Construction", 3);
                case 4:
                    return new Drop("Instant Repair", 4);
                case 5:
                    return new Drop("Token", 5);
                default:
                    return new Drop("", 0);
            }
        }

        private Drop GetDropFromID(int idNum, double hours)
        {
            switch (idNum)
            {
                case 0:
                    return new Drop("", 0, 0);
                case 1:
                    return new Drop("T-Doll Contact", 1, hours);
                case 2:
                    return new Drop("Equipment Contract", 2, hours);
                case 3:
                    return new Drop("Instant Construction", 3, hours);
                case 4:
                    return new Drop("Instant Repair", 4, hours);
                case 5:
                    return new Drop("Token", 5, hours);
                default:
                    return new Drop("", 0, 0);
            }
        }
    }
}
