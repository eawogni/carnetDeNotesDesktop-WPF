using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarnetDeNotes;

namespace TestsCarnet2Notes
{
    [TestClass]
    public class EtudiantTests
    {
        [TestMethod]
        public void EtudiantTest()
        {
            Etudiant etd = new Etudiant("AWOGNI", "Emmanuel");
            Assert.AreEqual(etd.Nom, "AWOGNI");
        }
    }
}
