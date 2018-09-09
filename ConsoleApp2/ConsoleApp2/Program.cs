using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a word");
            String word = Console.ReadLine();
            char[] word1 = word.ToCharArray();
            Array.Reverse(word1);
            var temp = new String(word1);
            Console.WriteLine(temp);
            if (word.Equals(temp))
            {
                Console.WriteLine("This is a Palindrone Word");
                Console.ReadLine();

            }
            else
            {
                Console.WriteLine("This is not a Palindrone Word");
                Console.ReadLine();
            }

        }
    }
}
