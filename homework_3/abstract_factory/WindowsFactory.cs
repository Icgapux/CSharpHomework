using System;
using OperatorSystemFactory;
using Interface;
using Operation;

namespace Windows {
    public class WindowsFactory: SystemFactory {
        public InterfaceController createInterfaceCtrl() {
            Console.WriteLine("created a windows Interface controller.");
            return new WindowsInterfaceCtrl();
        }
        public OperationController createOperationCtrl() {
            Console.WriteLine("created a windows Operation controller.");
            return new WindowsOperationCtrl();
        }
    }
    public class WindowsInterfaceCtrl: InterfaceController {
        public void control() {
            Console.WriteLine("Controlling the Interface of windows system.");
        }
    }
    public class WindowsOperationCtrl: OperationController {
        public void control() {
            Console.WriteLine("Controlling the Operation of windows system.");
        }
    }
}
