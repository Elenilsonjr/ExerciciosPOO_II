using exerciciosWeek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace exerciciosWeek2 {
    internal class Arara : Ave, IVoar, IOviparo {


        public double VelocidadeDoVoo { get; set; }
        //{
            //get { return 40; }
            //set { VelocidadeDoVoo=value;} 
        //}
        public int AltitudeMaximaEmMetros { get; set; } 
        //{
            //get { return 74; }
            //set{ AltitudeMaximaEmMetros = value; } 
        //}
        public Arara(string nome, DateTime dataNascimento, char sexo, int idade, bool rapina, string corPena, double velocidadeDoVoo,
        int altitudeMaximaEmMetros) : base(nome, dataNascimento, sexo, idade, rapina, corPena) {
            VelocidadeDoVoo = velocidadeDoVoo;
            AltitudeMaximaEmMetros = altitudeMaximaEmMetros;


        }

        public void Voar() {
            Console.WriteLine($"A {Nome} voa a uma altitude de {AltitudeMaximaEmMetros} pés e a uma velocidade de {VelocidadeDoVoo} km/h!");

        }
        public void Botar() {
            Console.WriteLine($"A {Nome} bota até 5 ovos.");
        }
        public void Chocar() {
            Console.WriteLine($"A {Nome} choca os ovos por mais de 15 dias.");

        }
    }
}
