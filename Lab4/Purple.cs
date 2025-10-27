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
            answer = new int[n + 2];
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
            int n = array.Length, cnt1 = 0,  cnt2 = 0;
            int last = n - 1;
            int value = 0;
            for (int i = n - 1; i >= 0; i--)
            {
                if (array[i] < 0)
                {
                    cnt1++;
                }
                else
                {
                    cnt2++;
                }
            }
            int[] array1 = new int[cnt1];
            int[] array2 = new int[cnt2];
            cnt1 = 0;
            cnt2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    array1[cnt1] = array[i];
                    cnt1++;
                }
                else
                {
                    array2[cnt2] = array[i];
                    cnt2++;
                }
            }
            for (int i = 0; i < array2.Length; i++)
            {
                array[i] = array2[i];
            }
            for (int i = 0; i < array1.Length; i++)
            {
                array[i + array2.Length] = array1[i];
            }
            // end
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            for (int i = 0; i < answer.Length; i++)
            {
                if (i <= k)
                {
                    answer[i] = A[i];
                }
                else if (i <= k + B.Length)
                {
                    answer[i] = B[i - k - 1];
                }
                else
                {
                    answer[i] = A[i - B.Length];
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
            C = new int[A.Length + B.Length];
            for (int i = 0; i < C.Length; i++)
            {
                if (i < A.Length)
                {
                    C[i] = A[i];
                }
                else
                {
                    C[i] = B[i - A.Length];
                }
            }
            Array.Sort(C);
            Array.Reverse(C);
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int[] answer = new int[array.Length];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[ind])
                {
                    ind = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (ind + i < answer.Length)
                {
                    answer[i] = array[ind + i];
                }
                else
                {
                    answer[i] = array[ind + i - answer.Length];
                }
            }
            array = answer;
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
            double move = (b - a) / (n + 1);
            double y = 0;
            for (double x = a; x < b; x += move)
            {
                y = Math.Cos(x) + x * Math.Sin(x);
            }
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

