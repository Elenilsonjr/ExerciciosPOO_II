using exerciciosWeek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Cisne : Ave, IVoar, IAquatico {

        

        public double VelocidadeDoVoo { get; set; }
        public int AltitudeMaximaEmMetros { get; set; }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
        public Cisne(string nome, DateTime dataNascimento, char sexo, int idade, bool rapina, string corPena, double velocidadeDoVoo,
        int altitudeMaximaEmMetros) : base(nome, dataNascimento, sexo, idade, rapina, corPena)
        {
            VelocidadeDoVoo = velocidadeDoVoo;
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;
        }

        public void Voar() {
            Console.WriteLine("Testando o metodo Voar");

        }
    }
}
