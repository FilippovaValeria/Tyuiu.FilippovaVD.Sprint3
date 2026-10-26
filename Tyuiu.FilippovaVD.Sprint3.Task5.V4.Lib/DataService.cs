using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FilippovaVD.Sprint3.Task5.V4.Lib
{
    public class DataService : ISprint3Task5V4
    {
        public double GetSumSumSeries(int x, int startValue1, int stopValue1, int startValue2, int stopValue2)
        {
            double totalSum = 0;

            for (int i = startValue1; i <= stopValue1; i++)
            {
                for (int k = startValue2; k <= stopValue2; k++)
                {
                    totalSum += (double)x / Math.Cos(k);
                }
            }

            return Math.Round(totalSum, 3);
        }
    }
}