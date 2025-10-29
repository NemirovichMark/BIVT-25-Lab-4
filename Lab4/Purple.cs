using System.Diagnostics.CodeAnalysis;
using System.Reflection.Metadata;
using static System.Net.Mime.MediaTypeNames;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            int imx = 0;
            double d = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                d += array[i];
                if (array[i] > array[imx])
                {
                    imx = i;
                }
            }
            double el = d / array.Length;
            for (int i = imx + 1; i < array.Length; ++i)
            {
                array[i] = el;
            }
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            int d1 = array.Length / 2 + array.Length % 2, d2 = array.Length / 2;
            even = new int[d1];
            for (int i = 0; i < array.Length; i += 2)
            {
                even[i / 2] = array[i];
            }
            odd = new int[d2];
            for (int i = 1; i < array.Length; i += 2)
            {
                odd[i / 2] = array[i];
            }
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;
            answer = new int[array.Length + 1];
            double d = 0;
            for (int i = 0; i < array.Length; i++)
            {
                d += array[i];
            }
            double el = d / array.Length;
            int ibest = 0;
            for (int i = 1; i < array.Length; ++i)
            {
                if (Math.Abs(el - array[ibest]) > Math.Abs(el - array[i]))
                {
                    ibest = i;
                }
            }
            for (int i = 0; i <= ibest; ++i)
            {
                answer[i] = array[i];
            }
            answer[ibest + 1] = P;
            
            for (int i = ibest + 1; i < array.Length; ++i)
            {
                answer[i + 1] = array[i];
            }

            return answer;
        }
        public void Task4(int[] array)
        {
            int pos = 0, neg = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                if (array[i] >= 0) ++pos;
                else ++neg;
            }
            int[] arraypos = new int[pos], arrayneg = new int[neg];
            int nowpos = 0, nowneg = 0;
            for (int i = 0; i < array.Length; ++i)
            {
                
                if (array[i] >= 0){
                    arraypos[nowpos++] = array[i]; 
                } else
                {
                    arrayneg[nowneg++] = array[i];
                }
            }
            for (int i = 0; i < pos; ++i)
            {
                array[i] = arraypos[i];
            }
            for (int i = pos; i < array.Length; ++i)
            {
                array[i] = arrayneg[i - pos];
            }
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            if (k > A.Length)
            {
                return A;
            }
            int[] answer = new int[A.Length + B.Length];
            for (int i = 0; i < k; ++i)
            {
                answer[i] = A[i];
            }
            for (int i = 0; i < B.Length; ++i)
            {
                answer[k + i] = B[i];
            }
            for (int i = k; i < A.Length; ++i)
            {
                answer[i + B.Length] = A[i];
            }


            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            if (A.Length != B.Length)
            {
                return (null, null);
            }
            int[] sum = new int[A.Length], dif = new int[A.Length];

            for (int i = 0; i < A.Length; ++i)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
           
            double[] normalized = new double[array.Length];

           
            int mn = array[0], mx = array[0];
            for (int i = 0; i < array.Length; ++i)
            {
                mn = Math.Min(array[i], mn);
                mx = Math.Max(array[i], mx);
            }
            if (mn == mx)
            {
                return null;
            }
            for (int i = 0; i < array.Length; ++i)
            {
                normalized[i] = -1 + (double)(array[i] - mn) / (double)(mx - mn) * 2.0;
            }
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = new int [A.Length + B.Length];
            for (int i = 0; i < A.Length; ++i)
            {
                for (int j = 0; j < A.Length - 1 - i; ++j)
                {
                    if (A[j] < A[j + 1])
                    {
                        (A[j], A[j + 1]) = (A[j + 1], A[j]);
                    }
                }
            }
            for (int i = 0; i < B.Length; ++i)
            {
                for (int j = 0; j < B.Length - 1 - i; ++j)
                {
                    if (B[j] < B[j + 1])
                    {
                        (B[j], B[j + 1]) = (B[j + 1], B[j]);
                    }
                }
            }
            int ai = 0, bi = 0;
            for (int i = 0; i < C.Length; ++i)
            {
                if (ai == A.Length || ((bi != B.Length) && A[ai] < B[bi]))
                {
                    C[i] = B[bi++];
                } else
                {
                    C[i] = A[ai++];
                }
            }

            // code here

            // end

            return C;
        }
        public void Task9(int[] array)
        {
            int imx = 0;
            for (int i = 0; i <  array.Length; ++i)
            {
                if (array[imx] < array[i]) imx = i;
            }
            for (int i = 0; i < imx; ++i)
            {
                for (int j = array.Length - 1; j >= 1; --j)
                {
                    (array[j], array[j - 1]) = (array[j - 1], array[j]);
                }
            }

        }
        public void Task10(int[] array, int N)
        {
            N--;
            for (int i = 1; N + i < array.Length && N - i >= 0; ++i)
            {
                array[N + i] = array[N - i];
            }

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
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
            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;
            if (raw.Length == 0) return (null, null, null);
            double sm = 0;
            for (int i = 0; i < raw.Length; ++i)
            {
                sm += raw[i];
            }
            double av = sm / raw.Length;
            int cntb = 0, cntd = 0;
            for (int i = 0; i < raw.Length; ++i)
            {
                if (raw[i] > av * 2)
                {
                    cntb++;
                } else if (raw[i] < av / 2)
                {
                    cntd++;
                }
            }
            bright = new double[cntb]; dim = new double[cntd];
            normal = new double[raw.Length - cntd - cntb];
            cntb = 0; cntd = 0;
            for (int i = 0; i < raw.Length; ++i)
            {
                if (raw[i] > av * 2)
                {
                    bright[cntb++] = raw[i];
                } else if (raw[i] < av / 2)
                {
                    dim[cntd++] = raw[i];
                } else
                {
                    normal[i - cntb - cntd] = raw[i];
                }
            }
            double avold = av;
            av = 0; sm = 0;
            for (int i = 0; i < normal.Length; ++i)
            {
                sm += normal[i];
            }
            
            av = sm / normal.Length;
            for (int i = 0; i < raw.Length; ++i)
            {
                if (raw[i] > avold * 2 || raw[i] < avold / 2)
                {
                    raw[i] = (av + raw[i]) / 2;
                }
            }
            normal = raw;
            for (int i = 0; i < normal.Length; ++i)
            {
                for (int j = 0; j < normal.Length - i - 1; ++j)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                    }
                }
            }
            return (bright, normal, dim);
        }
    }
}