using System;
using System.Collections.Generic;
using System.Text;

namespace GitTest.GitTest
{
    class Speech
    {
        private int _myWar;

        public int ID { get; set; }
        public string Line { get; set; }

        public int MyWar
        {
            get { return _myWar; }
            set { _myWar = value; }
        }

        public Speech(int iD, string line, int myWar)
        {
            ID = iD;
            Line = line;
            MyWar = myWar;
        }


    }
}
