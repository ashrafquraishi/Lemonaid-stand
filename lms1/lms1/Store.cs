using System.Collections.Generic;

namespace lms1
{
    public class Store
    {
        List<Product> products;
        static double lemonPrice = 0.50;
        static double sugarPrice = 0.30;
        static double iceCubePrice = 0.10;
        static double cupPrice = 0.90;

        public List<Product> Products
        {
            get { return products; }
            private set { Products = value; }
        }
        public Store()
        {
            products = new List<Product>();
            products.Add(new Product("lemon", lemonPrice, "each", "pitcher"));
            products.Add(new Product("sugar", sugarPrice, "cup", "pitcher"));
            products.Add(new Product("ice cube", iceCubePrice, "each", "cup"));
            products.Add(new Product("cup", cupPrice, "each", "cup"));
        }
