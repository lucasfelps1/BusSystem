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

    public static void RemoverTerminal(int id)
    {
        var context = new AppDbContext();

        var terminal = context.Terminal.FirstOrDefault(x => x.Id == id); 

        context.Terminal.Remove(terminal);
        context.SaveChanges();
    }

    public static void VerificarTerminais(int terminalID)
    {
        var context = new AppDbContext();

        var terminalAchado = context.Terminal.FirstOrDefault(X => X.Id == terminalID);

        var onibusNoTerminal = context.Onibus.Where(X => X.TerminalId == terminalAchado.Id).ToList();

        var terminalInfo = new Terminal
        {
            Nome = terminalAchado.Nome,
            Onibus = onibusNoTerminal
        };
        
        string listaDeOnibus = string.Join(", ", onibusNoTerminal.Select(x => x.Placa));

        Console.WriteLine($"Nome: {terminalAchado.Nome} - Ônibus: {listaDeOnibus}");
        
    }

}
