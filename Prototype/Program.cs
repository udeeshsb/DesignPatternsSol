using System;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! This is Prototype pattern.");
            Console.WriteLine("\nSpecify the kind of Objects to create using a prototypical instance, and create new objects by copying this prototype.");
            Console.WriteLine("\nThe concept is shallow copy or deep copy using prototype pattern.");

            SoftwareAgreement softwareAgreement = new SoftwareAgreement("XYZ Consultancy",
                new NonDisclosureAgreement { Id = 123, NDAgreementName = "Source Code" });

            softwareAgreement.Print("Initial Agreement");

            var clonedAgreement = (SoftwareAgreement)softwareAgreement.ShallowCopy();
            clonedAgreement.Print("Cloned Agreement");
            clonedAgreement.NonDisclosureAgreement.Id = 789456;
            clonedAgreement.Print("Agreement with updated non disclosure id");
            softwareAgreement.Print("Initial Agreement");

            var deepAgreement = (SoftwareAgreement)softwareAgreement.DeepCopy();
            deepAgreement.Print("Deep Copy Agreement");
            deepAgreement.NonDisclosureAgreement.Id = 123456;
            deepAgreement.Print("Agreement with updated non disclosure id");
            softwareAgreement.Print("Initial Agreement");
        }
    }
}
