using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Case
{
    class Program
    {
        static void Main(string[] args)
        {
            Condition m = new Condition();
            m.GetCoordinates();
            m.GetInputData();
            m.GetVariables();
            m.Calculation();
        }

    }
}

