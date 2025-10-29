namespace Lab4
{
    public class Program
    {
        public static void Main()
        {
            Purple purple = new Purple();

            // Task 3

            Console.WriteLine("Task 3\n");

            var sizes = new int [] { 4, 8, 12, 10, 15, 22 };
            for (int i = 0; i < 6; i++)
            {
                int n = sizes[i];
                var a = new int[n];
                Random k = new Random();
                int sum = 0;
                for (int j = 0; j < n; j++)
                {
                    a[j] = k.Next(11);
                    sum += a[j];
                }
                Console.WriteLine(string.Join(" ", a));
                double mid = (double)sum / n;
                Console.WriteLine($"mid: {mid}");
                int p = (int)(mid + k.Next(-3, 4));
                Console.WriteLine($"p: {p}");
                var ans_a = purple.Task3(a, p);
                Console.WriteLine(string.Join(" ", ans_a));
                Console.WriteLine();
            }

            // Task 4

            Console.WriteLine("Task 4\n");

            var a4 = new int[] { 3, -6, -2, 2, 4, 62, -32, 1, 0, 2};
            Console.WriteLine(string.Join(" ", a4));
            purple.Task4(a4);
            Console.WriteLine($"{string.Join(" ", a4)}\n");

            // Task 5

            Console.WriteLine("Task 5\n");

            Random gen = new Random();

            var a5 = new int[] { 334, -61, -243, 23, 41, 62, -32, 10, 54, 24 };
            var b5 = new int[] { 0, 1, 2, 3 };
            Console.WriteLine($"a: {string.Join(" ", b5)}\n");
            Console.WriteLine($"b: {string.Join(" ", a5)}\n");

            var k_ind = new int[] {0, gen.Next(4, 7), a5.Length - 1, 50};

            foreach (int k_ind_i in k_ind)
            {
                Console.WriteLine($"k: {k_ind_i}");
                var ans5 = purple.Task5(a5, b5, k_ind_i);
                if (ans5 != null)
                {
                    Console.WriteLine($"{string.Join(" ", ans5)}\n");
                }
            }

            // Task 7

            Console.WriteLine("Task 7\n");

            var a7 = new int[] { 0, 1, 4, 8, 6, 7, 10 };
            var ans7 = purple.Task7(a7);
            Console.WriteLine(string.Join(" ", a7));
            Console.WriteLine($"{string.Join(" ", ans7)}\n");

            // Task 8

            Console.WriteLine("Task 8\n");

            var a8 = new int[] { 3, -4, 2, 1 };
            var b8 = new int[] { 9, -2, 5, -2, 4, 2, 2 };
            Console.WriteLine(string.Join(" ", a8));
            Console.WriteLine(string.Join(" ", b8));
            var ans8 = purple.Task8(a8, b8);
            Console.WriteLine(string.Join(" ", a8));
            Console.WriteLine(string.Join(" ", b8));
            Console.WriteLine($"{string.Join(" ", ans8)}\n");

            // Task 9

            Console.WriteLine("Task 9\n");

            var a9 = new int[] { -2, -5, 3, -4, 2, 1, 2, 3, 3, 0, -6 };
            Console.WriteLine(string.Join(" ", a9));
            purple.Task9(a9);
            Console.WriteLine($"{string.Join(" ", a9)}\n");

            // Task 10

            Console.WriteLine("Task 10\n");

            var a10 = new int[] { 3, 1, 8, 4, 9, 5, 7, 0, -2, 31, 4 };
            int N10 = 3;
            Console.WriteLine(string.Join(" ", a10));
            purple.Task10(a10, N10);
            Console.WriteLine($"{string.Join(" ", a10)}\n");
            
            N10 = 8;
            Console.WriteLine(string.Join(" ", a10));
            purple.Task10(a10, N10);
            Console.WriteLine($"{string.Join(" ", a10)}\n");

            // Task 11

            Console.WriteLine("Task 11\n");

            double[] a11 = { 7, 7, 4, 10, 10, 10, 10, 10 };
            double[] b11 = { 7, 7, 0, 19, 19, 19, 19, 19 };
            int[] n11 =    { 1, 5, 3, 0,  1,  2,  3,  6 };
            double[] Xext, Yext;

            for (int i = 0; i < n11.Length; i++)
            {
                Console.WriteLine($"a = {a11[i]}  b = {b11[i]}  n = {n11[i]}");
                (Xext, Yext) = purple.Task11(a11[i], b11[i], n11[i]);
                if (Xext != null)
                {
                    Console.WriteLine(Xext.Length);
                    Console.WriteLine($"Xext: {string.Join(" ", Xext)}");
                    Console.WriteLine($"Yext: {string.Join(" ", Yext)}");
                }
                Console.WriteLine();
            }

            // Task 12

            Console.WriteLine("Task 12\n");

            double[] raw12 = { 7, 10, 3, 8, 4, -1, -3, 1, -2, 4, 6, -3, 6, 0, -3 };
            Console.WriteLine($"raw: {string.Join(" ", raw12)}");
            purple.Task12(raw12);
        }
    }
}
