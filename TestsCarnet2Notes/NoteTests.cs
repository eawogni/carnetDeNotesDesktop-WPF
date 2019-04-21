using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    [TestClass()]
    public class NoteTests
    {
        [TestMethod()]
        public void NoteTest()
        {
            Note note = new Note(12, false);
            Assert.AreEqual(note.Valeur,12);
           // Assert.Fail();
        }
        [TestMethod()]
        public void ToStringTest()
        {
            Note note = new Note(12, false);
            Assert.AreEqual(note.ToString(), "12/20");
            // Assert.Fail();
        }


    }
}