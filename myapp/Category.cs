using System;

namespace myapp
{
    public class Category
    {
        private int categoryId;
        private string categoryName;

        public Category(int categoryId, string categoryName)
        {
            this.categoryId = categoryId;
            this.categoryName = categoryName;
        }
    }
}