using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Estudantes
    {
        public string estudante;
        public string posicaoX;
        public string posicaoY;

        public string estudantesAsString()
        {
            return estudante + "#" + posicaoX + "#" + posicaoY;
        }

        public void estudantesFromString(string data)
        {
            string[] info = data.Split('#');
            estudante = info[0];
            posicaoX = info[1];
            posicaoY = info[2];
        }
    }
}
