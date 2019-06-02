using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_YersonEscolastico.Entidades
{
    public class Inventario
    {
        [Key]
        public int Id { get; set; }
        public double Total { get; set; }

        public Inventario()
        {
            Id = 0;
            Total = 0;
        }
    }
}
