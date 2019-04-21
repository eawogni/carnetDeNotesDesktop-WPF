using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class SemestreTests
    {
        [TestMethod()]
        public void SemestreTest()
        {
            Semestre c = new Semestre();
          
            //Assert.Fail();
        }

        [TestMethod()]
        public void AjouterUETest()
        {
            Semestre c = new Semestre();
            UE monUE = new UE("Info");
            c.AjouterUE(monUE);
            UE[] tabUE = c.ListeDesUE();
            Assert.AreEqual(tabUE[0].Nom, "Info");
            // Assert.Fail();
        }

        [TestMethod()]
        public void ListeModulesTest()
        {

            UE monUE1 = new UE("Info");
            monUE1.AjouterModule("M3105","Poo", 3);
            UE monUE2 = new UE("Methodologie");
            monUE2.AjouterModule("M1015","GestionSi", 2);

            Semestre c = new Semestre();
            c.AjouterUE(monUE1);
            c.AjouterUE(monUE2);

          

            Assert.AreEqual(2, c.ListeModules().Length);
            Assert.AreEqual("Poo", c.ListeModules()[0].Nom);
            Assert.AreEqual(2, c.ListeModules()[1].Coefficient);
            

            //Assert.Fail();
        }

        [TestMethod()]
        public void ListeDesUETest()
        {
            UE monUE1 = new UE("Info");
            UE monUE2 = new UE("Methodologie");

            Semestre c = new Semestre();

            c.AjouterUE(monUE1);
            c.AjouterUE(monUE2);



            Assert.AreEqual(2, c.ListeDesUE().Length);

            Assert.AreEqual("Info", c.ListeDesUE()[0].Nom);
            Assert.AreEqual(0, c.ListeDesUE()[1].Coefficient);

            // Assert.Fail();
        }

        [TestMethod()]
        public void GetUETest()
        {
            UE monUE1 = new UE("Info");
            Semestre c = new Semestre();

            c.AjouterUE(monUE1);
            Assert.AreEqual(c.GetUE("Info").Nom,"Info");

            //Assert.Fail();
        }
    }
}