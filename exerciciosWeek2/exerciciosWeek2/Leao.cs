using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Leao : Animal {

        public Leao(
            string nome,
            DateTime dataNascimento,
            char sexo,
            int idade) : base(nome, dataNascimento, sexo, idade) {

        }
    }
}
