using GitTest.GitTest;
using System;

namespace GitTest
{
    class Program
    {
        public string MyProperty { get; set; }



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

            ====== HEADER
            byte[] b3 = new byte[1];
     <<<<<<<<<< Text
            new Random().NextBytes(b3);
<<<<<<<<<<<< Text 2
            return b3[0];
    ======== END
        }

    }
}
