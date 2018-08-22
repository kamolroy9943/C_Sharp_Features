using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate
{
    public class MyClass
    {
        public delegate int Operation(int x);

        public static int TernsForm(int value,Operation operation)
        {
            return operation(value);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            var result = MyClass.TernsForm(20, CalCulation.Cuber);

            Console.WriteLine(result);
        }

    }

    public class CalCulation
    {
        public static int Squere(int value)
        {
            return value * value;
        }
        public static int Cuber(int value)
        {
            return value * value * value;
        }
    }
}
