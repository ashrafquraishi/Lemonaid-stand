namespace lms1
{
    public class Product
    {
        string name;
        string unit;
        public string recipePart;
        double price;


        public Product(string name, double price, string unit, string recipePart)
        {
            this.name = name;
            this.unit = unit;
            this.recipePart = recipePart;
            this.price = price;

        }
        public string Name
        {
            get { return name; }
            private set { name = value; }
        }

        public double Price
        {
            get { return price; }
            private set { price = value; }
        }

        public string Recipepart
        {
            get { return recipePart; }
            private set { recipePart = value; }
        }

        public string Unit
        {
            get { return unit; }
            private set { unit = value; }
        }
    }
}
