using System;

namespace myapp
{
    class Program
    {
        static void Main(string[] args)
        {
        //    Class methods and constructors exercise
        /*   
        string[] skills = {"Java", "SQL"};

        Instructor simon = new Instructor(10, 3, "Simon", new string[] {"Java", "stuff"} );
        Instructor james = new Instructor(3, 1, "James", new string[] {"Java", "stuff"} );

        Console.WriteLine(simon.checkSkill("Java"));
        Console.WriteLine(james.checkSkill("Java"));
 */
        //Day 1 overloading-1
        /*
          Purchase order1 = new Purchase("djfp2f",15, "hell", new DateTime(), "V" );
        Console.WriteLine(order1.calculateBillAmount(15.00));
        Console.WriteLine(order1.calculateBillAmount(15.00, 25)); */

        // Day 1, Overloading-2
        /*
        Account p1 = new Account(1234, 1000439000.00, new string[] {"tony", "michael", "louise"}, new long[] {1,2,3,4,5});
        Console.WriteLine(p1.debitAmount(3000.00));
        Console.WriteLine(p1.debitAmount(999999999999.00));
        Console.WriteLine(p1.transferMoney("tony", 50000000.00));
        Console.WriteLine(p1.transferMoney("kitty", 5dot0000000.00));
        Console.WriteLine(p1.transferMoney(5, 5235));
        Console.WriteLine(p1.transferMoney(7, 5235));
         */

         Purchase order = new Purchase(new DateTime(1996,6,1),"Visa", 666, "hell");
         new Purchase(new DateTime(2001, 12,25), "MasterCard", 777,"heaven");
         new Purchase(new DateTime(1,1,1), "A", 777, "Earth");

        Console.WriteLine(Purchase.getPurchasePercentage(
            new DateTime[] {order.DateOfPurchase, order.DateOfPurchase }, order.DateOfPurchase));

        }

    }
}