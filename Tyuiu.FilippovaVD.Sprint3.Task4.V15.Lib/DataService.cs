using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FilippovaVD.Sprint3.Task4.V15.Lib
{
    public class DataService : ISprint3Task4V15
    {
        public double Calculate(int startValue, int stopValue)
        {
            double p = 1; 

            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    continue;
                }

                double y = (Math.Sin(x) + x) / x + 0.75;

                p *= y;
            }

            return Math.Round(p, 3);
        }
    }
}
