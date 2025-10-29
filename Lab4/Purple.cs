namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double mx = int.MinValue;
            double summ = 0;
            double average = 0;
            int ind = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    ind = i;
                }
                summ += array[i];
            }
            average = summ / array.Length;

            for (int i = array.Length-1; i>ind; i--)
            {
                array[i] = average;
            }

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            even = new int[array.Length / 2 + array.Length % 2];
            odd = new int[array.Length / 2];
            for (int i = 0; i < array.Length; i++)
            {
                if (i%2==0)
                {
                    even[i/2] = array[i];
                }
                else
                {
                    odd[i/2] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            int[] a = new int[array.Length + 1];
            double diff = int.MaxValue;
            double summ = 0;
            double average = 0;
            int ind = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            average = summ / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(average - array[i])<diff)
                {
                    diff = Math.Abs(array[i] - average);
                    ind = i;
                }
            }
            for (int i = 0; i < array.Length+1; i++)
            {
                if (i <= ind) a[i] = array[i];
                else if (i == ind + 1) a[i] = P;
                else a[i] = array[i - 1];
            }
            answer = a;
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int count_pos = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) count_pos++;
            }

            int[] pos = new int[count_pos];
            int[] neg = new int[array.Length - count_pos];

            int countn = 0; int countp = 0;

            for (int i =0; i< array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    pos[countp] = array[i];
                    countp++;
                }
                else
                {
                    neg[countn] = array[i];
                    countn++;
                }
            }

            for (int i = 0; i < pos.Length; i++) array[i] = pos[i];
            for (int i = 0; i < neg.Length; i++) array[i + pos.Length] = neg[i];
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            if (k == A.Length)
            {
                int ind = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    answer[ind++] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[ind++] = B[i];
                }
            }
            else if (k < A.Length)
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
            else
            {
                answer = new int[A.Length]; 
                for (int i = 0; i < A.Length; i++)
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
            if (A.Length == B.Length)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
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
            bool f = true;
            int el = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == el) continue;
                else
                {
                    f = false;
                    break;
                }
            }

            if (f==false)
            {
                normalized = new double[array.Length];
                double mn = int.MaxValue; double mx = int.MinValue;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < mn) mn = array[i];
                    if (array[i] > mx) mx = array[i];
                }
                for (int i = 0; i < normalized.Length; i++)
                {
                    normalized[i] = -1 + (array[i] - mn) / (mx - mn) * (1 - (-1));
                }
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++) C[i] = A[i];
            for (int i = 0; i < B.Length; i++) C[i + A.Length] = B[i];

            int n = C.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (C[j] < C[j + 1]) (C[j], C[j + 1]) = (C[j + 1], C[j]);
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int ind = 0;
            int mx = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>mx)
                {
                    ind = i;
                    mx = array[i];
                }
            }

            int[] a = new int[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (i+ind >= array.Length)
                {
                    a[i + ind - array.Length] = array[i];
                }
                else
                {
                    a[i + ind] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++) array[i] = a[i];
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int left = N - 2, right = N;
            while (left >= 0 && right < array.Length)
            {
                array[right] = array[left];
                right++;
                left--;
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            double d = 0;
            if (n == 1)
            {
                Xext = new double[0];
                Yext = new double[0];
                return (Xext, Yext);
            }
            else if (n <= 2 || a >= b)
            {
                return (Xext, Yext);
            }
            else
            {
                d = (b - a) / (n - 1);
                X = new double[n];
                Y = new double[n];
                for (int i = 0; i < n; i++)
                {
                    X[i] = a + d * i;
                    Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
                }

                int count = 0;

                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i-1] < Y[i] && Y[i] > Y[i+1]) || (Y[i-1] > Y[i] && Y[i] < Y[i+1]))
                    {
                        count++;
                    }
                }

                Xext = new double[count];
                Yext = new double[count];
                count = 0;

                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                    {
                        Xext[count] = X[i];
                        Yext[count] = Y[i];
                        count++;
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
            double average = 0;
            double sum = 0;
            for (int i = 0; i < raw.Length; i++) sum += raw[i];
            average = sum/ raw.Length;

            int n1 = 0, n2 = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] / average > 2) n1++;
                else if (raw[i] < average / 2) n2++;
            }

            bright = new double[n1];
            dim = new double[n2];
            normal = new double[raw.Length - n1 - n2];

            n1 = 0; n2 = 0; int n3 = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] / average > 2)
                {
                    bright[n1] = raw[i];
                    n1++;
                }
                else if (raw[i] < average / 2)
                {
                    dim[n2] = raw[i];
                    n2++;
                }
                else
                {
                    normal[n3] = raw[i];
                    n3++;
                }
            }

            double norm_sum = 0;
            for (int i = 0; i < normal.Length; i++) norm_sum += normal[i];

            double norm_average = norm_sum / (normal.Length);

            double[] extra = new double[raw.Length];
            for (int i = 0; i < normal.Length; i++) extra[i] = normal[i];
            for (int i = 0; i < bright.Length; i++) extra[i + normal.Length] = (norm_average + bright[i]) / 2;
            for (int i = 0; i < dim.Length; i++) extra[i + normal.Length + bright.Length] = (norm_average + dim[i]) / 2;

            int n = extra.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (extra[j] < extra[j + 1]) (extra[j], extra[j + 1]) = (extra[j + 1], extra[j]);
                }
            }

            normal = new double[raw.Length];
            for (int i = 0; i < extra.Length; i++) normal[i] = extra[i];
            // end

            return (bright, normal, dim);
        }
    }

}
