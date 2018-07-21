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
            string str = "e5fj33gf44dvbbttvdfghhjf5e";
            string pal = "34th";
            bool result = val.CheckStringByPal(str, pal);

            Console.WriteLine(" String  -  {0}\n Noise  -  {1} \n Result  - {2}", str, pal, result);
            Console.ReadLine();
        }
    }
}
