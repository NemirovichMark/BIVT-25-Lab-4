namespace Lab4
{
    public class Purple
    {
        public void Task1(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIndex]) maxIndex = i;
            int sum = 0;
            for (int i = 0; i < array.Length; i++) sum += array[i];
            double avg = (double)sum / array.Length;
            for (int i = maxIndex + 1; i < array.Length; i++)
                array[i] = (int)Math.Round(avg);
        }

        public void Task2(int[] array, out int[] even, out int[] odd)
        {
            if (array == null) { even = new int[0]; odd = new int[0]; return; }
            List<int> evenList = new List<int>();
            List<int> oddList = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) evenList.Add(array[i]);
                else oddList.Add(array[i]);
            }
            even = evenList.ToArray();
            odd = oddList.ToArray();
        }

        public int[] Task3(int[] array, int P)
        {
            if (array == null || array.Length == 0) return new int[0];
            double avg = array.Average();
            int nearest = 0;
            double minDiff = Math.Abs(array[0] - avg);
            for (int i = 1; i < array.Length; i++)
            {
                double diff = Math.Abs(array[i] - avg);
                if (diff < minDiff)
                {
                    minDiff = diff;
                    nearest = i;
                }
            }
            int[] result = new int[array.Length + 1];
            for (int i = 0; i <= nearest; i++) result[i] = array[i];
            result[nearest + 1] = P;
            for (int i = nearest + 1; i < array.Length; i++)
                result[i + 1] = array[i];
            return result;
        }

        public void Task4(int[] array)
        {
            if (array == null || array.Length == 0) return;
            List<int> positive = new List<int>();
            List<int> negative = new List<int>();
            foreach (int x in array)
            {
                if (x >= 0) positive.Add(x);
                else negative.Add(x);
            }
            int idx = 0;
            foreach (int x in positive) array[idx++] = x;
            foreach (int x in negative) array[idx++] = x;
        }

        public int[] Task5(int[] A, int[] B, int k)
        {
            if (A == null || B == null) return new int[0];
            if (k < 0) k = 0;
            if (k > A.Length) k = A.Length;
            int[] result = new int[A.Length + B.Length];
            for (int i = 0; i < k; i++) result[i] = A[i];
            for (int i = 0; i < B.Length; i++) result[k + i] = B[i];
            for (int i = k; i < A.Length; i++) result[B.Length + i] = A[i];
            return result;
        }

        public void Task6(int[] A, int[] B, out int[] sum, out int[] diff)
        {
            if (A == null || B == null || A.Length != B.Length)
            {
                sum = new int[0];
                diff = new int[0];
                return;
            }
            int n = A.Length;
            sum = new int[n];
            diff = new int[n];
            for (int i = 0; i < n; i++)
            {
                sum[i] = A[i] + B[i];
                diff[i] = A[i] - B[i];
            }
        }

        public double[] Task7(int[] array)
        {
            if (array == null || array.Length == 0) return new double[0];
            int min = array.Min();
            int max = array.Max();
            if (min == max) return new double[0];
            double[] norm = new double[array.Length];
            for (int i = 0; i < array.Length; i++)
                norm[i] = -1 + 2.0 * (array[i] - min) / (max - min);
            return norm;
        }

        public int[] Task8(int[] A, int[] B)
        {
            if (A == null || B == null) return new int[0];
            int[] res = new int[A.Length + B.Length];
            A = A.OrderByDescending(x => x).ToArray();
            B = B.OrderByDescending(x => x).ToArray();
            int i = 0, j = 0, k = 0;
            while (i < A.Length && j < B.Length)
            {
                if (A[i] >= B[j]) res[k++] = A[i++];
                else res[k++] = B[j++];
            }
            while (i < A.Length) res[k++] = A[i++];
            while (j < B.Length) res[k++] = B[j++];
            return res;
        }

        public void Task9(int[] array)
        {
            if (array == null || array.Length == 0) return;
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx]) maxIdx = i;
            int shift = maxIdx;
            int[] res = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
                res[(i + shift) % array.Length] = array[i];
            for (int i = 0; i < array.Length; i++)
                array[i] = res[i];
        }

        public void Task10(int[] array, int N)
        {
            if (array == null || N < 0 || N >= array.Length - 1) return;
            int len = Math.Min(N + 1, array.Length - (N + 1));
            for (int i = 0; i < len; i++)
                array[N + 1 + i] = array[N - i];
        }

        public void Task11(double a, double b, int n, out double[] X, out double[] Y, out double[] Xext, out double[] Yext)
        {
            if (n <= 1)
            {
                X = new double[0];
                Y = new double[0];
                Xext = new double[0];
                Yext = new double[0];
                return;
            }

            X = new double[n];
            Y = new double[n];
            double h = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                X[i] = a + h * i;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }

            List<double> xext = new List<double>();
            List<double> yext = new List<double>();
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1] && Y[i] > Y[i + 1]) || (Y[i] < Y[i - 1] && Y[i] < Y[i + 1]))
                {
                    xext.Add(X[i]);
                    yext.Add(Y[i]);
                }
            }
            Xext = xext.ToArray();
            Yext = yext.ToArray();
        }

        public void Task12(double[] data, out double[] bright, out double[] normal, out double[] dim)
        {
            if (data == null || data.Length == 0)
            {
                bright = new double[0];
                normal = new double[0];
                dim = new double[0];
                return;
            }

            double avg = data.Average();
            List<double> b = new List<double>();
            List<double> n = new List<double>();
            List<double> d = new List<double>();

            foreach (double x in data)
            {
                if (x > 2 * avg) b.Add(x);
                else if (x < 0.5 * avg) d.Add(x);
                else n.Add(x);
            }

            bright = b.ToArray();
            dim = d.ToArray();
            normal = n.OrderByDescending(x => x).ToArray();
        }
    }
}