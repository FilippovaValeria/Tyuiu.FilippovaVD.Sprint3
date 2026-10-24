using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FilippovaVD.Sprint3.Task1.V23.Lib
{
    public class DataService : ISprint3Task1V23
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            int k = startValue;

            while (k <=stopValue)
            {
                double denominator = Math.Sin(value) + Math.Pow(value, k);

                double term = Math.Pow(300.0 / denominator, k);

                p *= term;

                k++;
            }

            return Math.Round(p, 3);
        }
    }
}
