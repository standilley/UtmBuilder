using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core.Tests
{
    [TestClass]
    public class UtmTests
    {
        private const string result = 
                "https://testando.io/" +
                "?utm_source=src" +
                "&utm_medium=med" +
                "&utm_campaign=nme" +
                "&utm_id=id" +
                "&utm_term=ter" +
                "&utm_content=ctn";
        private readonly Url _url = new ("https://testando.io/");
        private readonly Campaign _campaign = new (
                "src",
                "med",
                "nme",
                "id",
                "ter",
                "ctn");
        [TestMethod]
        public void Deve_retornar_da_string_para_utm()
        {
            var utm = new Utm(_url, _campaign);

            Assert.AreEqual(result.ToString(), utm.ToString());// testando o implicit operator
        }
        [TestMethod]
        public void Deve_retornar_do_utm_para_string()
        {
            var utm = new Utm(_url, _campaign);

            Assert.AreEqual((string)utm, result); // testando o implicit operator
        }
        [TestMethod]
        public void Deve_retornar_de_utm_para_url()
        {
            Utm utm = result;
            Assert.AreEqual("https://testando.io/", utm.Url.Address);
            Assert.AreEqual("src", utm.Campaign.Source);
            Assert.AreEqual("med", utm.Campaign.Medium);
            Assert.AreEqual("nme", utm.Campaign.Name);
            Assert.AreEqual("id", utm.Campaign.Id);
            Assert.AreEqual("ter", utm.Campaign.Term);
            Assert.AreEqual("ctn", utm.Campaign.Content);
        }
    }
}
