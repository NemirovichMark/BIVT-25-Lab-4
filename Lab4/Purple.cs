using System.Security.Cryptography;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sr = 0, mx = array[0];
            int index_mx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sr += array[i];
                if (mx < array[i])
                {
                    mx = array[i];
                    index_mx = i;
                }
            }
            sr = (double) sr/array.Length;
            for (int i=index_mx+1; i<array.Length; i++)
            {
                array[i] = sr;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int count = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    count++;
                }
            }
            even = new int[count];
            odd = new int[array.Length - count];

            int index_even = 0, index_odd = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[index_even] = array[i];
                    index_even++;
                }
                else
                {
                    odd[index_odd] = array[i];
                    index_odd++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length + 1];
            double sr = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sr += array[i];
            }
            sr /= array.Length;
            double abs = Math.Abs(array[0] - sr);
            int index = 0, index_el = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - sr) < abs)
                {
                    abs = Math.Abs(array[i] - sr);
                    index_el = i;
                }
            }
            while (index < array.Length + 1)
            {
                if (index < index_el)
                {
                    answer[index] = array[index];
                }
                else if (index == index_el)
                {
                    answer[index] = array[index];
                    index++;
                    answer[index] = P;
                }
                else
                {
                    answer[index] = array[index - 1];
                }
                index++;
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] answer = new int[array.Length];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[index] = array[i];
                    index++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    answer[index] = array[i];
                    index++;
                }
            }

            for (int i=0; i < array.Length; i++)
            {
                array[i] = answer[i];
            }

            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length+ B.Length];
            int index = k;
            if (k >= A.Length)
            {
                return A;
            }
            for (int i = 0; i < A.Length + B.Length; i++)
            {
                if (i < k)
                {
                    answer[i] = A[i];
                }
                else if (index - k < B.Length)
                {
                    answer[i] = B[index - k];
                    index++;
                }
                else
                {
                    answer[i] = A[i - B.Length];
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i=0; i < A.Length; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            double min = array[0], max = array[0];
            bool b = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] != array[i - 1])
                {
                    b = true;
                }

            }
            if (b)
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = 2 * (array[i] - min) / (max - min) - 1;
                }
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        (A[j], A[j + 1]) = (A[j + 1], A[j]);
                    }
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B.Length - 1; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        (B[j], B[j + 1]) = (B[j + 1], B[j]);
                    }
                }
            }
            int index_a = 0, index_b = 0;
            while (index_a + index_b < A.Length + B.Length)
            {
                if (index_a == A.Length)
                {
                    C[index_a + index_b] = B[index_b];
                    index_b++;
                }
                else if (index_b == B.Length)
                {
                    C[index_a + index_b] = A[index_a];
                    index_a++;
                }
                else if (A[index_a] > B[index_b])
                {
                    C[index_a + index_b] = A[index_a];
                    index_a++;
                }
                else
                {
                    C[index_a + index_b] = B[index_b];
                    index_b++;
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = array[0], index = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }
            int[] answer = new int[array.Length];
            for (int i = 0;  i < array.Length; i++)
            {
                answer[(i+index)%array.Length] = array[i];
            }
            for (int i = 0;i < answer.Length; i++)
            {
                array[i] = answer[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            N--;
            if (N > array.Length - N)
            {
                for (int i = 0; i < array.Length - N; i++)
                {
                    array[i + N] = array[N - i];
                }
            }
            else
            {
                for (int i = 0; i < N + 1; i++)
                {
                    array[N + i] = array[N - i];
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a > b)
                return (null, null);
            if (a == b)
            {
                if (n == 1)
                    return (new double[0], new double[0]);
                else
                    return (null, null);
            }
            X = new double[n];
            Y = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * step;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }
            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    count++;
                }
            }
            if (count == 0)
            {
                Xext = new double[0];
                Yext = new double[0];
                return (Xext, Yext);
            }
            Xext = new double[count];
            Yext = new double[count];
            int k = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) ||
                    (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    Xext[k] = X[i];
                    Yext[k] = Y[i];
                    k++;
                }
            }
            // end


            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sm = 0, sr = 0;
            int count_bright = 0, count_dim = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sr += raw[i];
            }
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] * raw.Length > 2 * sr)
                {
                    count_bright++;
                    sm += raw[i];
                }
                else if (raw[i] * raw.Length * 2 < sr)
                {
                    count_dim++;
                    sm += raw[i];
                }
            }
            bright = new double[count_bright];
            dim = new double[count_dim];
            normal = new double[raw.Length];
            int index_bright = 0, index_dim = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] * raw.Length > 2 * sr)
                {
                    bright[index_bright] = raw[i];
                    normal[i] = (double)(Math.Abs(sm - sr) / (raw.Length - count_bright - count_dim) + raw[i]) / 2;
                    index_bright++;
                }
                else if (raw[i] * raw.Length * 2 < sr)
                {
                    dim[index_dim] = raw[i];
                    normal[i] = (double)(Math.Abs(sm - sr) / (raw.Length - count_bright - count_dim) + raw[i]) / 2;
                    index_dim++;
                }
                else
                {
                    normal[i] = raw[i];

                }
            }
            for (int i = 0; i < normal.Length; i++)
            {
                for (int j = 0; j < normal.Length - 1; j++)
                {
                    if (normal[j + 1] > normal[j])
                    {
                        (normal[j + 1], normal[j]) = (normal[j], normal[j + 1]);
                    }
                }
            }

            // end

            return (bright, normal, dim);
        }
    }
 }
