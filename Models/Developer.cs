using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Office.Models
{
    internal class Developer: Employee
    {
        public int ProjectCount { get; set; }
        public string Speciality { get; set; }

        public override void GetInfo()
        {
            Console.WriteLine($"Developer: {FirstName} {LastName}, Project count: {ProjectCount}");
        }
    }
}