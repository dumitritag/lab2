using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Bridge
{
    public class PurchasedPolicy : Policy
    {
        public void purchase()
        {
            Console.WriteLine("Am cuparat!");
        }
    }
}
