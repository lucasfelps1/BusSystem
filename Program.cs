using BusSystemConsole.Contex;
using BusSystemConsole.Models;
using Microsoft.VisualBasic;

internal class Program
{   
    private static void Main(string[] args)
    {
        Console.WriteLine("O que você deseja fazer? : ");
        Console.WriteLine("============================================");
        Console.WriteLine("1 - Adicionar onibus");
        Console.WriteLine("2 - Remover onibus e saber tempo de estadia");
        Console.WriteLine("3 - Adiconar terminal");
        Console.WriteLine("4 - Remover terminal");
        Console.WriteLine("0 - Sair");

        var resposta = int.Parse(Console.ReadLine());


        if (resposta == 3)
        {   
            var context = new AppDbContext();

            Console.WriteLine("Digite o nome do terminal: ");
            var nome = Console.ReadLine();
            Console.WriteLine("Digite a quantidade de vagas do terminal");
            var vagas = int.Parse(Console.ReadLine());

            Terminal.AdicionarTerminal(context, nome, vagas);
        }


        // if (resposta == 1)
        // {
        //     var context = new AppDbContext();

        //     Console.WriteLine("Digite a Placa, Exemplo: XXX-XXXX");
        //     var placa = Console.ReadLine();

        //     Console.WriteLine("Digite o nome do Motorista,");
        //     var motorista = Console.ReadLine();

        //     Onibus.AdicionarOnibus(context, placa, motorista);
        // }

    }
}