using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharp
{
    class SelectionConcept
    {
        static void Main(string[] args)
        {
            float gpa = float.Parse(Console.ReadLine());
            if (gpa >= 3.0)
            {
                Console.WriteLine("You made Dean's List !!");
            }
            else
            {
                Console.WriteLine("Not on Dean's List this time. Keep trying.");
            }
            Console.WriteLine("Enter a letter: ");
            char musicType = char.Parse(Console.ReadLine());
            switch (musicType)
            {
                case 'R':
                    Console.WriteLine("Rock and Roll rules");
                    break;
                case 'B':
                    Console.WriteLine("Blues rules");
                    break;
                case 'J':
                    Console.WriteLine("Jazz rules");
                    break;
                case 'C':
                    Console.WriteLine("Classical rules");
                    break;
                default:
                    Console.WriteLine("You must not like music");
                    break;
            }

            Console.ReadLine();
        }
    }
}
