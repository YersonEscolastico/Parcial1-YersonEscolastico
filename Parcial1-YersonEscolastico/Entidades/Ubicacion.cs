using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_YersonEscolastico.Entidades
{
    public class Ubicacion
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }

    public Ubicacion()
        {
            Id = 0;
            Descripcion = string.Empty;
        }
    }
}