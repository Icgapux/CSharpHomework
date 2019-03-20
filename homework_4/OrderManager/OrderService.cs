using System;
using System.Collections.Generic;

namespace OrderManager {
    public class FindNoOrderException: Exception {
        public string message;
        public FindNoOrderException(string message):base(message) {
            this.message = message;
        }
    }

    public class OrderService {
        private List<Order> orders = new List<Order>();
        private int orderCounter = 0;
        public void addOrder(string commodity, string client) {
            Order o = new Order(orderCounter++, commodity, client);
            orders.Add(o);
        }
        public void delOrderById(int id) {
            bool success = false;
            for (var i = 0; i < orders.Count; i++) {
                if (orders[i].checkId(id)) {
                    orders.RemoveAt(i);
                    success = true;
                    break;
                }
            }
            if (!success) {
                string message = "The order with specific id " + id.ToString() + " is not exist.";
                var e = new FindNoOrderException(message);
                throw e;
            }
        }
        public void changeOrderCommodityById(int id, string commodity) {
            bool success = false;
            for (var i = 0; i < orders.Count; i++) {
                if (orders[i].checkId(id)) {
                    orders[i].commodity = commodity;
                    success = true;
                    break;
                }
            }
            if (!success) {
                string message = "The order with specific id " + id.ToString() + " is not exist.";
                var e = new FindNoOrderException(message);
                throw e;
            }
        }
        public void changeOrderClientById(int id, string client) {
            bool success = false;
            for (var i = 0; i < orders.Count; i++) {
                if (orders[i].checkId(id)) {
                    orders[i].client = client;
                    success = true;
                    break;
                }
            }
            if (!success) {
                string message = "The order with specific id " + id.ToString() + " is not exist.";
                var e = new FindNoOrderException(message);
                throw e;
            }
        }
        public Order findOrderById(int id) {
            for (var i = 0; i < orders.Count; i++) {
                if (orders[i].checkId(id)) {
                    // orders[i].print();
                    return orders[i];
                }
            }
            return null;
        }
        public List<Order> findOrdersByCommodity(string commodity) {
            var ordersMatched = new List<Order>();
            foreach (Order o in orders) {
                if (o.checkCommodity(commodity)) {
                    ordersMatched.Add(o);
                }
            }
            return ordersMatched;
        }
        public List<Order> findOrdersByClient(string client) {
            var ordersMatched = new List<Order>();
            foreach (Order o in orders) {
                if (o.checkClient(client)) {
                    ordersMatched.Add(o);
                }
            }
            return ordersMatched;
        }
    }
}
