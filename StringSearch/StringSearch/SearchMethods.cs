using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using in_at;
using System.Reflection;

namespace StringSearch
{
    public class SearchMethods
    {
        public void Identical(string first, string second)
        {
            Assembly identical = Assembly.LoadFrom(@"E:\Visual Project\StringSearch\searchIdentical\searchIdentical\bin\Debug\searchIdentical.dll");

            var identicalType = identical.GetType("searchIdentical.Identical");

            var infoIdentical = Activator.CreateInstance(identicalType) as IMethodInfo;
            infoIdentical.PrintMethodInfo();

            var algoritm = Activator.CreateInstance(identicalType) as ISearch;
            algoritm.Search(first, second);
            Console.WriteLine("Input string: {0}\n", first);
        }

        public void WithoutRegister(string first, string second)
        {
            Assembly withoutRegister = Assembly.LoadFrom(@"E:\Visual Project\StringSearch\searchWithoutRegister\searchWithoutRegister\bin\Debug\searchWithoutRegister.dll");

            var withoutRegisterType = withoutRegister.GetType("searchWithoutRegister.WithoutRegister");

            var infoWithoutRegister = Activator.CreateInstance(withoutRegisterType) as IMethodInfo;
            infoWithoutRegister.PrintMethodInfo();

            var algoritm = Activator.CreateInstance(withoutRegisterType) as ISearch;
            algoritm.Search(first, second);
            Console.WriteLine("Input string: {0}\n", first);
        }

        public void WithoutSpaces(string first, string second)
        {
            Assembly withoutSpaces = Assembly.LoadFrom(@"E:\Visual Project\StringSearch\searchWithoutSpaces\searchWithoutSpaces\bin\Debug\searchWithoutSpaces.dll");

            var withoutSpacesType = withoutSpaces.GetType("searchWithoutSpaces.WithoutSpaces");

            var infoWithoutSpaces = Activator.CreateInstance(withoutSpacesType) as IMethodInfo;
            infoWithoutSpaces.PrintMethodInfo();

            var algoritm = Activator.CreateInstance(withoutSpacesType) as ISearch;
            algoritm.Search(first, second);
            Console.WriteLine("Input string: {0}\n", first);
        }

        public void WithoutSpacesAndRegister(string first, string second)
        {
            Assembly WithoutSpacesAndRegister = Assembly.LoadFrom(@"E:\Visual Project\StringSearch\searchWithoutSpacesAndRegister\searchWithoutSpacesAndRegister\bin\Debug\searchWithoutSpacesAndRegister.dll");

            var withoutSpacesAndRegisterType = WithoutSpacesAndRegister.GetType("searchWithoutSpacesAndRegister.WithoutSpacesAndRegister");

            var infoWithoutSpacesAndRegister = Activator.CreateInstance(withoutSpacesAndRegisterType) as IMethodInfo;
            infoWithoutSpacesAndRegister.PrintMethodInfo();

            var algoritm = Activator.CreateInstance(withoutSpacesAndRegisterType) as ISearch;
            algoritm.Search(first, second);
            Console.WriteLine("Input string: {0}\n", first);
        }
    }
}
