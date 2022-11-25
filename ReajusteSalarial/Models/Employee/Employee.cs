using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReajusteSalarial.Models.Employee
{
    internal class Employee : IEmployee
    {

        public Employee()
        {
            
        }
        public Employee(string name, double salary, int year)
        {
            this.Name = name;
            this.Salary = salary;
            this.year = year;
        }

        public string Roll { get; set; }
        public double Salary { get; set; }
        public string Name { get; set; }
        public int year { get; set; }

        
    }
}

   
