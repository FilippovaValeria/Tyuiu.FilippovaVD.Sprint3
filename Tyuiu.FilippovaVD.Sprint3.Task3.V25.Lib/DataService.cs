using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FilippovaVD.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int maxCount = 0;     
            int currentCount = 0; 
            char prevChar = '\0'; 

            foreach (char c in value)
            {
                if (c == item)
                {
                    if (prevChar == item)
                    {
                        currentCount++;
                    }
                    else
                    {
                        currentCount = 1;
                    }
                }
                else
                {
                    currentCount = 0;
                }

                if (currentCount > maxCount)
                {
                    maxCount = currentCount;
                }

                prevChar = c;
            }

            return maxCount;
        }
    }
}
