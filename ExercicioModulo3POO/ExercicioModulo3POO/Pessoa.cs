using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace ExercicioModulo3POO {
    public class Pessoa {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public Pessoa(string nome, int idade) {
            Nome = nome;
            Idade = idade;
        }

        public void Cumprimentar() {
            Console.WriteLine($"Olá, sou o(a) {Nome}");
            }

        public void DizerIdade() {
                Console.WriteLine($"tenho {Idade} anos");


            }
        }


    }
