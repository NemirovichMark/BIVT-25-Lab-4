using System.Numerics;
using System.Runtime.InteropServices.Marshalling;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0, mx = double.MinValue;
            int n = array.Length, imx = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    imx = i;
                }
                sum += array[i];
            }
            double sr = sum / n;
            bool flag = false;
            for (int i = imx + 1; i < n; i++)
            {
                array[i] = sr;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int l_even = (array.Length + 1) / 2;
            int l_odd = (array.Length) / 2;
            int ind_even = 0, ind_odd = 0;
            even = new int[l_even];
            odd = new int[l_odd];
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[ind_even] = array[i];
                    ind_even++;

                }
                else
                {
                    odd[ind_odd] = array[i];
                    ind_odd++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double mn_dist = double.MaxValue;
            double summa = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summa += array[i];
            }
            double sr = summa / array.Length;
            int found_elem_ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                double dist = Math.Abs(array[i] - sr);
                if (dist < mn_dist)
                {
                    mn_dist = dist;
                    found_elem_ind = i;
                }
            }
            int[] answer2 = new int[array.Length + 1];
            for (int i = 0; i <= found_elem_ind; i++)
            {
                answer2[i] = array[i];
            }
            answer2[found_elem_ind + 1] = P;
            for (int i = found_elem_ind + 1; i < array.Length; i++)
            {
                answer2[i + 1] = array[i];
            }

            answer = answer2;
            // end

            return answer;
        }
        public void Task4(int[] array)
        {
            // code here
            int[] new_array = new int[array.Length];
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    new_array[cnt] = array[i];
                    cnt++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    new_array[cnt] = array[i];
                    cnt++;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new_array[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            if (k > A.Length)
            {
                answer = new int[A.Length];
                for (int i = 0; i <  A.Length; i++)
                {
                    answer[i] = A[i];
                }
            }
            else
            {
                int ind = 0;
                for (int i = 0; i < k; i++)
                {
                    answer[ind++] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[ind++] = B[i];
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[ind++] = A[i];
                }
            }

            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A == null || B == null)
            {
                return (null, null);
            }
            if (A.Length != B.Length)
            {
                return (null, null);
            }
            int[] sum2 = new int[A.Length];
            int[] dif2 = new int[A.Length];
            for (int i = 0; i < A.Length; i++)
            {
                sum2[i] = A[i] + B[i];
                dif2[i] = A[i] - B[i];
            }
            sum = sum2;
            dif = dif2;
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            normalized = new double[array.Length];
            double mn = double.MaxValue, mx = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                }
                if (array[i] < mn)
                {
                    mn = array[i];
                }
            }
            if (mn == mx)
            {
                return null;
            }
            for (int i = 0; i < array.Length; i++)
            {
                double t = 2 * (array[i] - mn) / (mx - mn) - 1;
                normalized[i] = t;
            }
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            for (int i = 0; i < A.Length; i++)
            {
                bool swap = false;
                for (int j = 0; j < A.Length - 1 - i; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        (A[j], A[j + 1]) = (A[j + 1], A[j]);
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                bool swap = false;
                for (int j = 0; j < B.Length - 1 - i; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        (B[j], B[j+1]) = (B[j + 1], B[j]);
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }
            }

            C = new int[A.Length + B.Length];
            int ind_i = 0, ind_j = 0, k = 0;
            while (ind_i < A.Length && ind_j < B.Length)
            {
                if (A[ind_i] >= B[ind_j])
                {
                    C[k++] = A[ind_i++];
                }
                else
                {
                    C[k++] = B[ind_j++];
                }
            } 
            while (ind_i < A.Length)
            {
                C[k++] = A[ind_i++];
            }
            while (ind_j < B.Length)
            {
                C[k++] = B[ind_j++];
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = int.MinValue, imx = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    imx = i;
                }
            }

            int[] new_array = new int[array.Length];
            for (int i = 0; i < new_array.Length; i++)
            {
                int new_index;
                if (i + imx < array.Length)
                {
                    new_array[i + imx] = array[i];
                }
                else
                {
                    new_array[i + imx - array.Length] = array[i];
                }
            }

            for (int i = 0; i < new_array.Length; i++)
            {
                array[i] = new_array[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N > array.Length || N < 1)
            {
                return;
            }
            N--;
            int[] bef = new int[N];
            for (int i = 0; i < N; i++)
            {
                bef[i] = array[i];
            }
            int[] reversed = new int[bef.Length];
            for (int i = 0; i < bef.Length; i++)
            {
                reversed[i] = bef[bef.Length - 1 - i];
            }
            for (int i = 0; i < reversed.Length; i++)
            {
                try
                {
                    array[N + i + 1] = reversed[i];
                }
                catch
                {
                    break;
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a < b || (a == b && n == 1))
            {
                double step = (b - a) / (n - 1);
                X = new double[n];
                Y = new double[n];
                int ind = 0;
                for (double x = a; x <= (b + step / 2); x += step)
                {
                    X[ind] = x;
                    Y[ind] = Math.Cos(x) + x * Math.Sin(x);
                    ind++;
                }

                double[] XExtNew = new double[n];
                double[] YExtNew = new double[n];
                ind = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if (((Y[i] < Y[i - 1]) && (Y[i] < Y[i + 1])) || (((Y[i] > Y[i - 1]) && (Y[i] > Y[i + 1]))))
                    {
                        XExtNew[i - 1] = X[i];
                        YExtNew[i - 1] = Y[i];
                        ind++;
                    }
                }

                Xext = new double[ind];
                Yext = new double[ind];

                ind = 0;
                for (int i = 0; i < XExtNew.Length; i++)
                {
                    if ((XExtNew[i] != 0) && (YExtNew[i] != 0))
                    {
                        Xext[ind] = XExtNew[i];
                        Yext[ind] = YExtNew[i];
                        ind++;
                    }
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sum = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            double avg = sum / raw.Length;

            int c_bright = 0, c_dim = 0, c_normal = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > avg * 2)
                {
                    c_bright++;
                }
                else if (raw[i] < avg / 2)
                {
                    c_dim++;
                }
                else
                {
                    c_normal++;
                }
            }
            bright = new double[c_bright];
            normal = new double[c_normal];
            dim = new double[c_dim];

            int idx_bright = 0, idx_dim = 0, idx_normal = 0;

            double[] norm = new double[c_normal];
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > avg * 2)
                {
                    bright[idx_bright++] = raw[i];
                }
                else if (raw[i] < avg / 2)
                {
                    dim[idx_dim++] = raw[i];
                }
                else
                {
                    norm[idx_normal++] = raw[i];
                }
            }

            double sum_left = 0;
            for (int i = 0; i < norm.Length; i++)
            {
                sum_left += norm[i];
            }
            double avg_left = sum_left / norm.Length;

            double[] new_raw = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > avg * 2 || raw[i] < avg / 2)
                {
                    new_raw[i] = (avg_left + raw[i]) / 2;
                }
                else
                {
                    new_raw[i] = raw[i];
                }
            }

            normal = new double[new_raw.Length];
            for (int i = 0; i < normal.Length; i++)
            {
                normal[i] = new_raw[i];
            }

            for (int i = 0; i < normal.Length; i++)
            {
                bool swap = false;
                for (int j = 0; j < normal.Length - 1 - i; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                        swap = true;
                    }
                }
                if (!swap)
                {
                    break;
                }
            }

            // end

            return (bright, normal, dim);
        }
    }
}
