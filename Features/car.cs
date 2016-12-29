using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Features
{
    enum Colours
    {
        Red,
        Yellow,
        Blue
    }
    class car
    {
        int intmotorPower;
        public int MotorPower
        {
            get
            {

                return intmotorPower;
            }
            set
            {
                if (value > 0 && value < 5000)
                {
                    intmotorPower = value;

                }
            }

        }
        public Colours Colour { get; set; }
    }
}
