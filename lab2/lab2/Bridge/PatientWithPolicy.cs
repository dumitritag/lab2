using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Bridge
{
    public class PatientWithPolicy : Patient
    {
        public PatientWithPolicy(Policy policyType) : base(policyType)
        {
        }

    public override void create()
        {
            Console.WriteLine("Pacient cu polita.");
            policyType.purchase();
        }
    }
}
