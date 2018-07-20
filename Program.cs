using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckStringByPal
{
    class Program
    {
        static void Main(string[] args)
        {
            Validator val = new Validator();
            string str = "";
            string str1 = "g";
            string pal = "34th";
            int numCharPal;
            bool result = val.CheckStringByPal(str, pal, out numCharPal);

            Console.WriteLine(" String  -  {0}\n Noise  -  {1}\n Number of noise char  -  {2} \n Result  - {3}", str, pal, numCharPal, result);
            Console.ReadLine();
        }
    }
}
