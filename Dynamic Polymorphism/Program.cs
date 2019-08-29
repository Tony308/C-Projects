using System;

namespace Dynamic_Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee javaGuy = new SystemEngineer("Java");
            Employee guy = new SystemEngineer("French");

            Employee SPM = new SeniorProjectManager();
            Employee manager = new Manager();
    
            Finance finance = new Finance();
            Console.WriteLine(finance.GetCalculatedSalary(SPM));
            Console.WriteLine(finance.GetCalculatedSalary(javaGuy));
            Console.WriteLine(finance.GetCalculatedSalary(guy));
            Console.WriteLine(finance.GetCalculatedSalary(manager));
        }
    }
}
