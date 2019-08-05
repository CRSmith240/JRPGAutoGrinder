using System;
using System.Collections.Generic;
using WindowsInput;
using WindowsInput.Native;
using System.Threading;

namespace JRPGAutoGrinder {
  public class Inputs {
    private const string D2Special = "ADDA";
    public readonly Dictionary<char, VirtualKeyCode> converter = new Dictionary<char, VirtualKeyCode>{
      {'A', VirtualKeyCode.RETURN},
      {'U', VirtualKeyCode.VK_W},
      {'D', VirtualKeyCode.VK_S},
      {'Y', VirtualKeyCode.VK_I},
      {'R', VirtualKeyCode.VK_D},
    };
    public readonly Dictionary<string, string[]> Disgaea = new Dictionary<string, string[]> {
      {"CoO4", new String[]{"AAAUUUUA", "275", $"{D2Special}DDDAA", "DDDDAAARUUUUA", "300", $"{D2Special}DDDDAAYA", "6000", "AA", "2000", "AA", "3500"}}
    };
  }
}