namespace ExercicioModulo3POO {
    internal class Program {
        static void Main(string[] args) {

            Pessoa P1 = new Pessoa("Junior", 30);
            P1.Cumprimentar();
            P1.DizerIdade();
            
            Aluno A1 = new Aluno("Joao", 21);
            A1.Cumprimentar();
            A1.DizerIdade();
            A1.IrParaEscola("Sou estudante");

            Professor Professor1 = new Professor("Mario", 30);
            Professor1.Cumprimentar();
            Professor1.DizerIdade();
            Professor1.Explicar("Seres vivos");

        }
    }
}