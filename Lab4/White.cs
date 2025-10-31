using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            double sum = 0;
            double c = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                c = vector[i] * vector[i];
                sum += c;
                length = Math.Sqrt(sum);
            }
            // end

            return length;
        }
        public int Task2(int[] array, int P, int Q)
        {
            int count = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if(array[i] > P && array[i] < Q)
                    count++;
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int max = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[max])
                {
                    max = i;
                }
            }
            if (max == array.Length - 1)
            {
                return;
            }
            int min = max;
            for (int i = max + 1; i < array.Length; i++)
            {
                if (array[i] < array[min])
                {
                    min = i;
                }
            }
            if (array[max] != array[min])
            {
                (array[max], array[min]) = (array[min], array[max]);
            }
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int ind = -1;
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i += 2)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    ind = i;
                }
            }
            if (ind != -1)
            {
                array[ind] = ind;
            }
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
                    return index;
                }
            }
            return -1;
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = int.MinValue;
            int ind = 0;
            for(int i = 0; i < array.Length;i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    ind = i;
                }   
            }
            if (ind == 0)
                    return;
            for (int i = 0; i < ind - 1; i+=2)
            {
                (array[i], array[i + 1]) = (array[i + 1], array[i]);
            }
                // end

            }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                    k++;
            }
            if (k == array.Length)
                return array;
            answer = new int[k];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    answer[ind] = array[i];
                    ind++;
                }
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            int i = 1, n = array.Length;
            while (n > i)
            {
                if (i == 0 || array[i] <= array[i - 1])
                    i++;
                else
                {
                    (array[i], array[i - 1]) = (array[i - 1], array[i]);
                    i--;
                }
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int left = 0, right = array.Length - 1;
            while (left < right)
            {
                // Меняем местами элементы
                (array[left], array[right]) = (array[right], array[left]);
                // Сдвигаем указатели к центру
                left++;
                right--;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int ind = 0;
            for (int i = 0; i < Math.Max(A.Length, B.Length); i++)
            {
                if (i < A.Length)
                {
                    C[ind] = A[i];
                    ind++;
                }
                if (i < B.Length)
                {
                    C[ind] = B[i];
                    ind++;
                }
            }
            // end

            return C;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] array = null;

            // code here
            if (a == b && n == 1)
            {
                return new double[] { a };
            }
            if (n <= 1 || (a == b && n != 1))
            {
                return null;
            }
            array = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                array[i] = a + i * step;
            }
            // end

            return array;
        }

        public double[] Task12(double[] raw)
        {
            double[] restored = null;

            // code here
            if (raw == null)
            {
                return restored;
            }

            if (raw.Length < 3)
            {
                return restored;
            }

            bool dam = true;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] != -1)
                {
                    dam = false;
                    break;
                }
            }

            restored = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                restored[i] = raw[i];
            }

            if (dam)
            {
                return restored;
            }

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] == -1)
                {
                    int leftIndex = (i - 1 + raw.Length) % raw.Length;
                    int rightIndex = (i + 1) % raw.Length;

                    double leftValue = raw[leftIndex];
                    double rightValue = raw[rightIndex];

                    if (leftValue != -1 && rightValue != -1)
                    {
                        restored[i] = (leftValue + rightValue) / 2.0;
                    }
                }
            }
                // end

                return restored;
        }
    }
}