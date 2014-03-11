using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reminder {
    [TestClass]
    public class TestNote {
        
        [TestMethod]
        public void TestNoteMethod() {
            DateTime dateTime = DateTime.Now;
            Note note = new Note("Name", "Text", dateTime);

            if (note.getDate() != dateTime)
                Assert.Fail();
            if (note.getName() != "Name")
                Assert.Fail();
            if (note.getText() != "Text")
                Assert.Fail();
        }
        
    }
}