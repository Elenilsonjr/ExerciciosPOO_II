namespace ExercicioClasseAbstrata {
    internal class Program {
        static void Main(string[] args) {

            Iphone Cel1 = new Iphone("83046327", "Iphone 12", "123456789", 32);
            Cel1.Ligar();
            Cel1.RecebeLigacao();
            Cel1.InstalarAplicativo("Instagram");
            Console.WriteLine();

            Motorola Cel2 = new Motorola("36051464", "Moto G2", "987654321", 64);
            Cel2.Ligar();
            Cel2.RecebeLigacao();
            Cel2.InstalarAplicativo("Facebook");
        }
    }
}