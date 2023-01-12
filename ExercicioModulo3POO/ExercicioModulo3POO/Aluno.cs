using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioModulo3POO {
    internal class Aluno: Pessoa {

        public Aluno(string nome, int idade): base(nome, idade) {

            Nome = nome;
            Idade = idade;

        }

        public void IrParaEscola(string texto) {
            Console.WriteLine(texto);
        }
    }
}
