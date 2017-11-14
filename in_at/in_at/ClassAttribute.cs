using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace in_at
{
    public class ClassAttribute : Attribute
    {
        public string Name;
        public string Description;
        public string Version;
    }

    public class ClassInfoAttribute : Attribute      
    {
        public static void PrintMethodInfo(Type t)
        {
            Attribute[] attrs = GetCustomAttributes(t);

            foreach (var attr in attrs)
            {
                if (attr is ClassAttribute)
                {
                    var a = (ClassAttribute)attr;
                    Console.WriteLine("Name: {0}\nDescription: {1}\n,Version{2}", a.Name, a.Description, a.Version);
                }
            }
        }
    }
}
