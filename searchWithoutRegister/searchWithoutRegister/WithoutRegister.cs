using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using in_at;

namespace searchWithoutRegister
{
    [Class(Name = "WithoutRegister Method", Description = "Search string without register in target string", Version = "1.0.0.0.0")]
    public class WithoutRegister : ISearch, IMethodInfo
    {
        public void Search(string target, string input)
        {
            var targetLower =  target.ToLower();
            var inputLower = input.ToLower();

            if (targetLower.Contains(inputLower))
                Console.WriteLine("Without register: {0}", input);
            else
                Console.WriteLine("Oopss!");
        }

        public void PrintMethodInfo()
        {
            Type t = typeof(WithoutRegister);
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
