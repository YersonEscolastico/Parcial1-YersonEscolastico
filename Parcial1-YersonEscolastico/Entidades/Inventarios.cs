using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_YersonEscolastico.Entidades
{
    public class Inventarios
    {
        [Key]
        public int Id { get; set; }
        public double Total { get; set; }

        public Inventarios()
        {
            Id = 0;
            Total = 0;
        }
    }
}

