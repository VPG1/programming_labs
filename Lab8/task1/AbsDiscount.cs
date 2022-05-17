namespace task1
{
    public class AbsDiscount : ITariffPrice
    {
        private decimal price;
        private decimal discount;

        public AbsDiscount(decimal price, decimal discount)
        {
            this.price = price;
            this.discount = discount;
        }
        public decimal GetTariffPrice()
        {
            return price - discount;
        }

    }
}