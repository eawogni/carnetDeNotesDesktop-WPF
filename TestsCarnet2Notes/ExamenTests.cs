using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class ExamenTests
    {
        [TestMethod()]
        public void ExamenTest()
        {
            Note n = new Note(12, false);
            Examen ex = new Examen("11/12/20117", "Mr Ambart", 3,n);
            Assert.AreEqual(ex.Ponderation,3);
            //Assert.Fail();
           
        }

       [TestMethod()]
        public void SetNoteTest()
        {
            Note n = new Note(12, false);
            Examen ex = new Examen("11/12/20117", "Mr Ambart", 3,n);
            Note no = new Note(13, false);
            ex.SetNote(no);
            Assert.AreEqual(ex.GetNote().Valeur, 13);

            //Assert.Fail();
        }

        [TestMethod()]
        public void GetNoteTest()
        {
            Note n = new Note(12, false);
            Examen e = new Examen("11/12/20117", "Mr Ambart", 3,n);          
            Assert.AreEqual(e.GetNote().Valeur, 12);
            //Assert.Fail();
        }
    }
}