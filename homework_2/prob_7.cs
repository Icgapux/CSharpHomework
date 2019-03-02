using System;

namespace ArrayCal {
    class ArrayCal {
        static void Main(String[] args) {
            string[] tokens = Console.ReadLine().Split();
            int[] num = new int[tokens.Length];
            for (int i = 0; i < tokens.Length; i++) {
                num[i] = int.Parse(tokens[i]);
            }
            int mx = num[0], mn = num[0], sum = 0;
            for (int i = 0; i < num.Length; i++) {
                mx = Math.Max(mx, num[i]);
                mn = Math.Min(mn, num[i]);
                sum += num[i];
            }
            Console.WriteLine("max = " + mx);
            Console.WriteLine("min = " + mn);
            Console.WriteLine("sum = " + sum);
            double ave = Convert.ToDouble(sum) / num.Length;
            Console.WriteLine("ave = " + ave);
        }
    }
}
