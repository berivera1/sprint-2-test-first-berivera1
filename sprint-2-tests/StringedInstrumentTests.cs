using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using sprint_2_base;

namespace sprint_2_tests {
    [TestClass]
    public class StringedInstrumentTests {
        private StringedInstrument _stringedInstrument;
        public StringedInstrument StringedInstrument { get { return _stringedInstrument; } set { _stringedInstrument = value; } }
        public StringedInstrumentTests() {
            StringedInstrument = new StringedInstrument();
        }
        [TestMethod]
        public void StringedInstrumentInit() {
            StringedInstrument si = this.StringedInstrument;
            Assert.AreEqual(si.IsBeingPlayed, false);
            Assert.AreEqual(si.IsStringed, true);
            Assert.AreEqual(si.NeedsExternalPower, false);
            Assert.AreEqual(si.NumStrings, 1);
            List<string> CorrectStrings = new List<string> { "A" };
            CollectionAssert.AreEqual(si.StringNotes, CorrectStrings);
        }
        [TestMethod]
        public void StringedInstrumentAbout() {
            StringedInstrument si = this.StringedInstrument;
            Assert.AreEqual(si.About(), $"This {si.ToString()} is stringed.\nIt does not need power.\nIt has 1 strings.");
        }
        [TestMethod]
        public void StringedInstrumentPlaying() {
            StringedInstrument si = this.StringedInstrument;
            Assert.AreEqual(si.StartPlaying(), $"This {si.ToString()} is being played.\nPlaying all the open strings. The notes A are played.");
            Assert.AreEqual(si.StopPlaying(), $"This {si.ToString()} is no longer being played.");
        }
    }
}
