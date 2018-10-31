using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Decorator
{
    public class Treatment : DoctorDecorator
    {
        public Treatment(Doctor oneDoctor) : base(oneDoctor)
        {
        }

        public String investigate()
        {
            return oneDoctor.investigate() + addTreatment();
        }

        private String addTreatment()
        {
            return "+ Aveti nevoie de un tratament.";
        }

    }
}
