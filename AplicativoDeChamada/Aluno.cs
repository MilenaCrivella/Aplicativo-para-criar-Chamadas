using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicativoDeChamada
{
    class Aluno
    {
        public string disciplina;
        public string data;
        public string alunos;
        public string presenca;

        public string alunoAsString()
        {
            return disciplina + "#" + data + "#" + alunos + "#" + presenca;
        }

        public void alunoFromString(string data)
        {
            string[] info = data.Split('#');
            disciplina = info[0];
            data = info[1];
            alunos = info[2];
            presenca = info[3];
        }
    }
}
