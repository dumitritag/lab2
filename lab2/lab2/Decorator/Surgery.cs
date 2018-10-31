using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Decorator
{
    public class Surgery : DoctorDecorator
    {
        public Surgery(Doctor oneDoctor) : base(oneDoctor)
        {
        }

        public String investigate()
        {
            return oneDoctor.investigate() + addSurgery();
        }

        private String addSurgery()
        {
            return "+ Aveti nevoie de o operatie.";
        }
    }
}
