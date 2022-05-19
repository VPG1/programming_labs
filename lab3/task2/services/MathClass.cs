using System;


namespace task2.services
{
    public class MathClass
    {
        public MathClass()
        {
        }

        public int numOfBranch;

        public double Calc(double z)
        {
            var x = GetX(z);
            return Math.Pow(Math.Cos(Math.Pow(x, 2)), 3) + Math.Pow(Math.Sin(Math.Pow(x, 3)), 2);
        }

        private double GetX(double z){
            numOfBranch = (z < 1 ? 1 : 2);
            return z < 1 ? Math.Pow(z, 3) + 0.2 : z + Math.Log(z);
        }
    }
}
