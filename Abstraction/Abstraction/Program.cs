using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
  

    public class Program
    {
        static void Main(string[] args)
        {

            List<FulltimeEmployee> xxx = new List<FulltimeEmployee>();

            for (int i = 0; i < 100; i++)
            {
                xxx.Add(new FulltimeEmployee()
                {
                    empId = i
                });

            }
            PartTimeEmployee ObjPT = new PartTimeEmployee();
            FulltimeEmployee ObjFT = new FulltimeEmployee();


            Console.Write("Enter Emplyee Type");
            string type = Console.ReadLine();

            if (type == "p")
            {
                Console.WriteLine("Please Enter your EmpID ");
                String id = Console.ReadLine();
                ObjPT.empId = Convert.ToInt32(id);
                Console.WriteLine("Please Enter your Firstname ");
                ObjPT.firstName = Console.ReadLine();
                Console.WriteLine("Please Enter your Last Name ");
                ObjPT.lastName = Console.ReadLine();
                Console.WriteLine("Please Enter your HoursWorked ");
                string hworked = Console.ReadLine();
                ObjPT.hoursWorked = Convert.ToInt32(hworked);
                Console.WriteLine("Please Enter your Hourlyrate ");
                string hrate = Console.ReadLine();
                ObjPT.hoursWorked = Convert.ToInt32(hrate);
                Console.ReadLine();            
            }
            else
            {
                Console.WriteLine("Please Enter your EmpID ");
                String id = Console.ReadLine();
                ObjFT.empId = Convert.ToInt32(id);
                Console.WriteLine("Please Enter your Firstname ");
                ObjFT.firstName = Console.ReadLine();
                Console.WriteLine("Please Enter your Last Name ");
                ObjFT.lastName = Console.ReadLine();
                Console.WriteLine("Please Enter your AnnualSalary ");
                string asalary = Console.ReadLine();
                ObjFT.annualSalary = Convert.ToInt32(asalary);
                Console.ReadLine();

            }

            PrintData(ObjFT);

            PrintData(ObjPT);
            Console.ReadKey();
            
        }

        public static int TotalSalary(int rate, int hours)
        {
            return rate * hours;
        }

        static void PrintData(Object x)
        {
            if (x is FulltimeEmployee)
            {
                FulltimeEmployee obj = (FulltimeEmployee)x;
                Console.WriteLine(obj.empId);
            }

            if (x is PartTimeEmployee)
            {
                PartTimeEmployee obj = (PartTimeEmployee)x;
                Console.WriteLine(obj.empId);
            }
        }

    }
    class ABC
    {
        private void method()
        {
            Program.TotalSalary(4, 6);
        }
    }
}




