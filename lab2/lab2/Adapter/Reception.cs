using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Adapter
{
    public class Reception
    {
        public void inform()
        {
            Console.WriteLine("Buna ziua!Cu ce va pot ajuta?");
            Console.ReadLine();
        }

        public void register()
        {
            Console.WriteLine("Informatii despre date personale.");
            Console.ReadLine();
        }

    }
}
