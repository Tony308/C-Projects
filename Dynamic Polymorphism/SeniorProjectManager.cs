using System;


namespace Dynamic_Polymorphism
{
    public class SeniorProjectManager : Employee
    {
        double CarAllowance {get;set;}
        public SeniorProjectManager() {
            CarAllowance = 6000;
        }
        public override double CalculateSalary() {
            return basicSalary + CarAllowance;
        }

    
    }
}