using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusSystemConsole.Contex;

namespace BusSystemConsole.Models
{
    public class Onibus
    {

        public int Id { get; set; }
        public string Placa { get; set; } = string.Empty;
        public string Motorista { get; set; }

        public DateTime EntradaTerminal { get; set; }
        public DateTime? SaidaTerminal { get; set; }
        public int? TerminalId { get; set; }
        public Terminal Terminal { get; set; } = null!;


        public static void AdicionarOnibus(AppDbContext context, string placa, string motorista)
        {
            var novoOnibus = new Onibus
            {
                Placa = placa,
                Motorista = motorista,
                EntradaTerminal = DateTime.Now,
                TerminalId = 1
            };

            context.Onibus.Add(novoOnibus);
            context.SaveChanges();
        }
    }
}