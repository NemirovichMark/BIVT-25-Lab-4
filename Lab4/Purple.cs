namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double m = double.MinValue;
            double c = array.Length, s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                if (array[i] > m) m = array[i];
            }

            double sr = s / c;
            bool f = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (!f)
                {
                    array[i] = sr;
                }
                if (array[i] == m)
                {
                    f = false;
                }
                
            }

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int k1 = 0, k2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) k1++;
                else k2++;
            }
            even = new int[k1];
            odd = new int[k2];
            int i1 = 0, i2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0) {
                    even[i1] = array[i];
                    i1++;
                        }
                else {
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
            int s = 0, c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                c++;
            }
            double sr = (double) s / c;
            answer = new int[c + 1];
            double r = double.MaxValue;
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - sr) < r)
                {
                    r = Math.Abs(array[i] - sr);
                    ind = i;
                }
            }
            bool f = true;
            for (int i = 0, i2 = 0; i < array.Length + 1; i++, i2++)
            {
                if (i == ind + 1 && f)
                {
                    answer[i] = P;
                    i2--;
                    f = false;
                    continue;
                }
                answer[i] = array[i2];
            }
                // end
            
                return answer;
        }   
        public void Task4(int[] array)
        {

            // code here
            int k1 = 0, k2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) k1++;
                else k2++;
            }
            int[] pol = new int[k1], otr = new int[k2];
            int c1 = 0, c2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) { 
                    pol[c1] = array[i];
                    c1++;
                }
                else
                {
                    otr[c2] = array[i];
                    c2++;
                }

            }
            int i1 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < pol.Length) array[i] = pol[i];
                else {
                    array[i] = otr[i1];
                    i1++;
                        }
                
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];

            if (k == A.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[i + A.Length] = B[i];
                }
                
            }
            else if (k < A.Length)
            {
                for (int i = 0; i < k; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[i + k] = B[i];
                }
                for (int i = 0; i < A.Length - k; i++)
                {
                    answer[i + B.Length + k] = A[i + k];
                }
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

                for (int i = 0; i < A.Length; ++i) {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }

            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            // code here
            double[] normalized = new double[array.Length];
            double min = double.MaxValue, max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
                if (array[i] < min)
                {
                    min = array[i];
                }
            }
            if (min == max)
            {
                return null;
            }
            for (int i = 0; i < array.Length; i++)
            {
                double t = 2 * (array[i] - min) / (max - min) - 1;
                normalized[i] = t;
            }
            // end 

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            C = new int[A.Length + B.Length];
            for (int f = 0; f < A.Length; f++)
            {
                C[f] = A[f];
            }
            for (int f = 0; f < B.Length; f++)
            {
                C[A.Length + f] = B[f];
            }
            int i = 1, j = 2;
            while (i < A.Length + B.Length)
            {
                if (i == 0 || C[i - 1] >= C[i])
                {
                    i = j;
                    j++;
                }
                else
                {
                    (C[i], C[i - 1]) = (C[i - 1], C[i]);
                    i--;
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here

            if (array.Length == 0) return;

            int ind = 0, max = int.MinValue;
            for (int i = 0; i < array.Length; i++) { 
                if (array[i] > max)
                {       
                    max = array[i];
                    ind = i;
                }
            }

            int start = 0, end = 0;
            for (int i = 0; i < ind; i++)
            {
                int last = array[^1];
                for (int k = array.Length - 1; k > 0; k--)
                {
  
                        array[k] = array[k - 1];
                    
                }
                array[0] = last;
            }
            // end
        }
        public void Task10(int[] array, int N)
        {

            // code here
            if (array == null || array.Length == 0 || N <= 1 || N > array.Length)
                return;

            int[] c = new int[N - 1];
            for (int i = 0; i < N - 1; i++) { 
                c[i] = array[N - i - 2];
            }
            int k = Math.Min(c.Length,array.Length - N);
                for (int i = 0; i < k; i++)
                {
                    array[N + i] = c[i];
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

            double step = 0;
            if (n == 1) step = (a + b) / 2;
            else step = (b - a) / (n - 1);

            if (step != 0 && b >= a)
            {
                int ind = 0;
                for (double x = a; x <= b + 0.0001; x += step)
                {
                    double y = Math.Cos(x) + x * Math.Sin(x);
                    X[ind] = x;
                    Y[ind] = y;
                    ind++;
                }

                int k = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if (((Y[i - 1] < Y[i]) && (Y[i + 1] < Y[i])) || ((Y[i - 1] > Y[i]) && (Y[i + 1] > Y[i]))) k++;
                }
  
                if (true)
                {
                    Xext = new double[k];
                    Yext = new double[k];
                    ind = 0;
                }
                for (int i = 1; i < n - 1; i++)
                {
                    if (((Y[i - 1] < Y[i]) && (Y[i + 1] < Y[i])) || ((Y[i - 1] > Y[i]) && (Y[i + 1] > Y[i])))
                    {
                        Xext[ind] = X[i];
                        Yext[ind] = Y[i];
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
            int brightCount = 0, normalCount = 0, dimCount = 0;
            double normalSum = 0;
            double totalSum = 0;

            for (int i = 0; i < raw.Length; i++)
            {
                totalSum += raw[i];
            }
            double average = totalSum / raw.Length;

            double[] brightValues = new double[raw.Length], normalValues = new double[raw.Length], dimValues = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] / average > 2) brightValues[brightCount++] = raw[i];
                else if (raw[i] / average < 0.5) dimValues[dimCount++] = raw[i];
                else
                {
                    normalValues[normalCount++] = raw[i];
                    normalSum += raw[i];
                }
            }
            double normalAverage = normalSum / normalCount;

            bright = new double[brightCount];
            for (int i = 0; i < brightCount; i++)
            {
                bright[i] = brightValues[i];
            }

            dim = new double[dimCount];
            for (int i = 0; i < dimCount; i++)
            {
                dim[i] = dimValues[i];
            }

            normal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if ((raw[i] / average <= 2) && (raw[i] / average >= 0.5))
                {
                    normal[i] = raw[i];
                }
                else
                {
                    normal[i] = (raw[i] + normalAverage) / 2;
                }
            }
            for (int i = 0; i < raw.Length; i++)
            {
                bool swapped = false;
                for (int j = 0; j < raw.Length - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        swapped = true;
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                    }
                }
                if (!swapped) break;
            }
            // end

            return (bright, normal, dim);
        }
    }
}
