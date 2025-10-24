using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Security;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            double max_elem = double.MinValue, sum = 0;
            int idx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (max_elem < array[i])
                {
                    max_elem = array[i];
                    idx = i;
                }
            }
            double avg = sum / array.Length;
            for (int i = idx + 1; i < array.Length; i++)
            {
                array[i] = avg;
            }

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = new int[array.Length % 2 == 0 ? array.Length/2 : array.Length / 2 + 1], odd = new int[array.Length/2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i / 2] = array[i];
                }
                else
                {
                    odd[i / 2] = array[i];
                }
            }
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = new int[array.Length + 1];
            double sum = 0;
            int idx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            double avg = sum / array.Length, r = Math.Abs(avg - array[0]);
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - avg) < r)
                {
                    r = Math.Abs(array[i] - avg);
                    idx = i;
                }
            }


            for (int i = 0; i <= idx; i++)
            {
                answer[i] = array[i];
            }

            answer[idx + 1] = P;

            for (int i = idx + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            return answer;
        }
        public void Task4(int[] array)
        {
            int idx = array.Length - 1; 
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 0)
                {
                    for (int j = i; j < idx; j++)
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                    }
                    idx--;
                }
            }

        }
        public int[] Task5(int[] A, int[] B, int k)
        {


            int[] answer = new int[A.Length + B.Length];

            if (k > A.Length)
            {
                return A;
            }
            for (int i = 0; i < k; i++)
            {
                answer[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                answer[i + k] = B[i];
            }
            for (int i = k; i < A.Length; i++)
            {
                answer[B.Length + i] = A[i];
            }


            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            
                
            
            int[] sum = null, dif = null;
            if (A.Length == B.Length)
            {
                int[] s = new int[A.Length], d = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    s[i] = A[i] + B[i];
                    d[i] = A[i] - B[i];
                }
                sum = s;
                dif = d;
                
            }
            return (sum, dif);


            
        }
        public double[] Task7(int[] array)
        {
            
            double[] normalized = null;
            bool flag = true;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] != array[i])
                {
                    flag = false;
                }
            }
            if (!flag)
            {
                double min_elem = double.MaxValue, max_elem = double.MinValue;
                double[] norm = new double [array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    min_elem = Math.Min(min_elem, array[i]);
                    max_elem = Math.Max(max_elem, array[i]);
                }
                for (int i = 0;i < array.Length; i++)
                {
                    norm[i] = 2 * (array[i] - min_elem)/(max_elem - min_elem) - 1;
                }
                normalized = norm;
            }
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = new int [A.Length + B.Length];


            for (int i = 1; i < A.Length; i++)
            {
                if (A[i - 1] < A[i])
                {
                    for (int j = i; j >= 1; j--)
                    {
                        if (A[j - 1] < A[j])
                        {
                            (A[j - 1], A[j]) = (A[j], A[j - 1]);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            for (int i = 1; i < B.Length; i++)
            {
                if (B[i - 1] < B[i])
                {
                    for (int j = i; j >= 1; j--)
                    {
                        if (B[j - 1] < B[j])
                        {
                            (B[j - 1], B[j]) = (B[j], B[j - 1]);
                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            int a = 0, b = 0, c = 0;
            while ((a < A.Length || b < B.Length) && c < A.Length + B.Length)
            {
                if (a == A.Length)
                {
                    C[c] = B[b];
                    b++; c++;
                    continue;
                }
                else if (b == B.Length)
                {
                    C[c] = A[a];
                    a++; c++;
                    continue;
                }
                else if (A[a] >= B[b])
                {
                    C[c] = A[a];
                    a++; c++;
                    continue;
                }
                else
                {
                    C[c] = B[b];
                    b++; c++;
                }
            }

            return C;
        }
        public void Task9(int[] array)
        {

            int idx = 0, max_elem = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max_elem)
                {
                    idx = i;
                    max_elem = array[i];
                }
            }
            int[] new_array = new int[idx];
            for (int i = 0; i < idx; i++)
            {
                new_array[i] = array[array.Length - idx + i];
            }
            for (int i = array.Length - 1; i >= idx; i--)
            {
                array[i] = array[i - idx];
            }
            for (int i = 0; i < idx; i++)
            {
                array[i] = new_array[i];
            }

        }
        public void Task10(int[] array, int N)
        {
            N--;

            for (int i = N + 1; i < array.Length; i++)
            {
                if (N - (i - N) >= 0)
                    {
                        array[i] = array[N - (i - N)];
                    }
                else
                    {
                        break;
                    }
            }

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            if (a > b || (a == b && n != 1)) { return (null, null); }
            if (n <= 2) { return (new double[0], new double[0]); };


            double[] X = new double[n];
            double[] Y = new double[n];
            for (int i = 0; i < n; i++)
            {
                X[i] = a + (b - a) / (n - 1) * i;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }
            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) ||
                    (Y[i - 1] > Y[i] && Y[i] < Y[i + 1])) 
                {
                    count++;
                }
            }


            if (count == 0) { return (new double[0], new double[0]); }


            double[] Xext = new double[count];
            double[] Yext = new double[count];
            int index = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) ||
                    (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                {
                    Xext[index] = X[i];
                    Yext[index] = Y[i];
                    index++;
                }
            }
            return (Xext, Yext);
        }
        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            

            double sum = 0, avg = 0, avg_1 = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }


            avg = sum / raw.Length;
            int br_c = 0, dim_c = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (2 * raw[i] < avg)
                {
                    dim_c++;
                }
                else if (raw[i] > 2 * avg)
                {
                    br_c++;
                }
            }


            double[] bright = new double[br_c], normal = new double[raw.Length], dim = new double[dim_c];
            normal = raw;


            int[] idx = new int[dim_c + br_c];
            int o = 0, p = 0, r = 0; 
            for (int i = 0; i < raw.Length; i++)
            {
                if (2 * raw[i] < avg)
                {
                    dim[o] = raw[i];
                    idx[o + p] = i;
                    o++;
                }
                else if (raw[i] > 2 * avg)
                {
                    bright[p] = raw[i];
                    idx[o + p] = i;
                    p++;
                }
                else
                {
                    avg_1 += raw[i];
                }
            }
            if (dim_c + br_c == raw.Length)
            {
                return (bright, normal, dim);
            }
            avg_1 = avg_1 / (raw.Length - dim_c - br_c);
            foreach (int i in idx)
            {
                normal[i] = (normal[i] + avg_1)/2;
            }
            for (int i = 1; i < normal.Length; i++)
            {
                if (normal[i - 1] < normal[i])
                {
                    for (int j = i; j >= 1; j--)
                    {
                        if (normal[j - 1] < normal[j])
                        {
                            (normal[j - 1], normal[j]) = (normal[j], normal[j - 1]);

                        }
                        else
                        {
                            break;
                        }
                    }
                }
            }
            return (bright, normal, dim);





        }
        }
}