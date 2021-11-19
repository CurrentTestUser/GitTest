using GitTest.GitTest;
using System;

namespace GitTest
{
    class Program
    {
        public static Test Test;
        public static byte LastByte;

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

        private static byte GetRandomByte()
        {
            byte[] b = new byte[1];
            new Random().NextBytes(b);
            return b[0];
        }

    }
}
