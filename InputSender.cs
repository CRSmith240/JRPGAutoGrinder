using System;
using System.Linq;
using System.Runtime.InteropServices;
using WindowsInput.Native;
using WindowsInput;
using System.Threading;

namespace JRPGAutoGrinder {
    public class InputSender {
        private Inputs inputs;
        private InputSimulator sim = new InputSimulator();

        [DllImport("user32.dll")]
        private static extern IntPtr FindWindow(string lpClassName, string lpWindowName);

        [DllImport("user32.dll")]
        private static extern IntPtr SetForegroundWindow(IntPtr hwnd);

        public InputSender(Inputs inputs) {
          this.inputs = inputs;
        }
        public void test(int cycleCount) {
            var x = inputs.inputType.InputChains();
            var chainType = x[GatherName()];
            var y = FindWindow(null, inputs.inputType.WindowName());
            SetForegroundWindow(y);
            while (true) { //TODO: add cycle amount
                foreach (var actionSet in chainType) {
                    int.TryParse(actionSet, out var delay);
                    if (delay > 0) {
                        Thread.Sleep(delay);
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

        private string GatherName() {
          //TODO List chain types and have user choose one
          Console.WriteLine("What's the name");
          return Console.ReadLine();
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