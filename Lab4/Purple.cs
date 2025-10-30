﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Runtime.InteropServices;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double[] answer = new double[array.Length];
            double maxEl = array[0];
            double sum = 0;
            foreach (double el in array)
            {
                if (el > maxEl) maxEl = el;
                sum += el;
            }
            bool isM = false;
            double sr = sum / array.Length;
            for (int n = 0; n < array.Length; n++)
            {
                if (array[n] == maxEl && !isM) { isM = true; answer[n] = maxEl; continue; }
                if (isM) answer[n] = sr;
                else answer[n] = array[n];
            }
            array = answer;
            //YES
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array.Length % 2 != 0) { even = new int[(array.Length / 2) + 1]; odd = new int[array.Length / 2]; }
            else { even = new int[array.Length / 2]; odd = new int[array.Length / 2]; }
            int k = 0;
            int z = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) { even[k] = array[i]; k++; }
                else { odd[z] = array[i]; z++; }
            }
            //YES
            // end
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int sum = 0;
            int closest = array[0];
            double average;
            foreach (int el in array) sum += el;
            average = (double)sum / array.Length;
            for(int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - average) < Math.Abs(closest - average))
                {
                    closest = array[i];
                }
            }
            answer = new int[array.Length + 1];
            bool isA = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (!isA & array[i] == closest)
                {
                    isA = true;
                    answer[i] = array[i];
                    answer[i + 1] = P;
                }
                else if (!isA) answer[i] = array[i];
                else answer[i + 1] = array[i]; 
            }
            //YES
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] answer = new int[array.Length];
            int countMinus = 0;
            foreach (int el in array) if (el < 0) countMinus++;
            int[] minus = new int[countMinus];
            int k = 0;
            int z = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] < 0)
                {
                    minus[k] = array[i];
                    k++;
                }
                else
                {
                    answer[z] = array[i];
                    z++;
                }
            }
            k = 0;
            for (int i = (array.Length - countMinus); i < array.Length; i++)
            {
                answer[i] = minus[k];
                k++;
            }
            array = answer;
            //YES
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k > (A.Length - 1)) answer = new int[A.Length];
            else answer = new int[A.Length + B.Length];
            bool isA = false;
            int a = 0;
            int b = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (i == k) isA = true;
                else if (b == B.Length) isA = false;
                if (!isA)
                {
                    answer[i] = A[a];
                    a++;
                }
                else if (isA)
                {
                    answer[i] = B[b];
                    b++;
                }
            }
            //YES
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length != B.Length) return (sum, dif);
            sum = new int[A.Length];
            dif = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }
            //YES
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            bool isEveryEqual = true;
            int temp = array[0];
            int maxEl = array[0];
            for(int i = 0; i < array.Length; i++)
            {
                if(temp != array[i]) isEveryEqual = false;
                if (array[i] > maxEl) maxEl = array[i];
            }
            if (!isEveryEqual)
            {
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++) normalized[i] = (double)array[i] / maxEl;
            }
            //YES
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int temp;
            for(int i = 0; i < A.Length; i++)
            {
                for(int k = 0; k < A.Length - i - 1; k++)
                {
                    if (A[k] < A[k + 1])
                    {
                        temp = A[k];
                        A[k] = A[k + 1];
                        A[k + 1] = temp;
                    }
                }
            }
            temp = B[0];
            for (int i = 0; i < B.Length; i++)
            {
                for (int k = 0; k < B.Length - i - 1; k++)
                {
                    if (B[k] < B[k + 1])
                    {
                        temp = B[k];
                        B[k] = B[k + 1];
                        B[k + 1] = temp;
                    }
                }
            }
            temp = 0;
            int z = 0, j = 0, y = 0;
            while(z < A.Length && j < B.Length)
            {
                if (A[z] >= B[j]) C[y++] = A[z++];
                else C[y++] = B[j++];
            }
            while (z < A.Length) C[y++] = A[z++];
            while (j < B.Length) C[y++] = B[j++];
            //YES
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int maxElIndex = 0;
            int maxEl = array[0];
            int[] answer = new int[array.Length];
            for (int i = 0; i < array.Length; i++) 
            {
                if (array[i] > maxEl)
                {
                    maxEl = array[i];
                    maxElIndex = i;
                }
            }
            int[] tempArray = new int[array.Length];
            int z = 0;
            for(int i = array.Length - maxElIndex; i < array.Length; i++) tempArray[z++] = array[i];
            for (int i = 0; i < array.Length - maxElIndex; i++) tempArray[z++] = array[i];
            array = tempArray;
            //YES
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int index = N - 1; // потому что N задан "по счёту", а индексы с 0

            int left = index;
            int right = array.Length - N;

            int z;
            if (left < right) z = left;
            else z = right;

            for (int i = 0; i < z; i++)
            {
                array[index + 1 + i] = array[index - 1 - i];
            }
            //YES
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            int z = 0;
            X = new double[n];
            Y = new double[n];
            if(a != b)
            {
                for(double x = a; x <= b; x += Math.Abs(b - a) / ((double)n - 1))
                {
                    X[z] = x;
                    Y[z] = Math.Cos(x) + x * Math.Sin(x);
                    z++;
                }
                z = 0;
                for (int i = 1; i < X.Length - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                    {
                        z++;
                    }
                }
                Xext = new double[z];
                Yext = new double[z];
                z = 0;
                for (int i = 1; i < X.Length - 1; i++) 
                {
                    if ( (Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                    {
                        Xext[z] = X[i];
                        Yext[z] = Y[i];
                        z++;
                    }
                }
            }
            //YES
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sum = 0;
            double average;
            normal = new double[raw.Length];
            foreach (double el in raw) sum += el;
            average = sum / raw.Length;
            int bright_count = 0;
            int dim_count = 0;
            double sum_withoutDef = 0;
            double average_withoutDef;
            for(int i = 0; i < raw.Length; i++)
            {
                if ((raw[i] / 2) > average) bright_count++;
                else if ((raw[i] * 2) < average) dim_count++;
                else sum_withoutDef += raw[i];
            }
            average_withoutDef = sum_withoutDef / (raw.Length - dim_count - bright_count);
            bright = new double[bright_count];
            dim = new double[dim_count];
            bright_count = 0; dim_count = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if ((raw[i] / 2) > average)
                {
                    bright[bright_count] = raw[i];
                    bright_count++;
                    normal[i] = (raw[i] + average_withoutDef) / 2;
                }
                else if ((raw[i] * 2) < average)
                {
                    dim[dim_count] = raw[i];
                    dim_count++;
                    normal[i] = (raw[i] + average_withoutDef) / 2;
                }
                else normal[i] = raw[i];
            }
            double temp;
            for (int i = 0; i < normal.Length; i++)
            {
                for (int k = 0; k < normal.Length - i - 1; k++)
                {
                    if (normal[k] < normal[k + 1])
                    {
                        temp = normal[k];
                        normal[k] = normal[k + 1];
                        normal[k + 1] = temp;
                    }
                }
            }
            //YES
            // end

            return (bright, normal, dim);
        }
    }
}