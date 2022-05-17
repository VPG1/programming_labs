namespace task1
{
    public class Tariff
    {
        private decimal value;

        public Tariff(decimal value)
        {
            this.value = value;
            Value = value;
        }
        
        public decimal Value { get; set; }

        public void Increase(decimal increaseValue)
        {
            value += increaseValue;
            Value = value;
        }

        public void Decrease(decimal decreaseValue)
        {
            value -= decreaseValue;
            Value = value;
        }
        
    }
}