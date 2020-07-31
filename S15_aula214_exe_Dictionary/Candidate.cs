using System;
using System.Collections.Generic;
using System.Text;

namespace S15_aula214_exe_Dictionary
{
    class Candidate
    {
        public string Name { get; set; }
        public int Votes { get; set; }

        public override string ToString() {
            return Name + ": " + Votes;
        }
    }
}
