namespace Dynamic_Polymorphism
{
    public class Finance
    {
        public double GetCalculatedSalary(Employee obj) {
            double bonus = 0.0;
            if (obj is SystemEngineer) {
                bonus = 5000;
            }
            else if (obj is Manager) {
                bonus = 9000;
            }
            else if (obj is SeniorProjectManager) {
                bonus = 15000;
            } else {
                bonus = 0.0;
            }
            return bonus + obj.CalculateSalary();
        }
    }
}