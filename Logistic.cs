﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Logistic
    {
        private int manpower;
        private int ammunition;
        private int rations;
        private int parts;
        private float time;
        private Drops drops;

        private void Set(int manp, int ammo, int ration, int part, float timetaken)
        {
            manpower = manp;
            ammunition = ammo;
            rations = ration;
            parts = part;
            time = timetaken;
        }

        public Logistic(int manp, int ammo, int ration, int part, float timetaken)
        {
            Set(manp, ammo, ration, part, timetaken);
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
    }
}