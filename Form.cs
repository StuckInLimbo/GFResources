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
        /* Form.cs
         * Windows-made file to handle all custom Form methods
         * We're going to use it to run some of our own code
         */
        
        //Global mission object so we can refer to all the missions in the Mission.cs file (Unassigned until Form.cs's constructer is run)
        //We store this variable and assign it early so it doesnt lag out when we click calculate, because if it was only stored in 
        //Get LogisticFromNum, it would have to run when even we ran that method, and thats a lot of calculations and assignments we dont need.
        Mission missions;

        //Called from Program.cs
        public Form()
        {
            InitializeComponent();
            Reset();
            missions = new Mission();
        }

        private void ToolStripMenuAbout_Clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Made by StuckInLimbo (UID:41038)", "About GF Calculator");
        }

        private void ToolStripHowToUse_Clicked(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Resources goes in first groups, echelons and their \n" +
                "respective chapters go in the dropdown boxes. \nSelect number of hours to farm, " +
                "it will show potential reward.", "How to Use GF Calculator");
        }

        private void ToolStripReset_Clicked(object sender, EventArgs e)
        {
            Reset();
        }

        //Called when the hours numericUpDown is clicked
        private void NumHours_ValueChanged(object sender, EventArgs e)
        {
            labelMinOutput.Text = "";
            labelMaxOutput.Text = "";
            CalcLogistics();
        }

        //Called when the button is clicked
        private void ButtonCalculate_Click(object sender, EventArgs e)
        {
            labelMinOutput.Text = "";
            labelMaxOutput.Text = "";
            CalcResources(); //For the calculation of resources
            CalcLogistics(); //For the calculation of logistics
        }

        private void checkBoxGreat_CheckedChanged(object sender, EventArgs e)
        {
            labelMinOutput.Text = "";
            labelMaxOutput.Text = "";
            CalcLogistics();
        }

        private void CalcResources()
        {
            //Get difference from Current resources and Desired resources
            int manpowerDifference = GetDifference((int)numManpower.Value, (int)numManpowerDesired.Value);
            int ammoDifference = GetDifference((int)numAmmo.Value, (int)numAmmoDesired.Value);
            int rationDifference = GetDifference((int)numRations.Value, (int)numRationsDesired.Value);
            int partDifference = GetDifference((int)numParts.Value, (int)numPartsDesired.Value);
            //Manp, ammo and rations are generated at 3 per 3min, parts are generated at 1 per 3min, so 60m, 60m, 60m, and 20m.
            double manTime = (double)manpowerDifference / 60;
            manTime = Math.Round(manTime, 2, MidpointRounding.AwayFromZero); //round to remove long ass decimal
            double ammoTime = (double)ammoDifference / 60;
            ammoTime = Math.Round(ammoTime, 2, MidpointRounding.AwayFromZero);
            double rationsTime = (double)rationDifference / 60;
            rationsTime = Math.Round(rationsTime, 2, MidpointRounding.AwayFromZero);
            double partTime = (double)partDifference / 20;
            partTime = Math.Round(partTime, 2, MidpointRounding.AwayFromZero);
            String output = "ManP: " + GetTimeFormat(manTime) + "| Ammo: " + GetTimeFormat(ammoTime) + "| Rations: " +
                GetTimeFormat(rationsTime) + "| Parts: " + GetTimeFormat(partTime);
            labelMaterials.Text = output;
        }

        private void CalcLogistics()
        {
            int[] e1, e2, e3, e4;
            //Arrays hold the following:
            //    0    1       2       3         4
            // { man, ammo, rations, parts, (int)time};
            double manph = 0, ammoph = 0, rationsph = 0, partsph = 0;
            double hours = 0;

            //Heres where shit gets sloppy
            //Echelon 1
            e1 = CalcE1();
            //I dont even know where to begin with this shit
            //We store hours from the 4th index in the array, holding time
            hours = e1[4];
            //If this time is greater than 60, we're in minutes so we need to convert
            if(hours >= 60)
            {
                manph = manph + (e1[0] / (hours/60));
                ammoph = ammoph + (e1[1] / (hours / 60));
                rationsph = rationsph + (e1[2] / (hours / 60));
                partsph = partsph + (e1[3] / (hours / 60));
            }
            else if(hours < 60 && hours > 0)
            {
                double remainder = (60 / hours); //idk even why this shit works, but it does.
                manph = manph + (e1[0] * remainder);
                ammoph = ammoph + (e1[1] * remainder);
                rationsph = rationsph + (e1[2] * remainder);
                partsph = partsph + (e1[3] * remainder);
            }

            //Echelon 2
            e2 = CalcE2();
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

            //Echelon 3
            e3 = CalcE3();
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

            //Echelon 4
            e4 = CalcE4();
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

            //Totals
            manph = manph * (double)numHours.Value;
            manph = Math.Round(manph, 2, MidpointRounding.AwayFromZero);

            ammoph = ammoph * (double)numHours.Value;
            ammoph = Math.Round(ammoph, 2, MidpointRounding.AwayFromZero);

            rationsph = rationsph * (double)numHours.Value;
            rationsph = Math.Round(rationsph, 2, MidpointRounding.AwayFromZero);

            partsph = partsph * (double)numHours.Value;
            partsph = Math.Round(partsph, 2, MidpointRounding.AwayFromZero);

            //Output text
            labelMinOutput.Text = "ManP/h: " + manph + " | Ammo/h: " + ammoph
                + " | Rations/h: " + rationsph + " | Parts/h: " + partsph; ;

            //Show max output only if its enabled
            if(checkBoxGreat.Checked)
            {
                //Max Output is normal * 1.5, not double
                labelMaxOutput.Text = "Great Reward - ManP/h: " + (manph * 1.5) + " | Ammo/h: " + (ammoph * 1.5) +
                    " | Rations/h: " + (rationsph * 1.5) + " | Parts/h: " + (partsph * 1.5); ;
            }
        }

        //Calculations for Echelon 1, returns an int array (all of the rest are basically copies, but for each echelon)
        //You'll realize why I did it this way soon, yes it could be done differently and it will eventually.
        private int[] CalcE1()
        {
            //Create a Logistic, and initialize it.
            Logistic logi = null;
            //vars to hold our information from logi, we technically dont *need* them but I'm lazy.
            int man, ammo, rations, parts;
            Drop d1, d2;
            double time;
            //We have to reset the output text, but we dont want to call Reset()
            labelE1Resources.Text = "";
            labelE1Rewards.Text = "";

            //Resources
            //Get a Logistic from our selected chapter and map, they are stored locally for debugging reasons
            logi = GetLogisticFromNum(comboE1Chapter.SelectedIndex, comboE1Map.SelectedIndex);
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            //We have to divide by 60, because we are in minutes, needs to be hours
            String sTime = GetTimeFormat(time / 60);

            labelE1Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: " + rations + 
                " | Parts: " + parts + " | Time: " + sTime;

            //Drops
            //Basically we get the drop from the Logisitic, if no drop then emptyDrop
            //We can call it this way, due to the static nature of the variable
            if(logi.GetNumOfDrops() == 1)
            {
                d1 = logi.GetDrop(1);
                d2 = Mission.emptyDrop;
            }
            else if (logi.GetNumOfDrops() == 2)
            {
                d1 = logi.GetDrop(1);
                d2 = logi.GetDrop(2);
            }
            else
            {
                d1 = Mission.emptyDrop;
                d2 = Mission.emptyDrop;
            }

            labelE1Rewards.Text = "Potential Rewards: " + GetTextFromDrop(d1) + GetTextFromDrop(d2);

            // Okay, to explain the array: when we get the total of all resources, gotta send it back somehow and 
            // normally we can't return > 1 object, so we return an array containing all the useful stuff
            // time is an int now, since it doesnt have decimal places/etc.
            int[] data = new int[] { man, ammo, rations, parts, (int)time};
            return data;
        }

        private int[] CalcE2()
        {
            Logistic logi = null;
            int man, ammo, rations, parts;
            Drop d1, d2;
            double time;
            labelE2Resources.Text = "";
            labelE2Rewards.Text = "";

            //Resources
            logi = GetLogisticFromNum(comboE2Chapter.SelectedIndex, comboE2Map.SelectedIndex);
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = GetTimeFormat(time / 60);
            labelE2Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: " + rations +
                " | Parts: " + parts + " | Time: " + sTime;

            //Drops
            if(logi.GetNumOfDrops() == 1)
            {
                d1 = logi.GetDrop(1);
                d2 = Mission.emptyDrop;
            }
            else if (logi.GetNumOfDrops() == 2)
            {
                d1 = logi.GetDrop(1);
                d2 = logi.GetDrop(2);
            }
            else
            {
                d1 = Mission.emptyDrop;
                d2 = Mission.emptyDrop;
            }

            labelE2Rewards.Text = "Potential Rewards: " + GetTextFromDrop(d1) + GetTextFromDrop(d2);

            int[] data = new int[] { man, ammo, rations, parts, (int)time };
            return data;
        }

        private int[] CalcE3()
        {
            Logistic logi = null;
            int man, ammo, rations, parts;
            Drop d1, d2;
            double time;
            labelE3Resources.Text = "";
            labelE3Rewards.Text = "";

            //Resources
            logi = GetLogisticFromNum(comboE3Chapter.SelectedIndex, comboE3Map.SelectedIndex);
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = GetTimeFormat(time / 60);

            labelE3Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: " + rations + 
                " | Parts: " + parts + " | Time: " + sTime;

            //Drops
            if (logi.GetNumOfDrops() == 1)
            {
                d1 = logi.GetDrop(1);
                d2 = Mission.emptyDrop;
            }
            else if (logi.GetNumOfDrops() == 2)
            {
                d1 = logi.GetDrop(1);
                d2 = logi.GetDrop(2);
            }
            else
            {
                d1 = Mission.emptyDrop;
                d2 = Mission.emptyDrop;
            }

            labelE3Rewards.Text = "Potential Rewards: " + GetTextFromDrop(d1) + GetTextFromDrop(d2);

            int[] data = new int[] { man, ammo, rations, parts, (int)time };
            return data;
        }

        private int[] CalcE4()
        {
            Logistic logi = null;
            int man, ammo, rations, parts;
            Drop d1, d2;
            double time;
            labelE4Resources.Text = "";
            labelE4Rewards.Text = "";

            //Resources
            logi = GetLogisticFromNum(comboE4Chapter.SelectedIndex, comboE4Map.SelectedIndex);
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = GetTimeFormat(time / 60);

            labelE4Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: " + rations + " | Parts: " + parts + " | Time: " + sTime;

            //Drops
            if (logi.GetNumOfDrops() == 1)
            {
                d1 = logi.GetDrop(1);
                d2 = Mission.emptyDrop;
            }
            else if (logi.GetNumOfDrops() == 2)
            {
                d1 = logi.GetDrop(1);
                d2 = logi.GetDrop(2);
            }
            else
            {
                d1 = Mission.emptyDrop;
                d2 = Mission.emptyDrop;
            }

            labelE4Rewards.Text = "Potential Rewards: " + GetTextFromDrop(d1) + GetTextFromDrop(d2);

            int[] data = new int[] { man, ammo, rations, parts, (int)time };
            return data;
        }

        //Resets the forms
        private void Reset()
        {
            labelMaterials.Text = "";
            labelE1Resources.Text = "";
            labelE2Resources.Text = "";
            labelE3Resources.Text = "";
            labelE4Resources.Text = "";
            labelE1Rewards.Text = "";
            labelE2Rewards.Text = "";
            labelE3Rewards.Text = "";
            labelE4Rewards.Text = "";
            labelMinOutput.Text = "";
            labelMaxOutput.Text = "";
            numManpower.Value = 0;
            numAmmo.Value = 0;
            numRations.Value = 0;
            numParts.Value = 0;
            numManpowerDesired.Value = 0;
            numAmmoDesired.Value = 0;
            numRationsDesired.Value = 0;
            numPartsDesired.Value = 0;
            comboE1Chapter.ResetText();
            comboE1Map.ResetText();
            comboE2Chapter.ResetText();
            comboE2Map.ResetText();
            comboE3Chapter.ResetText();
            comboE3Map.ResetText();
            comboE4Chapter.ResetText();
            comboE4Map.ResetText();
        }

        //Just subtracts and returns the difference
        private int GetDifference(int before, int after)
        {
            return after - before;
        }

        //Returns a Drop from a specified ID
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

        //Returns a Drop form a specified ID, and adds the hours to it
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

        //Returns a Logistic from specifed chapter and mission num
        private Logistic GetLogisticFromNum(int chapter, int mission)
        {
            Logistic logistic = null;

            if (chapter == 0)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c0e1;
                        break;
                    case 1:
                        logistic = missions.c0e2;
                        break;
                    case 2:
                        logistic = missions.c0e3;
                        break;
                    case 3:
                        logistic = missions.c0e4;
                        break;
                }
            }
            else if (chapter == 1)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c1e1;
                        break;
                    case 1:
                        logistic = missions.c1e2;
                        break;
                    case 2:
                        logistic = missions.c1e3;
                        break;
                    case 3:
                        logistic = missions.c1e4;
                        break;
                }
            }
            else if (chapter == 2)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c2e1;
                        break;
                    case 1:
                        logistic = missions.c2e2;
                        break;
                    case 2:
                        logistic = missions.c2e3;
                        break;
                    case 3:
                        logistic = missions.c2e4;
                        break;
                }
            }
            else if (chapter == 3)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c3e1;
                        break;
                    case 1:
                        logistic = missions.c3e2;
                        break;
                    case 2:
                        logistic = missions.c3e3;
                        break;
                    case 3:
                        logistic = missions.c3e4;
                        break;
                }
            }
            else if (chapter == 4)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c4e1;
                        break;
                    case 1:
                        logistic = missions.c4e2;
                        break;
                    case 2:
                        logistic = missions.c4e3;
                        break;
                    case 3:
                        logistic = missions.c4e4;
                        break;
                }
            }
            else if (chapter == 5)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c5e1;
                        break;
                    case 1:
                        logistic = missions.c5e2;
                        break;
                    case 2:
                        logistic = missions.c5e3;
                        break;
                    case 3:
                        logistic = missions.c5e4;
                        break;
                }
            }
            else if (chapter == 6)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c6e1;
                        break;
                    case 1:
                        logistic = missions.c6e2;
                        break;
                    case 2:
                        logistic = missions.c6e3;
                        break;
                    case 3:
                        logistic = missions.c6e4;
                        break;
                    default:
                        logistic = null;
                        break;
                }
            }
            else if (chapter == 7)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c7e1;
                        break;
                    case 1:
                        logistic = missions.c7e2;
                        break;
                    case 2:
                        logistic = missions.c7e3;
                        break;
                    case 3:
                        logistic = missions.c7e4;
                        break;
                    default:
                        logistic = null;
                        break;
                }
            }
            else if (chapter == 8)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c8e1;
                        break;
                    case 1:
                        logistic = missions.c8e2;
                        break;
                    case 2:
                        logistic = missions.c8e3;
                        break;
                    case 3:
                        logistic = missions.c8e4;
                        break;
                    default:
                        logistic = null;
                        break;
                }
            }
            else if (chapter == 9)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c9e1;
                        break;
                    case 1:
                        logistic = missions.c9e2;
                        break;
                    case 2:
                        logistic = missions.c9e3;
                        break;
                    case 3:
                        logistic = missions.c9e4;
                        break;
                    default:
                        logistic = null;
                        break;
                }
            }
            else if (chapter == 10)
            {
                switch (mission)
                {
                    case 0:
                        logistic = missions.c10e1;
                        break;
                    case 1:
                        logistic = missions.c10e2;
                        break;
                    case 2:
                        logistic = missions.c10e3;
                        break;
                    case 3:
                        logistic = missions.c10e4;
                        break;
                    default:
                        logistic = null;
                        break;
                }
            }
            else
            {
                //fallback: no NullPtrs for us
                logistic = missions.emptyMission;
            }
            return logistic;
        }

        //Returns a String containing the output for the potential rewards.
        private String GetTextFromDrop(Drop drop)
        {
            String s = "";
            if(drop == null)
            {
                return "";
            }
            s = s + drop.GetName() + " ";
            return s;
        }

        //Takes in a time in HOURS, returns a string with that time formated to days, hours or minutes;
        private String GetTimeFormat(double d)
        {
            String s = "";
            if(d >= 24)
            {
                d = d / 24;
                d = Math.Round(d, 2, MidpointRounding.AwayFromZero); //Gotta rounnd again or its gonna fuck up.
                s = s + d + " day(s) ";
            }
            else if (d >= 1 && d < 24)
            {
                s = s + d + " hour(s) ";
            }
            else
            {
                d = d * 60;
                s = s + d + " minutes(s) ";
            }
            return s;
        }
    }
}
