using System;
using OperatorSystemFactory;
using Interface;
using Operation;
using XmlUtil;

namespace Client {
    public class Client {
        static void Main(string[] args) {
            SystemFactory factory = (SystemFactory)XMLUtil.getBean();
            InterfaceController interfaceCtrl = factory.createInterfaceCtrl();
            OperationController operationCtrl = factory.createOperationCtrl();
            interfaceCtrl.control();
            operationCtrl.control();
        }
    }
}
