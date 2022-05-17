namespace task1
{
    public class Tariff
    {
        public string TariffType { get; private set; }
        public decimal Coast { get; private set; }

        public Tariff(string tariffType, decimal coast)
        {
            TariffType = tariffType;
            Coast = coast;
        }
    }
}