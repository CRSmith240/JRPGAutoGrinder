using System;
using System.Linq;
using System.Runtime.InteropServices;

namespace JRPGAutoGrinder {
    public class InputSender {
        private Inputs inputs = new Inputs();

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        public string test() {
          return inputs.Disgaea["CoO4"].First();
        }
    }
}