using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class PartTimeEmployee : Employee
    {
        public int hoursWorked { get; set; }
        public int hourlyrate { get; set; }
        public int TotalSalary { get; set; }
        
    }
      
}
