namespace OverridingQuickKart_App_Exercise
{
    public class RegularCustomer : Customer
    {
        private double discountPercentage;

        public double DiscountPercentage { get => discountPercentage; set => discountPercentage = value; }

        public override double CalculateDiscount() {

            return 0;
        }
    }
}