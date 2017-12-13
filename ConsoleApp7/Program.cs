using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            //get user input
            ConsoleKeyInfo UserInput = Console.ReadKey();
            char Input = UserInput.KeyChar;

            //check if user input is letter. If so, proceed...
            if (Char.IsLetter(Input))
            {
                if ((int)Input > 90)
                {
                    int Conv = ((((int)Input - 97) + 1) % 26) + 97;
                    Console.WriteLine();
                    Console.WriteLine("{0}", (char)Conv);
                    Console.ReadKey();
                }
                else
                {
                    int Conv = ((((int)Input - 65) + 1) % 26) + 65;
                    Console.WriteLine();
                    Console.WriteLine("{0}", (char)Conv);
                    Console.ReadKey();
                }
            }
            //If not, show error message
            else
            {
                Console.WriteLine();
                Console.WriteLine("Error: Must enter letter!");
                Console.ReadKey();
            }

        }
    }
}
