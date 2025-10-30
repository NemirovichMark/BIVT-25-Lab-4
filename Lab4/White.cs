using System.ComponentModel.Design;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Numerics;
using System.Runtime.Intrinsics;
using System.Security.Authentication;
using static System.Net.WebRequestMethods;

namespace Lab4
{
    public class White
    {
        public double Task1(int[] vector)
        {
            double length = 0;

            // code here
            for (int i = 0; i<vector.Length; i++)
            {
                length += Math.Pow(vector[i], 2);
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
                    count++;
            }
            // end

            return count;
        }
        public void Task3(int[] array)
        {

            // code here
            int maximum = -1000000;
            int maxindex = -1;
            int minindex = -1;
            int minimum = 1000000;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i]>maximum)
                {
                    maximum = array[i];
                    maxindex = i;
                }
            }
            for (int j = maxindex; j < array.Length; j++)
            {
                if (array[j] < minimum)
                {
                    minimum = array[j];
                    minindex = j;
                }
            }
            int p = array[maxindex];
            array[maxindex]=array[minindex];
            array[minindex] = p;
            // end

        }
        public void Task4(int[] array)
        {

            // code here
            int maximum = -1000000;
            int maxindex = -1;
            for (int i = 0; i < array.Length; i+=2)
            {
                if (array[i]>maximum)
                {
                    maximum = array[i];
                    maxindex = i;
                }
            }
            array[maxindex] = maxindex;
            // end

        }
        public int Task5(int[] array, int P)
        {
            int index = 0;

            // code here
            while (array[index] != P)
            {
                index++;
                if (index == array.Length)
                    return -1;
            }
            // end

            return index;
        }
        public void Task6(int[] array)
        {

            // code here
            int maximum = -1000000;
            int maxindex = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maximum)
                {
                    maximum = array[i];
                    maxindex = i;
                }
            }
            if (maxindex == 0)
                return;
            for (int j = 0; j < maxindex-1; j+=2)
            {
                int p = array[j];
                array[j]=array[j+1];
                array[j+1]=p;
            }
            // end

        }
        public int[] Task7(int[] array)
        {
            int[] answer = null;

            // code here
            int n = 0;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] >= 0)
                    n++;
            }
            answer = new int[n];
            n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                    answer[n++] = array[i];
            }
            // end

            return answer;
        }
        public void Task8(int[] array)
        {

            // code here
            bool changed = false;
            for (int i = 0; i<array.Length-1; i++)
            {
                for (int j = 0; j<array.Length-1-i; j++)
                {
                    if (array[j] < array[j+1])
                    {
                        int p = array[j];
                        array[j]=array[j+1];
                        array[j+1]=p;
                        changed = true;
                    }
                }
            }
            // end

        }
        public void Task9(int[] array)
        {

            // code here
            int left = 0;
            int right = array.Length-1;
            while (left < right)
            {
                int p = array[left];
                array[left] = array[right];
                array[right] = p;
                left++;
                right--;
            }
            // end

        }
        public int[] Task10(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A.Length == 0)
                C = new int[A.Length];
            if (B.Length == 0)
                C = new int[B.Length];
            C = new int[A.Length+B.Length];
            int ia = 0, ib = 0, ic = 0;
            while (ia < A.Length || ib < B.Length)
            {
                if (ia<A.Length)
                    C[ic++] = A[ia++];
                if (ib<B.Length)
                    C[ic++] = B[ib++];
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
            else if (n == 1 && a!=b)
            {
                array = null;
            }
            else if (a == b)
            {
                if (n==1)
                {
                    for (int i = 0; i<n; i++)
                    {
                        array[i] = a;
                    }
                }
                else
                {
                    array = null;
                }
            }
            else if (a < b)
            {
                array = new double[n];
                double sk = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                { 
                    array[i] = a + i * sk;
                }
            }
            else if (a > b)
            {
                array = new double[n];
                double sk = (a - b) / (n - 1);
                for (int i = 0; i < n; i++)
                { 
                    array[i] = a - i * sk;
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
                restored = null;
            }
            else
            {
                restored = new double[raw.Length];
                for (int i = 0; i < raw.Length; i++)
                {
                    if (raw[i] == -1 && raw[(i - 1 + raw.Length) % raw.Length] != -1 && raw[(i + 1) % raw.Length] != -1)
                    {
                        restored[i] = (raw[(i + 1)%raw.Length] + raw[(i - 1 + raw.Length)%raw.Length]) / 2;
                    }
                    else
                    {
                        restored[i] = raw[i];
                    }
                }
            }
            // end

            return restored;
        }
    }
}