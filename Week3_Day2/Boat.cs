using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week3_Day2
{
    class Boat
    {
        public int numberOfPassengers;

        private string name;
        private double engineSize;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        public Boat()
        {

        }

        public void Move()
        {
            //code to make the boat move
        }

        private double CalculateMPG()
        {
            //code to calculate the MPG
            return MPG;
        }
    }
}
