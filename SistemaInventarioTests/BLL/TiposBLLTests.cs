using Microsoft.VisualStudio.TestTools.UnitTesting;
using SistemaInventario.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaInventario.BLL.Tests
{
    [TestClass()]
    public class TiposBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            var tiposUsuarios = new Models.TiposUsuarios();

            Assert.IsTrue(TiposBLL.Guardar(tiposUsuarios));
        }
    }
}