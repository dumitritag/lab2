using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Decorator
{
    public class DoctorDecorator : Doctor
    {
        public Doctor oneDoctor;

        public DoctorDecorator(Doctor oneDoctor)
        {
            this.oneDoctor = oneDoctor;
        }

        public String investigate()
        {
            return oneDoctor.investigate();
        }

    }
}
