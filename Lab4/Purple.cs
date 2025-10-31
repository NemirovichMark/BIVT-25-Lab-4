using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            // int max = Array.IndexOf(array, array.Max());
            int max = -1;
            double maxval = Int32.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                double value = array[i];
                if (value > maxval)
                {
                    maxval = value;
                    max = i;
                }
            }
            double sr = 0;

            foreach (double a in array)
            {
                sr += a;
            }

            sr /= array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (i > max)
                {
                    array[i] = sr;
                }

            }


            Console.WriteLine(string.Join(" ", array));

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            even = new int[(array.Length + 1) / 2];
            odd = new int[array.Length / 2];

            // code here
            int even_c = 0;
            int odd_c = 0;
            Console.WriteLine($"{even.Length} {odd.Length}");
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine($"{i} of {array.Length} | {even_c} {odd_c}");
                if (i % 2 == 0)
                {
                    even[even_c] = array[i];
                    even_c++;
                }
                else
                {
                    odd[odd_c] = array[i];
                    odd_c++;
                }
            }   
            
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int len = array.Length;

            if (len == 0)
            {
                return new int[] { P };
            }

            double sum = 0;
            foreach (int i in array)
            {
                sum += i;
            }
            double sr = sum / len;

            double min = Math.Abs(array[0] - sr);
            int ind = 0;

            for (int i = 1; i < array.Length; i++)
            {
                double curr = Math.Abs(array[i] - sr);
                if (curr < min)
                {
                    min = curr;
                    ind = i;
                }
            }

            int[] answer = new int[len + 1];

            for (int i = 0; i <= ind; i++)
            {
                answer[i] = array[i];
            }

            answer[ind + 1] = P;

            for (int i = ind + 1; i < len; i++)
            {
                answer[i + 1] = array[i];
            }

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] arr = new int[array.Length];
            int count = 0;

            foreach (int i in array)
            {
                if (i < 0) count++;
            }

            int[] negs = new int[count];
            int[] pos = new int[array.Length - count];

            count = 0;
            int count_pos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negs[count] = i;
                    count++;
                }
                else
                {
                    pos[count_pos] = i;
                    count_pos++;
                }
            }

            Console.WriteLine($"исходный { string.Join(" ", array)}");

            for (int i = 0; i < pos.Length; i++)
            {
                arr[i] = array[pos[i]];
            }

            for (int i = 0; i < negs.Length; i++)
            {
                arr[i + pos.Length] = array[negs[i]];
            }

            Console.WriteLine($"новый {string.Join(" ", arr)}");
            for (int i = 0; i < arr.Length; i++)
            {
                array[i] = arr[i];
            }

            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;
            int n = A.Length;
            int m = B.Length;
            answer = new int[n + m];

            if (k > n)
            {
                return A;
            }
            else if (k == n)
            {
                for (int i = 0; i < n; i++)
                {
                    answer[i] = A[i];
                }

                for (int i = 0; i < m; i++)
                {
                    answer[n + i] = B[i];
                }
            }
            else
            {
                for (int i = 0; i < k; i++)
                {
                    answer[i] = A[i];
                }

                for (int i = 0; i < m; i++)
                {
                    answer[k + i] = B[i];
                }

                for (int i = k; i < n; i++)
                {
                    answer[m + i] = A[i];
                }
            }

            

            Console.WriteLine($"A: {string.Join(" ", A)}");
            Console.WriteLine($"B: {string.Join(" ", B)}");
            Console.WriteLine($"K: {k}");
            Console.WriteLine($"ANS: {string.Join(" ", answer)}");

            return answer;

        }

        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here

            if (A.Length != B.Length) return (null, null);

            int[] s = new int[A.Length];
            int[] r = new int[B.Length];

            int len = int.Min(A.Length, B.Length);

            for (int i = 0; i < len; i++)
            {
                s[i] = A[i] + B[i];
                r[i] = A[i] - B[i];
            }

            sum = s;
            dif = r;

            Console.WriteLine($"S: {string.Join(" ", s)}");
            Console.WriteLine($"R: {string.Join(" ", r)}");
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            if (array == null || array.Length == 0)
                return null;

            int min = array[0];
            int max = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }

            if (min == max)
                return null;

            double[] normalized = new double[array.Length];
            double range = max - min;

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2.0 * (array[i] - min) / range - 1.0;
            }

            Console.WriteLine("initial: " + string.Join(",", array));
            Console.WriteLine("norm: " + string.Join(",", normalized));

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            for (int i = 0; i < A.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < A.Length; j++)
                {
                    if (A[j] > A[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = A[i];
                A[i] = A[maxIndex];
                A[maxIndex] = temp;
            }


            for (int i = 0; i < B.Length - 1; i++)
            {
                int maxIndex = i;
                for (int j = i + 1; j < B.Length; j++)
                {
                    if (B[j] > B[maxIndex])
                    {
                        maxIndex = j;
                    }
                }

                int temp = B[i];
                B[i] = B[maxIndex];
                B[maxIndex] = temp;
            }


            int[] C = new int[A.Length + B.Length];
            int x = 0, y = 0, z = 0;

            while (x < A.Length && y < B.Length)
            {
                if (A[x] >= B[y])
                {
                    C[z++] = A[x++];
                }
                else
                {
                    C[z++] = B[y++];
                }
            }

            while (x < A.Length)
            {
                C[z++] = A[x++];
            }

            while (y < B.Length)
            {
                C[z++] = B[y++];
            }

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            (int, int) max = (int.MinValue, 0);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max.Item1) { max = (array[i], i);  }
            }

            int n = array.Length;
            int shift = max.Item2;
            shift = shift % n;
            for (int i = 0; i < shift; i++)
            {
                int temp = array[n - 1];
                for (int j = n - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }
            // end

        }
        public void Task10(int[] array, int N)
        {
            // code here
            int ind = N - 1;

            int left = ind;
            int right = array.Length - ind - 1;

            int count = Math.Min(left, right);

            for (int i = 0; i < count; i++)
            {
                array[ind + 1 + i] = array[ind - 1 - i];
            }
            // end
        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a < b || a == b && n == 1)
            {
                X = new double[n];
                Y = new double[n];
                int pos = 0;
                double x;
                for (int i = 0; i < n; i++)
                {
                    x = a + i * (b - a) / (n - 1);
                    X[i] = x;
                    Y[i] = Math.Cos(x) + x * Math.Sin(x);
                    pos++;
                }

                int len = 0;
                for (int i = 1; i < (n - 1); i++)
                {
                    if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                    {
                        len++;
                    }
                }

                Xext = new double[len];
                Yext = new double[len];
                pos = 0;
                for (int i = 1; i < (n - 1); i++)
                {
                    if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                    {
                        Xext[pos] = X[i];
                        Yext[pos] = Y[i];
                        pos++;
                    }
                }
            }

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            if (raw == null || raw.Length == 0)
            {
                return (new double[0], new double[0], new double[0]);
            }

            double sr = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sr += raw[i];
            }
            sr /= raw.Length;

            int brightCount = 0;
            int dimCount = 0;
            int normalCount = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr)
                {
                    brightCount++;
                }
                else if (raw[i] < 0.5 * sr)
                {
                    dimCount++;
                }
                else
                {
                    normalCount++;
                }
            }

            double[] bright = new double[brightCount];
            double[] dim = new double[dimCount];
            double[] normal = new double[raw.Length];

            double normalSum = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] <= 2 * sr && raw[i] >= 0.5 * sr)
                {
                    normalSum += raw[i];
                }
            }
            double normalavg = normalCount > 0 ? normalSum / normalCount : 0;

            int brighti = 0;
            int dimi = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr)
                {
                    bright[brighti++] = raw[i];
                    normal[i] = (normalavg + raw[i]) / 2;
                }
                else if (raw[i] < 0.5 * sr)
                {
                    dim[dimi++] = raw[i];
                    normal[i] = (normalavg + raw[i]) / 2;
                }
                else
                {
                    normal[i] = raw[i];
                }
            }

            int n = normal.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        double temp = normal[j];
                        normal[j] = normal[j + 1];
                        normal[j + 1] = temp;
                    }
                }
            }

            return (bright, normal, dim);
        }
    }
}