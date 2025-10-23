using System.Buffers;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.ExceptionServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            // code here
            double max = double.MinValue;
            int max_ind = -1;
            double avg = 0;
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (max < array[i])
                {
                    max = array[i];
                    max_ind = i;
                }
                avg += array[i];
            }
            if (n > 0)
            {
                avg /= n;
            }
            if (max_ind > -1)
            {
                for (int i = max_ind + 1; i < n; i++)
                {
                    array[i] = avg;
                }
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
            int even_ind = 0, odd_ind = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    even[even_ind] = array[i];
                    even_ind++;
                }
                else
                {
                    odd[odd_ind] = array[i];
                    odd_ind++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double diff = double.MaxValue;
            double avg = 0;
            int n = array.Length;
            int P_ind = -1;

            for (int i = 0; i < n; i++)
            {
                avg += array[i];
            }
            avg /= n;

            for (int i = 0; i < n; i++)
            {
                if (Math.Abs(array[i] - avg) < diff)
                {
                    diff = Math.Abs(array[i] - avg);
                    P_ind = i + 1;
                }
            }
            int n_answer = n + 1;
            answer = new int[n_answer];

            for (int i = 0; i < n_answer; i++)
            {
                if (i == P_ind)
                {
                    answer[i] = P;
                }
                else if (i < P_ind)
                {
                    answer[i] = array[i];
                }
                else if (i > P_ind)
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
            int n = array.Length;
            int temp;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 0)
                {
                    for (int j = i - 1; j > -1; j--)
                    {
                        if (array[j] >= 0)
                        {
                            break;
                        }
                        else
                        {
                            temp = array[j];
                            array[j] = array[j + 1];
                            array[j + 1] = temp;
                        }
                    }
                    temp = 0;
                }
            }
        }
        // end
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            int nb = B.Length, na = A.Length;
            answer = new int[na + nb];

            if (na == k)
            {
                for (int i = 0; i < na; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < nb; i++)
                {
                    answer[na + i] = B[i];
                }
            }
            else if (k < na)
            {
                for (int i = 0; i < k; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < nb; i++)
                {
                    answer[k + i] = B[i];
                }
                for (int i = k; i < na; i++)
                {
                    answer[nb + i] = A[i];
                }
            }
            else
            {
                answer = new int[na];
                for (int i = 0; i < na; i++)
                {
                    answer[i] = A[i];
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            int na = A.Length, nb = B.Length;
            if (na == nb)
            {
                sum = new int[na];
                dif = new int[na];
                for (int i = 0; i < na; i++)
                {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
                }
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            double mx = Double.MinValue, mn = Double.MaxValue;
            int n = array.Length;
            int identical = 0, last = array[0];
            for (int i = 0; i < n; i++)
            {
                if (mx < array[i])
                {
                    mx = array[i];
                }
                if (mn > array[i])
                {
                    mn = array[i];
                }
                if (array[i] == last)
                {   
                    identical++;
                }
                last = array[i];
            }
            if (identical != n)
            {
                normalized = new double[n];
                for (int i = 0; i < n; i++)
                {
                    normalized[i] = 2 * (double)((array[i] - mn) / (mx - mn)) - 1;
                }
            }


            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int na = A.Length, nb = B.Length;
            C = new int[na + nb];
            for (int i = 0; i < na - 1; i++)
            {
                int amax = A[i];
                int imax = i;
                for (int k = i + 1; k < na; k++)
                {
                    if (A[k] > amax)
                    {
                        amax = A[k];
                        imax = k;
                    }
                }
                (A[i], A[imax]) = (A[imax], A[i]);
            }
            for (int i = 0; i < nb - 1; i++)
            {
                int bmax = B[i];
                int imax = i;
                for (int k = i + 1; k < nb; k++)
                {
                    if (B[k] > bmax)
                    {
                        bmax = B[k];
                        imax = k;
                    }
                }
                (B[i], B[imax]) = (B[imax], B[i]);
            }
            int i_ = 0, j_ = 0, k_ = 0;
            while (i_ < A.Length && j_ < B.Length)
            {
                if (A[i_] >= B[j_])
                {
                    C[k_++] = A[i_++];
                }
                else
                {
                    C[k_++] = B[j_++];
                }

            }
            while (i_ < A.Length)
            {
                C[k_++] = A[i_++];
            }
            while (j_ < B.Length)
            {
                C[k_++] = B[j_++];
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = Int32.MinValue, shift = -1, n = array.Length;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    shift = i;
                }
            }

            int[] temp = new int[n];
            for (int i = 0; i < shift; i++)
            {
                temp[i] = array[n - shift + i];
            }
            for (int i = 0; i < n - shift; i++)
            {
                temp[i + shift] = array[i];
            }
            for (int i = 0; i < n; i++)
            {
                array[i] = temp[i];
            }

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int n = array.Length;
            if ( N != 0 && N <= n)
            {
                int[] left_copy = new int[N - 1];
                int index = N - 1;
                for (int i = 0; i < index; i++)
                {
                    left_copy[index - 1 - i] = array[i];
                }

                for (int i = N; i < n; i++)
                {
                    if (i - N < index)
                    {
                        array[i] = left_copy[i - N];
                    }
                }
            }
            // end
        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;
            if (n < 3 && a <= b)
            {
                return (new double[] { }, new double[] { });
            }

            else if (a >= b)
            {
                return (null, null);
            }
            else if (n < 3)
            {
                return (new double[] { }, new double[] { });
            }
            // code here
            // y = cosx + x * sinx в n равноудалённых точках отрезка a, b (a + b / n)
            double distance = b - a;
            double x = a;
            double bonus = distance / (n - 1);
            X = new double[n];
            Y = new double[n];
            for (int i = 0; i < n; i++)
            {
                X[i] = x;
                Y[i] = Math.Cos(x) + x * Math.Sin(x);
                x += bonus;
            }
            int m = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i + 1] > Y[i]))
                {
                    m++;
                }
            }
            Xext = new double[m];
            Yext = new double[m];
            int j = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i + 1] > Y[i]))
                {
                    Xext[j] = X[i];
                    Yext[j] = Y[i];
                    j++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            int n = raw.Length, c1 = 0, c2 = 0, c3 = 0;
            double avg = 0, avgl = 0;

            for (int i = 0; i < n; i++)
            {
                avg += raw[i];
            }
            avg /= n;
            
            // длины массивов
            for (int i = 0; i < n; i++)
            {
                if (raw[i] > 2 * avg)
                {
                    c1++;
                }
                else if (raw[i] < avg / 2)
                {
                    c3++;
                }
                else
                {
                    avgl += raw[i];
                    c2++;
                }
            }
            // инициализация массивов
            if (c2 > 0)
            {
                avgl /= c2;
            }
            normal = new double[n];
            bright = new double[c1];
            dim = new double[c3];
            c1 = c3 = 0;
            // заполнение массивов
            for (int i = 0; i < n; i++)
            {
                if (raw[i] > 2 * avg)
                {
                    bright[c1++] = raw[i];
                }
                else if (raw[i] < avg / 2)
                {
                    dim[c3++] = raw[i];
                }
                else
                {
                    normal[i] = raw[i];
                }
            }
            c1 = c3 = 0;
            for (int i = 0; i < n; i++)
            {
                if (raw[i] > 2 * avg)
                {
                    normal[i] = (avgl + bright[c1++]) / 2;
                }
                else if (raw[i] < avg / 2)
                {
                    normal[i] = (avgl + dim[c3++]) / 2;
                }
            }
            for (int i = 0; i < n - 1; i++)
            {
                double normal_max = normal[i];
                int imax = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (normal[j] > normal_max)
                    {
                        imax = j;
                        normal_max = normal[j];
                    }
                }
                (normal[i], normal[imax]) = (normal[imax], normal[i]);
            }
            // end

            return (bright, normal, dim);
        }
    }
}