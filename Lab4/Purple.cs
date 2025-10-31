namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            double t = 0;
            double maxx = array[0];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                t += 1;
                if (array[i] > maxx)
                {
                    ind = i;
                    maxx = array[i];
                }
            }
            double sr = (double)s / t;
            for (int i = ind + 1; i < array.Length; i++)
            {
                array[i] = sr;
            }
            Console.Write(string.Join(" ", array));
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
            }
            else
            {
                even = new int[array.Length / 2 + 1];
                odd = new int[array.Length / 2];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[i / 2] = array[i];
                }
                else
                {
                    odd[(i - 1) / 2] = array[i];
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double delta = 100000000000;
            int ind = 0;
            answer = new int[array.Length + 1];
            double sr = 0;
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            sr = s / array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(sr - array[i]) < delta)
                {
                    delta = Math.Abs(sr - array[i]);
                    ind = i;
                }
            }
            for (int i = 0; i < array.Length + 1; i++)
            {
                if (i <= ind)
                {
                    answer[i] = array[i];
                }
                else if (i == ind + 1)
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
            int[] temp = new int[array.Length];
            int plus = 0;
            int minus = array.Length - 1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    temp[plus] = array[i];
                    plus++;
                }
            }

            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] < 0)
                {
                    temp[minus] = array[i];
                    minus--;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = temp[i];
            }
        
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k > A.Length)
            {
                answer = new int[A.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                }
            }
            else
            {
                answer = new int[A.Length + B.Length];
                int ind = k;

                for (int i = 0; i < A.Length + B.Length; i++)
                {
                    if (i < k)
                    {
                        answer[i] = A[i];
                    }
                    else if (ind - k < B.Length)
                    {
                        answer[i] = B[ind - k];
                        ind++;
                    }
                    else
                    {
                        answer[i] = A[i - B.Length];
                    }
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
            double min = array[0];
            double max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < min)
                    min = array[i];
                if (array[i] > max)
                    max = array[i];
            }
            if (min != max)
            {

                double range = max - min;
                normalized = new double[array.Length];
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = 2 * (array[i] - min) / range - 1;
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
            for (int i = 0; i < A.Length - 1; i++)
            {
                for (int j = 0; j < A.Length - 1; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        (A[j], A[j + 1]) = (A[j + 1], A[j]);
                    }
                }
            }
            for (int i = 0; i < B.Length - 1; i++)
            {
                for (int j = 0; j < B.Length - 1; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        (B[j], B[j + 1]) = (B[j + 1], B[j]);
                    }
                }
            }
            int a = 0;
            int b = 0;
            int ind = 0;
            while (a < A.Length && b < B.Length)
            {
                if (A[a] > B[b])
                {
                    C[ind] = A[a++];
                    ind++;
                }
                else
                {
                    C[ind] = B[b++];
                    ind++;
                }
            }
            while (a < A.Length)
            {
                C[ind++] = A[a++];
            }
            while (b < B.Length)
            {
                C[ind++] = B[b++];
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int step = 0;
            double max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    step = i;
                    max = array[i];
                }
            }
            int[] a = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                a[(i + step) % array.Length] = array[i];
            }
            for (int i = 0; i < a.Length; i++)
            {
                array[i] = a[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int ind = N - 1;
            int leftCount = ind;
            int rightCount = array.Length - ind - 1;
            int count = Math.Min(leftCount, rightCount);
            for (int i = 0; i < count; i++)
            {
                int leftind = ind - 1 - i;
                int rightind = ind + 1 + i;
                array[rightind] = array[leftind];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;
            if (a > b)
                return (null, null);

            if (a == b)
            {
                if (n == 1)
                    return (new double[0], new double[0]);
                else
                    return (null, null);
            }

            if (n < 3)
                return (null, null);

            X = new double[n];
            Y = new double[n];

            double h = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * h;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    count++;
                }
            }

            if (count == 0)
            {
                Xext = new double[0];
                Yext = new double[0];
                return (Xext, Yext);
            }

            Xext = new double[count];
            Yext = new double[count];
            int k = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) ||
                    (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    Xext[k] = X[i];
                    Yext[k] = Y[i];
                    k++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            //double s = 0;
            //for (int i = 0; i < raw.Length; i++)
            //{
            //    s += raw[i];
            //}
            //double sr1 = s / raw.Length;
            //double[] a = new double[raw.Length];
            ////double[] b = new double[raw.Length];
            //double[] re = new double[raw.Length];
            //double t = 0;
            //double sum = 0;
            //for (int i = 0; i <  raw.Length; i++)
            //{
            //    if (sr1 / raw[i] > 2)
            //    {
            //        a[i] = raw[i];
            //        raw[i] = 0;
            //    }
            //    else if (raw[i] /  sr1 > 2)
            //    {
            //        a[i] = raw[i];
            //        raw[i] = 0;
            //    }
            //    else
            //    {
            //        sum += raw[i];
            //        t ++;
            //    }
            //}
            //double sr2 = sum / t;

            //for (int i = 0; i < raw.Length; i++)
            //{
            //    if (raw[i] == 0 && a[i] != 0)
            //    {
            //        raw[i] = (sr2 + a[i]) / 2;
            //    }
            //}
            //Array.Sort(raw);
            //Array.Reverse(raw);
            double sm = 0, sr = 0;
            int count_bright = 0, count_dim = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sr += raw[i];
            }
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] * raw.Length > 2 * sr)
                {
                    count_bright++;
                    sm += raw[i];
                }
                else if (raw[i] * raw.Length * 2 < sr)
                {
                    count_dim++;
                    sm += raw[i];
                }
            }
            bright = new double[count_bright];
            dim = new double[count_dim];
            normal = new double[raw.Length];
            int index_bright = 0, index_dim = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] * raw.Length > 2 * sr)
                {
                    bright[index_bright] = raw[i];
                    normal[i] = (double)(Math.Abs(sm - sr) / (raw.Length - count_bright - count_dim) + raw[i]) / 2;
                    index_bright++;
                }
                else if (raw[i] * raw.Length * 2 < sr)
                {
                    dim[index_dim] = raw[i];
                    normal[i] = (double)(Math.Abs(sm - sr) / (raw.Length - count_bright - count_dim) + raw[i]) / 2;
                    index_dim++;
                }
                else
                {
                    normal[i] = raw[i];

                }
            }
            for (int i = 0; i < normal.Length; i++)
            {
                for (int j = 0; j < normal.Length - 1; j++)
                {
                    if (normal[j + 1] > normal[j])
                    {
                        (normal[j + 1], normal[j]) = (normal[j], normal[j + 1]);
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}
