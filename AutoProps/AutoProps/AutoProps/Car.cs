﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoProps
{
    class Car
    {
        // Авоматические свойства!
        public string PetName
        {
            get;
            set;
        }
        public int Speed
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        public void DisplayStatus()
        {
            Console.WriteLine("Car Name: {0}", PetName);
            Console.WriteLine("Speed: {0}", Speed);
            Console.WriteLine("Color: {0}", Color);
        }
    }
}