using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C___Methods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayHi();
            // methods with  parameters
            sayHiUser("Merenda");
            sayHiAge("John", 55);
            Console.ReadLine();



        }
        //creating a method .ignoring static for now, use capital as per conventions.
        static void SayHi()
        {
            Console.WriteLine("HI");
            //METHOD WITH MORE THAN ONE PARAMETER

            static void SayHiUser(string name)
            {
                Console.WriteLine("Hello" + name);

            }
        }
        //method with many parameters
        static void SatHiAge(string name, int age)
        {
            Console.WriteLine("hello" + name + "you are " + age);
        }
    }
}
