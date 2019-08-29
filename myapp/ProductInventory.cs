using System; 
namespace myapp
{
    public class ProductInventory
    {
        private int inventoryId;
        private int quantityInHand;

        public ProductInventory(int inventoryId, int quantityInHand)
        {
            this.inventoryId = inventoryId;
            this.quantityInHand = quantityInHand;
        }
    }
}