namespace Motor_Insurance_Policy
{
    public class LifeInsurancePolicy: InsurancePolicy
    {
        int Age {get;set;}

        string MedicalHistory {get;set;}

        public LifeInsurancePolicy(int age, string MedicalHistory, double policyCover, int policyTerm) 
        :base(policyTerm) {
            this.Age = age;
            this.MedicalHistory = MedicalHistory;
            this.PolicyCover = policyCover;
        }
        public override double CalculatePolicyCover() {
            return this.PolicyCover;
        }

        public override double CalculateRisk() {
            double risk = 0.0;
            if (Age <= 25) {
                risk =+ 0.05;
            } else if (Age <= 40) {
                risk =+ 0.1;
            } else if (Age <= 55) {
                risk =+ 0.15;
            } else {
                risk =+ 0.2;
            }

            if (MedicalHistory == "Clear") {
                risk =+ 0.05;
            } else if (MedicalHistory == "Minor") {
                risk =+ 0.1;
            } else if (MedicalHistory == "Moderate") {
                risk =+ 0.15;
            } else if (MedicalHistory == "Major") {
                risk =+ 0.2;
            }
            return risk;
        }


    }
}