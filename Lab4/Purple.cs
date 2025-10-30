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

            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here

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
            if (N > 1)
            {
                int[] mirror = new int[N - 1];
                int K = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (i < N - 1)
                    {
                        mirror[i] = array[i];
                    }
                }
                if (N < array.Length)
                {
                    for (int i = N; i < array.Length; i++)
                    {
                        array[i] = mirror[^K];
                        K++;
                    }
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here

            // end

            return (bright, normal, dim);
        }
    }
 }
