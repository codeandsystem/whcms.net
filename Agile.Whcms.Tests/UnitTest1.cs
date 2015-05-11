using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Agile.Whcms.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestGetClients()
        {
            Whcms client = new Whcms("http://clientes.codeandsystem.com/includes/api.php","zerosofadown", "Li8ujko97!");
            client.GetClients();
        }
    }
}
