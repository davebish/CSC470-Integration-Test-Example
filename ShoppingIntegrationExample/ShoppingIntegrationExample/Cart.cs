using System.Collections.Generic;

namespace ShoppingIntegrationExample
{
    public class Cart
    {
        private Dictionary<string, Item> Items = new Dictionary<string, Item>();
        private Dictionary<string, int> Quantities = new Dictionary<string, int>();

        public void AddItem(Item item, int quantity)
        {
            Items.Add(item.GetName(), item);
            Quantities.Add(item.GetName(), quantity);
        }

        public decimal TotalPrice()
        {
            decimal total = 0.0M;

            foreach (KeyValuePair<string, Item> entry in Items)
            {
                total += entry.Value.GetPrice() * Quantities[entry.Value.GetName()];
            }

            return total;
        }
    }
}
