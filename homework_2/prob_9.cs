using System;
using System.Collections.Generic;

namespace Sieve {
    class Sieve {
        static void Main(String[] args) {
            bool[] isPrime = new bool[101];
            List<int> prime = new List<int>();
            // int[] prime = new int[50];
            for (int i = 2; i <= 100; i++) {
                isPrime[i] = true;
            }
            for (int i = 2; i <= 100; i++) {
                if (isPrime[i]) {
                    prime.Add(i);
                    for (int j = i; j + i <= 100; j += i) {
                        isPrime[j + i] = false;
                    }
                }
            }
            foreach (int x in prime) {
                Console.WriteLine(x);
            }
        }
    }
}
