using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double mx = -10000;
            int imx = 0;
            double summ = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    imx = i;
                }
                summ+= array[i];
            }
            for (int i = imx+1; i < array.Length; i++)
            {
                array[i] = summ / array.Length;
            }
        }
            // end

        

        public (int[] even, int[] odd) Task2(int[] array)
        {

            // code here
            int[] even = null, odd = null;
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
            int evenI = 0, oddI = 0;
            for (int i = 0; i < array.Length; i++)
                {
                    if (i % 2 == 0)
                    {
                        even[evenI++] = array[i];
                    }
                else
                {
                    odd[oddI++] = array[i];
                }
                }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;
            double summ = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                summ += array[i];
            }
            double mse = summ / array.Length;
            double r = 10000;
            int ielem = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - mse) < r)
                {
                    r = Math.Abs(array[i] - mse);
                    ielem = i;
                }
            }
            answer = new int[array.Length+1];
            int inow = 0;
            for (int i = 0; i < array.Length; i++)
            {   
                answer[inow] = array[i];
                inow++;
                if (i == ielem) {
                    answer[inow] = P;
                    inow++;
                }
            }
            

            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int[] positives = array.Where(x => x >= 0).ToArray();
            int[] negatives = array.Where(x => x < 0).ToArray();
            int inow = 0;
            for (int i =0; i < positives.Length; i++)
            {
                array[inow++] = positives[i];
            }
            for (int i = 0; i < negatives.Length; i++)
            {
                array[inow++] = negatives[i];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            
            answer = new int[A.Length+B.Length];
            if (k > A.Length)
            {
                return A;
            }
            int inow = 0;

            for (int i = 0; i < k; i++) {
                answer[inow++] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                answer[inow++] = B[i];
            }
            for (int i = k; i < A.Length; i++)
            {
                answer[inow++] = A[i];
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
                dif = new int[B.Length];
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
            double maxe = -1000;
            double mine = 1000;
            double sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxe)
                {
                    maxe = array[i];
                }
                if (array[i] < mine)
                {
                    mine = array[i];
                }
                sum += array[i];
            }
            if (sum != array[0] * array.Length)
            {
                normalized = new double[array.Length];
                int inow = 0;
                for (int i = 0;i < array.Length; i++)
                {
                    normalized[inow++] = 2 * (Convert.ToDouble(array[i])-mine)/(maxe-mine) - 1;
                }
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length+B.Length];
            int inow = 0;
            for (int i = 0; i < A.Length; i++)
            {
                C[inow++] = A[i];
            }
            for (int i = 0; i<B.Length; i++)
            {
                C[inow++] = B[i];
            }
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < C.Length - 1; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        (C[j], C[j + 1]) = (C[j+1], C[j]);
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int mx = -1000;
            int imx = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mx)
                {
                    mx = array[i];
                    imx = i;
                }
            }
            int[] result = new int[array.Length];
            for (int i = imx;i< result.Length; i++)
            {
                result[i] = array[i-imx];
            }
            for (int i = 0; i < imx; i++)
            {
                result[i] = array[i + result.Length-imx];
            }
            for (int i = 0; i < array.Length; i++)
                array[i] = result[i];
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            for (int i = N;i< array.Length; i++)
            {
                if (2*(N-1)-i >= 0)
                {
                    array[i] = array[2 * (N - 1) - i];
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a < b || (a == b && n == 1))
            {



                X = new double[n];
                Y = new double[n];
                int inow = 0;
                double step = (b - a) / (n - 1);
                for (double x = a; x <= (b + step / 2); x += step)
                {

                    X[inow] = x;
                    Y[inow++] = Math.Cos(x) + x * Math.Sin(x);
                }
                int len = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i] > Y[i - 1]) && (Y[i] > Y[i + 1]))
                    {
                        len++;
                    }
                    else if ((Y[i] < Y[i - 1]) && (Y[i] < Y[i + 1]))
                    {
                        len++;
                    }
                }
                Xext = new double[len];
                Yext = new double[len];
                inow = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i] > Y[i - 1]) && (Y[i] > Y[i + 1]))
                    {
                        Xext[inow] = X[i];
                        Yext[inow++] = Y[i];
                    }
                    else if ((Y[i] < Y[i - 1]) && (Y[i] < Y[i + 1]))
                    {
                        Xext[inow] = X[i];
                        Yext[inow++] = Y[i];
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
            normal = new double[raw.Length];
            double mse = 0;
            
            for (int i = 0; i < raw.Length; i++)
            {
                mse += raw[i];
            }
            mse = mse / raw.Length;
            bright = raw.Where(x => x > 2 * mse).ToArray();
            dim = raw.Where(x => x < mse / 2).ToArray();
            double sumNew = 0;
            double iNew = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2*mse || raw[i]<mse/2)
                {
                    continue;
                }
                else
                {
                    sumNew += raw[i];
                    iNew++;
                }
            }
            double mseNew = sumNew / iNew;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * mse || raw[i] < mse / 2)
                {
                    raw[i] = (mseNew + raw[i]) / 2;
                }
            }
            int ine = 0;
            for (int i =0;i<raw.Length; i++)
            {
                normal[ine++] = raw[i];
            }
            for (int i = 0; i < normal.Length; i++)
            {
                for (int j = 0; j < normal.Length - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}