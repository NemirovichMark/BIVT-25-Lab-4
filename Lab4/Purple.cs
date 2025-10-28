using System.Globalization;
using System.Reflection.Emit;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sr = 0;
            int mx = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                sr += array[i];
                if (array[i] > array[mx])
                {
                    mx = i;
                }
            }
            sr /= n;
            for (int i = mx + 1; i < n; i++)
            {
                array[i] = sr;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int n = array.Length;
            even = new int[(n + 1) / 2];
            odd = new int[n / 2];
            for (int i = 0; i < n; i++)
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
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int mx = 0;
            double sr = 0;
            answer = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                sr += array[i];
            }
            sr /= n;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i] - sr) < Math.Abs(array[mx] - sr))
                {
                    mx = i;
                }
            }
            for (int i = 0; i < n + 1; i++)
            {
                if (i <= mx)
                {
                    answer[i] = array[i];
                }
                else if (i == mx + 1)
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
            int n = array.Length, cnt1 = 0,  cnt2 = 0;
            int last = n - 1;
            int value = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (array[i] < 0)
                {
                    cnt1++;
                }
                else
                {
                    cnt2++;
                }
            }
            int[] array1 = new int[cnt1];
            int[] array2 = new int[cnt2];
            cnt1 = 0;
            cnt2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    array1[cnt1] = array[i];
                    cnt1++;
                }
                else
                {
                    array2[cnt2] = array[i];
                    cnt2++;
                }
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array[i] = array2[i];
            }
            for (int i = 0; i < array1.Length; i++)
            {
                array[i + array2.Length] = array1[i];
            }
            // end
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            // if (k >= A.Length)
            // answer = new int[A.Length + B.Length];
            // for (int i = 0; i < k + 1; i++)
            // {
            //     answer[i] = A[i];
            // }
            // for (int i = 0; i < B.Length; i++)
            // {
            //     answer[i + B.Length] = B[i];
            // }
            // for (int i = 1; i < A.Length - k; i++)
            // {
            //     answer[i + B.Length + k] = A[k + i];
            // }
            int[] answer = new int[A.Length + B.Length];
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length != B.Length){
                return (null, null);
            }
            sum = new int[A.Length]; dif = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                sum[i] = A[i] + B[i]; dif[i] = A[i] - B[i];
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here

            normalized = new double[array.Length];
            bool fl = true;
            double mx = (double)(array[0]), mn = (double)(array[0]);
            int MaxInt = array[mx];

            for (int i = 0; i < array.Length; i++)
            {
                mx = Math.Max(mx, array[i]);
                mn = Math.Min(mn, array[i]);
            }

            if (mx == mn)
            {
                normalized = null;
            }

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = (array[i] - mn) / (mx - mn) * 2.0 - 1;
            }

            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            for (int i = 0; i < C.Length; i++)
            {
                if (i < A.Length)
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i - A.Length];
                }
            }
            Array.Sort(C);
            Array.Reverse(C);
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int[] answer = new int[array.Length];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[ind])
                {
                    ind = i;
                }
            }
            for (int i = 0; i < answer.Length; i++)
            {
                if (i + ind < answer.Length)
                {
                    answer[i + ind] = array[i];
                }
            }
            for (int i = 0; i < ind; i++)
            {
                answer[i] = array[array.Length - ind + i];
            }
            for (int i = 0; i < answer.Length; i++)
            {
                array[i] = answer[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N > array.Length || N == 0)
            {
                return array;
            }
            int cnt = N - 1;
            if (array.Length - N < cnt)
            {
                cnt = array.Length - N;
            }
            int[] test = new int[cnt];
            for (int i = 0; i < cnt; i++)
            {
                test[i] = array[N - i - 2];
            }
            for (int i = 0; i < cnt; i++)
            {
                array[N + i] = test[i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            
            double[] X = new double[n], Y = new double[n];
            double[] Xext = new double[0], Yext = new double[0];

            if (a == b && n == 1)
            {
                return (Xext, Yext);
            }
            if (a > b || n < 3 || (a == b && n > 1))
            {
                return (null, null);

            }
            double d = (b - a) / (n - 1);
            double x = a;
            for (int i = 0; i < n; ++i)
            {
                X[i] = x;
                Y[i] = Math.Cos(x) + x * Math.Sin(x);
                x += d;
            }
            int cnt = 0;
            for (int i = 1; i < n - 1; ++i)
            {
                if (Y[i - 1] < Y[i] && Y[i] > Y[i + 1] || Y[i - 1] > Y[i] && Y[i] < Y[i + 1]) ++cnt;
            }
            Xext = new double[cnt]; Yext = new double[cnt];
            int now = 0;
            for (int i = 1; i < n - 1; ++i)
            {
                if (Y[i - 1] < Y[i] && Y[i] > Y[i + 1] || Y[i - 1] > Y[i] && Y[i] < Y[i + 1])
                {
                    Xext[now] = X[i];
                    Yext[now] = Y[i];
                    now++;
                }
            }

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here

            double sr = 0;
            double S = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                S += raw[i];
            }
            sr = S / raw.Length;
            int cb = 0; int cd = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr)  cb++; 
                else if (raw[i] < sr / 2) cd++; 
            }
            bright = new double[cb]; normal = new double[raw.Length]; dim = new double[cd];
            int b = 0;
            int d = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr)
                {
                    bright[b++] = raw[i];
                }
                else if (raw[i] < sr / 2)
                {
                    dim[d++] = raw[i];
                }
            }
            double bb = 0;
            double dd = 0;
            double n = 0;
            for (int i = 0; i < bright.Length; i++)
            {
                bb += bright[i];
            }
            for (int i = 0; i < dim.Length; i++)
            {
                dd += dim[i];
            }
            n = (S - dd - bb) / (raw.Length - (cd+cb));
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr || raw[i] < sr / 2)
                {
                    normal[i] = (n + raw[i]) / 2;
                }
                else
                {
                    normal[i] = raw[i];
                }
            }
            for (int i = 0; i < normal.Length - 1; i++)
            {
                double max = normal[i];
                int indexofmax = i;
                for (int j = i + 1; j < normal.Length; j++)
                {
                    if (normal[j] > max)
                    {
                        max = normal[j];
                        indexofmax = j;
                    }
                }
                (normal[i], normal[indexofmax]) = (normal[indexofmax], normal[i]);
            }

            // end

            return (bright, normal, dim);
        }
    }
}
