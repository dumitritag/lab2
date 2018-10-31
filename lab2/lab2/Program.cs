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


            Console.ReadKey();
        }
    }
}
