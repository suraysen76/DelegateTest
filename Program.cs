using System;

namespace DelegateTest
{
    internal class Program
    {
        public delegate int TestDelegate(int x, int y);
        static void Main(string[] args)
        {
            Console.WriteLine("Start");
            TestDelegate del1 = new TestDelegate(CalculatorClass.Add);
            //Invoke Add() method using the delegate.
            int addResult = del1(5, 5);
            Console.WriteLine("5 + 5 = {0}\n", addResult);

            TestDelegate del2 = new TestDelegate(CalculatorClass.Multiply);
            int multiplyResult = del2(5, 5);
            Console.WriteLine("5 * 5 = {0}\n", multiplyResult);

        }
        public class CalculatorClass
        {
            public static int Add(int x, int y)
            {
                return x + y;
            }
            public static int Multiply(int x, int y)
            {
                return x * y;
            }
        }
    }
}
