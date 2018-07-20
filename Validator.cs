using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStringByPal
{
    class Validator
    {
        public bool CheckStringByPal(string str, string pal)
        {
            int numNoiseChar = 0;

            if (str == null)
            {
                return false;
            }

            bool result = true;
            
            int leftIndex = 0;
            int rightIndex = str.Length - 1;
            while (leftIndex < rightIndex)
            {
                if (IsNoise(str[leftIndex], pal))
                {
                    numNoiseChar++;
                    leftIndex++;
                    continue;
                }

                if (IsNoise(str[rightIndex], pal))
                {
                    numNoiseChar++;
                    rightIndex--;
                    continue;
                }

                if (str[leftIndex] != str[rightIndex])
                {
                    result = false;
                    break;
                }

                leftIndex++;
                rightIndex--;
            }
               
                if (numNoiseChar == str.Length)
                {
                    result = false;
                }               
            return result;
        }




        private bool IsNoise(char ch, string pal)
        {
            if ((pal == null) && (pal == ""))
            {
                return false;
            }

            bool result = false;

            for (int i = 0; i < pal.Length; i++)
            {
                if (ch == pal[i])
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
