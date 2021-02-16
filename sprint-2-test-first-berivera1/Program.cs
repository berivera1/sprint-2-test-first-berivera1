using System;

namespace sprint_2_base {
    class Program {
        static void Main(string[] args) {
            Tester t = new Tester();
            t.Test();
        }
        class Tester
        {
            public void Test()
            {
                Trumpet tr = new Trumpet();
                Console.WriteLine(tr.About());
                Console.WriteLine(tr.StartPlaying());
            }
        }
    }
}
