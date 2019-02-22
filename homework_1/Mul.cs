using System;

namespace Mul {
    class Mul {
        static void Main(string[] args) {
            string[] tokens = Console.ReadLine().Split();
            int a = int.Parse(tokens[0]), b = int.Parse(tokens[1]);
            Console.WriteLine(a * b);
        }
    }
}
