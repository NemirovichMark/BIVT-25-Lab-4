using System.Data;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector != null && vector.Length > 0)
            {
                double sum = 0;
                for (int i = 0; i < vector.Length; i++)
                {
                    sum += vector[i] * vector[i];
                }
                length = Math.Sqrt(sum);
            }
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (array != null && array.Length > 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if ( array[i] > Math.Min(P, Q) && array[i] < Math.Max(P, Q) )
                    {
                        count++;
                    }
                }
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array != null && array.Length > 1)
            {
                int maxIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                        maxIndex = i;
                }

                if (maxIndex < array.Length - 1)
                {
                    int minIndex = maxIndex + 1;
                    for (int i = maxIndex + 2; i < array.Length; i++)
                    {
                        if (array[i] < array[minIndex])
                            minIndex = i;
                    }

                    if (array[minIndex] != array[maxIndex])
                    {
                        int temp = array[maxIndex];
                        array[maxIndex] = array[minIndex];
                        array[minIndex] = temp;
                    }
                }
            }
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array != null && array.Length > 0)
            {
                int maxIndex = 0;
                for (int i = 2; i < array.Length; i += 2)
                {
                    if (array[i] > array[maxIndex])
                        maxIndex = i;
                }
                array[maxIndex] = maxIndex;
            }
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;
            if (array != null)
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
            if (array != null && array.Length > 1)
            {
                int maxIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex])
                        maxIndex = i;
                }

                if (maxIndex > 0)
                {
                    for (int i = 0; i < maxIndex - 1; i += 2)
                    {
                        int temp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = temp;
                    }
                }
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array != null)
            {
                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0) count++;
                }

                answer = new int[count];
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                        answer[index++] = array[i];
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array != null && array.Length > 1)
            {
                for (int i = 0; i < array.Length - 1; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (array[j] > array[i])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            if (array != null && array.Length > 1)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int temp = array[i];
                    array[i] = array[array.Length - 1 - i];
                    array[array.Length - 1 - i] = temp;
                }
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A == null && B == null)
            {
                C = new int[0];
            }
            else if (A == null)
            {
                C = new int[B.Length];
                Array.Copy(B, C, B.Length);
            }
            else if (B == null)
            {
                C = new int[A.Length];
                Array.Copy(A, C, A.Length);
            }
            else
            {
                C = new int[A.Length + B.Length];
                int index = 0;
                int i = 0, j = 0;

                while (i < A.Length && j < B.Length)
                {
                    C[index++] = A[i++];
                    C[index++] = B[j++];
                }

                while (i < A.Length) C[index++] = A[i++];
                while (j < B.Length) C[index++] = B[j++];
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n == 1 && a == b)
            {
                array = new double[] { a };
            }
            else if (n > 1 && a != b)
            {
                array = new double[n];
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * step;
                }
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw != null && raw.Length >= 3)
            {
                restored = new double[raw.Length];
                Array.Copy(raw, restored, raw.Length);
                if (restored[0] == -1 && restored[1] != -1 && restored[raw.Length - 1] != -1)
                {
                    restored[0] = (restored[1] + restored[raw.Length - 1]) / 2;
                }
                if (restored[raw.Length - 1] == -1 && restored[0] != -1 && restored[raw.Length - 2] != -1)
                {
                    restored[raw.Length - 1] = (restored[0] + restored[raw.Length - 2]) / 2;
                }
                for (int i = 1; i < raw.Length - 1; i++)
                {
                    double prev = restored[(i - 1)];
                    double next = restored[(i + 1)];
                    if (restored[i] == -1 && prev != -1 && next != -1)
                    {

                        restored[i] = (prev + next) / 2;

                    }
                }
            }
            // end

            return restored;
        }
    }
}
