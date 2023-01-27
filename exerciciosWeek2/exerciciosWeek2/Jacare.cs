using exerciciosWeek2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exerciciosWeek2 {
    internal class Jacare : Reptil, IAquatico {

        public Jacare(string nome, DateTime dataNascimento, char sexo, int idade, bool temEscamas, bool temCasco) : base(nome, dataNascimento, sexo, idade, temEscamas, temCasco) {
        }

        public bool ViveEmTerra { get; set; }
        public bool Mergulho { get; set; }
        public bool AguaDoce { get; set; }
    }
}
