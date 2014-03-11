using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Reminder {
    [TestClass]
    public class TestNotesController {

        [TestMethod]
        public void TestController() {
            NotesController controller = new NotesController();
            int length = controller.getNotes().Length;

            controller.addNote(new Note("name", "text", DateTime.Now));
            if (length + 1 != controller.getNotes().Length)
                Assert.Fail();

            controller.deleteNote("name");

            if (length != controller.getNotes().Length)
                Assert.Fail();

        }

    }
}
