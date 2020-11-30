using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AAPC.Models;

namespace AAPC.Data
{
    public class MvcAAPCContext : DbContext
    {
        public MvcAAPCContext(DbContextOptions<MvcAAPCContext> options)
            : base(options)
        {
        }

        public DbSet<Participante> Participante { get; set; }

        public DbSet<Treino> Treino { get; set; }
    }
}