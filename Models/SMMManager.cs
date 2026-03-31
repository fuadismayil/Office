using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.Models
{
    internal class SMMManager: Employee
    {
        public int WorkHours { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"SMM Manager: {FirstName} {LastName}, Work hours: {WorkHours}");
        }
    }
}