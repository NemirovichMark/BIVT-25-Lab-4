using System;
using System.Security.Cryptography;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double n = 0;

            for (int i = 0; i < vector.Length; i++)
            {
                n += Math.Pow(vector[i], 2);
            }
            length = Math.Sqrt(n);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            int max = Math.Max(Q, P);
            int min = Math.Min(Q, P);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < max && array[i]>min)
                {
                    count++;
                }
            }

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > array[maxIndex]) {
                    maxIndex= i;
                }
            }
            if (maxIndex == array.Length - 1) { return; }

            int min = maxIndex + 1;
            for (int i = maxIndex + 2; i < array.Length; i++)
            {
                if (array[i] < array[min]) { min = i; }
            }

            (array[maxIndex], array[min]) = (array[min], array[maxIndex]);
            Console.WriteLine(string.Join(",", array));
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > array[maxIndex])
                {
                    maxIndex= i;
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
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i]== P)
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
            for (int i =0; i < array.Length; i++)
            {
                if (array[i] > array[max]) { max = i; }
            }

            for (int i = 0; i < max-1; i+=2)
            {
                (array[i], array[i+1]) = (array[i+1], array[i]);
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int c = 0;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i]>=0)
                    c++;
            }

            answer = new int[c];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) { 
                answer[j] = array[i];
                j++; }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int k = 0; k < array.Length - i - 1; k++)
                {
                    if (array[k] < array[k + 1])
                    {
                        (array[k], array[k + 1]) = (array[k + 1], array[k]);
                    }
                }
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int[] arr = new int[array.Length];
            int j = 0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                arr[j] = array[i];
                j++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = arr[i];
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int indexA = 0;
            int indexB = 0;
            int indexC = 0;
            C = new int[A.Length + B.Length];
            // code here
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
             if (n <= 0) { return null; }
             if (n == 1)
            {
                if (a == b)
                {
                    return new double[] { a };
                }
                else
                {
                    return null;
                }
            }

            if (a == b) { return null; }


            array = new double[n];
            if (a < b)
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a + i * step;
                }
            }
            else 
            {
                double step = (a - b) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    array[i] = a - i * step;
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
            {
                return null;
            }

            else
            {
                bool allMinusOne = true;
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] != -1)
                    {
                        allMinusOne = false;
                        break;
                    }
                }

                if (allMinusOne)
                {
                    restored = new double[raw.Length];
                    for (int i = 0; i < raw.Length; i++)
                    {
                        restored[i] = -1;
                    }
                    return restored;
                }

                restored = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                {
                    restored[i] = raw[i];
                }

                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] == -1)
                    {
                        double leftNeighbor;
                        if (i == 0)
                        {
                            leftNeighbor = raw[raw.Length - 1];
                        }
                        else
                        {
                            leftNeighbor = raw[i - 1];
                        }

                        double rightNeighbor;
                        if (i == raw.Length - 1)
                        {
                            rightNeighbor = raw[0];
                        }
                        else
                        {
                            rightNeighbor = raw[i + 1];
                        }

                        if (leftNeighbor != -1 && rightNeighbor != -1)
                        {
                            restored[i] = (leftNeighbor + rightNeighbor) / 2;
                        }

                    }
                }
            }
            // end

            return restored;
        }
    }
}


