using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Shahab4.Sprint4.Task7.V20.Lib
{
    public class DataService : ISprint4Task7V20 
    {
        public DataService()
        {
        }

        public int Calculate(string str)
        {
            
            if (string.IsNullOrEmpty(str) || str.Length != 15)
            {
                return 0;
            }

          
            int product = 1;
            bool foundEven = false;

            for (int i = 0; i < str.Length; i++)
            {
                char c = str[i];

                if (char.IsDigit(c))
                {
                    int digit = int.Parse(c.ToString());

                    
                    if (digit % 2 == 0)
                    {
                        product = product * digit; 
                        foundEven = true;
                    }
                }
            }

            return foundEven ? product : 0;
        }

        public int Calculate(int n, int m, string value)
        {
            throw new NotImplementedException();
        }
    }
}