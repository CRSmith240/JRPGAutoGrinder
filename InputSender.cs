using System;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsInput.Native;
using WindowsInput;
using System.Threading;

namespace JRPGAutoGrinder {
    public class InputSender {
        private Inputs inputs = new Inputs();
        private InputSimulator sim = new InputSimulator();

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hwnd);


        public void test() {
            var x = inputs.Disgaea["CoO4"];
            var y = FindWindow(null, "Disgaea2 PC");
            SetForegroundWindow(y);
            while (true) {
                foreach (var actionSet in x) {
                    int.TryParse(actionSet, out var z);
                    if (z > 0) {
                        Thread.Sleep(z);
                        Console.WriteLine("sleep end");
                        continue;
                    } else {
                        foreach (var action in actionSet) {
                            Console.WriteLine(action);
                            DelayPress(inputs.converter[action]);
                        }
                    }
                }
            }

        }

        private void DelayPress(VirtualKeyCode key) {
            //Keyboard.KeyPress is too fast and won't register, add a sleep so the game has time to register the input
            sim.Keyboard.KeyDown(key);
            Thread.Sleep(50);
            sim.Keyboard.KeyUp(key);
            Thread.Sleep(115);
        }
    }
}