using Parcial1_YersonEscolastico.DAL;
using Parcial1_YersonEscolastico.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_YersonEscolastico.BLL
{
    public class InventariosBLL
    {

        public static bool Guardar(Inventarios inventario)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Inventario.Add(inventario) != null)
                {
                   paso = contexto.SaveChanges() >0;
                   
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



        public static bool Modificar(Inventarios inventario)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(inventario).State = EntityState.Modified;
                paso = (contexto.SaveChanges() > 0);
               
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



        public static Inventarios Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Inventarios inventario = new Inventarios();
            try
            {
                inventario = contexto.Inventario.Find(id);
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return inventario;
        }
    }
}
