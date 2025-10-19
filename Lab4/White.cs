﻿namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            if (vector == null || vector.Length == 0)
                return 0;
            double sum = 0;
            foreach (int x in vector)
            {
                sum += x * x;
            }
            length = System.Math.Sqrt(sum);
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            if (array == null || array.Length == 0)
                return 0;
            int min = System.Math.Min(P, Q);
            int max = System.Math.Max(P, Q);
            foreach (int x in array)
            {
                if (x > min && x < max)
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

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                    maxIdx = i;
            }

            if (maxIdx == array.Length - 1)
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

            if (minIdx == -1 || array[maxIdx] == array[minIdx])
                return;

            int temp = array[maxIdx];
            array[maxIdx] = array[minIdx];
            array[minIdx] = temp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;
            int maxIdx = -1;
            int maxVal = int.MinValue;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    maxIdx = i;
                }
            }
            if (maxIdx != -1)
                array[maxIdx] = maxIdx;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = -1;

            // code here
            if (array == null || array.Length == 0)
                return -1;
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

            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx])
                    maxIdx = i;
            }
            if (maxIdx < 2)
                return;
            for (int i = 0; i + 1 < maxIdx; i += 2)
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
            if (array == null || array.Length == 0)
                return new int[0];
            int count = 0;
            foreach (int x in array)
                if (x >= 0)
                    count++;
            answer = new int[count];
            int idx = 0;
            foreach (int x in array)
                if (x >= 0)
                    answer[idx++] = x;
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;
            // Simple stable bubble sort for decreasing
            for (int i = 0; i < array.Length - 1; i++)
            {
                for (int j = 0; j < array.Length - i - 1; j++)
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
            if (array == null || array.Length <= 1)
                return;
            int n = array.Length;
            for (int i = 0; i < n / 2; i++)
            {
                int temp = array[i];
                array[i] = array[n - 1 - i];
                array[n - 1 - i] = temp;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if ((A == null || A.Length == 0) && (B == null || B.Length == 0))
                return new int[0];
            if (A == null || A.Length == 0)
                return (int[])B.Clone();
            if (B == null || B.Length == 0)
                return (int[])A.Clone();

            int lenA = A.Length, lenB = B.Length;
            C = new int[lenA + lenB];
            int i = 0, j = 0, k = 0;
            while (i < lenA && j < lenB)
            {
                C[k++] = A[i++];
                C[k++] = B[j++];
            }
            while (i < lenA)
                C[k++] = A[i++];
            while (j < lenB)
                C[k++] = B[j++];
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (n <= 0)
                return null;
            if (a == b)
            {
                if (n == 1)
                {
                    array = new double[1];
                    array[0] = a;
                    return array;
                }
                else
                    return null;
            }
            array = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                array[i] = a + step * i;
            }
            // Если a > b, то step отрицательный, что корректно
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null || raw.Length < 3)
                return null;
            bool allNeg = true;
            foreach (double x in raw)
                if (x != -1)
                {
                    allNeg = false;
                    break;
                }
            if (allNeg)
                return (double[])raw.Clone();

            restored = (double[])raw.Clone();
            int n = raw.Length;
            for (int i = 0; i < n; i++)
            {
                if (restored[i] == -1)
                {
                    double prev = restored[(i - 1 + n) % n];
                    double next = restored[(i + 1) % n];
                    if (prev != -1 && next != -1)
                        restored[i] = (prev + next) / 2.0;
                }
            }
            // end

            return restored;
        }
    }
}
