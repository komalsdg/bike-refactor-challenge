namespace BikeDistributor.Discount
{
    public class Discounts
    {
        public Discounts(string code, string opertor, int quantity, double bikeprice, double amount)
        {
            Code = code;
            Operator = opertor;
            Quantity = quantity;
            BikePrice = bikeprice;
            Amount = amount;
        }

        public string Code { get; private set; }
        public string Operator { get; private set; }
        public int Quantity { get; private set; }
        public double BikePrice { get; private set; }
        public double Amount { get; private set; }
    }
}
