using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Models {
    internal class Pessoa {
        public int ID { get; private set; }

        public string Nome { get; set; }

        public string Telefone { get; set; }

        public string Email { get; private set; }

        public string Login { get; set; }

        protected string Senha { get; private set; }

        public Endereco Endereco { get; set; }

        //construtor

    }
}
