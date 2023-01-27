using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Elefante : Mamifero {

        public Elefante(string nome, DateTime dataNascimento, char sexo, int idade, int qtdeDeMamas, bool pelos, string corDoPelo) : base(nome, dataNascimento, sexo, idade, qtdeDeMamas, pelos, corDoPelo) {
        }
    }
}
