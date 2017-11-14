using System;
using in_at;

namespace searchIdentical
{
    [Class(Name = "Identical Method", Description = "Search identical string in target string", Version = "1.0.0.0.0")]
    public class Identical : ISearch, IMethodInfo
    {
        
        public void Search(string first, string second)
        {
            if (first.Contains(second))
                Console.WriteLine("Identical: {0}", second);
            else
                Console.WriteLine("Oops!");

        }

        public void PrintMethodInfo()
        {
            Type t = typeof(Identical);
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
