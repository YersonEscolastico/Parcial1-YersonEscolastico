using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parcial1_YersonEscolastico.Entidades;
using Parcial1_YersonEscolastico.DAL;
using System.Linq.Expressions;
using System.Data.Entity;
namespace Parcial1_YersonEscolastico.BLL
{
    public class UbicacionesBLL
    {
        public static bool Guardar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.ubicacion.Add(ubicacion) != null)
                {
                    paso = contexto.SaveChanges() > 0;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }



        public static bool Modificar(Ubicaciones ubicacion)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                contexto.Entry(ubicacion).State = EntityState.Modified;
                paso = contexto.SaveChanges() > 0;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return paso;
        }



        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                var eliminar = db.ubicacion.Find(id);
                db.Entry(eliminar).State = EntityState.Deleted;
                paso = (db.SaveChanges() > 0);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                db.Dispose();
            }
            return paso;
        }
   


        public static Ubicaciones Buscar(int id)
        {
            Ubicaciones ubicaciones = new Ubicaciones();
            Contexto contexto = new Contexto();
            try
            {
                ubicaciones = contexto.ubicacion.Find(id);

            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return ubicaciones;
        }



        public static List<Ubicaciones> getList(Expression<Func<Ubicaciones, bool>> ubicaciones)
        {
            List<Ubicaciones> lista = new List<Ubicaciones>();
            Contexto contexto = new Contexto();
            try
            {
                lista = contexto.ubicacion.Where(ubicaciones).ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }
    }
}