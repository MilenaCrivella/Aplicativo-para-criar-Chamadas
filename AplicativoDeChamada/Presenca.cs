using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoDeChamada
{
    class Presenca
    {
        public string estudante;
        public string disciplina;
        public string data;

        public string estudantesAsString()
        {
            return estudante + "#" + disciplina + "#" + data;
        }

        public void estudantesFromString(string data)
        {
            string[] info = data.Split('#');
            estudante = info[0];
            disciplina = info[1];
            data = info[2];
        }
    }
}
