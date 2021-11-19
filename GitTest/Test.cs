using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.GitTest
{
    class Test
    {
        public List<ScenarioImporter> ScenarioImporters { get; set; }

        public Test()
        {
            ScenarioImporters = new List<ScenarioImporter>();
            ScenarioImporters.Add(new ScenarioImporter(1024));
        }

    }
}
