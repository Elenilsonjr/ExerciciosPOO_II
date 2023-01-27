

namespace exerciciosWeek2 {
    public class Program {
        static void Main(string[] args) {
            Arara arara1 = new Arara("arara", new DateTime(2022,02,02), 'F', 1, false, "Azul", 25.5, 20);

            Console.WriteLine($"{arara1.Nome}, " +
                $"data de nascimento: {arara1.DataNascimento.ToString()}, " +
                $"sexo: {arara1.Sexo}, " +
                $"idade: {arara1.Idade.ToString()} ano, " +
                $"É ave de rapina?: {arara1.Rapina}, " +
                $"cor da pena: {arara1.CorPena}, " +
                $"Velocidade do vôo: {arara1.VelocidadeDoVoo} km/h, " +
                $"Altitude Máxima: {arara1.AltitudeMaximaEmMetros} metros");

            arara1.Carnivoro("semente");
            arara1.Peconhento("não");
            arara1.Alimentar();
            arara1.Voar();
            arara1.Comunicar();
            arara1.Movimentar();
            arara1.Ciscar();

        }
    }
}