using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Flyweight
{
    public class Treatment : Disease
    {

        public static int NumberOfInstances;

        public Treatment()
        {
            NumberOfInstances++;
        }

        public override void write(Target target)
        {
            Console.WriteLine("Boala {0}, starea {1}.", target.ID, state);
        }

    }
}
