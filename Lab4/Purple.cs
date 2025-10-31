namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            int maxIndex = 0;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex])
                    maxIndex = i;
                sum += array[i];
            }
            
            sum /= array.Length;

            for (int i = maxIndex + 1; i < array.Length; i++)
                array[i] = sum;
            return;

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;
            even = new int[(array.Length + 1) >> 1];
            odd = new int[array.Length >> 1];
            //branch-predictor friendly
            for (int i = 0; i < even.Length; i++)
                even[i] = array[i << 1];
            for (int i = 0; i < odd.Length; i++)
                odd[i] = array[(i << 1) + 1];
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer =  new int[array.Length + 1];
            int aI = 0, sum = 0;
            for (int i = 0; i < array.Length; i++)
                sum += array[i];
            for (int i = 0; i < array.Length; i++)
                if (Math.Abs(array[i] * array.Length - sum) < Math.Abs(array[aI] * array.Length - sum))
                    aI = i;
            for (int i = 0; i <= aI; i++)
                answer[i] = array[i];
            answer[aI + 1] = P;
            for (int i = aI + 1; i < array.Length; i++)
                answer[i + 1] = array[i];
            return answer;
        }
        public void Task4(int[] array)
        {
            int[] ans = new int[array.Length];
            int cnt = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] >= 0)
                    ans[cnt++] = array[i];
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0)
                    ans[cnt++] = array[i];
            for (int i = 0; i < array.Length; i++)
                array[i] = ans[i];
        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            if (k > A.Length)
                return A;
            int[] answer = new int[A.Length + B.Length];
            for (int i = 0; i < k; i++)
                answer[i] = A[i];
            for (int i = k; i < k + B.Length; i++)
                answer[i] = B[i - k];
            for (int i = k + B.Length; i < answer.Length; i++)
                 answer[i] = A[i - B.Length];
            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            if (A.Length != B.Length)
                return (null, null);
            int[] sum = new int[A.Length], dif = new int[B.Length];
            for (int i = 0; i < A.Length; i++)
                sum[i] = A[i] + B[i];
            for (int i = 0; i < B.Length; i++)
                dif[i] = A[i] - B[i];
            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            int min = array[0], max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
                max = Math.Max(max, array[i]);
            }

            if (min == max)
                return null;
            double[] normalized = new Double[array.Length];
            for (int i = 0; i < array.Length; i++)
                normalized[i] = -1.0 + (double)(array[i] - min) / (double)(max - min) * 2.0;
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = new int[A.Length +  B.Length];
            for (int i = 1; i < A.Length; i++)
                for (int j = 1; j < A.Length; j++)
                    if (A[j] > A[j - 1])
                        (A[j], A[j - 1]) = (A[j - 1], A[j]);
            for (int i = 1; i < B.Length; i++)
                for (int j = 1; j < B.Length; j++)
                    if (B[j] > B[j - 1])
                        (B[j], B[j - 1]) = (B[j - 1], B[j]);
            int l = 0, r = 0;
            for (int i = 0; i < C.Length; i++)
                if (l != A.Length && (r == B.Length || A[l] > B[r]))
                    C[i] = A[l++];
                else
                    C[i] = B[r++];
            return C;
        }
        public void Task9(int[] array)
        {
            int mI = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > array[mI])
                    mI = i;
            int [] answer = new int[array.Length];
            for (int i =  0; i < array.Length; i++)
                answer[i] = array[(array.Length + i - mI) % array.Length];
            for (int i = 0; i < array.Length; i++)
                array[i] = answer[i];
        }
        public void Task10(int[] array, int N)
        {
            --N;
            for (int i = 1; i <= N; i++)
            {
                if (N + i >= array.Length)
                    break;
                array[N + i] = array[N - i];
            }
        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            if (n < 2)
                return (new double[0], new double[0]);
            else if (a >= b)
                return (null, null);
            
            double[] X = new double[n], Y = new double[n];
            double[] Xext = null, Yext = null;

            for (int i = 0; i < n; i++)
            {
                double x = ((double)(i) / (n - 1)) * (b - a) + a;
                double y = Math.Cos(x) + x * Math.Sin(x);
                X[i] = x;
                Y[i] = y;
            }
            
            int cnt = 0;
            for (int i = 1; i + 1 < n; i++)
            {
                if ((Y[i - 1] < Y[i] && Y[i + 1] < Y[i])
                    || (Y[i - 1] > Y[i] && Y[i + 1] > Y[i]))
                    cnt++;
            }
            
            Xext = new double[cnt];
            Yext = new double[cnt];
            cnt = 0;
            
            for (int i = 1; i + 1 < n; i++)
            {
                if ((Y[i - 1] < Y[i] && Y[i + 1] < Y[i])
                    || (Y[i - 1] > Y[i] && Y[i + 1] > Y[i]))
                {
                    Xext[cnt] = X[i];
                    Yext[cnt++] = Y[i];
                }
            }
            
            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            double sum = 0;
            for (int i = 0; i < raw.Length; i++)
                sum += raw[i];
            sum /= raw.Length;

            int bc = 0, dc = 0;
            for (int i = 0; i < raw.Length; i++)
                if (raw[i] > 2 * sum)
                    bc++;
                else if (raw[i] * 2 < sum)
                    dc++;
            
            bright = new double[bc];
            dim = new double[dc];

            bc = 0;
            dc = 0;
            for (int i = 0; i < raw.Length; i++)
                if (raw[i] > 2 * sum)
                    bright[bc++] = raw[i];
                else if (raw[i] * 2 < sum)
                    dim[dc++] = raw[i];
            
            normal = new double[raw.Length];
            
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sum || raw[i] * 2 < sum)
                    normal[i] = (raw[i] + sum) / 2.0;
                else
                    normal[i] = raw[i];
            }
            
            for (int i = 1; i < normal.Length; i++)
                for (int j = 1; j < normal.Length; j++)
                    if (normal[j] > normal[j - 1])
                        (normal[j], normal[j - 1]) = (normal[j - 1], normal[j]);
            
            return (bright, normal, dim);
        }
    }
}
