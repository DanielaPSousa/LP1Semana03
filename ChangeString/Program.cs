using System;

namespace ChangeString
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert a string:")
            string s= Console.ReadLine();

            Console.Write("Insert a char:")
            char crt= Console.ReadKey().KeyChar;

            foreach(char str in s)
            {
                if (str == crt)
                {
                    Console.Write("X")
                }
                
                else
                {
                    Console.Write(str)
                }
            }

        }
    }
}
