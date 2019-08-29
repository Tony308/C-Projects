namespace Dynamic_Polymorphism
{
    public class Manager: Employee
    {
        double PhoneAllowance{ get;set;}

        public Manager() {
            PhoneAllowance = 4000;
        }
        public override double CalculateSalary() {
            return this.basicSalary + this.PhoneAllowance;
        }

    }
}