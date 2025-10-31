using System.Security.Cryptography;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double max = double.MinValue, sum = 0;
            int max_i = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_i = i;
                }
                sum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i > max_i)
                {
                    array[i] = (sum / array.Length);
                }

            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int amount_even = 0, amount_odd = 0;
            if (array.Length % 2 == 0)
            {
                amount_even = array.Length / 2;
                amount_odd = array.Length / 2;
            }
            else
            {
                amount_even = array.Length / 2 + 1;
                amount_odd = array.Length / 2;
            }
            even = new int[amount_even];
            odd = new int[amount_odd];
            int ei = 0, oi = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (i % 2 == 0)
                {
                    even[ei] = array[i];
                    ei++;
                }
                else
                {
                    odd[oi] = array[i];
                    oi++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double e = 10000000;
            double mid = 0;
            int index = -1;
            foreach (int i in array)
            {
                mid += i;
            }
            mid = mid / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(mid - array[i]) < e)
                {
                    e = Math.Abs(mid - array[i]);
                    index = i;
                }
            }
            answer = new int[array.Length + 1];
            for (int i = 0; i < answer.Length; i++)
            {
                if (i <= index)
                {
                    answer[i] = array[i];
                }
                else if (i == index + 1)
                {
                    answer[i] = P;
                }
                else
                {
                    answer[i] = array[i - 1];
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int positive = 0, negative = 0, n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    negative++;
                }
                else
                {
                    positive++;
                }
            }
            int[] pos = new int[positive], neg = new int[negative];
            positive = 0;
            negative = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    neg[negative] = array[i];
                    negative++;
                }
                else
                {
                    pos[positive] = array[i];
                    positive++;
                }
            }
            positive = 0;
            negative = 0;
            for (int i = 0; i < n; i++)
            {
                if (i >= pos.Length)
                {
                    array[i] = neg[negative];
                    negative++;
                }
                else
                {
                    array[i] = pos[positive];
                    positive++;
                }
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            int n = A.Length + B.Length;
            answer = new int[n];
            if (k <= A.Length)
            {
                for (int i = 0; i < n; i++)
                {
                    if (i < k)
                    {
                        answer[i] = A[i];
                    }
                    else if (i < k + B.Length)
                    {
                        answer[i] = B[i - k];
                    }
                    else if (A.Length != k)
                    {
                        answer[i] = A[i - B.Length];
                    }
                }
            }
            else
            {
                answer = A;
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
                for (int i = 0; i < A.Length; i++)
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
            double min = double.MaxValue, max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                }
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            if (!(max == min))
            {
                normalized = new double[array.Length];
                for (int i = 0;i < array.Length; i++)
                {
                    normalized[i] = (array[i] - min) / (max - min) * 2 - 1;
                }
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int i = 1, j = 0, k = 0;
            int lA = A.Length, lB = B.Length;
            while (i < lA)
            {
                if (i == 0 || A[i] <= A[i - 1])
                {
                    i++;
                }
                else
                {
                    (A[i], A[i - 1]) = (A[i - 1], A[i]);
                    i--;
                }
            }
            i = 1;
            while (i < lB)
            {
                if (i == 0 || B[i] <= B[i - 1])
                {
                    i++;
                }
                else
                {
                    (B[i], B[i - 1]) = (B[i - 1], B[i]);
                    i--;
                }
            }
            i = 0;
            C = new int[lA + lB];
            while ((i < lA) && (j < lB))
            {
                if (A[i] > B[j])
                {
                    C[k++] = A[i++];
                }
                else
                {
                    C[k++] = B[j++];
                }
            }
            while (i < lA)
            {
                C[k++] = A[i++];
            }
            while (j < lB)
            {
                C[k++] = B[j++];
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = int.MinValue, max_i = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_i = i;
                }
            }
            int[] temp = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                temp[((i + max_i) % array.Length)] = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int i = 1;
            while (true)
            {
                if ((N + i <= array.Length) && (N - i > 0))
                {
                    array[N + i - 1] = array[N - i - 1];
                    i++;
                }
                else
                {
                    break;
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (!(((a == b) && (n > 1)) || (a > b)))
            {
                double step = (b - a) / (n - 1);
                X = new double[n];
                Y = new double[n];
                int ext_count = 0;
                int count = 0;
                for (double i = a; i < (b + 0.00001); i += step)
                {
                    X[count] = i;
                    Y[count] = Math.Cos(i) + i * Math.Sin(i);
                    count++;
                }
                for (int p = 0; p < n; p++)
                {
                    if (!(p == 0 || p == (n - 1)))
                    {
                        if ((Y[p] > Y[p - 1] && Y[p] > Y[p + 1]) || (Y[p] < Y[p - 1] && Y[p] < Y[p + 1]))
                        {
                            ext_count++;
                        }
                    }
                }
                Xext = new double[ext_count];
                Yext = new double[ext_count];
                ext_count = 0;
                count = 0;
                for (double i = a; i < (b + 0.00001); i += step)
                {
                    if (!(count == 0 || count == n - 1))
                    {
                        if ((Y[count] > Y[count - 1] && Y[count] > Y[count + 1]) || (Y[count] < Y[count - 1] && Y[count] < Y[count + 1]))
                        {
                            Xext[ext_count] = X[count];
                            Yext[ext_count] = Y[count];
                            ext_count++;
                        }
                    }
                    count++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            int n = raw.Length, d = 0, b = 0;
            double mid = 0;
            for (int i = 0; i < n; i++)
            {
                mid += raw[i];
            }
            mid = mid / n;
            double left_mid = 0;
            int left = 0;
            for (int i = 0; i < n; i++)
            {
                if ((raw[i] >= (mid / 2)) && (raw[i] <= (2 * mid)))
                {
                    left_mid += raw[i];
                    left++;
                }
                else if (raw[i] <= (mid / 2))
                {
                    d++;
                }
                else
                {
                    b++;
                }
            }
            bright = new double[b];
            normal = new double[n];
            dim = new double[d];
            b = 0;
            d = 0;
            left_mid = left_mid / left;
            for (int i = 0; i < n; i++)
            {
                if ((raw[i] >= (mid / 2)) && (raw[i] <= (2 * mid)))
                {
                    normal[i] = raw[i];
                }
                else if (raw[i] <= (mid / 2)) 
                {
                    normal[i] = ((raw[i] + left_mid) / 2);
                    dim[d] = raw[i];
                    d++;
                }
                else
                {
                    normal[i] = ((raw[i] + left_mid) / 2);
                    bright[b] = raw[i];
                    b++;
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}