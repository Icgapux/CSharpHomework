using System;

namespace Factor {
    class Factor {
        static void Main(String[] args) {
            int n = int.Parse(Console.ReadLine());
            Console.Write(n + " = ");
            for (int i = 2; i <= n; i++) {
                while (n % i == 0) {
                    n = n / i;
                    Console.Write(i);
                    if (n > 1) {
                        Console.Write("*");
                    }
                }
            }
            Console.WriteLine("");
        }
    }
}
