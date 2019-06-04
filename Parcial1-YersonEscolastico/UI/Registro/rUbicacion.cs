using Parcial1_YersonEscolastico.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Parcial1_YersonEscolastico.BLL;
using System.Text.RegularExpressions;
using Parcial1_YersonEscolastico.DAL;

namespace Parcial1_YersonEscolastico.UI.Registro
{
    public partial class rUbicacion : Form
    {
        public rUbicacion()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {
            IdnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private Ubicaciones LlenaClase()
        {
            Ubicaciones ubicacion = new Ubicaciones();

            ubicacion.Id = Convert.ToInt32(IdnumericUpDown.Value);
            ubicacion.Descripcion = DescripciontextBox.Text;

            return ubicacion;
        }


        private void LlenaCampo(Ubicaciones ubicacion)
        {
            IdnumericUpDown.Value = ubicacion.Id;
            DescripciontextBox.Text = ubicacion.Descripcion;
        }


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (String.IsNullOrWhiteSpace(DescripciontextBox.Text.Trim()))
            {
                MyErrorProvider.SetError(DescripciontextBox, "Este campo no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (RepetidosNo(DescripciontextBox.Text))
            {
                MessageBox.Show("Ya existe un producto con ese nombre");
                DescripciontextBox.Focus();
                paso = false;
            }
            return paso;
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Ubicaciones ubicacion;
            bool paso = false;

            if (!Validar())
                return;

            ubicacion = LlenaClase();


            if (IdnumericUpDown.Value == 0)
            {
                paso = UbicacionesBLL.Guardar(ubicacion);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una ubicacion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = UbicacionesBLL.Modificar(ubicacion);

            }

            if (paso)
                MessageBox.Show("Guardado!!", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                MessageBox.Show("No fue posible guardar!!", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            Limpiar();
        }



        public static bool RepetidosNo(string descripcion)
        {
            bool paso = false;
            Contexto db = new Contexto();
            try
            {
                if (db.ubicacion.Any(p => p.Descripcion.Equals(descripcion)))
                {
                    paso = true;
                }
            }
            catch (Exception)
            {
                throw;
            }
            return paso;
        }




        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Ubicaciones ubicacion = new Ubicaciones();
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            ubicacion= UbicacionesBLL.Buscar(id);

            if (ubicacion != null)
            {
                MessageBox.Show("Producto Encontrado");
                LlenaCampo(ubicacion);
            }
            else
            {
            }
        }


        private bool ExisteEnLaBaseDeDatos()
        {
           Ubicaciones ubicacion = UbicacionesBLL.Buscar((int)IdnumericUpDown.Value);

            return (ubicacion != null);
        }



        private bool VEliminar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (IdnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IdnumericUpDown, "Debe introducir un id para poder eliminar un producto");
                IdnumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }




        private void Eliminarbutton_Click_1(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            VEliminar();
            int id;
            int.TryParse(IdnumericUpDown.Text, out id);

            if (!ExisteEnLaBaseDeDatos())
                return;
            if (ProductosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }

            else
                MyErrorProvider.SetError(IdnumericUpDown, "No se puede eliminar un producto que no existe");
        }
    }
}
