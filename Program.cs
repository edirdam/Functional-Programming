using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramming
{
    class Program
    { 
        static void Main(string[] args)
        {
            Action<string> sayGreeting;
            Func<string, string> conversate = (message) =>
            {
                Console.WriteLine(message);
                return Console.ReadLine();
            };

            string input = conversate("What's your name?");

            sayGreeting = (greeting) =>
            {
                Console.WriteLine(string.Format(greeting, input));
            };


            sayGreeting("Hello, {0}");
            conversate("Nice to see you!");
            conversate("Are you doing well?");
            sayGreeting("Bye, {0}");


        }
    }
}
