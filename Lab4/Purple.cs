using System.ComponentModel.DataAnnotations;
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
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int sum = 0;
            double avarege;
            double distance;
            int closest = array[0];
            foreach (int el in array) sum += el;
            avarege = (double)sum / array.Length;
            distance = Math.Abs(avarege - array[0]);
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(avarege - array[i]) < distance)
                {
                    closest = array[i];
                    distance = Math.Abs(avarege - array[i]);
                }
            }
            answer = new int[array.Length + 1];
            bool isA = true;
            int z = 0;
            for(int i = 0; i < answer.Length; i++)
            {
                if (isA & array[z] == closest)
                {
                    isA = false;
                    answer[i] = array[i];
                    answer[i + 1] = P;
                    continue;
                }
                else if (!isA) answer[i] = array[i - 1];
                else answer[i] = array[i];
                Console.WriteLine(answer[i]);
            }
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
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            bool isA = false;
            int a = 0;
            int b = 0;
            for (int i = 0; i < answer.Length; i++)
            {
                if (i + 1 == k) isA = true;
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
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here

            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here

            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here

            // end

            return (bright, normal, dim);
        }
    }
}