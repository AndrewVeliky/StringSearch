using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using in_at;

namespace StringSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var method = new SearchMethods();
            method.Identical("asda s da","da s");
            method.WithoutRegister("sdfsASmmdfssd", "aSm");
            method.WithoutSpaces("1231 123 123 12 1C2B 3a 123123123 123 123 12", "1C 2B 3a");
            method.WithoutSpacesAndRegister("1231 123 123 12 1C2B 3a 123123123 123 123 12", "1C 2b 3A");

            Console.ReadKey();
        }

        

        

        


    }
}
