using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Ave : Animal {

        public bool Rapina { get; set; }
        public string CorPena { get; set; }

        public Ave(
            string nome,
            DateTime dataDeNascimento,
            char sexo,
            int idade,
            bool rapina,
            string corPena) : base(nome, dataDeNascimento, sexo, idade) {
            Rapina = rapina;
            CorPena = corPena;
        }

        public void Ciscar()
        {
            Console.WriteLine($"testando o método ciscar");
        }
    }
}
