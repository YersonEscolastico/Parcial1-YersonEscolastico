using Parcial1_YersonEscolastico.BLL;
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

namespace Parcial1_YersonEscolastico.UI.Consultas
{
    public partial class cInventario : Form
    {
        public cInventario()
        {
            InitializeComponent();
        }

        private void RefrescarButton_Click(object sender, EventArgs e)
        {
            Inventarios inventario = InventariosBLL.Buscar(1);
            double TotalInventario;
            TotalInventario = inventario.Total;
            TotalTextBox.Text = TotalInventario.ToString();
        }
    }
}
