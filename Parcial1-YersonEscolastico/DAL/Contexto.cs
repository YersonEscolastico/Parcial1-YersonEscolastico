using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_YersonEscolastico.Entidades;
using System.Data.Entity;


namespace Parcial1_YersonEscolastico.DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Productos> Productos { get; set; }

        public Contexto() : base("ConStr")
        { }
    }
}
