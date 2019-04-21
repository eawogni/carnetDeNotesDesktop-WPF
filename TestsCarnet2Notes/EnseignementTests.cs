using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class EnseignementTests
    {
        [TestMethod()]
        public void EnseignementTest()
        {
            Enseignement s = new UE("M1101");
            Assert.AreEqual(s.Nom ,"M1101");
            //Assert.Fail();
        }
    }
}