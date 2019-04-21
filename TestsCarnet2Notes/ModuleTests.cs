using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ModuleTests
    {
        [TestMethod()]
        public void ModuleTest()
        {
            Module mod = new Module("M3105","POO", 2);
            Assert.AreEqual(mod.Nom, "POO");
            Assert.AreEqual(mod.Coefficient,2);
            //Assert.Fail();
        }

        [TestMethod()]
        public void AjouterExamenTest()
        {
            Module mod = new Module("M3105", "POO", 2); ;
            Note n = new Note(12, false);  
            mod.AjouterExamen("11/12/2017", "Mr Ambart", 3, n);
            Assert.AreEqual(mod.ListeExamen().Length, 1);
            Assert.AreEqual(mod.ListeExamen()[0].NomProf, "Mr Ambart");
            //Assert.Fail();
        }

        [TestMethod()]
        public void ListeExamenTest()
        {
            Module mod = new Module("M3105", "POO", 2);

            Note n = new Note(12, false);
            Note n1 = new Note(11, false);
            Note n2 = new Note(15, false);

            mod.AjouterExamen("11/12/2017", "Mr Ambart", 3, n);
            mod.AjouterExamen("12/11/2017", "Mr Aubert", 2, n1);
            mod.AjouterExamen("01/12/2017", "Mme Serier", 3.5f, n2); ;
           


           Assert.AreEqual(mod.ListeExamen().Length,3);
           Assert.AreEqual(mod.ListeExamen()[2].NomProf, "Mme Serier");
         
            //Assert.Fail();
        }

        [TestMethod()]
        public void ListeNotesTest()
        {
            Module mod = new Module("M3105", "POO", 2) ;

            Note n = new Note(12, false);
            Note n1 = new Note(11, false);
            Note n2 = new Note(15, false);
            mod.AjouterExamen("11/12/2017", "Mr Ambart", 3, n);
            mod.AjouterExamen("11/12/2017", "Mr Ambart", 3, n1);
            mod.AjouterExamen("11/12/2017", "Mr Ambart", 3, n2);


            Assert.AreEqual(mod.ListeNotes()[0].Valeur,12);
            Assert.AreEqual(mod.ListeNotes()[2].Valeur,15);


        }
        [TestMethod()]
        public void MoyenneTest()
        {
            Module mod = new Module("M3105", "POO", 2);

            Note n = new Note(12, false);
            mod.AjouterExamen("11/12/20117", "Mr Ambart", 3, n);
            Assert.AreEqual(mod.Moyenne(), 12);

        }

        [TestMethod()]
        public void ToStringTest()
        {
            Module mod = new Module("M3105", "POO", 2); ;
            Assert.AreEqual(mod.ToString(), "POO (2)") ;

        }
    }
}