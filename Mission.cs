using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFResources
{
    class Mission
    {
        public Logistic empty = new Logistic(0, 0, 0, 0, 0);
        //Chapter 0
        public Logistic c0e1 = new Logistic(0, 145, 145, 0, 50);
        public Logistic c0e2 = new Logistic(550, 0, 0, 350, 180);
        public Logistic c0e3 = new Logistic(900, 900, 900, 250, 720);
        public Logistic c0e4 = new Logistic(0, 1200, 800, 750, 1440);
        //Chapter 1
        public Logistic c1e1 = new Logistic(10, 30, 15, 0, 15);
        public Logistic c1e2 = new Logistic(0, 40, 60, 0, 30);
        public Logistic c1e3 = new Logistic(30, 0, 30, 10, 60);
        public Logistic c1e4 = new Logistic(160, 160, 0, 0, 120);
        //Chapter 2
        public Logistic c2e1 = new Logistic(100, 0, 0, 30, 40);
        public Logistic c2e2 = new Logistic(60, 200, 80, 0, 90);
        public Logistic c2e3 = new Logistic(10, 10, 10, 230, 240);
        public Logistic c2e4 = new Logistic(0, 250, 600, 60, 360);
        //Chapter 3
        public Logistic c3e1 = new Logistic(50, 0, 75, 0, 20);
        public Logistic c3e2 = new Logistic(0, 120, 70, 30, 45);
        public Logistic c3e3 = new Logistic(0, 300, 0, 0, 90);
        public Logistic c3e4 = new Logistic(0, 0, 300, 300, 300);
        //Chapter 4
        public Logistic c4e1 = new Logistic(0, 185, 185, 0, 60);
        public Logistic c4e2 = new Logistic(0, 0, 0, 210, 120);
        public Logistic c4e3 = new Logistic(800, 550, 0, 0, 360);
        public Logistic c4e4 = new Logistic(400, 400, 400, 0, 480);
        //Chapter 5
        public Logistic c5e1 = new Logistic(0, 0, 100, 45, 30);
        public Logistic c5e2 = new Logistic(0, 600, 300, 0, 150);
        public Logistic c5e3 = new Logistic(800, 400, 400, 0, 240);
        public Logistic c5e4 = new Logistic(100, 0, 0, 700, 400);
        //Chapter 6
        public Logistic c6e1 = new Logistic(300, 300, 0, 100, 120);
        public Logistic c6e2 = new Logistic(0, 200, 550, 100, 180);
        public Logistic c6e3 = new Logistic(0, 0, 200, 500, 300);
        public Logistic c6e4 = new Logistic(800, 800, 800, 0, 720);
    }
}
