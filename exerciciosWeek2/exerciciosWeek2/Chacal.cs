using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Chacal : Animal {

        public Chacal(string nome, DateTime dataNascimento, char sexo, int idade, bool carnivoro, bool peconhento) : base(nome, dataNascimento, sexo, idade) {
        }
    }
}
