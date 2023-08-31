using BusSystemConsole.Models;
using Microsoft.VisualBasic;

internal class Program
{
    private static void Main(string[] args)
    {
        var onibus1 = new Onibus("ABC-1234", "Lucas");
        var onibus2 = new Onibus("CBA-123", "Laura");

        var terminal1 = new Terminal("Terminal Ipiranga", 1);
    }
}