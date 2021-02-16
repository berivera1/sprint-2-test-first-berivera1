using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using sprint_2_base;

namespace sprint_2_tests {
    [TestClass]
    public class BassGuitarTests {
        private BassGuitar _bassGuitar;
        public BassGuitar BassGuitar { get { return _bassGuitar; } set { _bassGuitar = value; } }
        public BassGuitarTests() {
            BassGuitar = new BassGuitar();
        }
        [TestMethod]
        public void BassGuitarInit() {
            BassGuitar bg = this.BassGuitar;
            Assert.AreEqual(bg.IsBeingPlayed, false);
            Assert.AreEqual(bg.IsStringed, true);
            Assert.AreEqual(bg.NeedsExternalPower, true);
            Assert.AreEqual(bg.NumStrings, 4);
            List<string> CorrectStrings = new List<string> { "E", "A", "D", "G" };
            CollectionAssert.AreEqual(bg.StringNotes, CorrectStrings);
        }
        [TestMethod]
        public void BassGuitarAbout() {
            BassGuitar bg = this.BassGuitar;
            Assert.AreEqual(bg.About(), $"This {bg.ToString()} is stringed.\nIt does need power.\nIt has 4 strings.");
        }
        [TestMethod]
        public void BassGuitarPlaying() {
            BassGuitar bg = this.BassGuitar;
            Assert.AreEqual(bg.StartPlaying(), $"This {bg.ToString()} is being played.\nPlaying all the open strings. The notes E, A, D, G are played.");
            Assert.AreEqual(bg.StopPlaying(), $"This {bg.ToString()} is no longer being played.");
        }
    }
}
