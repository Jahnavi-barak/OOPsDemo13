using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassandObject
{
     public class Calculator
     {
        int num1;
        int num2;
        int result;
        void Add()
        {
            result = num1 + num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        void substract()
        {
            result = num1 - num2;
            Console.WriteLine(result);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            Calculator obj = new Calculator();
            obj.num1 = 10;
            obj.num2 = 20;
            obj.Add();
            obj.substract();
        }
    }
}
