using GitTest.GitTest;
using System;

namespace GitTest
{
    class Program
    {
        public static Test Test;

        static void Main(string[] args)
        {
            Test = new Test();

            while (true)
            {
                if(Console.ReadLine() == "e")
                {
                    break;
                }

                if(Console.ReadLine() == "print")
                {
                    Test.ScenarioImporters[0].Speeches.ForEach(item => { Console.WriteLine($"{item.ID}\t{item.Line}\t{item.MyWar}\t"); });
                }

            }

        }
    }
}
