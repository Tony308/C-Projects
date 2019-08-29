using System; 

namespace Dynamic_Polymorphism
{
    public class Employee
    {
        protected int employeeId {
            get;set;
        }

        protected double basicSalary {
            get;set;
        }

        protected double bonus {get;set;}

        public Employee() {
            basicSalary = 10000;
        }

        public virtual double CalculateSalary() {
            return this.basicSalary;
        }

    }
}