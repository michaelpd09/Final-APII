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
    public class AlmacenesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            var registroAlmacen = new Models.RegistroAlmacenes();

            Assert.IsTrue(AlmacenesBLL.Guardar(registroAlmacen));
        }
    }
}