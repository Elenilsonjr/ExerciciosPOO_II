using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2
{
    public abstract class Animal
    {

        public string Nome { get; set; }
        public DateTime DataNascimento { get; set; }
        public char Sexo { get; set; }
        public int Idade { get; set; }

        public Animal(string nome, DateTime dataNascimento, char sexo, int idade)
        {
            Nome = nome;
            DataNascimento = dataNascimento;
            Sexo = sexo;
            Idade = idade;
            
        }


        public void Movimentar()
        {
            Console.WriteLine("Teste movimentar");
        }

        public void Comunicar()
        {
            Console.WriteLine("teste comunicar");
        }

        public void Alimentar()
        {
            Console.WriteLine("Testando o método Alimentar");
        }
        public bool Carnivoro(string tipoComida)
        {
            if(tipoComida == "Carne")
            {
                return true;
            }
            return false;
        }

        public bool Peconhento(string veneno)
        {
            if (veneno == "Sim")
            {
                return true;
            }
            return false;
        }



    }
}
