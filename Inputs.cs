using System;
using System.Collections.Generic;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;

namespace JRPGAutoGrinder {
    public class Inputs {
      public readonly IInputType inputType;
      public readonly Dictionary<char, VirtualKeyCode> converter = new Dictionary<char, VirtualKeyCode>{
        {'A', VirtualKeyCode.RETURN},
        {'U', VirtualKeyCode.VK_W},
        {'D', VirtualKeyCode.VK_S},
        {'Y', VirtualKeyCode.VK_I},
        {'R', VirtualKeyCode.VK_D},
      };
      public Inputs(IInputType input) {
          inputType = input;
      }
    }
}