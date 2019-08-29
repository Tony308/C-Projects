using System;

namespace Constructor_Chaining_Demo
{
 class Program
    {
        static void Main(string[] args)
        {
            // To understand the order of constructor calls
            RegularCustomer customerOne = new RegularCustomer();
            EliteCustomer customerTwo = new EliteCustomer();
            //To print customer details
            RegularCustomer customerThree = new RegularCustomer("Tom","9876543456","Tom@gmail.com","New Delhi",15);
            Console.WriteLine(customerThree.CustomerId);
            Console.WriteLine(customerThree.CustomerName);
            Console.WriteLine(customerThree.ContactNumber);
            Console.WriteLine(customerThree.EmailId);
            Console.WriteLine(customerThree.Address);
            Console.WriteLine(customerThree.DiscountPercentage);
            EliteCustomer customerFour =new EliteCustomer("Tibi","9876543218", "Tibi@gmail.com", "New York", 4);
            Console.WriteLine(customerFour.CustomerId);
            Console.WriteLine(customerFour.CustomerName);
            Console.WriteLine(customerFour.ContactNumber);
            Console.WriteLine(customerFour.EmailId);
            Console.WriteLine(customerFour.Address);
            Console.WriteLine(customerFour.CouponsOwned);
        }
    }

}
