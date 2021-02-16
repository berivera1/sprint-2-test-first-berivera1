using System;
using System.Collections.Generic;
using System.Text;

namespace sprint_2_base
{
    public abstract class Instrument {
        public bool IsStringed { get; set; }
        public bool IsBeingPlayed { get; set; }
        public bool NeedsExternalPower { get; set; }
        public virtual string About() {
            return "WRITE STUFF HERE";
        }
        public string GetBaseAttributesString() {
            return "WRITE STUFF HERE";
        }
        public virtual string StartPlaying() {
            return "WRITE STUFF HERE";
        }
        public string StopPlaying() {
            return "WRITE STUFF HERE";
        }
    }
}
