using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductiontoCSharp
{
    class StringExample
    {
        public static void Main(string[] args)
        {
            Name myname = new Name("John Q. Public");
            myname.Print();
            Name myname1 = new Name("Oscar Z. Plagudorski");
            myname1.Print();
            Console.ReadLine();

        }
    }
    class Name
    {
        string firstName;
        char middleName;
        string lastName;
        string name;
        public string FirstName { get { return firstName; } }
        public char MiddleName { get { return middleName; } }
        public string LastName { get { return lastName; } }
        public Name(string name)
        {
            this.name = name;
            int firstSpace = name.IndexOf(' ');
            firstName = name.Substring(0, firstSpace);
            middleName = name[firstSpace + 1];
            lastName = name.Substring(name.LastIndexOf(' ')+1);
        }
        public void Print()
        {
            Console.WriteLine("{0}, {1} {2}", lastName, firstName, middleName);
            
        }
        
    }
}
