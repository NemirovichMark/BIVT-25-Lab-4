using System.Globalization;
using System.Numerics;
using System.Runtime.ExceptionServices;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double mx = -1000000;
            int indMx = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    indMx = i;
                }
                sum += array[i];
            }
            double middle = sum / array.Length;
            for (int i = array.Length - 1; i > indMx; i--)
                array[i] = middle;
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            even = new int[array.Length / 2 + array.Length % 2];
            odd = new int[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    even[i / 2] = array[i];
                else
                    odd[i / 2] = array[i];
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int[] nouns = new int[array.Length + 1];
            double dist = 100000;
            int sum = 0;
            double middle = 0;
            int indNear = 0;
            foreach (var i in array) sum += i;
            middle = (double)sum / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                double curDist = Math.Abs(middle - array[i]);
                if (dist > curDist)
                {
                    dist = curDist;
                    indNear = i;
                }
            }
            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i <= indNear) nouns[i] = array[i];
                else if (i == indNear + 1) nouns[i] = P;
                else nouns[i] = array[i - 1];
            }
            answer = nouns;
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int countNegative = 0;
            foreach (var i in array)
            {
                if (i < 0)
                    countNegative++;
            }
            int[] positives = new int[array.Length - countNegative];
            int[] negatives = new int[countNegative];
            int countPos = 0;
            int countNeg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negatives[countNeg] = array[i];
                    countNeg++;
                }
                else
                {
                    positives[countPos] = array[i];
                    countPos++;
                }
            }
            int curInd = 0;
            for (int i = 0; i < countPos; i++)
            {
                array[i] = positives[i];
                curInd++;
            }
            for (int i = 0; i < countNeg; i++) array[curInd + i] = negatives[i];

            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k == A.Length)
            {
                answer = new int[A.Length + B.Length];
                int id = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    answer[id++] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[id++] = B[i];
                }
            }
            else if (k < A.Length)
            {
                answer = new int[A.Length + B.Length];
                int id = 0;
                for (int i = 0; i < k; i++)
                {
                    answer[id] = A[i];
                    id += 1;
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[id] = B[i];
                    id += 1;
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[id] = A[i];
                    id += 1;
                }
            }
            else
            {
                answer = new int[A.Length];
                int id = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    answer[id++] = A[i];
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
            bool equal = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    equal = false;
                    break;
                }
            }
            int mx = int.MinValue;
            int mn = int.MaxValue;
            foreach (int i in array)
            {
                if (i > mx)
                    mx = i;
                if (i < mn)
                    mn = i;
            }
            if (!equal)
            {
                double normal = 0.0;
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normal = (double)(array[i] - mn) / (mx - mn);
                    normalized[i] = 2.0 * normal - 1;
                }
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int len = A.Length + B.Length;
            C = new int[len];
            int[] sorted = new int[len];
            for (int i = 0; i < A.Length; i++) C[i] = A[i];
            for (int i = 0; i < B.Length; i++) C[i + A.Length] = B[i];
            while (len != 0)
            {
                int mx = int.MinValue;
                int ind = 0;
                for (int i = 0; i < C.Length; i++)
                {
                    if (C[i] > mx)
                    {
                        mx = C[i];
                        ind = i;
                    }
                }
                sorted[C.Length - len] = mx;
                C[ind] = int.MinValue;
                len--;
            }
            C = sorted;
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = int.MinValue;
            int ind = 0;

            int[] preArray = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    ind = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (ind + i < array.Length)
                    preArray[ind + i] = array[i];
                else
                    preArray[i + ind - array.Length] = array[i];
            }
            for (int i = 0; i < array.Length; i++) array[i] = preArray[i];
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            //int[] preArray = new int[array.Length];
            int left = N - 2, right = N;
            while (left >= 0 && right < array.Length)
            {
                array[right] = array[left];
                right++;
                left--;
            }


            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            // ext mx: Yi-1 < Yi > Yi+1
            // ext mn: Yi-1 > Yi < Yi+1
            if (n == 1)
            {
                Xext = new double[0];
                Yext = new double[0];
                return (Xext, Yext);
            }

            if (n <= 2 || a >= b)
                return (Xext, Yext);

            X = new double[n];
            Y = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * step;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            int extremumCount = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                    extremumCount++;
            }

            Xext = new double[extremumCount];
            Yext = new double[extremumCount];
            if (extremumCount == 0)
            {
                return (Xext, Yext);
            }

            int extIndex = 0;

            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                {
                    Xext[extIndex] = X[i];
                    Yext[extIndex] = Y[i];
                    extIndex++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            int brightCount = 0;
            int dimCount = 0;
            double middleSum = 0;

            foreach (double x in raw)
                middleSum += x;

            middleSum /= raw.Length;

            foreach (double x in raw)
            {
                if (middleSum * 2 < x)
                    brightCount++;
                else if (middleSum * 0.5 > x)
                    dimCount++;
            }

            bright = new double[brightCount];
            dim = new double[dimCount];
            normal = new double[raw.Length];
            brightCount = 0;
            dimCount = 0;
            int normalCount = 0;
            double middleIgnoreSum = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (middleSum * 2 < raw[i])
                {
                    bright[brightCount++] = raw[i];
                }

                else if (middleSum * 0.5 > raw[i])
                {
                    dim[dimCount++] = raw[i];
                }
                else
                {
                    normalCount++;
                    middleIgnoreSum += raw[i];
                }
            }
            middleIgnoreSum /= normalCount;

            for (int i = 0; i < raw.Length; i++)
            {
                if (middleSum * 2 < raw[i] || middleSum * 0.5 > raw[i])
                {
                    raw[i] = (raw[i] + middleIgnoreSum) / 2;
                }
            }

            int len = raw.Length;
            double[] sorted = new double[len];
            while (len != 0)
            {
                double mx = double.MinValue;
                int ind = 0;
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] > mx)
                    {
                        mx = raw[i];
                        ind = i;
                    }
                }
                sorted[raw.Length - len] = mx;
                raw[ind] = double.MinValue;
                len--;
            }
            normal = sorted;
            // end

            return (bright, normal, dim);
        }
    }
}
