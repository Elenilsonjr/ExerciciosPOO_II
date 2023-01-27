using exerciciosWeek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Lontra : Mamifero, IAquatico {

        public Lontra(string nome, DateTime dataNascimento, char sexo, int idade, int qtdeDeMamas, bool pelos, string corDoPelo) : base(nome, dataNascimento, sexo, idade, qtdeDeMamas, pelos, corDoPelo) {
        }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
