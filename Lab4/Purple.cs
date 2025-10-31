namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            int M=0;
            double nf = array[^1], S=0;
            for (int i = array.Length - 1; i >= 0; i--)
            {
                if (array[i] >= nf)
                {
                    M = i;
                    nf = array[i];
                }
                S += array[i];
            }
            S = S / array.Length;
            for (int i = M+1; i < array.Length; i++)
            {
                array[i] = S;
            }
            Console.WriteLine(string.Join(", ", array));

            // end


        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            odd = new int[array.Length / 2];
            even = new int[(array.Length+1) / 2];
            int iodd = 0, ieven=0; 
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[ieven]=array[i];
                    ieven++;
                }
                else
                {
                    odd[iodd]=array[i];
                    iodd++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length+1];
            double S = 0;
            foreach (int i in array)
            {
                S += i;
            }
            S = S / array.Length;
            double R = Math.Abs(array[^1]-S);
            int M = array.Length - 1;
            for (int i = array.Length-1; i>=0; i--)
            {
                if (Math.Abs(array[i] - S) <= R)
                {
                    M = i;
                    R = Math.Abs(array[i] - S);
                }
            }
            bool fl = true;
            for (int i = 0; i < array.Length; i++)
            {
                if (i == M+1)
                {
                    answer[i] = P;
                    fl = false;
                }
                if (fl) answer[i] = array[i];
                if (!fl) answer[i+1] = array[i];
            }
            if (array.Length == 1)
            {
                answer[1] = P;
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int pos = 0, neg = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) pos++;
                if (array[i] < 0 ) neg++;
            }
            int[] POS = new int[pos];
            int[] NEG = new int[neg];
            int iP=0, iN=0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) POS[iP++] = array[i];
                if (array[i] < 0 ) NEG[iN++] = array[i];
            }
            
            for (int i = 0; i < POS.Length; i++)
            {
                array[i] = POS[i];
            }
            for (int i = 0; i < NEG.Length; i++)
            {
                array[POS.Length + i] = NEG[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (A.Length < k) answer = A;
            else
            {
                answer = new int[A.Length + B.Length];
                for (int i = 0; i < k; i++)
                {
                    answer[i] = A[i];
                }
                int iB = 0;
                for (int i = k; i < k + B.Length; i++)
                {
                    answer[i] = B[iB];
                    iB++;
                }
                int iA = k;
                for (int i = k + B.Length; i < A.Length + B.Length; i++)
                {
                    answer[i] = A[iA];
                    iA++;
                }
            }
            Console.WriteLine(string.Join(", ", answer));
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            int n = A.Length > B.Length ? A.Length : B.Length;
            int z = A.Length > B.Length ? B.Length : A.Length;
            //int[] x = A.Length > B.Length ? A : B;
            if (A.Length == B.Length)
            {
                sum = new int[n];
                dif = new int[n];
                for (int i = 0; i < z; i++)
                {
                    sum[i] = A[i] + B[i];
                    dif[i] = A[i] - B[i];
                }
            }
            //if (A.Length != B.Length)
            //{
            //    for (int i = z; i < n; i++)
            //    {
            //        sum[i] = x[i];
            //        dif[i] = x[i];
            //    }
            //}
            // end

            return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            normalized = new double[array.Length];
            int mn = int.MaxValue, mx = int.MinValue;
            foreach (int i in array)
            {
                if (i < mn) mn = i;
                if (i > mx ) mx = i;
            }
            if (mn == mx) return null;

            for (int i = 0; i < array.Length; i++)
            {
                normalized[i] = 2.0 * (array[i] - mn) / (mx - mn) - 1.0;
            }

            Console.WriteLine("{0}, {1}", mn, mx);
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
                for (int j = 0; j < A.Length - i - 1; j++)
                {
                    if (A[j] < A[j+1]) (A[j], A[j+1]) = (A[j+1], A[j]);
                }
            }
            for (int i = 0; i < B.Length - 1; i++)
            {
                for (int j = 0; j < B.Length - i - 1; j++)
                {
                    if (B[j] < B[j + 1]) (B[j], B[j + 1]) = (B[j + 1], B[j]);
                }
            }
            Console.WriteLine(string.Join(",", A));
            Console.WriteLine(string.Join(",", B));

            int z = 0, x = 0, c = 0;
            while (z < A.Length && x<B.Length)
            {
                if (A[z] >= B[x]) C[c++]=A[z++];
                else C[c++] = B[x++];
            }
            while (z < A.Length)
            {
                C[c++] = A[z++];
            }
            while (x < B.Length)
            {
                C[c++] = B[x++];
            }
            Console.WriteLine(string.Join(",", C));
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = int.MinValue, t=-1;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    t = i;
                }
            }
            t = t % array.Length;
            for (int i=0; i<t; i++)
            {
                int temp = array[array.Length - 1];
                for (int j = array.Length-1; j>0; j--)
                {
                    array[j] = array[j-1];
                }
                array[0] = temp;
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            //if (N < 1) return;
            //int[] Z = new int[N-1];
            //for (int i = 0; i < N - 1; i++)
            //{
            //    Z[i]=array[N-i-2];
            //}
            //int n = Z.Length;
            //int k = array.Length - N;
            //for (int i=0; i<n; i++)
            //{
            //    if (k==i) break;
            //    array[N+i]=Z[i];
            //}
            //Console.WriteLine(string.Join(", ", array));
            int l = N - 2, r = N;
            while (l >= 0 && r < array.Length)
            {
                array[r] = array[l];
                r++;
                l--;
            }
            Console.WriteLine(string.Join(", ", array));
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (n == 1)
            {
                Xext = new double[0];
                Yext = new double[0];
                return (Xext, Yext);
            }
            else if (n < 3 || a >= b) return (Xext, Yext);
            X = new double[n];
            Y = new double[n];
            double h = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                X[i] = a + i * h;
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }
            int e = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1]) && (Y[i] > Y[i + 1]) || ((Y[i] < Y[i - 1]) && (Y[i] < Y[i + 1]))) e++;
            }
            Xext = new double[e];
            Yext = new double[e];
            int cnt = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if ((Y[i] > Y[i - 1]) && (Y[i] > Y[i + 1]) || ((Y[i] < Y[i - 1]) && (Y[i] < Y[i + 1])))
                {
                    Xext[cnt] = X[i];
                    Yext[cnt] = Y[i];
                    cnt++;
                }
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double S = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                S += raw[i];
            }
            double ave = S / raw.Length;
            int j = 0, h = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (ave * 2 < raw[i]) j++;
                if (ave / 2 > raw[i]) h++;
            }
            bright = new double[j];
            dim = new double[h];
            normal = new double[raw.Length - j - h];
            j = 0; h= 0;
            int k = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (ave * 2 < raw[i])
                {
                    bright[j] = raw[i];
                    j++;
                }
                else if (ave / 2 > raw[i])
                {
                    dim[h] = raw[i];
                    h++;
                }
                else
                {
                    normal[k] = raw[i];
                    k++;
                }
            }
            S = 0;
            for (int i = 0; i < normal.Length; i++)
            {
                S += normal[i];
            }
            ave = S / normal.Length;
            double[] E = new double[raw.Length];

            for (int i = 0; i < normal.Length; i++)
            {
                E[i] = normal[i];
            }
            for (int i = 0; i < bright.Length; i++)
            {
                E[i + normal.Length] = (ave + bright[i]) / 2;
            }
            for (int i = 0; i < dim.Length; i++)
            {
                E[i + normal.Length + bright.Length] = (ave + dim[i]) / 2;
            }

            int n = E.Length;
            bool swapped = false;
            for (int i = 0; i < n - 1; i++)
            {
                for (j = 0; j < n - i - 1; j++)
                {
                    if (E[j] < E[j + 1]) (E[j], E[j + 1]) = (E[j + 1], E[j]);
                    swapped = true;
                }
                if (!swapped) break;
            }

            normal = E;
            // end

            return (bright, normal, dim);
        }
    }

}
