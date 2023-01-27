using exerciciosWeek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Morcego : Animal, IVoar {

        public int AltitudeMaximaEmMetros { get; set; }
        public double VelocidadeDoVoo { get; set; }

        public Morcego(string nome, DateTime dataNascimento, char sexo, int idade, double velocidadeDoVoo,
        int altitudeMaximaEmMetros) : base(nome, dataNascimento, sexo, idade) {
            VelocidadeDoVoo = velocidadeDoVoo;
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
        }

        public void Voar() {
            Console.WriteLine("Testando o metodo Voar");

        }
    }
}
