using System;
using System.Collections.Generic;
using System.Data.Common;
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


        public static void AdicionarOnibus(string placa, string motorista, int terminal)
        {   
            var context = new AppDbContext();

            var novoOnibus = new Onibus
            {   

                Placa = placa,
                Motorista = motorista,
                EntradaTerminal = DateTime.Now,
                TerminalId = terminal
            };
            
            context.Onibus.Add(novoOnibus);
            context.SaveChanges();
        }

        public static void RemoverOnibus(string placa)
        {
            var context = new AppDbContext();


            var onibus = context.Onibus.FirstOrDefault(X => X.Placa == placa);

             var entradaTerminal = onibus.EntradaTerminal;
            var saidaTerminal = DateTime.Now;
            var tempoDeEstadia = saidaTerminal - entradaTerminal;

            context.Remove(onibus);
            context.SaveChanges();

            string tempoFormatado = string.Format("{0}d {1:D2}h {2:D2}m",
            (int)tempoDeEstadia.TotalDays, tempoDeEstadia.Hours, tempoDeEstadia.Minutes);

            var terminal = context.Terminal.FirstOrDefault();

            Console.WriteLine($"O tempo de estadia do ônibus no terminal {terminal.Nome} foi de: {tempoFormatado}");
        }
    }
}
