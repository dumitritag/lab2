using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Flyweight
{
    public class Treatment : Disease
    {
        /*private String name;
        private String state;

        public Treatment(String name)
        {
            this.name = name;
        }

        public void setState(String state)
        {
            this.state = state;
        }

    public void write(Target target)
        {
            Console.WriteLine("Boala " + name + ", starea " + state + "are acest tratament." + target.ID);
        }*/

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
