using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.Models
{
    internal class Saler: Employee
    {
        public double Salary { get; set; }
        public double Benefit { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Saler: {FirstName} {LastName}, Salary: {Salary}");
        }
    }
}
