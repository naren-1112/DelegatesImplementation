using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesImplementation
{
    public class Delegates
    {      
        public delegate void Delegate(int x, int y);
        static void Main(string[] args)
        {
            //UniCast Delegate
            Delegate del1 = new Delegate(Add);
            del1 (11, 12);

            Delegate del2 = new Delegate (Sub);
            del2(11, 12);

            Delegate del3 = new Delegate (Multiply);
            del3(11, 12);

            //MultiCast Delegate
            //Delegate del1 = new Delegate(Add);
            //del1(11, 12);
            //del1 += Sub;
            //del1 += Multiply;

            Console.WriteLine();
        }
        public static void Add(int x, int y)
        {
            int Sum = x + y;
            Console.WriteLine("Sum of {0}+{1} = {2}",x,y,Sum);
        }
        public static void Sub(int x, int y)
        {
            int Difference = x - y;
            Console.WriteLine("Difference of {0}-{1} = {2}", x, y, Difference);
        }
        public static void Multiply(int x, int y)
        {
            int Multiplied = x * y;
            Console.WriteLine("Multiplication of {0}*{1} = {2}", x, y, Multiplied);
        }

    }
}