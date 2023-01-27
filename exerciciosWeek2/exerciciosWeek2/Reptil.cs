using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Reptil : Animal {

        public bool TemEscamas { get; set; }
        public bool TemCasco { get; set; }


        public Reptil(
            string nome,
            DateTime dataDeNascimento,
            char sexo,
            int idade,
            bool temEscamas,
            bool temCasco) : base(nome, dataDeNascimento, sexo, idade) {
            TemEscamas = temEscamas;
            TemCasco = temCasco;
        }
    }
}
