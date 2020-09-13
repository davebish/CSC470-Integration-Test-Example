namespace ShoppingIntegrationExample
{
    public class Shopper
    {
        private int Id;
        private string Name;
        private string State;
        private Cart cart = new Cart();

        public Shopper(int id, string name, string state)
        {
            Id = id;
            Name = name;
            State = state;
        }
        public int GetId()
        {
            return Id;
        }
        public string GetName()
        {
            return Name;
        }

        public string GetState()
        {
            return State;
        }
        
        public void Add(Item item, int quantity)
        {
            cart.AddItem(item, quantity);
        }
        public decimal CheckOut()
        {
            decimal totalWithoutTax = cart.TotalPrice();
            Tax tax = new Tax();
            decimal taxAmt = tax.Calculate(totalWithoutTax, this);
            return taxAmt + totalWithoutTax;
        }
    }
}
