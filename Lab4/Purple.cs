using System.Data;
using System.Formats.Asn1;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using Microsoft.Win32.SafeHandles;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            if (array.Length == 0) return;
            double max_i = -9999;
            bool flag = false;
            double s = 0;
            for (int i = 0; i != array.Length; i++)
            {
                if (array[i] > max_i) max_i = array[i];
                s += array[i];
            }

            s = s / array.Length;

            for (int i = 0; i != array.Length; i++)
            {
                if (flag == false && max_i == array[i]) flag = true;
                else if (flag == true) array[i] = s;
            }
            return;
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            if (array.Length == 0) return (even, odd);

            if (array.Length % 2 != 0)
            {
                even = new int[(array.Length - 1) / 2 + 1];
                odd = new int[(array.Length - 1) / 2];
            }
            else
            {
                even = new int[(array.Length / 2)];
                odd = new int[(array.Length / 2)];
            }

            int even_counter = 0;
            int odd_counter = 0;

            for (int i = 0; i != array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[even_counter] = array[i];
                    even_counter++;
                }

                else
                {
                    odd[odd_counter] = array[i];
                    odd_counter++;
                }
            }

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = new int[array.Length + 1];
            double sr = 0;
            for (int i = 0; i != array.Length; i++) sr += array[i];

            sr /= array.Length;

            int newP_index = 0;
            double raz = 999;

            for (int i = 0; i != array.Length; i++)
            {
                if (Math.Abs(array[i] - sr) < raz)
                {
                    newP_index = i;
                    raz = Math.Abs(array[i] - sr);
                }
            }

            for (int i = 0; i <= newP_index; i++)
                answer[i] = array[i];

            answer[newP_index + 1] = P;

            for (int i = newP_index + 2; i < answer.Length; i++)
                answer[i] = array[i - 1];

            return answer;
        }
        public void Task4(int[] array)
        {
            int index = 0;

            int[] answer = new int[array.Length];

            for (int i = 0; i != array.Length; i++)
                if (array[i] >= 0)
                    answer[index++] = array[i];

            for (int i = 0; i != array.Length; i++)
                if (array[i] < 0)
                    answer[index++] = array[i];

            for (int i = 0; i != array.Length; i++)
                array[i] = answer[i];
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            if (k >= A.Length)
                return A;

            int[] answer = new int[A.Length + B.Length];
            int answerIndex = 0;

            for (int i = 0; i < k; i++)
                answer[answerIndex++] = A[i];

            for (int i = 0; i < B.Length; i++)
                answer[answerIndex++] = B[i];
    
            for (int i = k; i < A.Length; i++)
                answer[answerIndex++] = A[i];

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            if (A.Length != B.Length)
                return (sum, dif);

            sum = new int[A.Length]; dif = new int[A.Length];

            for (int i = 0; i != A.Length; i++)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }
            
            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            if (array == null || array.Length == 0)
                return null;

            int max = array[0];
            int min = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                if (array[i] < min)
                    min = array[i];
            }

            if (max == min)
                return null;

            double[] normalized = new double[array.Length];
            double range = max - min;

            for (int i = 0; i < array.Length; i++)
                normalized[i] = 2.0 * (array[i] - min) / range - 1.0;

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;
            bool swaped_a = true;

            while (swaped_a == true)
            {
                swaped_a = false;

                for (int i = 0; i != A.Length - 1; i++)
                {
                    if (A[i] < A[i + 1])
                    {
                        var p = A[i + 1];
                        A[i + 1] = A[i];
                        A[i] = p;
                        swaped_a = true;
                    }
                }

                if (swaped_a == false)
                    break;

                for (int i = A.Length - 2; i != 0; i--)
                {
                    if (A[i] < A[i + 1])
                    {
                        var p = A[i + 1];
                        A[i + 1] = A[i];
                        A[i] = p;
                        swaped_a = true;
                    }
                }
            }

            for (int i = 0; i != B.Length; i++)
                for (int x = 0; x != B.Length - 1; x++)
                    if (B[x] < B[x + 1])
                    {
                        var p = B[x + 1];
                        B[x + 1] = B[x];
                        B[x] = p;
                    }

            C = new int[A.Length + B.Length];
            for (int i = 0; i != C.Length; i++)
                if (i < A.Length)
                    C[i] = A[i];
                else
                    C[i] = B[i - A.Length];

            int a_index = 0;
            int b_index = 0;

            for (int i = 0; i != C.Length; i++)
                if (a_index == A.Length)
                    C[i] = B[b_index++];
                else if (b_index == B.Length)
                    C[i] = A[a_index++];
                else if (A[a_index] > B[b_index])
                    C[i] = A[a_index++];
                else
                    C[i] = B[b_index++];
            
            return C;
        }
        public void Task9(int[] array)
        {
            if (array == null || array.Length <= 1)
                return;

            int max = array[0];
            int max_index = 0;

            for (int i = 1; i < array.Length; i++)
                if (array[i] > max)
                {
                    max = array[i];
                    max_index = i;
                }

            if (max_index == 0)
                return;

            int n = array.Length;
            int k = max_index;

            int left = 0, right = n - 1;
            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }

            left = 0;
            right = k - 1;
            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }

            left = k;
            right = n - 1;
            while (left < right)
            {
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++;
                right--;
            }
        }
        public void Task10(int[] array, int N)
        {
            int left = N - 1;
            int right = array.Length - N;

            if (left < right)
                for (int i = 0; i < left; i++)
                    array[N + i] = array[N - 2 - i];
            else
                for (int i = 0; i < right; i++)
                    array[N + i] = array[N - 2 - i];
        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            if (n < 2)
                return (new double[0], new double[0]);
            else if (a >= b)
                return (null, null);

            double h = (b - a) / (n - 1);
            double[] X = new double[n];
            double[] Y = new double[n];

            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * h;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            int count = 0;

            for (int i = 1; i < n - 1; i++)
                if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1])
                    count++;
                else if (Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                    count++;

            double[] Xext = new double[count];
            double[] Yext = new double[count];
            int index = 0;

            for (int i = 1; i < n - 1; i++)
                if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1])
                {
                    Xext[index] = X[i];
                    Yext[index++] = Y[i];
                }
                else if (Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                {
                    Xext[index] = X[i];
                    Yext[index++] = Y[i];
                }

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            if (raw.Length == 0)
                return (new double[0], new double[0], new double[0]);

            double sr = 0;
            for (int i = 0; i < raw.Length; i++)
                sr += raw[i];
            sr /= raw.Length;

            int brightCount = 0;
            int dimCount = 0;
            for (int i = 0; i < raw.Length; i++)
                if (raw[i] > 2 * sr)
                    brightCount++;
                else if (raw[i] < sr / 2)
                    dimCount++;

            double[] bright = new double[brightCount];
            double[] dim = new double[dimCount];
            double[] normal = new double[raw.Length];

            int brightIndex = 0, dimIndex = 0;
            double srNormal = 0;
            int countNormal = 0;

            for (int i = 0; i < raw.Length; i++)
                if (raw[i] > 2 * sr)
                {
                    bright[brightIndex++] = raw[i];
                    normal[i] = 0;
                }
                else if (raw[i] < sr / 2)
                {
                    dim[dimIndex++] = raw[i];
                    normal[i] = 0;
                }
                else
                {
                    normal[i] = raw[i];
                    srNormal += raw[i];
                    countNormal++;
                }


            srNormal = (countNormal > 0) ? srNormal / countNormal : sr;

            brightIndex = 0; dimIndex = 0;
            for (int i = 0; i < raw.Length; i++)
                if (raw[i] > 2 * sr)
                    normal[i] = (bright[brightIndex++] + srNormal) / 2;
                else if (raw[i] < sr / 2)
                    normal[i] = (dim[dimIndex++] + srNormal) / 2;

            for (int i = 0; i < normal.Length - 1; i++)
                for (int x = 0; x < normal.Length - 1 - i;x++)
                    if (normal[x] < normal[x + 1])
                        (normal[x], normal[x + 1]) = (normal[x + 1], normal[x]);

            return (bright, normal, dim);
        }
    }
}
