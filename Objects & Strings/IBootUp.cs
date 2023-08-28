using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects___Strings
{
    internal interface IBootUp
    {

        //calls on the metod IsOn
        public bool IsOn { get; set; }

        //creates a refence for powerOnOff method
        public void PowerOnOff();
    }
}
