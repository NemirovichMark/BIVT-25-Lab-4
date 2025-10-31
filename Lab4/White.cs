using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null || vector.Length == 0)
                return 0;

            double sumSquares = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                sumSquares += vector[i] * vector[i];
            }

            length = Math.Sqrt(sumSquares);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0)
                return 0;

            int minValue = Math.Min(P, Q);
            int maxValue = Math.Max(P, Q);

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > minValue && array[i] < maxValue)
                    count++;
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            if (maxIndex == array.Length - 1)
                return;

            int minAfter = maxIndex + 1;
            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < array[minAfter])
                {
                    minAfter = i;
                }
            }

            bool allEqual = true;
            for (int i = maxIndex + 1; i < array.Length; i++)
            {
                if (array[i] != array[minAfter])
                {
                    allEqual = false;
                    break;
                }
            }

            if (!allEqual)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[minAfter];
                array[minAfter] = temp;
            }
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            int maxIndex = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            array[maxIndex] = maxIndex;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            index = -1;

            if (array == null)
                return index;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == P)
                {
                    index = i;
                    break;
                }
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex = i;
                }
            }

            for (int i = 0; i < maxIndex - 1; i += 2)
            {
                int temp = array[i];
                array[i] = array[i + 1];
                array[i + 1] = temp;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            if (array == null)
                return answer;

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    count++;
                }
            }

            answer = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[index] = array[i];
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - 1 - i; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            for (int i = 0; i < array.Length / 2; i++)
            {
                int temp = array[i];
                array[i] = array[array.Length - 1 - i];
                array[array.Length - 1 - i] = temp;
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
                return C;
            }

            if (A == null || A.Length == 0)
            {
                C = (int[])B.Clone();
                return C;
            }

            if (B == null || B.Length == 0)
            {
                C = (int[])A.Clone();
                return C;
            }

            C = new int[A.Length + B.Length];

            int indexA = 0;
            int indexB = 0;
            int indexC = 0;

            while (indexA < A.Length && indexB < B.Length)
            {
                C[indexC] = A[indexA];
                indexC++;
                indexA++;

                C[indexC] = B[indexB];
                indexC++;
                indexB++;
            }

            while (indexA < A.Length)
            {
                C[indexC] = A[indexA];
                indexC++;
                indexA++;
            }

            while (indexB < B.Length)
            {
                C[indexC] = B[indexB];
                indexC++;
                indexB++;
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0) return null;

            if (Math.Abs(a - b) < double.Epsilon)
            {
                if (n == 1)
                    array = new double[] { a };
                else
                    return null;
            }
            else
            {

                if (n < 2) return null;

                array = new double[n];
                double step = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                    array[i] = a + step * i;
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3)
                return null;

            restored = (double[])raw.Clone();

            for (int i = 0; i < restored.Length; i++)
            {
                if (restored[i] == -1)
                {
                    int prevIndex = i == 0 ? restored.Length - 1 : i - 1;
                    int nextIndex = i == restored.Length - 1 ? 0 : i + 1;

                    double prevValue = restored[prevIndex];
                    double nextValue = restored[nextIndex];

                    if (prevValue != -1 && nextValue != -1)
                    {
                        restored[i] = (prevValue + nextValue) / 2.0;
                    }
                }
            }
            // end

            return restored;
        }
    }
}