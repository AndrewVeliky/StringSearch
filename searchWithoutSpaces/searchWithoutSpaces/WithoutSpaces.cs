using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using in_at;

namespace searchWithoutSpaces
{
    [Class(Name = "WithoutSpaces Method", Description = "Search string without spaces in target string", Version = "1.0.0.0.0")]
    public class WithoutSpaces : ISearch, IMethodInfo
    {
        public void Search(string target, string input)
        {
           var targetWithoutSpaces = target.Replace(" ", string.Empty);
           var inputWithoutSpaces = input.Replace(" ", string.Empty);

            if (targetWithoutSpaces.Contains(inputWithoutSpaces))
            {
                Console.WriteLine("Without spaces: {0}", input); 
            }
            else
            {
                Console.WriteLine("Oops!");
            }
        }

        public void PrintMethodInfo()
        {
            Type t = typeof(WithoutSpaces);
            Attribute[] attrs = Attribute.GetCustomAttributes(t);

            foreach (var attr in attrs)
            {
                if (attr is ClassAttribute)
                {
                    var a = (ClassAttribute)attr;
                    Console.WriteLine("\tName: {0}\n\tDescription: {1}\n\tVersion: {2}\n", a.Name, a.Description, a.Version);
                }
            }
        }
    }
}
