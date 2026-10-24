using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FilippovaVD.Sprint3.Task0.V24.Lib
{
    public class DataService : ISprint3Task0V24
    {
        public double GetMultiplySeries(int value, int startValue, int stopValue)
        {
            double p = 1;

            for (int i = startValue; i <= stopValue; i++)
            {
                double xPower = Math.Pow(value, -1);

                double term = Math.Pow(3.0 / (i + xPower), 2);

                p *= term;
            }

            return Math.Round(p, 3);
            
        }
    }
}
