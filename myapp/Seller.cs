using System;

namespace myapp
{
    public class Seller
    {
        private string sellerId;
        private static int sellerIdCount;
        private string sellerName;

        public Seller(string SellerId, string sellerName)
        {   
            this.sellerId = "S" + sellerIdCount++;
            this.sellerName = sellerName;
        }

public Seller() {}
        static Seller() {
            sellerIdCount = 1001;
        } 

        public string SellerId { get => sellerId; set => sellerId = value; }
        public int SellerIdCount { get => sellerIdCount; set => sellerIdCount = value; }
        public string SellerName { get => sellerName; set => sellerName = value; }
    }
}