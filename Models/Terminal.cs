using BusSystemConsole.Contex;

namespace BusSystemConsole.Models;
public class Terminal
{

    public int Id { get; set; } 
    public string Nome { get; set; }
    public int Vagas { get; set; }
    public ICollection<Onibus> Onibus { get; set; } = new List<Onibus>();

    public static void AdicionarTerminal(AppDbContext context, string nome, int vagas)
    {
        var novoTerminal = new Terminal
        {
            Nome = nome,
            Vagas = vagas,
            Onibus = new List<Onibus>()
        };

        context.Terminal.Add(novoTerminal);
        context.SaveChanges();
    }
}