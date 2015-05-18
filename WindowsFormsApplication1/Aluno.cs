using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Aluno
    {
        public string disciplina;
        public string data;
        public string alunos;

        public string funcionarioAsString()
        {
            return disciplina + "#" + data + "#" + alunos;
        }

        public void funcionarioFromString(string data)
        {
            string[] info = data.Split('#');
            disciplina = info[0];
            data = info[1];
            alunos = info[2];
        }
    }
}
