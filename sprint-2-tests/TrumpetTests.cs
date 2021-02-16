using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using sprint_2_base;

namespace sprint_2_tests {
    [TestClass]
    public class TrumpetTests {
        private Trumpet _trumpet;
        public Trumpet Trumpet { get { return _trumpet; } set { _trumpet = value; } }
        public TrumpetTests() {
            Trumpet = new Trumpet();
        }
        [TestMethod]
        public void TrumpetInit() {
            Trumpet tr = this.Trumpet;
            Assert.AreEqual(tr.IsBeingPlayed, false);
            Assert.AreEqual(tr.IsStringed, false);
            Assert.AreEqual(tr.NeedsExternalPower, false);
        }
        [TestMethod]
        public void TrumpetAbout() {
            Trumpet tr = this.Trumpet;
            Assert.AreEqual(tr.About(), $"This {tr.ToString()} is not stringed.\nIt does not need power.");
        }
        [TestMethod]
        public void TrumpetPlaying() {
            Trumpet tr = this.Trumpet;
            Assert.AreEqual(tr.StartPlaying(), $"This {tr.ToString()} is being played.");
            Assert.AreEqual(tr.StopPlaying(), $"This {tr.ToString()} is no longer being played.");
        }
    }
}
