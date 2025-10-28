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
            int n = array.Length;
            int cnt1 = 0,  cnt2 = 0;
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
            //int[] answer = null;

            // code here
            if (k > A.Length)
            {
                return A;
            }
            int[] answer = new int[A.Length + B.Length];
            for (int i = 0; i < k; i++)
            {
                answer[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                answer[k + i] = B[i];
            }
            for (int i = k; i < A.Length; i++)
            {
                answer[i + B.Length] = A[i];
            }
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

            for (int i = 0; i < array.Length; i++)
            {
                mx = Math.Max(mx, array[i]);
                mn = Math.Min(mn, array[i]);
            }

            if (mx == mn)
            {
                return null;
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
            int mx = 0;
            int[] rev = new int[C.Length];
            for (int i = 0; i < C.Length; i++)
            {
                mx = i;
                for (int j = i; j < C.Length; j++)
                {
                    if (C[mx] < C[j])
                    {
                        mx = j;
                    }

                }
                rev[i] = C[mx];
                (C[mx], C[i]) = (C[i], C[mx]);
            }
            C = rev;
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
            if (N <= array.Length && N != 0)
            {
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
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            
            if (a == b && n == 1)
            {
                return (new double[0], new double[0]);
            }
            if (a > b || a == b && n > 1)
            {
                return (null, null);
            }
            Y = new double[n]; X = new double[n];
            double x = a;
            double y = 0;
            double move = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                y = Math.Cos(x) + x * Math.Sin(x);
                Y[i] = y; X[i] = x;
                x += move;
            }

            int cnt = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1] || Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                {
                    cnt++;
                }
            }

            Yext = new double[cnt];
            Xext = new double[cnt];
            int ind = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1] || Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                {
                    Yext[ind] = Y[i];
                    Xext[ind] = X[i];
                    ind++;
                }
            }

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            if (raw.Length == 0)
            {
                return (null, null, null);
            }
            double sr = 0;
            for (int i = 0; i < raw.Length; ++i)
            {
                sr += raw[i];
            }
            sr /= raw.Length;
            int cntb = 0, cntd = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > sr * 2)
                {
                    cntb++;
                }
                else if (raw[i] < sr / 2)
                {
                    cntd++;
                }
            }
            bright = new double[cntb];
            dim = new double[cntd];
            normal = new double[raw.Length - cntd - cntb];
            cntb = 0; cntd = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > sr * 2)
                {
                    bright[cntb++] = raw[i];
                }
                else if (raw[i] < sr / 2)
                {
                    dim[cntd++] = raw[i];
                }
                else
                {
                    normal[i - cntb - cntd] = raw[i];
                }
            }

            double sr2 = 0;
            for (int i = 0; i < normal.Length; i++)
            {
                sr2 += normal[i];
            }

            sr2 /= normal.Length;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > sr * 2 || raw[i] < sr / 2)
                {
                    raw[i] = (sr2 + raw[i]) / 2;
                }
            }
            normal = raw;
            bool fl;
            for (int i = 0; i < normal.Length; i++)
            {
                fl = false;
                for (int j = 1; j < normal.Length; j++)
                {
                    if (normal[j] > normal[j - 1])
                    {
                        (normal[j], normal[j - 1]) = (normal[j - 1], normal[j]);
                        fl = true;
                    }
                }
                if (!fl)
                {
                    break;
                }
            }
            //end

            return (bright, normal, dim);
        }
    }
}
