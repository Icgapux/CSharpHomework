using System;
using OperatorSystemFactory;
using Interface;
using Operation;

namespace Symbian {
    public class SymbianFactory: SystemFactory {
        public InterfaceController createInterfaceCtrl() {
            Console.WriteLine("created a symbian Interface controller.");
            return new SymbianInterfaceCtrl();
        }
        public OperationController createOperationCtrl() {
            Console.WriteLine("created a symbian Operation controller.");
            return new SymbianOperationCtrl();
        }
    }
    public class SymbianInterfaceCtrl: InterfaceController {
        public void control() {
            Console.WriteLine("Controlling the Interface of symbian system.");
        }
    }
    public class SymbianOperationCtrl: OperationController {
        public void control() {
            Console.WriteLine("Controlling the Operation of symbian system.");
        }
    }
}
