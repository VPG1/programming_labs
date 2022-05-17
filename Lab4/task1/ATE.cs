using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace task1
{
    public class ATE
    {
        private static ATE instance;
        private string address;
        private int numOfClients;

        public string Address { get; }

        public int NumOfClients { get; }

        public Tariff Tariff { get; }


        public ATE(string address, int numOfClients, Tariff tariff)
        {
            this.address = address;
            this.numOfClients = numOfClients;
            this.Tariff = tariff;
            
            Address = address;
            NumOfClients = numOfClients;
            Tariff = tariff;
        }

        public static ATE GetInstance(string address, int numOfClients, Tariff tariff)
        {
            return instance ?? (instance = new ATE(address, numOfClients, tariff));
        }

        public void IncreaseTariff(decimal increaseValue)
        {
            Tariff.Increase(increaseValue);
        }
        
        public void DecreaseTariff(decimal decreaseValue)
        {
            Tariff.Decrease(decreaseValue);
        }

        public decimal CalculatePay()
        {
            return numOfClients * Tariff.Value;
        }
        
    }
}