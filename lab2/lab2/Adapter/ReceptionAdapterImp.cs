using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Adapter
{
    public class ReceptionAdapterImp : ReceptionAdapter
    {
        Reception receptor;

        public ReceptionAdapterImp(Reception newReceptor)
        {
            receptor = newReceptor;
        }

    public void informInEnglish()
        {
            receptor.inform();
            Console.WriteLine("Hello, can I help you?");
            Console.ReadLine();
        }

    public void registerInEnglish()
        {
            receptor.register();
            Console.WriteLine("I need your personal data information.");
            Console.ReadLine();
        }

    }
}
