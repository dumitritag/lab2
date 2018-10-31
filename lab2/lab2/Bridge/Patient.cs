using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Bridge
{
    public abstract class Patient
    {
        public Policy policyType;

        public Patient(Policy policyType)
        {
            this.policyType = policyType;
        }

        abstract public void create();
    }
}
