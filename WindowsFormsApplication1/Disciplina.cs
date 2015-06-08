using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Disciplina
    {
        public string disciplina;
        public string disciplinaAsString()
        {
            return disciplina;
        }

        public void disciplinaFromString(string data)
        {
            string[] info = data.Split('#');
            disciplina = info[0];
        }
    }
}
