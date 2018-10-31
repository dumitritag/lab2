using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Facade
{
    public class Therapy : Department
    {
        public void visit()
        {
            Console.WriteLine("Sectia Terapie!");
        }
    }
}
