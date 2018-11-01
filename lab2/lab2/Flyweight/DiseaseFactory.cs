using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2.Flyweight
{
    class DiseaseFactory
    {
        private readonly Dictionary<string, Disease> treatmentDictionary = new Dictionary<string, Disease>();

        public  Disease getTreatment(String type)
        {
            
                if (treatmentDictionary.ContainsKey(type))
                {
                    return treatmentDictionary[type];
                }
                Disease treatment;

                switch (type)
                {
                    case "Gripa":
                    treatment = new Treatment
                    {
                        name = "Gripa",
                        state = "Medie"
                        };
                        break;

                    case "Pneumonie":
                        treatment = new Treatment
                        {
                            name = "Pneumonie",
                            state = "Acuta"
                        };
                        break;

                    case "Tuberculoza":
                        treatment = new Treatment
                        {
                            name = "Tuberculoza",
                            state = "Slaba"
                        };
                        break;

                    default:
                        throw new ArgumentException();
                }

            treatmentDictionary.Add(type, treatment);
                return treatment;
            }
    }
}
