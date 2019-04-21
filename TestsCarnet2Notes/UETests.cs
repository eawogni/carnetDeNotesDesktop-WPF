using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class UETests
    {
        [TestMethod()]
        public void UETest()
        {
            UE e = new UE("Info");
            Assert.AreEqual(e.Nom, "Info");
            //Assert.Fail();
        }

        [TestMethod()]
        public void AjouterModuleTest()
        {
            UE e = new UE("Info");
            e.AjouterModule("M3105","Poo", 2);
            Assert.AreEqual(e.ListeModule()[0].Nom, "Poo");

            //Assert.Fail();
        }

        [TestMethod()]
        public void ListeModuleTest()
        {
            UE e = new UE("Info");
            e.AjouterModule("M1011","Graphe", 2);
            Assert.AreEqual(e.ListeModule().Length, 1);
            //Assert.Fail();
        }
        [TestMethod()]
        public void ToStringTest()
        {
            UE e = new UE("Info");
            e.AjouterModule("M3105", "Poo", 2);
            Assert.AreEqual(e.ToString(), "Info (2)");

        }

        [TestMethod()]
        public void MoyenneTest()
        {
            UE e = new UE("Info");
            e.AjouterModule("M3105","Poo", 2);
            Note n = new Note(12, false);

            e.ListeModule()[0].AjouterExamen("11/12/20117", "Mr Ambart", 3, n);
            Assert.AreEqual(e.Moyenne(), 12);

        }


    }
}