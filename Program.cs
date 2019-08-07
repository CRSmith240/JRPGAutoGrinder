using System;

namespace JRPGAutoGrinder {
    class Program {
        static void Main(string[] args) {
            // Console.WriteLine("What Game are you playing");
            // var read = Console.ReadLine();
            // var z = (IInputType)Type.GetType(read);
            var x = new InputSender(new Inputs(new Disgaea2()));
            //get cycle count
            x.test(6);
        }
    }
}
