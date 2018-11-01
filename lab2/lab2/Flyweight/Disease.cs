using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Flyweight
{
    public abstract  class Disease
    {
        public string name { get; internal set; }
        public string state { get; internal set; }


        public abstract void write(Target target);
    }
}
