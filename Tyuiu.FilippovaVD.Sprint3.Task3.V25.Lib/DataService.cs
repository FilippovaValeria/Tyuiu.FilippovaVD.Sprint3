using System;
using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.FilippovaVD.Sprint3.Task3.V25.Lib
{
    public class DataService : ISprint3Task3V25
    {
        public int GetMinCharCount(string value, char item)
        {
            int minCount = int.MaxValue; 
            int currentCount = 0;
            char prevChar = '\0';
            bool foundAny = false;

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
                    if (currentCount > 0)
                    {
                        foundAny = true;
                        if (currentCount < minCount)
                        {
                            minCount = currentCount;
                        }
                        currentCount = 0;
                    }
                }
                prevChar = c;
            }

            if (currentCount > 0)
            {
                foundAny = true;
                if (currentCount < minCount)
                {
                    minCount = currentCount;
                }
            }

            if (!foundAny)
                return 0;

            return minCount;
        }
    }
}
