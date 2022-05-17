namespace task1
{
    public class NoDiscount : ITariffPrice
    {
        private decimal price;

        public NoDiscount(decimal price)
        {
            this.price = price;
        }
        public decimal GetTariffPrice()
        {
            return price;
        }
    }
}