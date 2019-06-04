using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_YersonEscolastico.Entidades
{
    public class Ubicaciones
    {
        [Key]
        public int Id { get; set; }
        public string Descripcion { get; set; }

    public Ubicaciones()
    {
        Id = 0;
        Descripcion = string.Empty;
        }
    }
}