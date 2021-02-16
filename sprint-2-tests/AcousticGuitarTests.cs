using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using sprint_2_base;

namespace sprint_2_tests {
    [TestClass]
    public class AcousticGuitarTests {
        private AcousticGuitar _acousticGuitar;
        public AcousticGuitar AcousticGuitar { get { return _acousticGuitar; } set { _acousticGuitar = value; } }
        public AcousticGuitarTests() {
            AcousticGuitar = new AcousticGuitar();
        }
        [TestMethod]
        public void AcousticGuitarInit() {
            AcousticGuitar ag = this.AcousticGuitar;
            Assert.AreEqual(ag.IsBeingPlayed, false);
            Assert.AreEqual(ag.IsStringed, true);
            Assert.AreEqual(ag.NeedsExternalPower, false);
            Assert.AreEqual(ag.NumStrings, 6);
            List<string> CorrectStrings = new List<string> { "E", "A", "D", "G", "B", "E" };
            CollectionAssert.AreEqual(ag.StringNotes, CorrectStrings);
        }
        [TestMethod]
        public void AcousticGuitarAbout() {
            AcousticGuitar ag = this.AcousticGuitar;
            Assert.AreEqual(ag.About(), $"This {ag.ToString()} is stringed.\nIt does not need power.\nIt has 6 strings.");
        }
        [TestMethod]
        public void AcousticGuitarPlaying() {
            AcousticGuitar ag = this.AcousticGuitar;
            Assert.AreEqual(ag.StartPlaying(), $"This {ag.ToString()} is being played.\nPlaying all the open strings. The notes E, A, D, G, B, E are played.");
            Assert.AreEqual(ag.StopPlaying(), $"This {ag.ToString()} is no longer being played.");
        }
    }
}
