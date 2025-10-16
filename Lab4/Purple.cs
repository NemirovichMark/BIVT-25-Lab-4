using System.Security.Cryptography;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double max = double.MinValue, sum = 0;
            int max_i = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_i = i;
                }
                sum += array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i > max_i)
                {
                    array[i] = (sum / array.Length);
                }

            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int amount_even = 0, amount_odd = 0;
            if (array.Length % 2 == 0)
            {
                amount_even = array.Length / 2;
                amount_odd = array.Length / 2;
            }
            else
            {
                amount_even = array.Length / 2 + 1;
                amount_odd = array.Length / 2;
            }
            even = new int[amount_even];
            odd = new int[amount_odd];
            int ei = 0, oi = 0;
            for (int i = 0; i < array.Length; i++) 
            {
                if (i % 2 == 0)
                {
                    even[ei] = array[i];
                    ei++;
                }
                else
                {
                    odd[oi] = array[i];
                    oi++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int e = 1000;
            double mid = 0;
            foreach (int i in array)
            {

            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here

            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here

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