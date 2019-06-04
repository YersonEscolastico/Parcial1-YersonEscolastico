
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
    public partial class rProductos : Form
    {
        public rProductos()
        {
            InitializeComponent();
            LlenarComboBox();
        }


        private void Limpiar()
        {
            IDnumericUpDown.Value = 0;
            DescripciontextBox.Text = string.Empty;
            ExistenciaNumericUpDown.Value = 0;
            CostoumericUpDown.Value = 0;
            ValorInventariotextBox.Text = string.Empty;
            MyErrorProvider.Clear();
        }


        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }


        private Productos LlenaClase()
        {
            Productos producto = new Productos();

            producto.ProductoId = Convert.ToInt32(IDnumericUpDown.Value);
            producto.Descripcion = DescripciontextBox.Text;
            producto.Costo = Convert.ToDouble(CostoumericUpDown.Value);
            producto.Existencia = Convert.ToDouble(ExistenciaNumericUpDown.Value);
            producto.ValorInventario = Convert.ToDouble(ValorInventariotextBox.Text);

            return producto;
        }


        private void LlenaCampo(Productos productos)
        {
            IDnumericUpDown.Value = productos.ProductoId;
            DescripciontextBox.Text = productos.Descripcion;
            ExistenciaNumericUpDown.Value =Convert.ToDecimal(productos.Existencia);
            CostoumericUpDown.Value = Convert.ToDecimal( productos.Costo);
            ValorInventariotextBox.Text =Convert.ToString( productos.ValorInventario);
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
            if (CostoumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(CostoumericUpDown, "Este campo no bebe ser 0");
                CostoumericUpDown.Focus();
                paso = false;

            }
            if (ExistenciaNumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(ExistenciaNumericUpDown, "Este campo no bebe ser 0");
                ExistenciaNumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }


        private bool ExisteEnLaBaseDeDatos()
        {
            Productos productos = ProductosBLL.Buscar((int)IDnumericUpDown.Value);

            return (productos != null);
        }


        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            Productos productos;
            bool paso = false;

            if (!Validar())
                return;

            productos = LlenaClase();


            if (IDnumericUpDown.Value == 0)
            {
                paso = ProductosBLL.Guardar(productos);
            }
            else
            {
                if (!ExisteEnLaBaseDeDatos())
                {
                    MessageBox.Show("No se puede modificar una ubicacion que no existe", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                paso = ProductosBLL.Modificar(productos);

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
                if (db.Productos.Any(p => p.Descripcion.Equals(descripcion)))
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


        private bool VEliminar()
        {
            bool paso = true;
            MyErrorProvider.Clear();

            if (IDnumericUpDown.Value == 0)
            {
                MyErrorProvider.SetError(IDnumericUpDown, "Debe introducir un id para poder eliminar un producto");
                IDnumericUpDown.Focus();
                paso = false;
            }
            return paso;
        }



        private void Eliminarbutton_Click(object sender, EventArgs e)
        {
            MyErrorProvider.Clear();
            VEliminar();
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
                MyErrorProvider.SetError(IDnumericUpDown, "No se puede eliminar un producto que no existe");
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
                LlenaCampo(productos);
            }
            else
            {
                MessageBox.Show("Producto no Encontado");
            }
        }




        private void LlenarComboBox()
        {
            var listado = new List<Ubicaciones>();
            listado = UbicacionesBLL.getList(p => true);
            ubicacioncomboBox.DataSource = listado;
            ubicacioncomboBox.DisplayMember = "Descripcion";
            ubicacioncomboBox.ValueMember = "Id";
        }


        private void MasButton_Click(object sender, EventArgs e)
        {
            rUbicacion ub = new rUbicacion();
            ub.ShowDialog();
        }

        public void TotalInventario()
        {
            ValorInventariotextBox.Text = Convert.ToString(Convert.ToDecimal(ExistenciaNumericUpDown.Value) * Convert.ToDecimal(CostoumericUpDown.Value));
        }

        private void ExistenciaNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TotalInventario();
        }

        private void CostoumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            TotalInventario();
        }
    }
}
