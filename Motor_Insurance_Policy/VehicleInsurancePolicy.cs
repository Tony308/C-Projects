namespace Motor_Insurance_Policy
{
    public class VehicleInsurancePolicy: InsurancePolicy
    {
        string VehicleCondition {get;set;}

        double VehiclePrice {get;set;}
        string VehicleType {get;set;}
        
        public VehicleInsurancePolicy() {}
        public VehicleInsurancePolicy(string vehicleCondition, double VehiclePrice, string vehicleType, int policyTerm)
        :base(policyTerm)
        {
            this.VehicleCondition = vehicleCondition;
            this.VehiclePrice = VehiclePrice;
            this.VehicleType = vehicleType;
        }
        public override double CalculatePolicyCover() {
            if (this.VehicleCondition == "New") {
                return 0.9*VehiclePrice;
            } else if (VehicleCondition == "Good") {
                return 0.75*VehiclePrice;
            } else if (VehicleCondition == "Old") {
                return 0.5*VehiclePrice;
            }
            return 0.5*VehiclePrice;
        } 

        public override double CalculateRisk() {
            if (this.VehicleType == "Sports") {
                return 0.35;
            }
            else if ( this.VehicleType == "Logistics") {
                return 0.4;
            }
            else if (this.VehicleType == "Sedan") {
                return 0.2;
            }
            else {
                return 0.15;
            }
        }

   
    }
}
