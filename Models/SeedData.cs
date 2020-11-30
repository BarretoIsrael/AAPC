using AAPC.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AAPC.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcAAPCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcAAPCContext>>()))
            {
                // Look for any movies.
                if (context.Participante.Any())
                {
                    return;   // DB has been seeded
                }

                context.Participante.AddRange(
                    new Participante
                    {
                        Nome = "Participante1",
                        Sobrenome = "Sobrenome1",
                        Nascimento = DateTime.Parse("1989-2-12"),
                        DiaDoTreino = "Terca-Feira"
                        //Genre = "Romantic Comedy",
                        //Price = 7.99M
                    },

                    new Participante
                    {
                        Nome = "Participante2",
                        Sobrenome = "Sobrenome2",
                        Nascimento = DateTime.Parse("1989-2-12"),
                        DiaDoTreino = "Quinta-Feira"
                        //Genre = "Romantic Comedy",
                        //Price = 7.99M
                    },

                    new Participante
                    {
                        Nome = "Participante3",
                        Sobrenome = "Sobrenome3",
                        Nascimento = DateTime.Parse("1989-2-12"),
                        DiaDoTreino = "Sabado"
                        //Genre = "Romantic Comedy",
                        //Price = 7.99M
                    },

                    new Participante
                    {
                        Nome = "Participante4",
                        Sobrenome = "Sobrenome4",
                        Nascimento = DateTime.Parse("1989-2-12"),
                        DiaDoTreino = "Terca-Feira"
                        //Genre = "Romantic Comedy",
                        //Price = 7.99M
                    }
                );
                context.SaveChanges();
            }

            using (var context = new MvcAAPCContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcAAPCContext>>()))
            {
                // Look for any movies.
                if (context.Treino.Any())
                {
                    return;   // DB has been seeded
                }

                context.Treino.AddRange(
                    new Treino
                    {
                        Dia = "Terça-Feira",
                        Horario = "20h",
                        Local = "Imbui"
                        //Genre = "Romantic Comedy",
                        //Price = 7.99M
                    },

                    new Treino
                    {
                        Dia = "Quinta-Feira",
                        Horario = "20h",
                        Local = "Imbui"
                        //Genre = "Romantic Comedy",
                        //Price = 7.99M
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
