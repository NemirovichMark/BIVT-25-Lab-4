using System.ComponentModel.DataAnnotations.Schema;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {
            double tong = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                tong += array[i];
            }

            double tb = tong / array.Length;
            int imax = 0;
            double max_elem = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max_elem)
                {
                    max_elem = array[i];
                    imax = i;
                }
            }

            for (int i = imax + 1; i < array.Length; i++)
            {
                array[i] = tb;
            }
            // end


        }

        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int chan = 0, le = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) chan++;
                else le++;
            }

            even = new int[chan];
            odd = new int[le];
            int i1 = 0, i2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i1] = array[i];
                    i1++;
                }
                else
                {
                    odd[i2] = array[i];
                    i2++;
                }
            }

            // end
            return (even, odd);
        }

        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            double tb = (sum * 1.0) / array.Length;
            double a = Math.Abs(tb - array[0]);
            int j = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - tb) < a)
                {
                    a = Math.Abs(array[i] - tb);
                    j = i;
                }
            }

            answer = new int[array.Length + 1];
            for (int i = 0; i <= j; i++)
            {
                answer[i] = array[i];
            }

            answer[j + 1] = P;
            for (int i = j + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }
            // end

            return answer;
        }

        public void Task4(int[] array)
        {

            // code here
            int duong = 0, am = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) duong++;
                else if (array[i] < 0) am++;
            }

            int[] sduong = new int[duong], sam = new int[am];
            int i1 = 0, i2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    sduong[i1] = array[i];
                    i1++;
                }
                else
                {
                    sam[i2] = array[i];
                    i2++;
                }
            }

            int j1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < sduong.Length)
                {
                    array[i] = sduong[i];
                }
                else
                {
                    array[i] = sam[j1];
                    j1++;
                }
            }
            // end

        }

        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
           int[] answer1 = new int[A.Length + B.Length];
            if (k == A.Length)
            {
                int j = 0;
                for (int i = 0; i < answer1.Length; i++)
                {
                    if (i < A.Length)
                    {
                        answer1[i] = A[i];
                    }
                    else
                    {
                        answer1[i] = B[j];
                        j++;
                    }
                }

                answer = answer1;
            }
            else if(k<A.Length)
            {
                int j = 0, k1 = 0;
                for (int i = 0; i < answer1.Length; i++)
                {
                    if (k1 < k)
                    {
                        answer1[i] = A[k1];
                        k1++;
                    }
                    else if (j < B.Length)
                    {
                        answer1[i] = B[j];
                        j++;
                    }
                    else
                    {
                        answer1[i] = A[k1];
                        k1++;
                    }
                }

                answer = answer1;
            }
            else
            {
                answer = A;
            }
            
            // end
            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                int i1 = 0, i2 = 0;
                for (int i = 0; i < sum.Length; i++)
                {
                    sum[i] = A[i1] + B[i2];
                    i1++;
                    i2++;
                }

                i1 = 0;
                i2 = 0;
                for (int i = 0; i < dif.Length; i++)
                {
                    dif[i] = A[i1] - B[i2];
                    i1++;
                    i2++;
                }
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            int ss = array[0];
            bool check = false;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != ss)
                {
                    check = true;
                    break;
                }
            }

            if (check)
            {
                normalized = new double[array.Length];
                int max_elem = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max_elem)
                    {
                        max_elem = array[i];
                    }
                }
                int min_elem = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] < min_elem)
                    {
                        min_elem = array[i];
                    }
                }
                int j = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[j] = -1 + (2 * array[i] - 2 * min_elem) / (max_elem - min_elem*1.0);
                    j++;
                }
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            if (A.Length >= 2)
            {
                int i = 1;
                while (i < A.Length)
                {
                    if (i == 0 || A[i] <= A[i - 1])
                    {
                        i++;
                    }
                    else
                    {
                        int tmp = A[i];
                        A[i] = A[i - 1];
                        A[i - 1] = tmp;
                        i--;
                    }
                }
            }

            if (B.Length >= 2)
            {
                int i = 1;
                while (i < B.Length)
                {
                    if (i == 0 || B[i] <= B[i - 1])
                    {
                        i++;
                    }
                    else
                    {
                        int tmp = B[i];
                        B[i] = B[i - 1];
                        B[i - 1] = tmp;
                        i--;
                    }
                }
            }

            int j1 = 0, j2 = 0;
            C = new int[A.Length + B.Length];
            for (int i1 = 0; i1 < C.Length; i1++)
            {
                if (j1 < A.Length && j2 < B.Length)
                {
                    if (A[j1] >= B[j2])
                    {
                        C[i1] = A[j1];
                        j1++;
                    }
                    else
                    {
                        C[i1] = B[j2];
                        j2++;
                    }
                }
                else
                {
                    if (j1 == A.Length)
                    {
                        C[i1] = B[j2];
                        j2++;
                    }
                    else if (j2 == B.Length)
                    {
                        C[i1] = A[j1];
                        j1++;
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max_elem = array[0], imax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max_elem)
                {
                    max_elem = array[i];
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max_elem)
                {
                    imax = i;
                    break;
                }
            }

            int j1 = array.Length-imax,j2=0;
            int[] ans = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i < imax)
                {
                    ans[i] = array[j1];
                    j1++;
                }
                else
                {
                    ans[i] = array[j2];
                    j2++;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = ans[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N - 1 < array.Length - N)
            {
                int i1 = 2 * N-2;
                for (int i = 0; i < N - 1; i++)
                {
                    array[i1] = array[i];
                    i1--;
                }
            }
            else
            {
                int i1 = 2 * N - 1 - array.Length;
                for (int i = array.Length - 1; i > N - 1; i--)
                {
                    array[i] = array[i1];
                    i1++;
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a == b && a == n)
            {
                Xext = null;
                Yext = null;
            }
            else if (n - 1 >= 0 && a<=b)
            {
                X = new double[n];
                Y = new double[n];
                double d = 0;
                for (int i = 0; i < n; i++)
                {
                    X[i] = a + d;
                    Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
                    d += (b - a) / (n - 1);
                }

                int dem = 0,j=0;
                double[] c = new double[n/2];
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                    {
                        c[j] = X[i];
                        dem++;
                        j++;
                    }
                }

                if (dem >= 0)
                {
                    Xext = new double[dem];
                    Yext = new double[dem];
                    for (int i = 0; i < dem; i++)
                    {
                        Xext[i] = c[i];
                        Yext[i] = Math.Cos(c[i]) + c[i] * Math.Sin(c[i]);
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
            double tb = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                tb += raw[i] / raw.Length;
            }

            int dem1 = 0, dem2 = 0, i1 = 0, i2 = 0;
            double[] sang = new double[raw.Length];
            double[] toi = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * tb)
                {
                    dem1++;
                    sang[i1] = raw[i];
                    i1++;
                }
                else if (raw[i] < 0.5 * tb)
                {
                    dem2++;
                    toi[i2] = raw[i];
                    i2++;
                }
            }

            bright = new double[dem1];
            dim = new double[dem2];
            for (int i = 0; i < dem1; i++)
            {
                bright[i] = sang[i];
            }

            for (int i = 0; i < dem2; i++)
            {
                dim[i] = toi[i];
            }

            double tb1 = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * tb || raw[i] < 0.5 * tb)
                {
                    continue;
                }

                tb1 += raw[i] / (raw.Length - dem1 - dem2);
            }

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * tb || raw[i] < 0.5 * tb)
                {
                    raw[i] = (tb1 + raw[i]) / 2;
                }
            }

            int j = 1;
            while (j < raw.Length)
            {
                if (j == 0 || raw[j] <= raw[j - 1])
                {
                    j++;
                }
                else
                {
                    double tmp = raw[j];
                    raw[j] = raw[j - 1];
                    raw[j - 1] = tmp;
                    j--;
                }
            }
            normal = raw;
            
            // end

            return (bright, normal, dim);
        }
    }
}
