using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BusSystemConsole.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BusSystemConsole.EntityConfigs
{
    public class TerminalEntityConfigs : IEntityTypeConfiguration<Terminal>
    {
        public void Configure(EntityTypeBuilder<Terminal> builder)
        {
            
        }
    }
}