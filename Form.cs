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
        Mission missions = new Mission();

        public Form()
        {
            InitializeComponent();
            reset();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //popup about menu
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
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
            double ammoTime = (double)ammoDifference / 60;
            double rationsTime = (double)rationDifference / 60;
            double partTime = (double)partDifference / 20;

            labelMaterials.Text = "ManP: " + manTime + " hours | Ammo: " + ammoTime + " hours | Rations: "
                + rationsTime + " hours | Parts: " + partTime + " hours";
        }

        private void calcLogistics()
        {
            //        0     1      2      3        4
            //data { man, ammo, rations, parts, (int)time };
            int[] e1, e2, e3, e4;
            double manph = 0, ammoph = 0, rationsph = 0, partsph = 0;
            double hours = 0;
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
            manph = manph * (double)numHours.Value;
            ammoph = ammoph * (double)numHours.Value;
            rationsph = rationsph * (double)numHours.Value;
            partsph = partsph * (double)numHours.Value;
            labelOutput.Text = "ManP/h: " + manph + " | Ammo/h: " + ammoph + " | Rations/h: " + rationsph + " | Parts/h: " + partsph;
        }

        private int[] calcE1()
        {
            Logistic logi = null;
            int man, ammo, rations, parts;
            double time;
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
                logi = missions.empty;
            }
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            int[] data = new int[] { man, ammo, rations, parts, (int)time };
            String sTime = "";
            if (time >= 60)
            {
                time = time / 60;
                sTime = "" + time + "h";
            }
            else
            {
                sTime = "" + time + "min";
            }
            labelE1Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: "
                + rations + " | Parts: " + parts + " | Time: " + sTime;
            return data;
        }

        private int[] calcE2()
        {
            Logistic logi = null;
            int man, ammo, rations, parts;
            double time;
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
                logi = missions.empty;
            }
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = "";
            int[] data = new int[] { man, ammo, rations, parts, (int)time };
            if (time >= 60)
            {
                time = time / 60;
                sTime = "" + time + "h";
            }
            else
            {
                sTime = "" + time + "min";
            }

            labelE2Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: "
                + rations + " | Parts: " + parts + " | Time: " + sTime;
            return data;
        }

        private int[] calcE3()
        {
            Logistic logi = null;
            int man, ammo, rations, parts;
            double time;
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
                logi = missions.empty;
            }
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = "";
            int[] data = new int[] { man, ammo, rations, parts, (int)time };
            if (time >= 60)
            {
                time = time / 60;
                sTime = "" + time + "h";
            }
            else
            {
                sTime = "" + time + "min";
            }

            labelE3Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: "
                + rations + " | Parts: " + parts + " | Time: " + sTime;
            return data;
        }

        private int[] calcE4()
        {
            Logistic logi = null;
            int man, ammo, rations, parts;
            double time;
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
                logi = missions.empty;
            }
            man = logi.GetManpower();
            ammo = logi.GetAmmo();
            rations = logi.GetRations();
            parts = logi.GetParts();
            time = logi.GetTime();
            String sTime = "";
            int[] data = new int[] { man, ammo, rations, parts, (int)time };
            if (time >= 60)
            {
                time = time / 60;
                sTime = "" + time + "h";
            }
            else
            {
                sTime = "" + time + "min";
            }

            labelE4Resources.Text = "" + "ManP: " + man + " | Ammo: " + ammo + " | Rations: "
                + rations + " | Parts: " + parts + " | Time: " + sTime;
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
            numManpower.Value = 0;
            numAmmo.Value = 0;
            numRations.Value = 0;
            numParts.Value = 0;
            numManpowerDesired.Value = 0;
            numAmmoDesired.Value = 0;
            numRationsDesired.Value = 0;
            numPartsDesired.Value = 0;
        }
    }
}
