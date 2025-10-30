namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double mx = -1000000000;
            double sum = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                }
                sum += array[i];
            }
            double srzn = sum / array.Length;
            int index=array.Length;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                {
                    index=i+1;
                    break;
                }
            }
            for (int i = index; i < array.Length; i++)
            {
                array[i] = srzn;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            if (array.Length % 2 == 0 && array.Length > 0)
            {
                even = new int[array.Length / 2];
                odd = new int[array.Length / 2];
            }
            else if (array.Length % 2 == 1 && array.Length > 0)
            {
                even = new int[array.Length / 2 + 1];
                odd = new int[(array.Length) / 2];
            }
            if (even is not null && odd is not null)
            {
                for (int i = 0; i < array.Length; i++)
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
            }
                // end

                return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            if (array.Length > 0)
            {
                answer = new int[array.Length + 1];
            }
            double sum = 0;
            double srzn = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            srzn = sum / array.Length;
            double mn = 100000000000;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - srzn) < mn)
                {
                    mn = Math.Abs(array[i] - srzn);
                }
            }
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - srzn) == mn)
                {
                    index = i + 1;
                    break;
                }
            }
            for (int i = 0; i < answer.Length; i++)
            {
                if (i < index)
                {
                    answer[i] = array[i];
                }
                else if (i == index)
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

            int minus = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    minus++;
                }
            }
            int plus = array.Length - minus;
            int[] minusy = new int[minus];
            int[] plusy = new int[plus];
            int indexmin = 0;
            int indexplus = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    minusy[indexmin++] = array[i];
                }
                else
                {
                    plusy[indexplus++] = array[i];
                }
            }
            for (int i = 0; i < plus; i++)
            {
                array[i] = plusy[i];
            }
            for (int i = plus; i < array.Length; i++)
            {
                array[i] = minusy[i - plus];
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
                for (int i = k; i < k + B.Length; i++)
                {
                    answer[i] = B[i - k];
                }
                for (int i = k + B.Length; i < answer.Length; i++)
                {
                    answer[i] = A[i - B.Length];
                }
            }
            else if (k == A.Length)
            {
                answer = new int[A.Length + B.Length];
                for (int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = k; i < answer.Length; i++)
                {
                    answer[i] = B[i - k];
                }
            }
            else if (k > A.Length)
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
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1])
                {
                    f = false;
                }
            }
            if (f == false)
            {
                normalized = new double[array.Length];
                long mx = -100000000;
                long mn = 1000000000;
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
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = (((double)2 * (array[i] - mn) / (mx - mn)) ) - 1;
                }

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
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] < A[j + 1])
                    {
                        (A[j], A[j + 1]) = (A[j + 1], A[j]);
                    }
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B.Length - i - 1; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        (B[j], B[j + 1]) = (B[j + 1], B[j]);
                    }
                }
            }
            C = new int[A.Length + B.Length];
            int m = 0, k = 0, n = 0;
            while (m < A.Length && k < B.Length)
            {
                if (A[m] > B[k])
                {
                    C[n++] = A[m++];
                }
                else
                {
                    C[n++] = B[k++];
                }
            }
            while (m < A.Length)
            {
                C[n++] = A[m++];
            }
            while (k < B.Length)
            {
                C[n++] = B[k++];
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = -1000000000;
            int shift = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == mx)
                {
                    shift = i;
                    break;
                }
            }
            for (int i = 0; i < shift; i++)
            {
                int temp = array[array.Length - 1];
                for (int j = array.Length - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            for (int i = 1; i < N && i < array.Length - N + 1; i++)
            {
                array[N + i - 1] = array[N - i - 1];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            double h = (double)(b - a) / (n - 1);
            if (a < b)
            {
                X = new double[n];
                Y = new double[n];
            }
            else if (a == b && n == 1)
            {
                X = new double[0];
                Y = new double[0];
            }
            if (X is not null && Y is not null)
            {
                double x = a;
                for (int i = 0; i < X.Length; i++)
                {
                    X[i] = x;
                    Y[i] = Math.Cos(x) + x * Math.Sin(x);
                    x += h;

                }
                int count = 0;
                for (int i = 1; i < Y.Length - 1; i++)
                {
                    if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1])
                    {
                        count++;
                    }
                    if (Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                    {
                        count++;
                    }
                }
                Yext = new double[count];
                Xext = new double[count];
                int p = 0;
                for (int i = 1; i < Y.Length - 1; i++)
                {
                    if (Y[i] > Y[i - 1] && Y[i] > Y[i + 1])
                    {
                        Yext[p] = Y[i];
                        Xext[p] = X[i];
                        p++;
                    }
                    if (Y[i] < Y[i - 1] && Y[i] < Y[i + 1])
                    {
                        Yext[p] = Y[i];
                        Xext[p] = X[i];
                        p++;
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
            double srzn = 0;
            for(int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            srzn = sum / raw.Length;
            int brightin = 0;
            int dimin=0;
            double newsum = 0;
            for(int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * srzn)
                {
                    brightin++;
                }
                if (raw[i] < srzn/2)
                {
                    dimin++;
                }
                if (raw[i]>=srzn/2 && raw[i] <= 2 * srzn)
                {
                    newsum += raw[i];
                }
            }
            bright = new double[brightin];
            dim = new double[dimin];
            double newsrzn = newsum / (raw.Length - brightin - dimin);
            int k = 0, j = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * srzn)
                {
                    bright[j]=raw[i];
                    raw[i] = (raw[i] + newsrzn) / 2;
                    j++;
                }
                if (raw[i] < srzn / 2)
                {
                    dim[k]=raw[i];
                    raw[i] = (raw[i] + newsrzn) / 2;
                    k++;
                }

            }
            normal =raw;
            for (int i = 0; i < normal.Length; i++)
            {
                for (int l = 0; l < normal.Length - i - 1; l++)
                {
                    if (normal[l] < normal[l + 1])
                    {
                        (normal[l], normal[l + 1]) = (normal[l + 1], normal[l]);
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}