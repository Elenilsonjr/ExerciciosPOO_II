using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioClasseAbstrata {
    public abstract class Smartphone {

        public string Numero { get; set; }

        public string Modelo { get; private set; }

        public string Imei { get; private set; }
        public int Memoria { get; private set; }


        public Smartphone(string numero, string modelo, string imei, int memoria) {

            Numero = numero;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        
        public void Ligar() {
            Console.WriteLine($"Ligando para o numero: {Numero} ");
        }

        public void RecebeLigacao() {
            Console.WriteLine($"Recebendo ligação do numero: {Numero}");
        }


        public virtual string InstalarAplicativo(string nome) {
            return nome;
        }


            
    }
}
