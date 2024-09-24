
namespace testeKogui
{
    internal class Program
    {   
        static async Task Main(string[] args)
        {

            //Resolução do Topico 1 
            Console.WriteLine("Resolução 1:");
            Topico1 resolucao1 = new Topico1();
            resolucao1.InstaciarListaChaveCor();
            resolucao1.MostrarListaChaveCor();

            //Separador de linha
            Console.WriteLine("--------------------------------------------------------");

            //Resolução do Topico 2
            Console.WriteLine("Resolução 2:");
            Topico2 resolucao2 = new Topico2();
            await resolucao2.MostrarFrase();

            //Separador de linha
            Console.WriteLine("--------------------------------------------------------");

            //Relolução do Topico 3
            Console.WriteLine("Resolução 3:");
            Topico3 resolucao3 = new Topico3();
            resolucao3.MostrarMatriz();
        }
    }
}