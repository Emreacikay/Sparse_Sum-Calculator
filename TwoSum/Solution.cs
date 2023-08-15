using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace TwoSum
{
    public class Solution
    {
        public int sparseCalculator(int number)
        {
            int lastValue = number - 1;
            int middle = number / 2;
            int result = -1;
            Dictionary<int,int> values  = new Dictionary<int,int>();


            for(int i =1; i < middle; i++)
            {
                if(lastValue + i == number)
                {
                    values.Add(lastValue, i);
                    result = isItSparse(values);
                    if(result > 0)
                    {
                        return result;
                    }
                    else
                    {
                        lastValue--;
                        continue;
                    }
                }
                else
                {
                    lastValue--;
                    continue;
                }
                
            }

            return -1;
        }




        int isItSparse(Dictionary<int,int> values)
        {
            if(binaryCalculator(values.Last().Value) && binaryCalculator(values.Last().Key))
            {
                return values.Last().Value;
            }
            else
            {
                return -1;
            }
        }

        bool binaryCalculator(int number)
        {
            string binary = Convert.ToString(number, 2);
            
            if (!binary.Contains("11"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        
    }

}
