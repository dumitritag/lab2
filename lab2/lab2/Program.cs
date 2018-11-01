using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****Hospital****\n");
            Facade.Hospital hospital = new Facade.Hospital();
            hospital.visitTherapy();

            Adapter.Reception receptor = new Adapter.Reception();
            Adapter.ReceptionAdapterImp receptorAdapter = new Adapter.ReceptionAdapterImp(receptor);

            Console.WriteLine("****Reception****\n");

            receptor.inform();
            receptor.register();

            Console.WriteLine("I don't speak Roumanian.");
            receptorAdapter.informInEnglish();
            receptorAdapter.registerInEnglish();

            Console.WriteLine("\n**************\n");
            Bridge.Patient patient1 = new Bridge.PatientWithPolicy(new Bridge.FreePolicy());
            patient1.create();
            Bridge.Patient patient2 = new Bridge.PatientWithoutPolicy(new Bridge.PurchasedPolicy());
            patient2.create();

            Console.WriteLine("\n**************\n");
            Decorator.Doctor doctor = new Decorator.Treatment(new Decorator.Surgery(new Decorator.DoctorImp()));
            Console.WriteLine(doctor.investigate());

            Console.WriteLine("\n**************\n");
            /* for (int i = 0; i< 30; i++) {
            Flyweight.Disease disease = (Flyweight.Disease)Flyweight.DiseaseFactory.getTreatment("Pneumonie");
            disease.setState("Acuta");
            disease.write();
             }*/

            Flyweight.DiseaseFactory factory = new Flyweight.DiseaseFactory();

            Flyweight.Target disease1 = new Flyweight.Target();
            disease1.ID = Guid.NewGuid();
            disease1.DiseaseData = factory.getTreatment("Gripa");

            Flyweight.Target disease2 = new Flyweight.Target();
            disease2.ID = Guid.NewGuid();
            disease2.DiseaseData = factory.getTreatment("Gripa");

            bool result = disease1.DiseaseData == disease2.DiseaseData;     // result = true
            Console.WriteLine("Sunt identice obiectele: " + result);
            string state = disease1.DiseaseData.state;

            Console.WriteLine("Instante Desease: " + Flyweight.Treatment.NumberOfInstances);

            Console.ReadKey();
        }
    }
}
