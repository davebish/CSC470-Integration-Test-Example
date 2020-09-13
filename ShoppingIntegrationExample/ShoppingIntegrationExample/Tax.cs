namespace ShoppingIntegrationExample
{
    public class Tax
    {
        public decimal Calculate(decimal Amount, Shopper shopper)
        {
            const string SOUTH_DAKOTA = "South Dakota";
            const string NEBRASKA = "Nebraska";
            const string MINNESOTA = "Minnesota";

            // Defalt taxrate of 5%
            decimal TaxRate = 0.05M;

            if (shopper.GetState() == SOUTH_DAKOTA)
            {
                TaxRate = 0.045M;
            }
            else if (shopper.GetState() == NEBRASKA)
            {
                TaxRate = 0.055M;
            }
            else if (shopper.GetState() == MINNESOTA)
            {
                TaxRate = 0.06875M;
            }

            return TaxRate * Amount;
        }
    }
}
