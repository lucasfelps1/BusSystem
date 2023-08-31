using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BusSystemConsole.Models
{
    public class Onibus
    {
        public Onibus(string placa, string motorista)
        {
            Placa = placa;
            Motorista = motorista;
        }

        public int Id { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Motorista { get; set; }

        public DateTime EntradaTerminal { get; set; }
        public DateTime? SaidaTerminal { get; set; }
        public int? TerminalId { get; set; }
        public Terminal Terminal { get; set; } = null!;

    }
}