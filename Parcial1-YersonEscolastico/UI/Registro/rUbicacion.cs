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

        private Ubicacion LlenaClase()
        {
            Ubicacion ubicacion = new Ubicacion();

            ubicacion.Id = Convert.ToInt32(IdnumericUpDown.Value);
            ubicacion.Descripcion = DescripciontextBox.Text;

            return ubicacion;
        }

        private void LlenaCampo(Ubicacion ubicacion)
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
            return paso;
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


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Ubicacion ubicacion;
            bool paso = false;

            if (!Validar())
                return;

            ubicacion = LlenaClase();

            if (IdnumericUpDown.Value == 0)
            {
                paso =UbicacionBLL .Guardar(ubicacion);
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(IdnumericUpDown.Value);
                ubicacion= UbicacionBLL.Buscar(id);

                if (ubicacion != null)
                {
                    paso = UbicacionBLL.Modificar(LlenaClase());
                    MessageBox.Show("Modificado!!", "Exito",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("Id no existe", "Falló",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (paso)
            {
                Limpiar();
            }
            else
                MessageBox.Show("No se pudo guardar!!", "Falló",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


        private void BuscarButton_Click(object sender, EventArgs e)
        {
            int id;
            Ubicacion ubicacion = new Ubicacion();
            int.TryParse(IdnumericUpDown.Text, out id);

            Limpiar();

            ubicacion= UbicacionBLL.Buscar(id);

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
           Ubicacion ubicacion = UbicacionBLL.Buscar((int)IdnumericUpDown.Value);

            return (ubicacion != null);
        }


        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
           
                MyErrorProvider.Clear();
                VEliminar();
                int id;
                int.TryParse(IdnumericUpDown.Text, out id);
                Limpiar();
                if (UbicacionBLL.Eliminar(id))
                {
                    MessageBox.Show("Eliminado");
                }
                else
                {
                    MyErrorProvider.SetError(IdnumericUpDown, "No se puede elimina, porque no existe");
                }

            }
    }
}
