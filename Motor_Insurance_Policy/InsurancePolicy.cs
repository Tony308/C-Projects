namespace Motor_Insurance_Policy
{
    public abstract class InsurancePolicy
    {
        protected double PolicyCover {get;set;}
        int PolicyTerm {get;set;}

        double Premium {get;set;}

        double Risk {get;set;}
        public InsurancePolicy() {}

        public InsurancePolicy(int PolicyTerm) {
            this.PolicyTerm = PolicyTerm;
        }
        public abstract double CalculatePolicyCover();

        double CalculatePremium() {
            double premium = CalculateRisk() * CalculatePolicyCover() / PolicyTerm;
            return premium;
        }

        public abstract double CalculateRisk();


    }
}