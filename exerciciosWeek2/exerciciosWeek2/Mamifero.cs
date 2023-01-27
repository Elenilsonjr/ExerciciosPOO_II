using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Mamifero : Animal {     
            public int QtdeDeMamas { get; set; }
            public bool Pelos { get; set; }
            public string CordDoPelo { get; set; }

            public Mamifero(
                string nome,
                DateTime dataNascimento,
                char sexo,
                int idade,
                int qtdeDeMamas,
                bool pelos,
                string corDoPelo) : base(nome, dataNascimento, sexo, idade) {
                QtdeDeMamas = qtdeDeMamas;
                Pelos = pelos;
                CordDoPelo = corDoPelo;
            }

            public void Amamentar() {
            Console.WriteLine("Testando o metodo amamentar");
        }
        }
}
