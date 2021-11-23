using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Prototype
{
    public class NonDisclosureAgreement
    {
        public int Id { get; set; }
        public string NDAgreementName { get; set; }
    }

    public class SoftwareAgreement : IAgreement
    {
        private string _vendorName;
        private AgreementDto _agreementDto;
        public NonDisclosureAgreement NonDisclosureAgreement;

        public SoftwareAgreement(string vendorName, NonDisclosureAgreement nonDisclosureAgreement)
        {
            _vendorName = vendorName;
            NonDisclosureAgreement = nonDisclosureAgreement;

            Console.WriteLine("\nFetching agreement clause from the remote server..");
            Thread.Sleep(4000); //To simulate the late behaviour i.e object creation is a expensive work
            Console.Clear();
            AgreementClause agreementClause = new AgreementClause();
            _agreementDto = agreementClause.GetAgreementClause();
        }

        public void Print(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"\n\nMessage: {message}");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n----------Agreement Prototype-----------");
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine($"\nVendor Name: {_vendorName}");
            Console.WriteLine($"\nNDA Id: {NonDisclosureAgreement.Id}");
            Console.WriteLine($"\nDeveloper Clause: {_agreementDto.DeveloperClause}");
            Console.WriteLine($"\nPost Delivery Clause: {_agreementDto.PostDeliveryClause}");
            Console.WriteLine($"\nTermination Clause: {_agreementDto.ProjectTerminationClause}");
            Console.WriteLine($"\n----------------------------------------------------------------------------------");
        }

        public IAgreement ShallowCopy()
        {
            return (IAgreement)this.MemberwiseClone();
        }

        public IAgreement DeepCopy()
        {
            var agreementCopy = (SoftwareAgreement)this.MemberwiseClone();
            agreementCopy.NonDisclosureAgreement = new NonDisclosureAgreement
            {
                Id = this.NonDisclosureAgreement.Id,
                NDAgreementName = this.NonDisclosureAgreement.NDAgreementName
            };

            return agreementCopy;
        }
    }
}
