using BusSystemConsole.Contex;
using BusSystemConsole.Models;
using Microsoft.VisualBasic;

internal class Program
{   
    private static void Main(string[] args)
    {
        int resposta;

        do
        {
            Console.WriteLine("O que você deseja fazer? : ");
            Console.WriteLine("============================================");
            Console.WriteLine("1 - Adicionar onibus");
            Console.WriteLine("2 - Remover onibus e saber tempo de estadia");
            Console.WriteLine("3 - Adiconar terminal");
            Console.WriteLine("4 - Remover terminal");
            Console.WriteLine("5 - Verificar terminais e seus onibus");
            Console.WriteLine("0 - Sair");

            resposta = int.Parse(Console.ReadLine());
            
            switch (resposta)
            {
                case 1:
                    Console.WriteLine("Digite a Placa, Exemplo: XXXXXX");
                    var placa = Console.ReadLine();

                    Console.WriteLine("Digite o nome do Motorista:");
                    var motorista = Console.ReadLine();

                    Console.WriteLine("Digite o id do terminal:");
                    var terminal = int.Parse(Console.ReadLine());

                    Onibus.AdicionarOnibus(placa, motorista, terminal);
                    break;

                case 2:
                    Console.WriteLine("Digite a placa do onibus que deseja excluir: ");
                    placa = Console.ReadLine();
                    Onibus.RemoverOnibus(placa);
                    break;    

                case 3:
                    Console.WriteLine("Digite o nome do terminal: ");
                    var nome = Console.ReadLine();
                    Console.WriteLine("Digite a quantidade de vagas do terminal");
                    var vagas = int.Parse(Console.ReadLine());

                    Terminal.AdicionarTerminal(nome, vagas);
                    break;    

                case 4:
                    Console.WriteLine("Digite o ID do terminal:");
                    var id = int.Parse(Console.ReadLine());

                    Terminal.RemoverTerminal(id);
                    break;  

                case 5:
                    Console.WriteLine("Digite o id do terminal que você deseja ver");
                    terminal = int.Parse(Console.ReadLine());

                    Terminal.VerificarTerminais(terminal);
                    break;  

            }

        } while (resposta != 0);
    }
}