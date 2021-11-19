using GitTest.GitTest;
using System;

namespace GitTest
{
    class Program
    {
        public static Test Test;

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Test = new Test();

            while (true)
            {
                if(Console.ReadLine() == "e")
                {
                    break;
                }

            }

        }
    }
}
