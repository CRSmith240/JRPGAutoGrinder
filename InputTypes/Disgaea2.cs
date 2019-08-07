using System;
using System.Collections.Generic;

namespace JRPGAutoGrinder {
  public class Disgaea2 : IInputType {
    private const string D2Special = "ADDA";

    public string WindowName() {
      return "Disgaea2 PC";
    }
    public Dictionary<string, string[]> InputChains() {
      return new Dictionary<string, string[]> {
        {"CoO4", new String[]{"AAAUUUUA", "350", $"{D2Special}DDDAA", "DDDDAAARUUUUA", "350", $"{D2Special}DDDDAAYA", "6000", "AA", "2000", "AA", "3500"}},
        {"sell", new String[]{"AAD"}},
        {"skill", new String[]{$"{D2Special}UUUAAYDA", "8000"}}
      };
    }
  }
}