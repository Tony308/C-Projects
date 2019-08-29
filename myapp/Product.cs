using System;

namespace myapp
{
    public class Product
    {
        private static int currentProductId;
        private string description;
        private double price;
        private string productId;
        private string productName;
        public Product(){}
        static Product() {
            currentProductId = 100;
        }
        public Product(string description, string productName,double price)
        {
            this.description = description;
            this.price = price;
            this.productId = "P" + currentProductId++;
            this.productName = productName;
        }

        public string Description { get => description; set => description = value; }
        public double Price { get => price; set => price = value; }
        public string ProductId { get => productId; set => productId = value; }
        public string ProductName { get => productName; set => productName = value; }
    }
}