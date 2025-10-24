using System.Diagnostics.CodeAnalysis;
using System.Xml.Serialization;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double max = double.MinValue;
            double sr = 0;
            int indmax=0;
            foreach (double a in array)
            {
                sr += a;
            }
            sr /= array.Length;
            for (int i = 0; i < array.Length; i++) if (array[i] > max) max = array[i];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    indmax = i;
                    break;
                }
            }
            for (int i = indmax + 1; i < array.Length; i++) array[i] = sr;
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int dlina = array.Length;
            int ela = 0;
            int elb = 0;
            if (dlina % 2 == 0)
            {
                even = new int[dlina / 2];
                odd = new int[dlina / 2];
            }
            else
            {
                even = new int[1 + dlina / 2];
                odd = new int[dlina / 2];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even[ela] = array[i];
                    ela++;
                }
                else
                {
                    odd[elb] = array[i];
                    elb++;
                }
            }
                // end

                return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int[] nov = new int[array.Length + 1];
            double[] mod = new double[array.Length];
            double minrazn = double.MaxValue;
            double sr = 0;
            int indmin = 0;
            foreach (int i in array) sr += i;
            sr /= array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                mod[i] = Math.Abs(array[i] - sr);
            }
            foreach (double i in mod) minrazn = Math.Min(i, minrazn);
            for (int i = 0; i < mod.Length; i++)
            {
                if (mod[i] == minrazn)
                {
                    indmin = i; break;
                }
            }
            for (int i = 0; i <= indmin; i++)
            {
                nov[i] = array[i];
            }
            nov[indmin+1] = P;
            for (int i = indmin+1; i < array.Length; i++) nov[i + 1] = array[i];
            answer = nov;
            // end

            return answer;
        }
        public void Task4(int[] array)
        {

            // code here
            int otr=0;
            int pol=0;
            int indpol = 0;
            int indotr = 0;
            foreach(int i in array)
            {
                if (i < 0) otr++;
                else pol++;
            }
            int[] mpol = new int[pol];
            int[] motr = new int[otr];
            int[] nova = new int[array.Length];
            foreach(int i in array)
            {
                if (i < 0) motr[indotr++] = i; else mpol[indpol++] = i;
            }
            indpol = 0;indotr = 0;
            for(int i=0;i<array.Length;i++)
            {
                if (i < mpol.Length) array[i] = mpol[indpol++];
                else array[i] = motr[indotr++];
            }
            // end

        }
        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            int[] obie = new int[A.Length + B.Length];
            if (k > A.Length) answer = A;
            else if (k == (A.Length))
            {
                int elb = 0;
                for (int i = 0; i < A.Length; i++) obie[i] = A[i];
                for (int i = A.Length; i < obie.Length; i++) obie[i] = B[elb++];
                answer = obie;
            }
            else if (k == 0)
            {
                int ela = 0;
                for (int i = 0; i < B.Length; i++) obie[i] = B[i];
                for (int i = B.Length; i < obie.Length; i++) obie[i] = A[ela++];
                answer = obie;
            }
            else
            {
                k += 1;
                int elb = 0;
                int ela = 0;
                for (int i = -1; i < k - 1; i++) obie[i + 1] = A[ela++];
                for (int i = k - 1; i < k + B.Length - 1; i++) obie[i] = B[elb++];
                ela -= 1;
                for (int i = k + B.Length - 1; i < obie.Length; i++) obie[i] = A[ela++];
                answer = obie;
            }
            // end

            return answer;
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            if (A.Length != B.Length)
            {
                sum = null;
                dif = null;
            }
            else
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
            double mmax = int.MinValue;
            double mmin = int.MaxValue;
            double[] drob = new double[array.Length];
            bool vse = true;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] != array[i + 1]) { vse = false;break; }
            }
            if (vse) return null;
            foreach (int i in array)
            {
                mmax = Math.Max(mmax, i);
                mmin = Math.Min(mmin, i);
            }
            for (int i = 0; i < array.Length; i++)
            {
                drob[i] = -1 + ((double)array[i] - mmin) * 2 / (mmax - mmin);
            }
            normalized = drob;
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            C = new int[A.Length + B.Length];
            int elc = 0;
            for (int i = 0; i < A.Length; i++)
            {
                C[elc++] = A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                C[elc++] = B[i];
            }
            for (int i = 0; i < C.Length; i++)
            {
                for (int j = 0; j < C.Length - 1; j++)
                {
                    if (C[j + 1] > C[j])
                    {
                        int t = C[j + 1];
                        C[j + 1] = C[j];
                        C[j] = t;
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
            int indm=0;
            for (int i = 0; i < array.Length; i++) max = Math.Max(max, array[i]);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    indm = i;break;
                }
            }
            int[] sdvig = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (i + indm < array.Length) sdvig[i + indm] = array[i];
                else
                {
                    sdvig[i + indm - array.Length] = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = sdvig[i];
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int[] zerk = new int[array.Length];
            if (N >= array.Length || N == 0 || N == 1) zerk = array;
            else if ((array.Length - N) > (N - 1))
            {
                int elz = N;

                for (int i = N - 2; i >= 0; i--) zerk[elz++] = array[i];
                for (int i = 0; i < array.Length; i++) if (zerk[i] == 0) zerk[i] = array[i];
            }
            else
            {
                int ela = N - 2;
                for (int i = N; i < array.Length; i++) zerk[i] = array[ela--];
                for (int i = 0; i < N; i++) zerk[i] = array[i];
            }
            for (int i = 0; i < array.Length; i++) array[i] = zerk[i];
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a >= b && n!=1) return (null, null);

            X = new double[n];
            Y = new double[n];
            double[] nol= new double[] {  };
            if (n==1 || n==2) return (nol, nol);
            int kvoext = 0;
            int el = 0;
            for (double i = a; i < b + 0.0001; i += ((b-a)/(n-1)))
            {
                X[el] = i;
                Y[el] = Math.Cos(i) + (i * Math.Sin(i));
                el++;
            }
            for (int i = 1; i < X.Length-1; i++)
            {
                if ((Y[i] > Y[i+1] && Y[i] > Y[i-1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1])) kvoext++;
            }
            Xext = new double[kvoext]; Yext = new double[kvoext];
            if (kvoext==0) return (Xext, Yext);
            int elex = 0;
            for (int i = 1; i < X.Length - 1; i++)
            {
                if ((Y[i] > Y[i + 1] && Y[i] > Y[i - 1]) || (Y[i] < Y[i + 1] && Y[i] < Y[i - 1]))
                {
                    Yext[elex] = Y[i];
                    Xext[elex] = X[i];
                    elex++;
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
            for (int i = 0; i < raw.Length; i++) normal[i] = raw[i];
            double sred = 0;
            int yark = 0; int kvoy = 0;
            int tusk = 0; int kvot = 0;
            double sredost = 0;
            foreach (double i in raw) sred += i;
            sred /= raw.Length;
            foreach(double i in raw)
            {
                if (i > sred * 2) kvoy++;
                if (i < sred / 2) kvot++;
            }
            bright = new double[kvoy];
            dim = new double[kvot];
            double sredy = 0, sredt = 0;
            for(int i = 0, ely=0,elt=0; i < raw.Length; i++)
            {
                if (raw[i] > sred * 2) { bright[ely++] = raw[i]; sredy += raw[i]; }
                if (raw[i] < sred / 2) { dim[elt++] = raw[i]; sredt += raw[i]; }
            }
            sredy /= raw.Length;
            sredt /= raw.Length;
            double sredn = (sred - (sredy + sredt)) * raw.Length / (raw.Length - (bright.Length + dim.Length));
            for (int i = 0; i < normal.Length; i++)
            {
                if (normal[i] > sred * 2) normal[i] = (sredn + normal[i]) / 2.0;
                if (normal[i] < sred / 2) normal[i] = (sredn + normal[i]) / 2.0;
            }
            for(int i = 0; i < normal.Length; i++)
            {
                for(int j = 0; j < normal.Length - 1; j++)
                {
                    if (normal[j] < normal[j + 1]) (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                }
            }
            // end

            return (bright, normal, dim);
        }
    }
}
