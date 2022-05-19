using System.Collections.Generic;

namespace task1
{
    public class Ate
    {
        private List<Tariff> tariffs = new List<Tariff>();


        public void AddAbsDiscountTariff(string name, decimal price, decimal discount)
        {
            tariffs.Add(new Tariff(name, new AbsDiscount(price, discount)));    
        }

        public void AddNoDiscountTariff(string name, decimal price)
        {
            tariffs.Add(new Tariff(name, new NoDiscount(price)));
        }

        public decimal GetAveragePrice()
        {
            decimal res = 0;
            foreach (var tariff in tariffs)
            {
                res += tariff.GetTariffPrice();
            }

            return res / tariffs.Count;
        }
    }
}