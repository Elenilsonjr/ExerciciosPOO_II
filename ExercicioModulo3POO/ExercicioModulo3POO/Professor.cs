using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioModulo3POO {
    public class Professor: Pessoa {

        public Professor(string nome, int idade) : base(nome, idade) {
            Nome = nome;
            Idade = idade;
                
        }

        public void Explicar(string assunto) {
            Console.WriteLine($"Hoje vamos estudar sobre {assunto}");

        }
    }
}
