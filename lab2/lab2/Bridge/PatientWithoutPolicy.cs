using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Bridge
{
    public class PatientWithoutPolicy : Patient
    {
        public PatientWithoutPolicy(Policy policyType) : base(policyType)
        {
        }

        public override void create()
        {
            Console.WriteLine("Pacient fara polita.");
            policyType.purchase();
        }
    }
}
