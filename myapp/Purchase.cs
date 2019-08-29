using System;

namespace myapp
{
    public class Purchase
    {

        private DateTime dateOfPurchase;
        private string paymentType;
        private static int purchaseCounter;
        private string purchaseId;
        private int quantityOrdered;
        private string shippingAddress;

        public DateTime DateOfPurchase { get => dateOfPurchase; set => dateOfPurchase = value; }
        public string PaymentType { get => paymentType; set => paymentType = value; }
    
        public string PurchaseId { get => purchaseId; set => purchaseId = value; }
        public int QuantityOrdered { get => quantityOrdered; set => quantityOrdered = value; }
        public string ShippingAddress { get => shippingAddress; set => shippingAddress = value; }

        Purchase() {
            
        }
        static Purchase(){
            purchaseCounter = 1001;
        }

        public Purchase(DateTime dateOfPurchase, string paymentType, int quantityOrdered, string shippingAddress)
        {
            this.dateOfPurchase = dateOfPurchase;
            this.paymentType = paymentType;
            this.purchaseId = "B" + purchaseCounter++;
            this.quantityOrdered = quantityOrdered;
            this.shippingAddress = shippingAddress;
        }

        public double calculateBillAmount(double price) {
            double total = 0;
            total += this.quantityOrdered * price;

            return total;
        }
   
        static double roundOffBill(double amount) {
            return Math.Round(amount,2);
        }
        public double calculateBillAmount(double price, double discountPercentage) {
            double total = 0;

            total = price * (1 -  discountPercentage/100);

            return total;
        }

        public static double getPurchasePercentage(DateTime[] transactionDates, DateTime dateForReport) {
            double purchasePercentage = 1;
            double counter = 0;
            foreach (DateTime date in transactionDates) {
                if (date == dateForReport) {
                    counter++;
                }
            }
            purchasePercentage = counter * transactionDates.Length / 100;
            return purchasePercentage;

        }

       
        
    }
}