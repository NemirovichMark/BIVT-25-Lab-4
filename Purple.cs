using System.ComponentModel.Design;
using System.Reflection.Metadata;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double s = array.Sum(), l = array.Length, m=array.Max();
            bool c = true;
            int j = -1;
            foreach (double i in array)
            {
                j++;
                if (c) array[j] = i;
                else array[j] = s/l;
                if (i == m) c = false;
            }
            return;
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int c,j=-1, e=0, o=0;
            if (array.Length%2==0) c=array.Length/2;
            else c=array.Length/2+1;
            even = new int[c];
            odd = new int[array.Length - c];
            foreach (int i in array)
            {
                j++;
                if (j % 2 == 0) {
                    even[e] = i;
                    e++;
                }
                else
                {
                    odd[o] = i;
                    o++;
                }
            }
            // end

            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            double s = array.Sum(), m=10000000;
            int j = -1, mi= 0, l = array.Length;
            foreach (int i in array)
            {
                j++;
                if (Math.Abs(i - (s / l)) < Math.Abs(m))
                {
                    m = i - (s / l);
                    mi = j;
                    Console.WriteLine(i - (s / l));
                }
            }
            answer = new int[l + 1];
            j = -1;
            foreach (int i in array)
            {
                j++;
                answer[j] = i;
                if (j == mi)
                {
                    j++;
                    answer[j] = P;
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int n = 0, nc=-1, pc=-1;
            foreach (int i in array) if (i < 0) n++;
            int[] neg = new int[n];
            int[] pos = new int[array.Length-n];
            foreach (int i in array)
            {
                if (i < 0)
                {
                    nc++;
                    neg[nc] = i;
                }
                else
                {
                    pc++;
                    pos[pc] = i;
                }
            }
            for (int i = 0; i < array.Length - n; i++) array[i] = pos[i];
            for (int i = array.Length - n; i < array.Length; i++) array[i] = neg[i - (array.Length - n)];
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            if (k < 0) k = 0;
            if (!(k > A.Length))
            {
                answer = new int[A.Length + B.Length];
                for (int i = 0; i < k; i++)
                    answer[i] = A[i];
                for (int i = 0; i < B.Length; i++)
                    answer[k + i] = B[i];
                for (int i = k; i < A.Length; i++)
                    answer[B.Length + i] = A[i];
            }
            else answer = A;

            var str = string.Join(" ", answer);
            Console.WriteLine(str);
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A != null && B != null && A.Length == B.Length)
            {
                int length = A.Length;
                sum = new int[length];
                dif = new int[length];

                for (int i = 0; i < length; i++)
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
            int max = -10000000, min = 10000000;
            normalized = new double[array.Length];
            foreach(int i in array) if (i > max) max = i;
            foreach (int i in array) if (i < min) min = i;
            for (int i = 0; i < array.Length; i++) normalized[i] = -1 + (Math.Abs(min - array[i]) / (Math.Abs(max - min) / 2.0) );
            if (max == min) normalized = null;
            // end

            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length+B.Length];
            for (int i = 0; i < A.Length; i++) C[i] = A[i];
            for (int i = 1; i <= B.Length; i++) C[i+A.Length-1] = B[i-1];
            var str = string.Join(" ", C);
            for (int i = 0; i < C.Length - 1; i++)
            {
                for (int j = 0; j < C.Length - i - 1; j++)
                {
                    if (C[j] < C[j + 1])
                    {
                        int temp = C[j];
                        C[j] = C[j + 1];
                        C[j + 1] = temp;
                    }
                }
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int m = -1000000, im=0;
            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++) if (array[i]>m) m = array[i];
            for (int i = 0; i < array.Length; i++) if (array[i] == m)
                {
                    im = i;
                    break;
                }
            for (int i = 0; i < array.Length; i++)
            {
                if (i - im < 0) copy[i] = array[array.Length + (i - im)];
                else copy[i] = array[Math.Abs((i-im)%array.Length)];
            }
            for (int i = 0; i < array.Length; i++) array[i] = copy[i];
                // end

            }
        public void Task10(int[] array, int N)
        {

            // code here
            if (N == 0) N = 1;
            int[] refl = new int[N-1];
            for(int i=0; i < array.Length; i++)
            {
                if (i<(N-1)) refl[i]=array[i];
                if (i > (N - 1) && i < (N * 2 - 1)) array[i] = refl[refl.Length - 1 - (i-N)];
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (b > a || (b==a && n==1))
            {
                int j = -1, k = -1, c = 0;
                double step = (b - a) / (double)(n - 1), y = 0;
                X = new double[n]; Y = new double[n];
                for (double x = a; x <= b + (step / 2.0); x += step)
                {
                    j++;
                    y = Math.Cos(x) + x * Math.Sin(x);
                    X[j] = x;
                    Y[j] = y;
                }
                for (int i = 1; i < (n - 1); i++) if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1])) c++;
                Xext = new double[c]; Yext = new double[c];
                for (int i = 1; i < (n - 1); i++)
                {
                    if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1]))
                    {
                        k++;
                        Xext[k] = X[i];
                        Yext[k] = Y[i];
                    }
                }
            }
            else
            {
                Xext = null; Yext=null;
            }
            // end

            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double sum = 0, av, avav, avsum=0;
            int cav = 0,ci=-1, updnum=-1, max = 0, imax=-1, min=0, imin=-1;
            
            foreach (double i in raw) sum += i;

            av = sum / raw.Length;
            for (int i = 0; i<raw.Length; i++) if (raw[i] > av * 2 || raw[i] < av / 2.0) cav++;

            for (int i = 0; i < raw.Length; i++) if (raw[i] > av * 2) max++;
            bright = new double[max];
            for (int i = 0; i < raw.Length; i++) if (raw[i] > av * 2)
            {
                imax++;
                bright[imax] = raw[i];
            }

            for (int i = 0; i < raw.Length; i++) if (raw[i] < av /2.0) min++;
            dim = new double[min];
            for (int i = 0; i < raw.Length; i++) if (raw[i] < av/2.0)
                {
                    imin++;
                    dim[imin] = raw[i];
                }

            double[] anomalias = new double[cav];
            normal = new double[raw.Length];
            int[] avinds = new int[cav];

            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > av*2 || raw[i] < av/2.0)
                {
                    ci++;
                    avinds[ci] = i;
                    anomalias[ci] = raw[i];
                }
                else avsum += raw[i];
            }
            avav = avsum/(double)(raw.Length-anomalias.Length);
            for (int i = 0; i < raw.Length; i++)
            {
                normal[i] = raw[i];
                foreach(int j in avinds)
                {
                    if (i == j)
                    {
                        updnum++;
                        normal[i] = ((avav + anomalias[updnum]) / 2.0);
                    }
                } 
            }
            for (int i = 0; i < normal.Length - 1; i++)
            {
                for (int j = 0; j < normal.Length - i - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        double temp = normal[j];
                        normal[j] = normal[j + 1];
                        normal[j + 1] = temp;
                    }
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}