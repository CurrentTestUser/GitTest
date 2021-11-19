using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.GitTest
{
    class ScenarioImporter
    {
        public List<Speech> Speeches = new List<Speech>();

        public ScenarioImporter(int count)
        {
            Random random = new Random();

            for (int i = 0; i < count; i++)
            {
                byte[] buffer = new byte[16];
                random.NextBytes(buffer);

                Speeches.Add(new Speech(random.Next(), $"{buffer}", random.Next()));

            }
        }
    }
}
