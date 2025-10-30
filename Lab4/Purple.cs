using System.ComponentModel.Design;
using System.Linq.Expressions;
using System.Transactions;
using System.Xml.Schema;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int n = array.Length; double sum = 0; double sa = 0;
            double max = double.MinValue; int index = 0;

            for (int i = 0; i < n; i++)
            {
                sum += array[i];
                if (array[i] > max)
                {
                    max = array[i];
                }
            }

            sa = (double)sum / n;

            for (int i = 0; i < n; i++)
            {
                if (array[i] == max)
                {
                    index = i;
                    break;
                }
            }

            for (int i = index + 1; i < n; i++)
            {
                array[i] = sa;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int el = (array.Length + 1) / 2;
            int ol = (array.Length) / 2;

            even = new int[el]; odd = new int[ol];
            int ei = 0; int oi = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[ei++] = array[i];
                }
                else
                {
                    odd[oi++] = array[i];
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
            double a = 0; double s = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            a = (double)s / array.Length;

            int ci = 0;
            double mindiff = Math.Abs(array[0] - a);
            
            for (int i = 0; i < array.Length; i++)
            {
                double diff = Math.Abs(array[i] - a);
                if (diff < mindiff)
                {
                    mindiff = diff;
                    ci = i;
                }
            }

            for (int i = 0; i <= ci; i++)
            {
                answer[i] = array[i];
            }

            answer[ci + 1] = P;

            for (int i = ci + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];   
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int nl = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { nl++; }
            }

            int pl = array.Length - nl;
            int[] p = new int[pl]; int[] n = new int[nl];

            int pi = 0; int ni = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    n[ni++] = array[i];
                }
                else
                {
                    p[pi++] = array[i];
                }
            }

            int i2 = 0;
            for (int i = 0; i < pi; i++)
            {
                array[i] = p[i];
                i2++;
            }
            for (int i = 0; i < ni; i++)
            {
                array[i2 + i] = n[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k < A.Length)
            {
                answer = new int[A.Length + B.Length];
                int ia = 0;
                for (int i = 0; i < k; i++)
                {
                    answer[ia++] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[ia++] = B[i];
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[ia++] = A[i];
                }
            }
            else if (k == A.Length)
            {
                answer = new int[A.Length + B.Length];
                int ia = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    answer[ia++] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[ia++] = B[i];
                }
            }
            else if (k >  A.Length) 
            {
                answer = new int[A.Length];
                int ia = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    answer[ia++] = A[i];
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
                sum = new int[A.Length]; dif = new int[A.Length];

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
            int max = int.MinValue; int min = int.MaxValue;

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

            if (min == max)
            {
                return normalized;
            }

            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2 * (double)(array[i] - min)/(max - min) - 1;
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
                C[i] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[i + A.Length] = B[i];
            }

            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 1; j < C.Length; j++)
                {
                    if (C[j-1] < C[j])
                    {
                        (C[j - 1], C[j]) = (C[j], C[j - 1]);
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = int.MinValue; int mxi = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    mxi = i;
                }
            }

            int[] a = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (mxi + i < array.Length)
                {
                    a[mxi + i] = array[i];
                }
                else
                {
                    a[mxi + i - array.Length] = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = a[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int r = N; int l = N - 2;
            while (l >= 0 && r < array.Length)
            { 
                array[r] = array[l];
                r++; l--;
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            X = new double[n];
            Y = new double[n];

            if (n > 1)
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    X[i] = a + i * step;
                    Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
                }
            }
            else
            {
                X[0] = (b + a) / 2;
                double x = X[0];
                for (int i = 0; i < n; i++)
                {
                    Y[i] = Math.Cos(x) + x * Math.Sin(x);
                }
            }

            if (a == b && n == 1 || a < b)
            {
                int extCnt = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                    {
                        extCnt++;
                    }
                }

                Xext = new double[extCnt];
                Yext = new double[extCnt];
                int iext = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                    {
                        Xext[iext] = X[i];
                        Yext[iext] = Y[i];
                        iext++;
                    }
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sum = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            double a = sum / raw.Length;

            int brightCount = 0, nrmlCount = 0, dimCount = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * a)
                {
                    brightCount++;
                }
                else if (raw[i] < 0.5 * a)
                {
                    dimCount++;
                }
                else
                {
                    nrmlCount++;
                }
            }

            bright = new double[brightCount]; 
            dim = new double[dimCount];
            double[] nrml = new double[nrmlCount];

            int brightI = 0, dimI = 0, nrmlI = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * a)
                {
                    bright[brightI++] = raw[i];
                }
                else if (raw[i] < 0.5 * a)
                {
                    dim[dimI++] = raw[i];
                }
                else
                {
                    nrml[nrmlI++] = raw[i];
                }
            }

            double nrmlSum = 0;
            for (int i = 0; i < nrmlCount; i++)
            {
                nrmlSum += nrml[i];
            }
            double nrmlAv = nrmlSum / nrmlCount;

            normal = new double[raw.Length];
            int normalI = 0;

            for (int i = 0; i < nrmlCount; i++)
            {
                normal[normalI++] = nrml[i];
            }
            for (int i = 0; i < brightCount; i++)
            {
                normal[normalI++] = (nrmlAv + bright[i]) / 2;
            }
            for (int i = 0; i < dimCount; i++)
            {
                normal[normalI++] = (nrmlAv + dim[i]) / 2;
            }

            for (int i = 0; i < normal.Length; i++)
            {
                for (int j = 1; j < normal.Length; j++)
                {
                    if (normal[j-1] < normal[j])
                    {
                        (normal[j - 1], normal[j]) = (normal[j], normal[j - 1]);
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}
