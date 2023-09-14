using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateImplementation
{
    public class ActionDelegate
    {
        static void Main(string[] args)
        {
            ActionDelegates();
            //Action Delegate does not have return type, we can use it as Void.
            //it take 16 parameters
            //Action<int,int>action=method()
        }
        public static void ActionDelegates()
        {
            Action<int, int> action = Add;
            action(11, 12);
        }
        public static void Add(int x, int y)
        {
            Console.WriteLine($"Addition : 11 + 12 = {x + y}");
        }

    }
}
