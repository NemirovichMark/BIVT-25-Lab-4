using System.Numerics;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here

            for (int i = 0; i < vector.Length; i++)
            {
                length += vector[i] * vector[i];
            }
            length = Math.Sqrt(length);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here


            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > P && array[i] < Q)
                {
                    count++;
                }
            }

            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here

            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            if (array.Length > max + 1)
            {
                int w = 0;
                for (int i = max + 1; i < array.Length; i++)
                {
                    if (array[i] == array[i - 1])
                    {
                        w++;
                    }
                }
                if (w < array.Length - max - 1 - 1)
                {
                    int min = max;
                    for (int i = max + 1; i < array.Length; i++)
                    {
                        if (array[i] < array[min])
                        {
                            min = i;
                        }
                    }
                    (array[max], array[min]) = (array[min], array[max]);
                }
            }

            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array.Length == 0) return;

            int max = 0;
            for (int i = 2; i < array.Length; i += 2)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }

            array[max] = max;

            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here

            index = -1;
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


            int max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            if (max > 1)
            {
                for (int i = 0; i < max - 1; i += 2)
                {
                    (array[i], array[i + 1]) = (array[i + 1], array[i]);
                }
            }

            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here

            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    c++;
                }
            }
            int[] b = new int[c];
            c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    b[c++] = array[i];
                }
            }
            answer = b;
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here

            for (int i = 0; i < array.Length; i++)
            {
                bool H = false;
                for (int j = 0; j < array.Length - 1; j++)
                {
                    if (array[j] < array[j + 1])
                    {
                        (array[j], array[j + 1]) = (array[j + 1], array[j]);
                        H = true;
                    }

                }
                if (!H) break;
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here

            int l = 0, r = array.Length - 1;
            while (l < r)
            {
                (array[l], array[r]) = (array[r], array[l]);
                l++;
                r--;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            if (A == null && B == null)
            {
                return new int[0];
            }

            if (A == null)
            {
                int[] copyB = new int[B.Length];
                for (int i = 0; i < B.Length; i++)
                {
                    copyB[i] = B[i];
                }
                return copyB;
            }

            if (B == null || B.Length == 0)
            {
                int[] copyA = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    copyA[i] = A[i];
                }
                return copyA;
            }

            C = new int[A.Length + B.Length];
            int indexA = 0;
            int indexB = 0;
            int indexC = 0;

            while (indexA < A.Length && indexB < B.Length)
            {
                C[indexC++] = A[indexA++];
                C[indexC++] = B[indexB++];
            }

            while (indexA < A.Length)
            {
                C[indexC++] = A[indexA++];
            }

            while (indexB < B.Length)
            {
                C[indexC++] = B[indexB++];
            }

            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here

            if (a == b)
            {
                if (n == 1)
                {
                    array = new double[] { 1 };
                }
            }
            else if (n >= 2)
            {
                array = new double[n];
                double s = (b - a) / (n - 1);

                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * s;
                }
            }
            // end

            return array;
        }
        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here

            if (raw.Length < 3)
                return null;

            bool allDamaged = true;
            foreach (int value in raw)
            {
                if (value != -1)
                {
                    allDamaged = false;
                    break;
                }
            }
            if (allDamaged)
            {
                double[] result = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                    result[i] = raw[i];
                return result;
            }
            restored = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
                restored[i] = raw[i];


            for (int i = 0; i < restored.Length; i++)
            {
                if (restored[i] == -1)
                {
                    int l = (i - 1 + restored.Length) % restored.Length;
                    int r = (i + 1) % restored.Length;

                    double leftV = restored[l];
                    double rightV = restored[r];

                    if (leftV != -1 && rightV != -1)
                    {
                        restored[i] = (leftV + rightV) / 2.0;
                    }
                }
            }
            // end

            return restored;
        }
    }
}
