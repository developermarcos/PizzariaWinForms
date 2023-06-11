using Microsoft.EntityFrameworkCore;
using PizzariaDoZe.Domain.FeatureIngrediente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzariaDoZe.Migration.Infra
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { 
        }
        public DbSet<Ingrediente> IngredienteDbSet { get; set; }
    }
}
