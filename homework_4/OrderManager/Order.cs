using System;

namespace OrderManager {
    public class Order {
        public Order(int id, string commodity, string client) {
            this.id = id;
            this.commodity = commodity;
            this.client = client;
        }
        private int id;
        public string commodity;
        public string client;
        public bool checkId(int id) {
            return this.id == id;
        }
        public bool checkCommodity(string commodity) {
            return this.commodity == commodity;
        }
        public bool checkClient(string client) {
            return this.client == client;
        }
        public void print() {
            Console.WriteLine("id: " + id);
            Console.WriteLine("commodity: " + commodity);
            Console.WriteLine("client: " + client);
        }
    }
}
