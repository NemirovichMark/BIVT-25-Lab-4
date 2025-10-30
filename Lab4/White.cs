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
            int max = 1000000000;
            int min = -1000000000;
            int indexmax = 0;
            int indexmin = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i]>min)
                {
                    min = array[i];
                    indexmax = i;
                }
            }
            for (int i = 0;i<array.Length; i++)
            {
                if (array[i]>min)
                {
                    min = array[i];
                    indexmin = i;
                }
            }
            int temp = 0;
            temp = array[indexmax];
            array[indexmax] = min;
            array[indexmin] = temp;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int max = 0;
            int index = 0;
            for (int i = 0;i<array.Length;i++)
            {
                if (array[i]>max)
                {
                    max = array[i]; 
                    index = i;
                }
            }
            array[index] = index;
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
            int index = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }

            for (int i = 0; i + 1 < index; i += 2)
            {
                int temp = 0;
                temp = array[i + 1];
                array[i + 1] = array[i];
                array[i] = temp;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int neg = 0;
            for (int i = 0; i<array.Length;i++)
            {
                if (array[i] >= 0) 
                {
                    neg++;
                }
            }
            int[] arr = new int[neg];
            int k = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    k++;   
                }
            }
            answer = arr;
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
            if (n <= 0 || (a != b && n == 1) || (a == b && n != 1))
            {
                return null;
            }

            if (a == b && n == 1)
            {
                return new double[] { a };
            }

            double[] newArray = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                double newValue = a + i * step;

                if (a < b)
                {
                    if (newValue <= b)
                        newArray[i] = newValue;
                    else
                        newArray[i] = b;
                }
                else
                {
                    if (newValue >= b)
                        newArray[i] = newValue;
                    else
                        newArray[i] = b;
                }
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
                return null;
            }
            bool allDamaged = true;
            foreach (double value in raw)
            {
                if (value != -1)
                {
                    allDamaged = false;
                    break;
                }
            }

            if (allDamaged)
            {
                return (double[])raw.Clone();
            }
            double[] rest = (double[])raw.Clone();

            bool changed;
            do
            {
                changed = false;
                for (int j = 0; j < rest.Length; j++)
                {
                    if (rest[j] == -1)
                    {
                        double left;
                        int leftIndex = (j == 0) ? rest.Length - 1 : j - 1;
                        left = rest[leftIndex];
                        double right;
                        int rightIndex = (j == rest.Length - 1) ? 0 : j + 1;
                        right = rest[rightIndex];
                        if (left != -1 && right != -1)
                        {
                            rest[j] = (left + right) / 2;
                            changed = true; 
                        }
                    }
                }
            } while (changed);
            // end

            return rest;
        }
    }
}
