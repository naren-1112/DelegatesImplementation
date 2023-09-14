using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesImplementation
{
    public class FuncDelegate
    {
        static void Main(string[] args)
        {
            FuncDelegates();
            //Func Delegates takes max of 16 parameters and last one as output
            //func<int,int,int,int>Myfunc=method()
            //Func Delegate can be only used when there is a return method

        }
        public static void FuncDelegates()
        {
            Func<int, int, int> MyFunc = Add;
            Console.WriteLine("Enter two numbers");
            int x= Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Addition of {x} and {y} is {MyFunc(x,y)}");

            //Func<int, int, int> MyFunc = Sub;
            //Console.WriteLine("Enter two numbers");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Addition of {x} and {y} is {MyFunc(x, y)}");

            //Func<int, int, int> MyFunc = Multiply;
            //Console.WriteLine("Enter two numbers");
            //int x = Convert.ToInt32(Console.ReadLine());
            //int y = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine($"Addition of {x} and {y} is {MyFunc(x, y)}");
            //Console.WriteLine( );
        }
        public static int Add(int x,int y)
        {
            int Sum = x + y;
            return Sum;
        }
        //public static int Sub(int x, int y)
        //{
        //    int Difference = x - y;
        //    return Difference;
        //}
        //public static int Multiply(int x, int y)
        //{
        //    int Multiplied = x * y;
        //    return Multiplied;
        //}
    }
}
