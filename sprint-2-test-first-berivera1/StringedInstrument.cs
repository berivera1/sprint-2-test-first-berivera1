using System;
using System.Collections.Generic;
using System.Text;

namespace sprint_2_base {
    public class StringedInstrument : Instrument {
        public int NumStrings { get; set; }
        public List<string> StringNotes { get; set; }
        public StringedInstrument() {
            // WRITE STUFF HERE
        }
        public StringedInstrument(int _numStrings, List<string> _stringNotes, bool _needsAmp) {
            // WRITE STUFF HERE
        }
        public override string About() {
            return "WRITE STUFF HERE";
        }
        public override string StartPlaying() {
            return "WRITE STUFF HERE";
        }
    }
}
