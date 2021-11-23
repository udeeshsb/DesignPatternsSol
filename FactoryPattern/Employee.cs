using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Employee
    {
        private int EmployeeId;
        private string EmployeeName;
        public double Salary { get; set; }
        public int Grade { get; set; }
        public string Company = "IBM";

        IEmail _email;
        public Employee(int employeeId, string employeeName, IEmail email)
        {
            this.EmployeeId = employeeId;
            this.EmployeeName = employeeName;
            this._email = email;
        }

        public void notifiyEmployee()
        {
            _email.SendMail();
        }
    }

    public interface IEmail
    {
        void SendMail();
    }

    public class OutlookEmail : IEmail
    {
        public void SendMail() {
            Console.WriteLine("Outlook Email send mail");
        }
    }

    public class WebserviceEmail : IEmail
    {
        public void SendMail()
        {
            Console.WriteLine("WebserviceEmail send mail");
        }
    }

    public class TestEmployee
    {
        static void Main()
        {
            IEmail email = new OutlookEmail();
            Employee permenantEmp = new Employee(100, "XYZ", email);
            permenantEmp.notifiyEmployee();

            email = new WebserviceEmail();
            Employee contractorEmp = new Employee(101, "ABC", email);
            contractorEmp.notifiyEmployee();
        }
    }
}
