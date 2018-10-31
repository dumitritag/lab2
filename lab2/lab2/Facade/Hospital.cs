using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Facade
{
    public class Hospital
    {
        private Department ginecology;
        private Department therapy;

        public Hospital()
        {
            ginecology = new Ginecology();
            therapy = new Therapy();
        }
        public void visitGinecology()
        {
            ginecology.visit();
        }
        public void visitTherapy()
        {
            therapy.visit();
        }

    }
}
