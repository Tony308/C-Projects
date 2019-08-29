using System;

namespace OverridingQuickKart_App_Exercise
{
    public class EliteCustomer : Customer
    {
        private int ownedCoupons;
        public int OwnedCoupons { get => ownedCoupons; set => ownedCoupons = value; }

        public EliteCustomer(string customerName, string address, DateTime dateOfBirth, string emailId, Gender gender, string password, int ownedCoupons) 
        : base() {
        }
        public double CalculateDiscount() {
            return 0;
        }
    }
}