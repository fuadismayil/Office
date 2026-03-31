using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.Models
{
    internal class Manager: Employee
    {
        public double Salary { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Manager: {FirstName} {LastName}, Salary: {Salary}");
        }
    }
}