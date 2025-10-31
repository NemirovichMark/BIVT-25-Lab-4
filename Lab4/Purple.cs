namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here

            int n = array.Length;
            double sum_elem = 0;
            double max_val = array[0];
            int max_ind = 0;
            for (int i = 0; i < n; i++)
            {
                if (max_val < array[i])
                {
                    max_val = array[i];
                    max_ind = i;
                }
                sum_elem += array[i];
            }
            double mid = sum_elem / n;

            for (int i = max_ind + 1; i < n; i++)
            {
                array[i] = mid;
            }

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here

            int n = array.Length;
            odd = new int[n / 2];
            even = new int[n - odd.Length];
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
            int sum_elem = 0;
            foreach (int elem in array)
            {
                sum_elem += elem;
            }
            double mid = (double)sum_elem / n;

            int closest_ind = 0;
            double closest_dif = Math.Abs(array[0] - mid);
            for (int i = 0; i < n; i++)
            {
                double new_dif = Math.Abs(array[i] - mid);
                if (new_dif < closest_dif)
                {
                    closest_dif = new_dif;
                    closest_ind = i;
                }
            }
            answer = new int[n + 1];
            for (int i = 0; i <= closest_ind; i++)
            {
                answer[i] = array[i];
            }
            answer[closest_ind + 1] = P;
            for (int i = closest_ind + 1; i < n; i++)
            {
                answer[i + 1] = array[i];
            }

            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here

            int n = array.Length;
            int neg_size = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    neg_size++;
                }
            }
            int pos_size = n - neg_size;

            var pos = new int[pos_size];
            var neg = new int[neg_size];

            int pos_ind = 0, neg_ind = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    neg[neg_ind++] = array[i];
                }
                else
                {
                    pos[pos_ind++] = array[i];
                }
            }
            for (int i = 0; i < pos_size; i++)
            {
                array[i] = pos[i];
            }
            for (int i = pos_size; i < n; i++)
            {
                array[i] = neg[i - pos_size];
            }

            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here

            if (k < A.Length)
            {
                answer = new int[A.Length + B.Length];
                for (int i = 0; i < k; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[i + k] = B[i];
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[B.Length + i] = A[i];
                }
            }
            if (answer == null)
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
                int n = A.Length;
                sum = new int[n];
                dif = new int[n];

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

            int n = array.Length;
            int MinVal = array[0], MaxVal = array[0];
            for (int i = 0; i < n; i++)
            {
                MinVal = Math.Min(MinVal, array[i]);
                MaxVal = Math.Max(MaxVal, array[i]);
            }
            if (MinVal != MaxVal)
            {
                normalized = new double[n];
                for (int i = 0; i < n; i++)
                {
                    normalized[i] = ((double)(array[i] - MinVal)) / (MaxVal - MinVal) * 2 - 1;
                }
            }

            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            int n = A.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int MaxInd = i;
                int MaxVal = A[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] > MaxVal)
                    {
                        MaxInd = j;
                        MaxVal = A[j];
                    }
                }
                (A[i], A[MaxInd]) = (A[MaxInd], A[i]);
            }

            int m = B.Length;
            for (int i = 0; i < m - 1; i++)
            {
                int MaxInd = i;
                int MaxVal = B[i];
                for (int j = i + 1; j < m; j++)
                {
                    if (B[j] > MaxVal)
                    {
                        MaxInd = j;
                        MaxVal = B[j];
                    }
                }
                (B[i], B[MaxInd]) = (B[MaxInd], B[i]);
            }

            C = new int[n + m];
            int i_A = 0, i_B = 0, i_C = 0;
            while (i_A < n || i_B < m)
            {
                if (i_A < n && i_B < m)
                {
                    if (A[i_A] > B[i_B])
                    {
                        C[i_C++] = A[i_A++];
                    }
                    else
                    {
                        C[i_C++] = B[i_B++];
                    }
                }
                else if (i_A < n)
                {
                    C[i_C++] = A[i_A++];
                }
                else
                {
                    C[i_C++] = B[i_B++];
                }
            }

            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here

            int n = array.Length;
            int MaxInd = 0;
            int MaxVal = array[0];
            for (int i = 0; i < n; i++)
            {
                if (array[i] > MaxVal)
                {
                    MaxVal = array[i];
                    MaxInd = i;
                }
            }

            var moved = new int[n];
            for (int i = 0; i < n; i++)
            {
                moved[(i + MaxInd) % n] = array[i];
            }
            // // Console.WriteLine(string.Join(" ", moved));
            for (int i = 0; i < n; i++)
            {
                array[i] = moved[i];
            }

            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here

            N--;
            for (int move = 1; move <= N && N + move < array.Length; move++)
            {
                array[N + move] = array[N - move];
            }

            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here

            X = new double[n];
            Y = new double[n];

            if (n == 1)
            {
                X[0] = (a + b) / 2;
            }
            else if (n >= 2)
            {
                double dif = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    X[i] = a + dif * i;
                }
            }
            for (int i = 0; i < n; i++)
            {
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            //// Console.WriteLine($"X: {string.Join(" ", X)}");
            //// Console.WriteLine($"Y: {string.Join(" ", Y)}");

            if (a == b && n == 1 || a < b)
            {
                int cntExt = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if (Y[i - 1] < Y[i] && Y[i] > Y[i + 1] ||
                        Y[i - 1] > Y[i] && Y[i] < Y[i + 1])
                    {
                        cntExt++;
                    }
                }

                Xext = new double[cntExt];
                Yext = new double[cntExt];
                int iExt = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if (Y[i - 1] < Y[i] && Y[i] > Y[i + 1] ||
                        Y[i - 1] > Y[i] && Y[i] < Y[i + 1])
                    {
                        Xext[iExt] = X[i];
                        Yext[iExt++] = Y[i];
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

            // a

            int n = raw.Length;
            int bright_len = 0, dim_len = 0;

            double sum = 0;
            foreach (double x in raw)
            {
                sum += x;
            }
            double mid = sum / n;
            // Console.WriteLine($"mid: {mid}");

            foreach (double x in raw)
            {
                if (x > mid * 2)
                {
                    bright_len++;
                }
                if (x * 2 < mid)
                {
                    dim_len++;
                }
            }

            bright = new double[bright_len];
            dim = new double[dim_len];
            int i_bright = 0, i_dim = 0;

            for (int i = 0; i < n; i++)
            {
                if (raw[i] > mid * 2)
                {
                    bright[i_bright++] = raw[i];
                }
                if (raw[i] * 2 < mid)
                {
                    dim[i_dim++] = raw[i];
                }
            }
            // Console.WriteLine($"bright: {string.Join(" ", bright)}");
            // Console.WriteLine($"dim: {string.Join(" ", dim)}");

            // b

            int good_cnt = n - bright_len - dim_len;
            normal = new double[n];
            double good_sum = 0;

            for (int i = 0; i < n; i++)
            {
                if (!(raw[i] > mid * 2 || raw[i] * 2 < mid))
                {
                    normal[i] = raw[i];
                    good_sum += normal[i];
                }
            }
            // Console.WriteLine($"normal: {string.Join(" ", normal)}");
            double good_mid = good_sum / good_cnt;
            // Console.WriteLine($"good_mid: {good_mid}");

            // c

            for (int i = 0; i < n; i++)
            {
                if (raw[i] > mid * 2 || raw[i] * 2 < mid)
                {
                    normal[i] = (good_mid + raw[i]) / 2;
                }
            }
            // Console.WriteLine($"normal: {string.Join(" ", normal)}");

            // d

            for (int i = 0; i < n; i++)
            {
                bool changed = false;
                for (int j = 1; j < n - i; j++)
                {
                    if (normal[j - 1] < normal[j])
                    {
                        (normal[j - 1], normal[j]) = (normal[j], normal[j - 1]);
                        changed = true;
                    }
                }
                if (!changed)
                {
                    break;
                }
            }
            // Console.WriteLine($"normal: {string.Join(" ", normal)}");

            // end

            return (bright, normal, dim);
        }
    }
}