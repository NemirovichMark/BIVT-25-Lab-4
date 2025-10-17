using System.Numerics;
using System.Xml.Serialization;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double im = array[0];
            int ind = 0;
            double s = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > im)
                {
                    im = array[i];
                    ind = i;
                }
                s += array[i];
            }
            double sr = s / array.Length;
            for (int j = ind + 1; j < array.Length; j++)
            {
                array[j] = sr;
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int ind1 = 0;
            int ind2 = 0;
            int l = array.Length;
            int ch, nech;
            ch = (l + 1) / 2;
            nech = l / 2;
            even = new int[ch];
            odd = new int[nech];
            for (int i = 0; i < l; i++)
            {
                if (i % 2 == 0 && ind1 < ch)
                {
                    even[ind1] = array[i];
                    ind1++;
                }
                else if (i % 2 == 1 && ind2 < nech)
                {
                    odd[ind2] = array[i];
                    ind2++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            answer = new int[array.Length + 1];
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
            }
            double sr = s / array.Length;
            double r = 10000000;
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - sr) < Math.Abs(r))
                {
                    r = array[i] - sr;
                    ind = i;
                }
            }
            for (int i = 0; i <= ind; i++)
            {
                answer[i] = array[i];
            }
            answer[ind + 1] = P;
            for (int i = ind + 1; i < array.Length; i++)
            {
                answer[i + 1] = array[i];
            }

            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0) n++;
            }
            int[] pos = new int[n];
            int[] neg = new int[array.Length - n];
            int ind1 = 0, ind2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 0)
                {
                    pos[ind1] = array[i];
                    ind1++;
                }
                else
                {
                    neg[ind2] = array[i];
                    ind2++;
                }
            }
            for (int i = 0; i < n; i++)
            {
                array[i] = pos[i];
            }
            for (int i = n; i < array.Length; i++)
            {
                array[i] = neg[i - n];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            
            if (k <= A.Length)
            {
                answer = new int[A.Length + B.Length];
                for (int i = 0; i < k; i++)
                {
                    answer[i] = A[i];
                }
                for (int i = 0; i < B.Length; i++)
                {
                    answer[i+k] = B[i];
                }
                for (int i = k; i < A.Length; i++)
                {
                    answer[i + B.Length] = A[i];
                }
            }
            else answer = A;
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            int mx;
            mx = A.Length;
            if (A.Length == B.Length && A != null && B != null)
            {
                sum = new int[mx];
                dif = new int[mx];
                for (int i = 0; i < mx; i++)
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
            int mx = -100000;
            int mn = 1000000;
            normalized = new double[array.Length];
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
            if (mx != mn)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    normalized[i] = -1 + Math.Abs((array[i] - mn)) * 2.0 / Math.Abs((mx - mn));
                }
            }
            else normalized = null;

            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length+B.Length];
            int n1 = A.Length;
            for (int d = 0; d < A.Length; d++)
            {
                for (int p = 0; p < n1 - 1; p++)
                {
                    if (A[p] < A[p + 1])
                    {
                        int temp = A[p];
                        A[p] = A[p + 1];
                        A[p + 1] = temp;
                    }
                }
            }
            for (int d = 0; d < B.Length; d++)
            {
                for (int p = 0; p < B.Length - 1; p++)
                {
                    if (B[p] < B[p + 1])
                    {
                        int temp = B[p];
                        B[p] = B[p + 1];
                        B[p + 1] = temp;
                    }
                }
            }
            //    double amx = A[p];
            //    int imx = p;
            //    for (int r = p + 1; r < n1; r++)
            //    {
            //        if (A[r] > amx)
            //        {
            //            amx = A[r];
            //            imx = r;
            //        }
            //    }
            //    (A[p], A[imx]) = (A[imx], A[p]);
            //}
            //int n2 = B.Length;
            //for (int p = 0; p < n2 - 1; p++)
            //{
            //    double amx = B[p];
            //    int imx = p;
            //    for (int r = p + 1; r < n2; r++)
            //    {
            //        if (B[r] > amx)
            //        {
            //            amx = B[r];
            //            imx = r;
            //        }
            //    }
            //    (B[p], B[imx]) = (B[imx], B[p]);
            //}
            int i = 0, j = 0, k = 0;
            while (i < A.Length && j < B.Length)
            {
                if (A[i] >= B[j])
                    C[k++] = A[i++];
                else
                    C[k++] = B[j++];
            }
            while (i < A.Length)
            {
                C[k++] = A[i++];
            }
            while (j < B.Length)
            {
                C[k++] = B[j++];
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = -1000000;
            int ind = 0;
            int[] ans = new int[array.Length];
            
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] > mx))
                {
                    mx = array[i];
                    ind = i;
                }
            }
            for (int i = 0; i < array.Length - ind; i++)
            {
                ans[i + ind] = array[i];
            }
            int k = 0;
            for (int i = array.Length - ind; i < array.Length; i++)
            {
                ans[k++] = array[i];
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
            int cen = N - 1;
            int pr = array.Length - N;
            int lev = N - 1;
            int f = 0;
            if (pr > lev) f = lev;
            else f = pr;
            if (N > 1)
            {

                for (int i = 0; i < f; i++)
                {
                    if (i < f)
                    {
                        array[N + i] = array[N - 2 - i];
                    }
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (b > a || (a == b && n == 1))
            {
                double h = (b - a) / (n - 1);
                X = new double[n];
                Y = new double[n];
                int ind = 0;
                for (double x = a; x <= b + 0.0001; x += h)
                {
                    X[ind] = x;
                    Y[ind] = Math.Cos(x) + x * Math.Sin(x);
                    ind++;
                }
                int count = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                    {
                        count++;
                    }
                }
                Xext = new double[count];
                Yext = new double[count];
                int kx = 0;
                int ky = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i - 1] < Y[i] && Y[i] > Y[i + 1]) || (Y[i - 1] > Y[i] && Y[i] < Y[i + 1]))
                    {
                        Xext[kx++] = X[i];
                        Yext[ky++] = Y[i];
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
            double sr = 0;
            double s = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                s += raw[i];
            }
            sr = s / raw.Length;
            int nb = 0;
            int nd = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr) { nb++; }
                else if (raw[i] < sr / 2) { nd++; }
            }
            bright = new double[nb];
            dim = new double[nd];
            normal = new double[raw.Length];
            int indb = 0;
            int indd = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr) 
                {
                    bright[indb++] = raw[i];
                    //raw[i] = 0;
                }
                else if (raw[i] < sr / 2) 
                {
                    dim[indd++] = raw[i];
                    //raw[i] = 0;
                }
            }
            double sb = 0;
            double sd = 0;
            double srn = 0;
            for (int i = 0; i < bright.Length; i++)
            {
                sb += bright[i];
            }
            for (int i = 0; i < dim.Length; i++)
            {
                sd += dim[i];
            }
            srn = (s - sd - sb) / (raw.Length - nb - nd);
         
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr || raw[i] < sr / 2)
                {
                    normal[i] = (srn + raw[i]) / 2;
                }
                else normal[i] = raw[i];
            }

            for (int i = 0; i < normal.Length - 1; i++)
            {
                double mx = normal[i];
                int mind = i;
                for (int j = i + 1; j < normal.Length; j++)
                {
                    if (normal[j] > mx)
                    {
                        mx = normal[j];
                        mind = j;
                    }
                }
                (normal[i], normal[mind]) = (normal[mind], normal[i]);
            }
            // end

            return (bright, normal, dim);
        }
    }
}