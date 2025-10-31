using Microsoft.VisualBasic.FileIO;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Security;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int n = array.Length;
            double sum = 0;
            int kolvo = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    sum += array[i];
                    kolvo++;
                }
            }
            double S = sum / kolvo;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = S;
                }
            }
            foreach (int element in array)
            {
                Console.WriteLine($"{element}, ");
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int indmin = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    indmin = i;
                    break;
                }
            }
            if (indmin == -1)
                return sum;
            for (int i = 0; i < indmin; i++)
            {
                sum += array[i] * array[i];
            }
            // end
            Console.WriteLine(sum);
            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;
            // code here
            int max = int.MinValue, min = int.MaxValue;
            int indmax = 0, indmin = 0, N = 0, ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indmax = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < min)
                {
                    min = array[i];
                    indmin = i;
                }
            }
            if (indmin < indmax)
            {
                for (int i = indmin + 1; i < indmax; i++)
                {
                    if (array[i] < 0)
                        N++;
                }
                if (N > 0)
                {
                    negatives = new int[N];
                    for (int i = indmin + 1; i < indmax; i++)
                    {
                        if (array[i] < 0)
                        {
                            negatives[ind] = array[i];
                            ind++;
                        }
                    }
                }
            }
            if (indmin > indmax)
            {
                for (int i = indmax + 1; i < indmin; i++)
                {
                    if (array[i] < 0)
                        N++;
                }
                if (N > 0)
                {
                    negatives = new int[N];
                    for (int i = indmax + 1; i < indmin; i++)
                    {
                        if (array[i] < 0)
                        {
                            negatives[ind] = array[i];
                            ind++;
                        }
                    }
                }
            }
            if (N == 0)
            {
                negatives = new int [0];
            }
            if (N > 0)
            {
                for (int i = 0; i < negatives.Length; i++)
                    Console.Write("{0} ", negatives[i]);
            }
            Console.WriteLine();
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int n = array.Length;
            int max = -1000;
            int imax = 0;
            int min = 0;
            int imin = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > max)
                {
                    if (array[i] == max)
                        imax = imax;
                    else 
                        max = array[i]; 
                        imax = i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    min = array[i];
                    imin = i;
                    int c = array[imin];
                    array[imin] = array[imax];
                    array[imax] = c;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ",array[i]);
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int c = 0;
            int N = 1;
            int max = -1000;
            for (int i = 0; i < n; i++)
            {
               if (array[i] >= max)
               {
                    if (max == array[i])
                        N++;
                    else
                        N = 1;
                    max = array[i];
               }
            }
            answer = new int[N];
            for (int i = 0; i < n; i++)
            {
                if (array[i] == max)
                {
                    answer[c] = i;
                    c++;
                }
            }

            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("{0} ", answer[i]);
            }
            // end
            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int n = array.Length;
            int N = 1;
            int max = -1000;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= max)
                    max = array[i];
            }
            for (int i = 0; i < n; i++)
            {
                if (array[i] == max)
                {
                    array[i] = array[i] + N;
                    N++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int n = array.Length;
            int max = -1000;
            int sum = 0;
            int sum2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                sum += array[i];
                if (array[i] == max)
                {
                    array[i] = sum2;
                }
                sum2 = sum; 
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int num = array[0];
            int N = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (num > array[i])
                {
                    length++;
                    if (length >= N)
                        N++;
                }
                else
                    length = 0;
                num = array[i];
            }
            if (N == 0)
                length = 1;
            Console.WriteLine(N);
            length = N;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = 0, N = 0, temp = 0, ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    n++;
            }
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            int[] array2 = new int[n];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array2[N] = array[i];
                    N++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив неотсортированный, состоящий из четных индексов: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            for (int i = 0; i < array2.Length; i++)
            {
                for (int j  = 0; j < array2.Length; j++)
                {
                    if (array2[i] < array2[j])
                    {
                        temp = array2[i];
                        array2[i] = array2[j];
                        array2[j] = temp;
                    }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив отсортированный, состоящий из четных индексов: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i] + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    array[i] = array2[ind];
                    ind++;
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            Console.WriteLine("Исходный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            cleared = array.Distinct().ToArray();
            Console.WriteLine();
            Console.WriteLine("Очищенный массив: ");
            for (int i = 0; i < cleared.Length; i++)
            {
                Console.Write(cleared[i] + " ");
            }
            Console.WriteLine();
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }
            double ss = 0;
            int n2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] >= 0)
                {
                    ss += A[i];
                    n2++;
                }
            }
            ss = ss / n2;
            n2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > ss)
                {
                    n2++;
                }
            }
            B = new double[n2];
            int g = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > ss)
                {
                    B[g++] = A[i];
                }
            }
            if ((n <= 1) || (a == b))
            {
                return null;
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] shul = new int[dices.Length];
            for (int i = 0; i <= 4 & i < dices.Length; i++)
            {
                shul[i] = 6 - i;
            }
            for (int i = 5; i < dices.Length; i++)
            {
                shul[i] = 1;
            }
            int k = 6;
            for (int i = 0; i < dices.Length - 1; i++)
            {
                if (dices[i] == k)
                {
                    for (int j = i + 1; j < dices.Length; j++)
                    {
                        dices[j] = dices[j] - 1;
                    }
                    k--;
                }
            }
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i] > shul[i])
                    wins++;
            }
            // end

            return wins;

        }
    }
}
