using System;

namespace OverridingQuickKart_App_Exercise
{
    public class PrivilegedCustomer : Customer
    {
        private CustomerCardType cardType;

        public CustomerCardType CardType { get => cardType; set => cardType = value; }
    }

    public override double CalculateDiscount() {

        return 0;
    }
}