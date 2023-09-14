using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateImplementation
{
    public class PredicateDelegate
    {
        static void Main(string[] args)
        {
            PredicateDelegates();
            //Predicate returns data type as bool(true/false)
            //It takes only one parameter
        }
        public static void PredicateDelegates()
        {
            Predicate<string> predicate = str => str.Equals(str.ToLower());
            Console.WriteLine($"{predicate("Naren")}");
            Console.WriteLine($"{predicate("sk")}");
            Predicate<string> predicate1 = str => str.Equals(str.ToUpper());
            Console.WriteLine($"{predicate1("DHONI")}");
            Console.WriteLine($"{predicate1("kohli")}");

        }
    }
}
