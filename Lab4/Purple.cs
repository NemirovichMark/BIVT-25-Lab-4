using System.Net.Mime;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sumOfArray = 0;
            double maxElem = double.MinValue;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElem)
                {
                    maxElem = array[i];
                    maxIndex = i;
                }
                sumOfArray += array[i];
            }
            double med = sumOfArray / array.Length;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                array[i] = med;
            }
            return;
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;
            int j = 0, k = 0;
            // code here
            if (array.Length % 2 == 0)
            {
                even = new int[array.Length / 2];
                odd = new int[array.Length / 2];
            }
            else
            {
                even = new int[array.Length / 2 + 1];
                odd = new int[array.Length / 2];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[j] = array[i];
                    j++;
                }
                else
                {
                    odd[k] = array[i];
                    k++;
                }
            }
            if (odd.Length == 0) odd = [];
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;
            int indexOfMinDiff = 0;
            double summOfArray = 0;
            // code here
            double minDifference = double.MaxValue;
            foreach (int i in array)
            {
                summOfArray += i;
            }
            double median = summOfArray / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - median) < minDifference)
                {
                    minDifference = Math.Abs(array[i] - median);
                    indexOfMinDiff = i;
                }
            }
            answer = new int[array.Length + 1];
            for (int i = 0; i <= indexOfMinDiff; i++)
            {
                answer[i] = array[i];
            }
            answer[indexOfMinDiff + 1] = P;
            for (int i = indexOfMinDiff + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int countPos = 0, countNeg = 0;
            foreach (int i in array)
            {
                if (i < 0) countNeg += 1;
                else countPos += 1;
            }
            int j = 0, k = 0;
            int[] neg = new int[countNeg];
            int[] pos = new int[countPos];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    neg[k] = array[i];
                    k++;
                }
                else
                {
                    pos[j] = array[i];
                    j++;
                }
            }
            for (int i = 0; i < pos.Length; i++)
            {
                array[i] = pos[i];
            }
            int m = 0; // переменная для нумерации индексов массива с отрицательными числами
            for (int i = pos.Length; i < array.Length; i++)
            {
                array[i] = neg[m];
                m++;
            }

            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {

            int[] answer = null;

            answer = new int[A.Length + B.Length];
            // code here
            if (k > A.Length) answer = A;
            else
            {
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
                    answer[B.Length + i] = A[i];
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A != null && A.Length == B.Length)
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
            double min = double.MaxValue;
            double max = double.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min) min = array[i];
                if (array[i] > max) max = array[i];
            }
            if (max == min) return null;
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2 * (array[i] - min) / (max - min) - 1; //вычитаем 1 ткесли не вычесть, то приведем к диапазону [0;1]
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
            for (int i = 0; i < C.Length - 1; i++)
            {
                for (int j = 0; j < C.Length - i - 1; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        int temp = C[j];
                        C[j] = C[j + 1];
                        C[j + 1] = temp;
                    }
                }
            }
            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int maxElem = -100000;
            int indexOfMax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxElem)
                {
                    maxElem = array[i];
                    indexOfMax = i;
                }
            }
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i - indexOfMax < 0)
                {
                    copy[i] = array[array.Length + i - indexOfMax];
                }
                else
                {
                    copy[i] = array[Math.Abs((i - indexOfMax) % array.Length)];
                }
            }
            for (int i = 0; i < array.Length; i++) array[i] = copy[i];
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int rightElems = array.Length - N;
            int leftElems = N - 1;
            int elemsToSub;
            if (rightElems > leftElems) elemsToSub = leftElems;
            else elemsToSub = rightElems;
            for (int i = 0; i < elemsToSub; i++)
            {
                array[N + i] = array[N - 2 - i];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (b < a || (b == a && n != 1))
            {
                Xext = null;
                Yext = null;
            }
            else
            {
                double step = (b - a) / (double)(n - 1);
                X = new double[n];
                Y = new double[n];
                double y;
                int k = 0;
                for (double x = a; x <= b; x += step)
                {
                    y = Math.Cos(x) + x * Math.Sin(x);
                    X[k] = x;
                    Y[k] = y;
                    k++;
                }
                int countExtremum = 0;
                for (int i = 1; i < (n - 1); i++)
                {
                    if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1]))
                    {
                        countExtremum++;
                    }
                }
                Xext = new double[countExtremum]; Yext = new double[countExtremum];
                int j = 0;
                for (int i = 1; i < (n - 1); i++)
                {
                    if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1]))
                    {
                        Xext[j] = X[i];
                        Yext[j] = Y[i];
                        j++;
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
            double totalSum = 0;
            double sumNorm = 0, countNorm = 0;
            int countBright = 0, countDim = 0;
            for (int i = 0; i < raw.Length; i++) totalSum += raw[i];
            double totalMedian = totalSum / raw.Length;
            foreach (double star in raw)
            {
                if (star > 2 * totalMedian) countBright++;
                else if (2 * star < totalMedian) countDim++;
            }
            bright = new double[countBright]; dim = new double[countDim];
            int b = 0, d = 0;
            foreach (double star in raw)
            {
                if (star > 2 * totalMedian)
                {
                    bright[b] = star;
                    b++;
                }
                else if (2 * star < totalMedian)
                {
                    dim[d] = star;
                    d++;
                }
                else
                {
                    sumNorm += star;
                    countNorm++;
                }
            }
            double normMedian = countNorm > 0 ? sumNorm / countNorm : 0;
            normal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * totalMedian || 2 * raw[i] < totalMedian)
                {
                    normal[i] = (raw[i] + normMedian) / 2;
                }
                else
                {
                    normal[i] = raw[i];
                }
            }
            for (int i = 0; i < normal.Length - 1; i++)
            {
                for (int j = 0; j < normal.Length - i - 1; j++)
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