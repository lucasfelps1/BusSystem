namespace BusSystemConsole.Models;
public class Terminal
{
    public Terminal(string nome, int vagas)
    {
        Nome = nome;
        Vagas = vagas;
    }

    public int Id { get; set; } 
    public string Nome { get; set; }
    public int Vagas { get; set; }
    public ICollection<Onibus> Onibus { get; set; }
}