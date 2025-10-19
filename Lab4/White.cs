namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null || vector.Length == 0)
            {
                length = 0;
            }
            else
            {
                double sum = 0.0;
                for (int i = 0; i < vector.Length; i++)
                {
                    double v = vector[i];
                    sum += v * v;
                }
                length = System.Math.Sqrt(sum);
            }
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0)
            {
                count = 0;
            }
            else
            {
                int min = System.Math.Min(P, Q);
                int max = System.Math.Max(P, Q);
                int c = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    int x = array[i];
                    if (x > min && x < max) c++;
                }
                count = c;
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) 
                return;

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                    maxIdx = i;
            }

            // if after max there are no elements, do nothing
            if (maxIdx >= array.Length - 1)
                return;

            int minIdx = -1;
            int minVal = int.MaxValue;
            for (int i = maxIdx + 1; i < array.Length; i++)
            {
                if (array[i] < minVal)
                {
                    minVal = array[i];
                    minIdx = i;
                }
            }

            if (minIdx == -1)
                return;

            // if min after max equals the max, do not change
            if (array[maxIdx] == array[minIdx])
                return;

            int tmp = array[maxIdx];
            array[maxIdx] = array[minIdx];
            array[minIdx] = tmp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            int bestIdx = -1;
            int bestVal = int.MinValue;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > bestVal)
                {
                    bestVal = array[i];
                    bestIdx = i;
                }
            }

            if (bestIdx != -1)
                array[bestIdx] = bestIdx;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            if (array == null || array.Length == 0)
            {
                // leave index = -1
            }
            else
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == P)
                    {
                        index = i;
                        break;
                    }
                }
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length < 2)
                return;

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                    maxIdx = i;
            }

            // swap neighboring pairs (0,1),(2,3),... that are located before maxIdx
            for (int i = 0; i + 1 < maxIdx; i += 2)
            {
                int tmp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = tmp;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null || array.Length == 0)
            {
                answer = new int[0];
            }
            else
            {
                int cnt = 0;
                for (int i = 0; i < array.Length; i++)
                    if (array[i] >= 0) cnt++;

                answer = new int[cnt];
                int k = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                        answer[k++] = array[i];
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length < 2)
                return;

            int n = array.Length;
            // stable bubble sort descending
            for (int i = 0; i < n - 1; i++)
            {
                bool swapped = false;
                for (int j = 0; j < n - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int tmp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = tmp;
                        swapped = true;
                    }
                }
                if (!swapped) break;
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length < 2)
                return;

            int n = array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int tmp = array[i];
                array[i] = array[n - 1 - i];
                array[n - 1 - i] = tmp;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            bool emptyA = (A == null || A.Length == 0);
            bool emptyB = (B == null || B.Length == 0);

            if (emptyA && emptyB)
            {
                C = new int[0];
            }
            else if (emptyA)
            {
                // copy B
                C = new int[B.Length];
                for (int i = 0; i < B.Length; i++) C[i] = B[i];
            }
            else if (emptyB)
            {
                // copy A
                C = new int[A.Length];
                for (int i = 0; i < A.Length; i++) C[i] = A[i];
            }
            else
            {
                int i = 0, j = 0, k = 0;
                C = new int[A.Length + B.Length];
                while (i < A.Length && j < B.Length)
                {
                    C[k++] = A[i++];
                    C[k++] = B[j++];
                }
                while (i < A.Length) C[k++] = A[i++];
                while (j < B.Length) C[k++] = B[j++];
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0)
            {
                array = null;
            }
            else if (a == b)
            {
                if (n == 1)
                    array = new double[] { a };
                else
                    array = null;
            }
            else
            {
                // Specification: in all other cases return null
                array = null;
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3)
            {
                restored = null;
            }
            else
            {
                int n = raw.Length;
                bool allNeg = true;
                for (int i = 0; i < n; i++)
                {
                    if (raw[i] != -1.0)
                    {
                        allNeg = false;
                        break;
                    }
                }

                // if all elements are -1 return a copy of the original array
                if (allNeg)
                {
                    restored = new double[n];
                    for (int i = 0; i < n; i++) restored[i] = raw[i];
                }
                else
                {
                    // copy raw
                    restored = new double[n];
                    for (int i = 0; i < n; i++) restored[i] = raw[i];

                    for (int i = 0; i < n; i++)
                    {
                        if (restored[i] == -1.0)
                        {
                            double left = restored[(i - 1 + n) % n];
                            double right = restored[(i + 1) % n];
                            if (left != -1.0 && right != -1.0)
                            {
                                restored[i] = (left + right) / 2.0;
                            }
                        }
                    }
                }
            }
            // end

            return restored;
        }
    }
}
