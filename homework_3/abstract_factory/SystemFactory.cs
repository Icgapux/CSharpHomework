using System;
using Interface;
using Operation;

namespace OperatorSystemFactory {
    public interface SystemFactory {
        InterfaceController createInterfaceCtrl();
        OperationController createOperationCtrl();
    }
}
