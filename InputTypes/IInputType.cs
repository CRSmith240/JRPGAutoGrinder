using System.Collections.Generic;

namespace JRPGAutoGrinder {
  public interface IInputType{

    string WindowName();
    Dictionary<string, string[]> InputChains(); //Returns dictionary of chains
  }
}