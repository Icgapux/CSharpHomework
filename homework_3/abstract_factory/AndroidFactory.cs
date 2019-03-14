using System;
using OperatorSystemFactory;
using Interface;
using Operation;

namespace Android {
    public class AndroidFactory: SystemFactory {
        public InterfaceController createInterfaceCtrl() {
            Console.WriteLine("created a android Interface controller.");
            return new AndroidInterfaceCtrl();
        }
        public OperationController createOperationCtrl() {
            Console.WriteLine("created a android Operation controller.");
            return new AndroidOperationCtrl();
        }
    }
    public class AndroidInterfaceCtrl: InterfaceController {
        public void control() {
            Console.WriteLine("Controlling the Interface of android system.");
        }
    }
    public class AndroidOperationCtrl: OperationController {
        public void control() {
            Console.WriteLine("Controlling the Operation of android system.");
        }
    }
}
