using System;

namespace OrderManager {
    public class Client {
        static void Main(String[] args) {
            var service = new OrderService();
            service.addOrder("ac", "bc");
            service.addOrder("ad", "bd");
            service.addOrder("ae", "be");
            try {
                service.findOrdersByCommodity("ac")[0].print();
                service.delOrderById(0);
                service.delOrderById(3);
            } catch (FindNoOrderException e) {
                Console.WriteLine(e.message);
            }
            try {
                service.changeOrderCommodityById(0, "aaa");
                Console.WriteLine(service.findOrdersByCommodity("aaa"));
            } catch (FindNoOrderException e) {
                Console.WriteLine(e.message);
            }
            try {
                service.changeOrderCommodityById(1, "aaa");
                service.findOrdersByCommodity("aaa")[0].print();
            } catch (FindNoOrderException e) {
                Console.WriteLine(e.message);
            }
        }
    }
}
