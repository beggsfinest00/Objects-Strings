using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects___Strings
{
    internal class Computer : IBootUp
    {
        //makes a bool named IsOn and gets and sets it
        public bool IsOn { get; set; }
        //makes a string named brand and gets and sets it
        public string Brand { get; set; }
        //makes a string named type and gets and sets it
        public string Type { get; set; }

        //creates a public metheod named Computer and pulls brand type isOn
        //also takes brand,Type,isOn and gives them the name brand,type and isOn
        public Computer(string brand, string type, bool isOn) 
        {
            Brand = brand;
            Type = type;
            IsOn = isOn;
        }

        //makes a public void method called PowerOnOff and finds weather the computer is on or off
        public void PowerOnOff()
        {
            IsOn = !IsOn;

            if (IsOn == true)
            {
                Console.WriteLine("The computer is booting up!");
            }
            else 
            { 
                Console.WriteLine("The computer is shutting down!"); 
            }
        }

        //crates a string override for when tostring is called
        public override string ToString()
        {
            return $"The computer is made by {Brand} and is a {Type} computer, it is on: {IsOn}!";
        }
    }
}
