using exerciciosWeek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Coruja : Ave, IVoar {


        public double VelocidadeDoVoo { get; set; }
        public int AltitudeMaximaEmMetros { get; set; }

        public Coruja(string nome, DateTime dataNascimento, char sexo, int idade, bool rapina, string corPena, double velocidadeDoVoo,
        int altitudeMaximaEmMetros) : base(nome, dataNascimento, sexo, idade, rapina, corPena) {
            VelocidadeDoVoo = velocidadeDoVoo;
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
        }


        public void Voar() {
            Console.WriteLine("Testando o método Voar");
        }
    }
}
