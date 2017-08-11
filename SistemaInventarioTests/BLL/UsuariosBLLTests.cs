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
    public class UsuariosBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
           var registroUsuarios = new Models.RegistroUsuarios();

           Assert.IsTrue(UsuariosBLL.Guardar(registroUsuarios));
        }
    }
}