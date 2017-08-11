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
    public class SparesBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            var registroSpares = new Models.DetalleRegistroSpares();

            Assert.IsTrue(SparesBLL.Guardar(registroSpares));
        }
    }
}