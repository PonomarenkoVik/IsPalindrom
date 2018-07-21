using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStringByPal
{
    class Validator
    {
        public bool CheckStringByPal(string pal, string noise)
        {
            int numNoiseChar = 0;

            if (pal == null)
            {
                return false;
            }

            bool result = true;
            
            int leftIndex = 0;
            int rightIndex = pal.Length - 1;
            while (leftIndex < rightIndex)
            {
                if (IsNoise(pal[leftIndex], noise))
                {
                    numNoiseChar++;
                    leftIndex++;
                    continue;
                }

                if (IsNoise(pal[rightIndex], noise))
                {
                    numNoiseChar++;
                    rightIndex--;
                    continue;
                }

                if (pal[leftIndex] != pal[rightIndex])
                {
                    result = false;
                    break;
                }

                leftIndex++;
                rightIndex--;
            }
               
                if (numNoiseChar == pal.Length)
                {
                    result = false;
                }               
            return result;
        }


        private bool IsNoise(char ch, string noise)
        {
            if ((noise == null) || (noise == ""))
            {
                return false;
            }

            bool result = false;

            foreach (var palChar in noise)
            {
                if (ch == palChar)
                {
                    result = true;
                    break;
                }
            }

            return result;
        }
    }
}
