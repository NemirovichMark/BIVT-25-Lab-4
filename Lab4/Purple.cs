using System.Reflection;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            
            double s = 0;
            int index = 0;
            double maxel = double.MinValue;
            
            for (int i = 0; i<array.Length; i++)
            {
                s += array[i];
                if (array[i] > maxel)
                {
                    maxel = array[i];
                    index = i;
                }
            }
            double sr = s / array.Length;
            for (int j = index+1 ; j<array.Length;j++)
            {
                array[j] = sr;
            }
            

            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            even = new int[(array.Length+1) / 2];
            odd = new int[array.Length / 2];
            int countCH = 0;
            int countNCH = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if(i%2==0)
                {
                    even[countCH] = array[i];
                    countCH++;
                }
                if (i%2!=0)
                {
                    odd[countNCH] = array[i];
                    countNCH++;
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
            double s = 0;
            for (int i = 0; i<array.Length;i++)
            {
                s += array[i];
            }
            double sr = s / array.Length;
            
            double zn = double.MaxValue;
            int inds = 0;
            for (int i = 0; i< array.Length; i++)
            {
                if (Math.Abs(sr - array[i])<zn)
                {
                    zn = Math.Abs(sr - array[i]);
                    inds = i;
                    
                }
                
            }
            
            for (int i = 0; i<=inds; i++)
            {
                answer[i] = array[i];
            }
            answer[inds + 1] = P;
            for (int i = inds+1; i< array.Length; i++)
            {
                answer[i+1] = array[i];
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int kn = 0;
            int kp = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] <0)
                {
                    kn++;
                }
                if (array[i] >=0)
                {
                    kp++;
                }
            }
            int[] p = new int[kp];
            int[] n = new int[kn];
            int a = 0;
            int b = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i]>=0)
                {
                    p[a] = array[i];
                    a++;
                }
                if (array[i]<0)
                {
                    n[b] = array[i];
                    b++;
                }
            }


            for (int i = 0; i < p.Length; i++)
            {
                array[i] = p[i];
            }
            int s = 0;
            for(int i = p.Length; i< array.Length; i++)
            {
                array[i] = n[s];
                s++;
            }
            
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            answer = new int[A.Length + B.Length];
            if (k > A.Length) answer = A;
            else
            {
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
                    answer[i + B.Length] = A[i];
                }
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length == B.Length && A != null&& B!= null)
            {
                sum = new int[A.Length];
                dif = new int[A.Length];
                for (int i = 0; i < sum.Length; i++)
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
            normalized = new double[array.Length];
            double min = double.MaxValue;
            double max = double.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >max)
                {
                    max = array[i];
                }
                if (array[i]< min)
                {
                    min = array[i];
                }
            }
            if (max == min)
            {
                normalized = null;
            }
            else
            {
                for (int i = 0; i < normalized.Length; i++)
                {
                    normalized[i] = -1 + ((array[i] - min) * 2) / (max - min);
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
            for(int i = 0; i< A.Length; i++)
            {
                for (int j = 0; j< A.Length-1-i; j++)
                {
                    if (A[j] < A[j+1])
                    {
                        (A[j], A[j + 1]) = (A[j + 1], A[j]);
                    }
                }
            }
            for (int i = 0; i < B.Length; i++)
            {
                for (int j = 0; j < B.Length - 1 - i; j++)
                {
                    if (B[j] < B[j + 1])
                    {
                        (B[j], B[j + 1]) = (B[j + 1], B[j]);
                    }
                }
            }
            for (int i = 0; i< A.Length; i++)
            {
                C[i] = A[i];
            }
            int k = 0;
            for (int i = A.Length; i < C.Length; i++)
            {
                C[i] = B[k];
                k++;
            }
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < C.Length - 1 - i; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        (C[j], C[j + 1]) = (C[j + 1], C[j]);
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int max = int.MinValue;
            int indexofmax = 0;
            int[] copy = new int[array.Length];
            for (int i = 0; i< array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indexofmax = i;
                }
            }
            for (int i = 0; i< array.Length-indexofmax; i++)
            {
                copy[i + indexofmax] = array[i];
            }
            int count = 0;
            for (int i = array.Length - indexofmax; i <array.Length ; i++)
            {
                copy[count] = array[i];
                count++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = copy[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int left = N - 1;
            int right = array.Length - N;
            int p;
            if (right > left)
            {
                p = left;
            }
            else
            {
                p = right;
            }
            for (int i = 0; i < p; i++)
            {
                array[N + i] = array[N - 2 - i];
            }


            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (b > a || (b == a && n == 1))
            {
                double s = (b - a) / (n - 1);
                X = new double[n];
                Y = new double[n];
                int p = 0;
                for (double x = a; x <= b; x += s)
                {
                    X[p] = x;
                    Y[p] = Math.Cos(x) + x * Math.Sin(x);
                    p++;
                }
                int c = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1]))
                    {
                        c++;
                    }
                }
                Xext = new double[c]; Yext = new double[c];
                int kx = 0;
                int ky = 0;
                for (int i = 1; i < n - 1; i++)
                {
                    if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1]))
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
            double S = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                S += raw[i];
            }
            sr = S / raw.Length;
            int cb = 0; int cd = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr)  cb++; 
                else if (raw[i] < sr / 2) cd++; 
            }
            bright = new double[cb]; normal = new double[raw.Length]; dim = new double[cd];
            int b = 0;
            int d = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr)
                {
                    bright[b++] = raw[i];
                }
                else if (raw[i] < sr / 2)
                {
                    dim[d++] = raw[i];
                }
            }
            double bb = 0;
            double dd = 0;
            double n = 0;
            for (int i = 0; i < bright.Length; i++)
            {
                bb += bright[i];
            }
            for (int i = 0; i < dim.Length; i++)
            {
                dd += dim[i];
            }
            n = (S - dd - bb) / (raw.Length - (cd+cb));
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > 2 * sr || raw[i] < sr / 2)
                {
                    normal[i] = (n + raw[i]) / 2;
                }
                else
                {
                    normal[i] = raw[i];
                }
            }
            for (int i = 0; i < normal.Length - 1; i++)
            {
                double max = normal[i];
                int indexofmax = i;
                for (int j = i + 1; j < normal.Length; j++)
                {
                    if (normal[j] > max)
                    {
                        max = normal[j];
                        indexofmax = j;
                    }
                }
                (normal[i], normal[indexofmax]) = (normal[indexofmax], normal[i]);
            }
            // end

            return (bright, normal, dim);
        }
    }
}