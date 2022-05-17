namespace task1
{
    public class Tariff
    {
        public string name { get; private set; }
        private ITariffPrice it;

        public Tariff(string name, ITariffPrice it)
        {
            this.name = name;
            this.it = it;
        }

        public decimal GetTariffPrice()
        {
            return it.GetTariffPrice();
        }
    }
}