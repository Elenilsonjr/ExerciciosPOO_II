using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAbstrata {
    public class Iphone : Smartphone {

        public Iphone(string numero, string modelo, string imei, int memoria)
            : base(numero, modelo, imei, memoria){

        }

        public override string InstalarAplicativo(string nome) {
            Console.WriteLine("Instalando aplicativo no Iphone...");
            Console.WriteLine($"O aplicativo {nome} foi instalado com sucesso!");
            return nome;
        }
    }
}
