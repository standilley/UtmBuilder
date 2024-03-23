using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Core.Tests.ValueObjects
{
    [TestClass]
    public class UrlTests
    {
        [TestMethod]
        [ExpectedException(typeof(InvalidUrlException))]
        public void Dado_uma_url_invalida_deve_retornar_uma_excecao()
        {
            new Url("fruta");      
        }
        [TestMethod]
        public void Dado_uma_url_valida_nao_deve_retornar_uma_excecao()
        {
            var url = new Url("https://teste.io");
            Assert.IsTrue(true);
        }
    }
}
