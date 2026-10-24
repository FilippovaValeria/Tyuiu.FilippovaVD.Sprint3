using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.FilippovaVD.Sprint3.Task2.V5.Lib
{
    public class DataService : ISprint3Task2V5
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double s = 0; 
            int k = startValue;

           
            do
            {
                
                double term = (Math.Pow(value, k) + 1) * Math.Cos(k);


                s += term;

                
                k++;
            }
            while (k <= stopValue); 

            
            return Math.Round(s, 3);
        }
    }
}
