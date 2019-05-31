using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_YersonEscolastico.Entidades
{
    public class Productos
    {

        public int ProductoId { get; set; }
        public string Descripcion { get; set; }
        public float Existencia { get; set; }
        public float Costo { get; set; }
        public float ValorInventario { get; set; }

        public Productos()
        {
            ProductoId = 0;
            Descripcion = string.Empty;
            Existencia = 0.0f;
            Costo = 0.0f;
            ValorInventario = 0.0f;
        }
    }
}
