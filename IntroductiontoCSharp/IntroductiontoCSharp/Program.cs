using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            /// <summary>
            ///Introduction to C#
            ///Different types of comments 
            ///1. Xml documentation comments, line comment and multiple line comment
            /// </summary>
            const float mass = 3.246f;             // Taking constant value, constant value doesn't change
            float acceleration;
            Console.WriteLine("Mass: {0}", mass); // Writing in Console
            Console.WriteLine("Give Acceleration: ");
            acceleration = float.Parse(Console.ReadLine()); // Reading the input from user and parsing to float 
            Console.WriteLine("Force: {0}", mass * acceleration);
            Console.ReadLine();
           
        }
    }
}
