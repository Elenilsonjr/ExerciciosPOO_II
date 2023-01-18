using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models {
    internal class Estudante : Pessoa {

        public int RA { get; set; }


        public List<Materia> Materia { get; private set; }

        //construtor
    }
}
