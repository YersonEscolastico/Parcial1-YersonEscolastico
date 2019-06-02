
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

namespace Parcial1_YersonEscolastico.UI.Registro
{
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
        }


        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            ExistenciatextBox.Text = string.Empty;
            CostotextBox.Text = string.Empty;
            ValorInventariotextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }


        private Productos LlenaClase()
        {
            Productos producto = new Productos();

            producto.ProductoId = Convert.ToInt32(IDnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Costo = Convert.ToSingle(CostotextBox.Text);
            producto.Existencia = Convert.ToSingle(ExistenciatextBox.Text);
            producto.ValorInventario = Convert.ToSingle(ValorInventariotextBox.Text);

            return producto;
        }


        private void LlenaCampo(Productos productos)
        {
            IDnumericUpDown.Value = productos.ProductoId;
            DescripciontextBox.Text = productos.Descripcion;
            ExistenciatextBox.Text = productos.Existencia.ToString();
            CostotextBox.Text = productos.Costo.ToString();
            ValorInventariotextBox.Text = productos.ValorInventario.ToString();
        }


        private bool Validar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (DescripciontextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(DescripciontextBox, "Este campo no puede estar vacio");
                DescripciontextBox.Focus();
                paso = false;
            }
            if (ExistenciatextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ExistenciatextBox, "Este campo no puede estar vacio");
                ExistenciatextBox.Focus();
                paso = false;
            }
            if (CostotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(CostotextBox, "Este campo no puede estar vacio");
                CostotextBox.Focus();
                paso = false;
            }

            if (ValorInventariotextBox.Text == string.Empty)
            {
                MyErrorProvider.SetError(ValorInventariotextBox, "Este campo no puede estar vacio");
                ValorInventariotextBox.Focus();
                paso = false;
            }

            return paso;
        }


            private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private bool ExisteEnLaBaseDeDatos()
        {
            Productos productos = ProductosBLL.Buscar((int)IDnumericUpDown.Value);

            return (productos != null);
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Productos producto;
            bool paso = false;

            if (!Validar())
                MessageBox.Show("Debe llenar los campos indicados", "Validación",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            producto = LlenaClase();

            if (IDnumericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(producto);
                MessageBox.Show("Guardado!!", "Exito",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                int id = Convert.ToInt32(IDnumericUpDown.Value);
                producto = ProductosBLL.Buscar(id);

                if (producto != null)
                {
                    paso = ProductosBLL.Modificar(LlenaClase());
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



        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            int id;
            int.TryParse(IDnumericUpDown.Text, out id);


            if (!ExisteEnLaBaseDeDatos())
                return;
            if (ProductosBLL.Eliminar(id))
            {
                MessageBox.Show("Eliminado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpiar();
            }

            else
                MyErrorProvider.SetError(IDnumericUpDown, "No se puede eliminar una persona que no existe");
        }



        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            int id;
            Productos productos = new Productos();
            int.TryParse(IDnumericUpDown.Text, out id);

            Limpiar();

            productos = ProductosBLL.Buscar(id);

            if (productos != null)
            {
                MessageBox.Show("Usuario Encontrado");
                LlenaCampo(productos);
            }
            else
            {
                MessageBox.Show("Usuario no Encontada");
            }
        }


            private void ExistenciatextBox_TextChanged(object sender, EventArgs e)
        {
            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = Convert.ToString(Convert.ToInt32(CostotextBox.Text) * Convert.ToInt32(ExistenciatextBox.Text));

            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";
        }



        private void CostotextBox_TextChanged(object sender, EventArgs e)
        {
            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = Convert.ToString(Convert.ToInt32(CostotextBox.Text) * Convert.ToInt32(ExistenciatextBox.Text));

            if (CostotextBox.Text.Length > 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length > 0)
                ValorInventariotextBox.Text = "0";

            if (CostotextBox.Text.Length == 0 && ExistenciatextBox.Text.Length == 0)
                ValorInventariotextBox.Text = "0";

        }
    }
}
