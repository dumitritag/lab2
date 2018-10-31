using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Bridge
{
    public class FreePolicy : Policy
    {
        public void purchase()
        {
            Console.WriteLine("Sunt student!");
        }
    }
}
