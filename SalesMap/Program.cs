using SalesMap.Entites;
using Microsoft.EntityFrameworkCore;
using SalesMap.Context;
using System.Diagnostics;

namespace SalesMap
{
    internal class Program
    {
        static void Main(string[] args)
        {
         

            using (SlaesOfficedbContext slaesOfficedbContext = new SlaesOfficedbContext())
            {
                Employee employee = new Employee
                {

                    Name = "Mohamed Elnahas",
                };

                slaesOfficedbContext.Employees.Add(employee);
                Console.WriteLine(slaesOfficedbContext.Entry(employee).State);

                slaesOfficedbContext.SaveChanges();

            }
        }
    }
}
