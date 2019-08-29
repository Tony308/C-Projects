using System;

namespace Constructor_Chaining_Demo
{
public class RegularCustomer : Customer  
    {
        private double discountPercentage;
        public RegularCustomer()
        {
            Console.WriteLine("derived class- RegularCustomer constructor..");
        }
        public RegularCustomer(string name, string contactNumber, string emailid, 
                                                 string address, double discount)
            :base(name,contactNumber,emailid,address) // here the 'base' keyword is used  to invoke parent class constructor to initialize the inherited members
        {
            this.discountPercentage = discount;
        }
        public double DiscountPercentage
        {
            get
            {
                return discountPercentage;
            }
            set
            {
                discountPercentage = value;
            }
        }
    }      
 public class EliteCustomer:Customer
    {
        private int couponsOwned;
        public EliteCustomer()
        {
            Console.WriteLine("derived class- EliteCustomer constructor..");
        }
        public EliteCustomer(string name, string contactNumber, string emailid, string 
                                                                 address, int coupons)
            :base(name,contactNumber,emailid,address) // here the 'base' keyword is used to invoke parent class constructor to initialize the inherited members
        {
            this.couponsOwned = coupons;
        }
        public int CouponsOwned
        {
            get
            {
                return couponsOwned;
            }
            set
            {
                couponsOwned = value;
            }
        }
        public double GetDiscount()
        {
            double discount = CouponsOwned * .01;
            this.CouponsOwned = 0;
            return discount;
        }
    }                                                                                                   

}