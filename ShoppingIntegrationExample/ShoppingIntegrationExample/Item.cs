namespace ShoppingIntegrationExample
{
    public class Item
    {
        private string Name;
        private decimal Price;

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public string GetName()
        {
            return Name;
        }

        public decimal GetPrice()
        {
            return Price;
        }
    }
}
