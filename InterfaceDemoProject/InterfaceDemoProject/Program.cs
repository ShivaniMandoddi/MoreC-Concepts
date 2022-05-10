using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace InterfaceDemoProject
{
    class Program
    {
        /*void ISampleInterface.SampleMethod()
        {
            Console.WriteLine("This is my SampleMethod from interface");
        }*/
        static void Main(string[] args)
        {
            //ISampleInterface myObject = new Program();
            //myObject.SampleMethod();
            ISquareRoot squareRoot = new ToCalculateSquareRoot(3,4);
            PrintTheValue(squareRoot);
            Console.WriteLine(squareRoot.MySquareRoot());
            Console.ReadLine();
        }
        public static void PrintTheValue(ISquareRoot _squareRoot)
        {
            Console.WriteLine("X : {0}, Y: {1}",_squareRoot.X,_squareRoot.Y);
        }
    }
    /*interface ISampleInterface
    {
        void SampleMethod();
    }*/
    interface ISquareRoot
    {
        int X { get; set; }
        int Y { get; set; }
        double MySquareRoot();
    }
    public class ToCalculateSquareRoot : ISquareRoot
    {
        public int X { get; set; }
        public int Y { get; set; }
        public ToCalculateSquareRoot(int x,int y)
        {
            X = x;
            Y = y;
        }
        public double MySquareRoot()
        {
            return (Math.Sqrt(X * X + Y * Y));
        }
        
    }
}
