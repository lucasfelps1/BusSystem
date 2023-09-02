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


        public static void AdicionarOnibus(AppDbContext context, string placa, string motorista)
        {
            var novoOnibus = new Onibus
            {
                Placa = placa,
                Motorista = motorista,
                EntradaTerminal = DateTime.Now,
                SaidaTerminal = null,
                TerminalId = 1
            };

            context.Onibus.Add(novoOnibus);
            context.SaveChanges();
        }

        public static void RemoverOnibus(string placa)
        {
            var context = new AppDbContext();


            var onibus = context.Onibus.FirstOrDefault(X => X.Placa == placa);

            var entradaTerminal = onibus.EntradaTerminal;
            var saidaTerminal = DateTime.Now - entradaTerminal;

            context.Remove(onibus);
            context.SaveChanges();

            string dataFormatada = string.Format($"{0:D2}h {1:D2}m", saidaTerminal.Hours, saidaTerminal.Minutes);

            Console.WriteLine($"O tempo de estádia do onibus no terminal foi de: {dataFormatada}");
        }
    }
}