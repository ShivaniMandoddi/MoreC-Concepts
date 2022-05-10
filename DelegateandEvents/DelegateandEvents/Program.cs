using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
delegate int NumberChanger(int value);
namespace DelegateandEvents
{
    class Program
    {
        static int number=10;
        static void Main(string[] args)
        {
            NumberChanger number1 = new NumberChanger(AddNumber);
            NumberChanger number2 = new NumberChanger(MultiplyNumber);

            number1(4);
            Console.WriteLine(GetNumber());
            number2(2);
            Console.WriteLine(GetNumber());
            Console.ReadLine();

        }
        public static int AddNumber(int X)
        {
            number += X;
            return (number);
        }
        public static int MultiplyNumber(int X)
        {
            number *= X;
            return (number);
        }
        public static int GetNumber()
        {
            return (number);
        }


    }
}
