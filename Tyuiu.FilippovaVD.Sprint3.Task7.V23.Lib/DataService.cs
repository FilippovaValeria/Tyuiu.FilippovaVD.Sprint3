using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FilippovaVD.Sprint3.Task7.V23.Lib
{
    public class DataService : ISprint3Task7V23
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int count = stopValue - startValue + 1;
            double[] result = new double[count];

            int index = 0; 

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 2.0 * x - 2.0;
                double y;

                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = 4.0 - 2.0 * x + (2.0 + Math.Cos(x)) / denominator;
                }

                result[index] = Math.Round(y, 2);
                index++;
            }

            return result;
        }
    }
}
