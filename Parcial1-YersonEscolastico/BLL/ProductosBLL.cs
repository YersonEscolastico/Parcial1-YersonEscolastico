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
    class ProductosBLL
    {

        public static bool Guardar(Productos productos)
        {
            bool paso = false;
            Contexto contexto = new Contexto();
            try
            {
                if (contexto.Productos.Add(productos) != null)
                    paso = contexto.SaveChanges() > 0;
                Inventario inventario = InventarioBLL.Buscar(1);
                inventario.Total += productos.ValorInventario;
                InventarioBLL.Modificar(inventario);
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

        public static bool Modificar(Productos producto)
        {
            bool paso = false;

            Contexto contexto = new Contexto();
            Productos pro = ProductosBLL.Buscar(producto.ProductoId);
            try
            {
                double resultado = producto.ValorInventario - pro.ValorInventario;

                Inventario inventario = InventarioBLL.Buscar(1);
                inventario.Total += resultado;
                InventarioBLL.Modificar(inventario);

                contexto.Entry(producto).State = EntityState.Modified;
                if (contexto.SaveChanges() > 0)
                {
                    paso = true;
                }
                contexto.Dispose();
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }


        public static bool Eliminar(int id)
        {
            bool paso = false;
            Contexto db = new Contexto();

            try
            {
                var eliminar = db.Productos.Find(id);

                var Inventario = InventarioBLL.Buscar(1);
                Inventario.Total -= eliminar.ValorInventario;
                InventarioBLL.Modificar(Inventario);
                //db.Persona.Remove(eliminar);
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



        public static Productos Buscar(int id)
        {
            Contexto contexto = new Contexto();
            Productos productos = new Productos();
            try
            {
                productos = contexto.Productos.Find(id);
            }
            catch
            {
                throw;

            }
            finally
            {
                contexto.Dispose();
            }
            return productos;
        }


        public static List<Productos> GetList(Expression<Func<Productos, bool>> productos)
        {
            Contexto contexto = new Contexto();
            List<Productos> lista = new List<Productos>();
            try
            {
                lista = contexto.Productos.Where(productos).ToList();

            }
            catch
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
