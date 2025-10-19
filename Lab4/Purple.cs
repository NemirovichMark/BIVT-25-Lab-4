using System.Globalization;
using System.Reflection.Emit;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sr = 0;
            int mx = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                sr += array[i];
                if (array[i] > array[mx])
                {
                    mx = i;
                }
            }
            sr /= n;
            for (int i = mx + 1; i < n; i++)
            {
                array[i] = sr;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int n = array.Length;
            even = new int[(n + 1) / 2];
            odd = new int[n / 2];
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    even[i / 2] = array[i];
                }
                else
                {
                    odd[i / 2] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int n = array.Length;
            int mx = 0;
            double sr = 0;
            answer = new int[n + 1];
            for (int i = 0; i < n; i++)
            {
                sr += array[i];
            }
            sr /= n;
            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i] - sr) < Math.Abs(array[mx] - sr))
                {
                    mx = i;
                }
            }
            for (int i = 0; i < n + 1; i++)
            {
                if (i <= mx)
                {
                    answer[i] = array[i];
                }
                else if (i == mx + 1)
                {
                    answer[i] = P;
                }
                else
                {
                    answer[i] = array[i - 1];
                }
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
            answer = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                if (i <= k)
                {
                    answer[i] = A[i];
                }
                else if (i == k + 1)
                {
                    for (int j = 0; j < B.Length; j++)
                    {
                        answer[i + j + 1] = B[j];
                    }
                }
                else
                {
                    answer[i + B.Length] = A[i];
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            sum = new int[A.Length]; dif = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                sum[i] = A[i] + B[i]; dif[i] = A[i] - B[i];
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            bool fl = true;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != array[i - 1])
                {
                    fl = false;
                }
            }
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = array[i] / int.MaxValue;
            }
            if (fl)
            {
                return null;
            }
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




