using System.Diagnostics.CodeAnalysis;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            foreach (double x in vector) length += x * x;
            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (P > Q) (P, Q) = (Q, P);
            foreach (int x in array) if (x > P && x < Q) count++;
            return count;
            // end

            return count;
        }
        public void Task3(int[] array)
        {
            // code here
            int maxs = 0;
            for (int i = 1; i < array.Length; i++) if (array[i] > array[maxs]) maxs = i;
            if (maxs >= array.Length - 1) return;
            int minss = maxs + 1;
            for (int i = maxs + 2; i < array.Length; i++) if (array[i] < array[minss]) minss = i;
            (array[maxs], array[minss]) = (array[minss], array[maxs]);
            // end
        }
        public void Task4(int[] array)
        {
            // code here
            int max = 0;
            for (int i = 0; i < array.Length; i++)
                if ((array[i] > array[max]) && (i % 2 == 0)) max = i;
            array[max] = max;
            // end
        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
                else index = -1;
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length < 2) return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++) if (array[i] > array[maxIndex]) maxIndex = i;
            if (maxIndex < 2) return;
            for (int i = 0; i < maxIndex - 1; i += 2)
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            // end
        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int count = 0;
            for (int i = 0; i != array.Length; i++) if (array[i] < 0) count++;
            answer = new int[array.Length - count];
            count = 0;
            for (int i = 0; i != array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[count] = array[i];
                    count++;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {
            // code here
            int n = array.Length;
            for (int i = 0; i < n - 1; i++)
                for (int j = 0; j < n - 1; j++)
                    if (array[j] < array[j + 1]) { (array[j], array[j + 1]) = (array[j + 1], array[j]); }
            // end 
        }
        public void Task9(int[] array)
        {

            // code here
            int p = 0;
            for (int i = 0; i < array.Length; i++) p++;
            int[] finish = new int[p];
            int w = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                finish[w] = array[i];
                w++;
            }
            for (int i = 0; i < array.Length; i++) array[i] = finish[i];
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int q = 0,w = 0;
            for (int i = 0; i < C.Length; i++)
            {
                if (q < A.Length && w < B.Length)
                {
                    if (i % 2 == 0)
                    {
                        C[i] = A[q];
                        q++;
                    }
                    else
                    {
                        C[i] = B[w];
                        w++;
                    }
                }
                else if (q >= A.Length)
                {
                    C[i] = B[w];
                    w++;
                }
                else
                {
                    C[i] = A[q];
                    q++;
                }
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0) return null;
            if (n == 1)
            {
                if (a == b) return new double[] { a };
                else return null;
            }
            if (a == b) return null; 
            array = new double[n];
            if (a < b)
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++) array[i] = a + i * step;
            }
            else
            {
                double step = (a - b) / (n - 1);
                for (int i = 0; i < n; i++) array[i] = a - i * step;
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {

            double[] restored = null;

            // code here
            if (raw.Length < 3) return null;
            else
            {
                bool f = true;
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] != -1)
                    {
                        f = false;
                        break;
                    }
                }
                if (f)
                {
                    restored = new double[raw.Length];
                    for (int i = 0; i < raw.Length; i++) restored[i] = -1; 
                    return restored;
                }
                restored = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++) restored[i] = raw[i];
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] == -1)
                    {
                        double leftNeighbor;
                        if (i == 0) leftNeighbor = raw[raw.Length - 1]; else leftNeighbor = raw[i - 1];
                        double rightNeighbor;
                        if (i == raw.Length - 1) rightNeighbor = raw[0]; else rightNeighbor = raw[i + 1];
                        if (leftNeighbor != -1 && rightNeighbor != -1) restored[i] = (leftNeighbor + rightNeighbor) / 2;
                    }
                }
            }
            // end

            return restored;
        }
    }
}
