using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radio
{
    class Radio
    {
        public void Power(bool turnOn)
        {
            Console.WriteLine("Radio on: {0}", turnOn);

        }
    }
    class Car
    {
        private Radio myRadio = new Radio();
        public void TurnOnRadio(bool onOff)
        {
            myRadio.Power(onOff);
        }
    }

}

