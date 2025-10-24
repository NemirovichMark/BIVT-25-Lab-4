using System.Data;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Lab4
{
    public class Purple
    {
        public static int[] Reverse(int[] a)
        {
            int[] b = new int[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[b.Length - 1 - i] = a[i];
            }
            return b;
        }

        public static double[] doubleReverse(double[] a)
        {
            double[] b = new double[a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                b[b.Length - 1 - i] = a[i];
            }
            return b;
        }

        public static int[] Sort(int[] array)
        {
            int[] result = (int[])array.Clone();

            for (int i=0; i<result.Length-1; i++)
            {
                for (int j=0; j<result.Length-i-1; j++)
                {
                    if (result[j]>result[j+1])
                    {
                        int temp = result[j];
                        result[j] = result[j+1];
                        result[j+1] = temp;
                    }
                }
            }
            return result;
        }

        public static double[] doubleSort(double[] array)
        {
            double[] result = (double[])array.Clone();

            for (int i = 0; i < result.Length - 1; i++)
            {
                for (int j = 0; j < result.Length - i - 1; j++)
                {
                    if (result[j] > result[j + 1])
                    {
                        double temp = result[j];
                        result[j] = result[j + 1];
                        result[j + 1] = temp;
                    }
                }
            }
            return result;
        }

        public void Task1(double[] array)
        {

            // code here
            double maxx = -1000000;
            double summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
                if (array[i] > maxx) {
                        maxx = array[i];
                }
            }
            double sr = summ / array.Length;
            bool m = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (m == true)
                {
                    array[i] = sr;
                } else
                {
                    if (array[i] == maxx)
                    {
                        m = true;
                    }
                }
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array.Length % 2 == 0)
            {
                even = new int[array.Length / 2];
                odd = new int[array.Length / 2];
            } else
            {
                even = new int[(array.Length - 1) / 2 + 1];
                odd = new int[(array.Length - 1) / 2];
            }
            int i_e = 0;
            int i_o = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i_e] = array[i];
                    i_e++;
                } else
                {
                    odd[i_o] = array[i];
                    i_o++;
                }
            }
                // end

                return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;
            int summ = 0;
            double sr = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            sr = (double)summ / array.Length;
            int min_index = 0;
            double min_r = 10000000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - sr) < min_r)
                {
                    min_index = i;
                    min_r = Math.Abs(array[i] - sr);
                }
            }
            answer = new int[array.Length + 1];
            bool t = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (t == false)
                {
                    answer[i] = array[i];
                } else
                {
                    answer[i + 1] = array[i];
                }
                if (i == min_index)
                {
                    answer[i + 1] = P;
                    t = true;
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] array2 = new int[array.Length];
            int p_i = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    array2[p_i] = array[i];
                    p_i++;
                }
            }
            int p_j = array.Length - 1;
            for (int j = array.Length - 1; j >= 0; j--)
            {
                if (array[j] < 0)
                {
                    array2[p_j] = array[j];
                    p_j--;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = array2[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;
            int k2 = k - 1;
            if (k2 > A.Length)
            {
                return A;
            }
            answer = new int[A.Length + B.Length];
            // code here
            int A_ind = 0;
            int B_ind = 0;
            if (k2 <= A.Length)
            {
                for (int i = 0; i < answer.Length; i++)
                {
                    if (i > k2)
                    {
                        if (i <= k2 + B.Length)
                        {
                            answer[i] = B[B_ind];
                            B_ind++;
                        }
                        else
                        {
                            answer[i] = A[A_ind];
                            A_ind++;
                        }
                    }
                    else
                    {
                        answer[i] = A[A_ind];
                        A_ind++;
                    }
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;
            if (A.Length != B.Length)
            {
                return (sum, dif);
            }
            sum = new int[A.Length];
            dif = new int[A.Length];
            // code here
            for (int i = 0; i < A.Length; i++)
            {
                sum[i] = A[i] + B[i];
                dif[i] = A[i] - B[i];
            }
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {

            double[] normalized = null;
            bool f = false;
            int maxx = -999999999;
            int minn = 999999999;
            for (int i = 0; i < array.Length - 1; i++) {
                if (array[i] != array[i+1])
                {
                    f = true;
                }
                if (array[i] > maxx)
                {
                    maxx = array[i];
                }
                if (array[i] < minn)
                {
                    minn = array[i];
                }
            }
            if (array[array.Length - 1] > maxx)
            {
                maxx = array[array.Length - 1];
            }
            if (array[array.Length - 1] < minn)
            {
                minn = array[array.Length - 1];
            }
            if (f == false)
            {
                return normalized;
            }
            normalized = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2 * (double)(array[i] - minn) / (maxx - minn) - 1;
            }
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {

            int[] C = null;

            // code here
            A = Sort(A);
            B = Sort(B);
            A = Reverse(A);
            B = Reverse(B);
            C = new int[A.Length + B.Length];
            int i = 0, j = 0, k = 0;
            while (i < A.Length && j < B.Length)
            {
                if (A[i] >= B[j])
                {
                    C[k] = A[i];
                    k++;
                    i++;
                }
                else
                {
                    C[k] = B[j];
                    k++;
                    j++;
                }
            }
            while (i < A.Length)
            {
                C[k] = A[i];
                k++;
                i++;
            }
            while (j < B.Length)
            {
                C[k] = B[j];
                k++;
                j++;
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {
            int max = -999999999;
            int max_ind = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    max_ind = i;
                }
            }
            int[] clone = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                clone[(i+max_ind%array.Length) % array.Length] = array[i];
            }

            for (int j = 0; j < array.Length; j++)
            {
                array[j] = clone[j];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            N = N - 1;
            int l = N;
            int r = array.Length-N-1;
            int n = 0;
            
            if (l < r)
            {
                n = l;
            } else
            {
                n = r;
            }
            for (int i=0; i<n; i++)
            {
                int c1 = N - 1 - i;
                int c2 = N + 1 + i;
                array[c2] = array[c1];
            }

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a > b)
            {
                return (null, null);
            }
            if (a == b && n == 1)
            {
                Xext = new double[0];
                Yext = new double[0];
                return (Xext, Yext);
            }
            if (n < 3)
            {
                return (null, null);
                
            }
            if (a == b && n > 1)
            {
                return (null, null);
            }
            X = new double[n];
            Y = new double[n];
            double step = (b - a) / (n - 1);
            for (int i=0; i<n; i++)
            {
                X[i] = a + i * step;
                double x = a + i * step;
                Y[i] = Math.Cos(x) + x * Math.Sin(x);
            }
            double[] tX = new double[n - 2];
            double[] tY = new double[n - 2];
            int count = 0;
            for (int i = 1; i < X.Length - 1; i++)
            {
                if (Y[i] > Y[i-1] && Y[i] > Y[i + 1])
                {
                    tX[count] = X[i];
                    tY[count] = Y[i];
                    count++;
                } else if (Y[i] < Y[i-1] && Y[i] < Y[i + 1])
                {
                    tX[count] = X[i];
                    tY[count] = Y[i];
                    count++;
                }
            }
            Xext = new double[count];
            Yext = new double[count];
            for (int i = 0; i < count; i++)
            {
                Xext[i] = tX[i];
                Yext[i] = tY[i];
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
            double sr = sum / (double) raw.Length;
            double[] tbright = new double[raw.Length];
            int br_count = 0;
            int dim_count = 0;
            int nrm_count = 0;
            double[] tdim = new double[raw.Length];
            double[] tnormal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr)
                {
                    tbright[br_count] = raw[i];
                    br_count++;
                } else if (raw[i] < 0.5 * sr)
                {
                    tdim[dim_count] = raw[i];
                    dim_count++;
                } else
                {
                    tnormal[i] = raw[i];
                    nrm_count++;
                }
            }

            double sum_nrm = 0;
            for (int i = 0; i<raw.Length; i++)
            {
                if (tnormal[i] != 0)
                {
                    sum_nrm += tnormal[i];
                }
            }
            double sr_nrm = sum_nrm / (double)nrm_count;
            for (int i = 0; i<raw.Length; i++)
            {
                if (tnormal[i] == 0)
                {
                    tnormal[i] = 0.5 * (sr_nrm + raw[i]);
                } 
            }
            tnormal = doubleSort(tnormal);
            tnormal = doubleReverse(tnormal);
            normal = new double[raw.Length];

            for (int i=0; i<raw.Length; i++)
            {
                normal[i] = tnormal[i];
            }
            bright = new double[br_count];
            for (int i = 0; i < br_count; i++)
            {
                bright[i] = tbright[i];
            }
            dim = new double[dim_count];
            for (int i = 0; i < dim_count; i++)
            {
                dim[i] = tdim[i];
            }
            // end
            return (bright, normal, dim);
        }
    }
}