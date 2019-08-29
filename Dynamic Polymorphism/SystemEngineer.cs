namespace Dynamic_Polymorphism
{
    public class SystemEngineer : Employee
    {
        double SpecialistAllowance{get;set;}

        string Speciliazation{get;set;}
        public SystemEngineer(string specialization) :base() {
            this.Speciliazation = specialization;
        }
        public override double CalculateSalary() {
        
            if (this.Speciliazation == "C#" || this.Speciliazation == "Java" || this.Speciliazation == "SQL") {
                this.SpecialistAllowance = 3000;
            } else {
                this.SpecialistAllowance = 0.0;
            }
            double salary = this.basicSalary + this.SpecialistAllowance;
            return salary;
        }

      
    }
}