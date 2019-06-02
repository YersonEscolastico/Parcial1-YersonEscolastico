using Microsoft.VisualStudio.TestTools.UnitTesting;
using Parcial1_YersonEscolastico.BLL;
using Parcial1_YersonEscolastico.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial1_YersonEscolastico.BLL.Tests
{
    [TestClass()]
    public class InventarioBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            bool paso = false;
            Inventario inventario = new Inventario();
            inventario.Id = 1;
            inventario.Total = 0;
            paso = InventarioBLL.Guardar(inventario);
            Assert.AreEqual(paso, true);
        }

        [TestMethod()]
        public void ModificarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }
    }
}