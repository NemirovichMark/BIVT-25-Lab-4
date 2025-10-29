using System.ComponentModel.DataAnnotations;

namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double sum = 0;
            double max = -1000000;
            int index = 0;
            for (int i = 0;  i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] > max)
                {
                    max = array[i];
                    index = i;
                }
            }

            double sr = sum / array.Length;

            for (int i = index + 1; i < array.Length; i++)
            {
                array[i] = sr;
            }   
            // end
        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            // code here
            int n = array.Length;
            int[] even = new int[(n - 1) / 2 + 1];
            int[] odd = new int[n / 2];

            int index1 = 0;
            int index2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i % 2 == 0)
                {
                    even[index1] = array[i];
                    index1++;
                }
                else
                {
                    odd[index2] = array[i];
                    index2++;
                }
            }
            // end
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = new int[array.Length + 1];
            double sr = 0, sum = 0, d = 10000;
            int ind = 0;

            // code here
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }
            sr = sum / array.Length;

            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i] - sr) < d)
                {
                    d = Math.Abs(array[i] - sr);
                    ind = i;
                }
            }
            answer[ind + 1] = P;
            for (int i = 0; i < array.Length; i++)
            {
                if (i <= ind)
                {
                    answer[i] = array[i];
                }
                else 
                {
                    answer[i + 1] = array[i];
                }
            }
            // end

            return answer;
        }
        public void Task4(int[] array)
        {
            // code here
            int n = array.Length;
            int kb = 0, km = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 0)
                {
                    kb++;
                }
            }
            km = n - kb ;

            int[] plus = new int[kb];
            int[] minus = new int[km];
            int index1 = 0, index2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] >= 0)
                {
                    plus[index1] = array[i];
                    index1++;
                }
                else if (array[i] < 0)
                {
                    minus[index2] = array[i];
                    index2++;
                }
            }

            int index11 = 0, index22 = 0;
            for (int i = 0; i < n; i++)
            {
                if (i < kb)
                {
                    array[i] = plus[index11];
                    index11++;
                }
                else
                {
                    array[i] = minus[index22];
                    index22++;
                }
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
                for (int i = 0; i < k && i < A.Length; i++)
                    answer[i] = A[i];
                for (int i = 0; i < B.Length; i++)
                    answer[k + i] = B[i];
                for (int i = k; i < A.Length; i++)
                    answer[B.Length + i] = A[i];
            }
            else
            {
                return A;
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
            int prev = array[0];
            bool flag = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == prev)
                {
                    flag = true;
                }
                else
                {
                    flag = false;
                    break;
                }
            }
            if (flag) return normalized;

            int max = -10000, min = 1000000;
            normalized = new double[array.Length];

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
                if (array[i] < min) min = array[i];
            }
            
            for (int i = 0; i < normalized.Length; i++)
            {
                normalized[i] = (double)2 * (array[i] - min) / (max - min) - 1;
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here

            C = new int[A.Length + B.Length];

            for (int i = 0; i < A.Length; i++)
            {
                C[i] = A[i];
            }

            for (int i = 0; i < B.Length; i++)
            {
                C[i + A.Length] = B[i];
            }

            for (int i = 0; i < C.Length - 1; i++)
            {
                int cmax = C[i];
                int imax = i;

                for (int j = i + 1; j < C.Length; j++)
                {
                    if (C[j] > cmax)
                    {
                        cmax = C[j];
                        imax = j;
                    }
                }
                (C[i], C[imax]) = (C[imax], C[i]);
            }
            // end

            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int imax = 0, amax = -100000;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > amax) {
                    amax = array[i];
                    imax = i;
                }
            }

            int[] shift = new int[array.Length];
            int ind = 0;

            for (int i = imax; i < array.Length; i++)
            {
                shift[i] = array[ind];
                ind++;
            }

            for (int i = 0; i < imax; i++)
            {
                shift[i] = array[ind];
                ind++;
            }
            
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = shift[i];
            }
           
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            for (int i = N - 1; i < array.Length && N > 0; i++)
            {
                array[i] = array[N - 1];
                N--;
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            if (a > b || (a == b && n != 1)) return (Xext, Yext);

            X = new double[n];
            Y = new double[n];
            X[0] = a;
            double step = (b - a) / (n - 1);
            for (int i = 1; i < n; i++)
            {
                X[i] = X[i - 1] + step;
            }


            for (int i = 0; i < n; i++)
            {
                Y[i] = Math.Cos(X[i]) + X[i] * Math.Sin(X[i]);
            }
            double[] xx = new double[n];
            double[] yy = new double[n];  
            
            // ищем экстремумы и их колво
            int count = 0;
            for (int i = 1; i < n - 1; i++)
            {
                if (Y[i - 1] < Y[i] && Y[i] > Y[i + 1])
                {
                    xx[count] = X[i];
                    yy[count] = Y[i];
                    count++;
                }
                else if (Y[i - 1] > Y[i] && Y[i] < Y[i + 1])
                {
                    xx[count] = X[i];
                    yy[count] = Y[i];
                    count++;
                }
            }
            Xext = new double[count];
            Yext = new double[count];
            for (int i = 0; i < count; i++)
            {
                Xext[i] = xx[i];
                Yext[i] = yy[i];
                Console.WriteLine(Xext[i] + " " + Yext[i]);
            }
            // end
            
            return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            int brightcount = 0, normalcount = 0, dimcount = 0;
            double normalsum = 0;
            double sum = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                sum += raw[i];
            }
            double sr = sum / raw.Length;


            double[] bri = new double[raw.Length], nor = new double[raw.Length], d = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] / sr > 2) bri[brightcount++] = raw[i];
                else if (raw[i] / sr < 0.5) d[dimcount++] = raw[i];
                else
                {
                    nor[normalcount++] = raw[i];
                    normalsum += raw[i];
                }
            }
            double normalsr = normalsum / normalcount;

            // заполняем яркие
            bright = new double[brightcount];
            for (int i = 0; i < brightcount; i++)
            {
                bright[i] = bri[i];
            }

            // заполняем тусклые
            dim = new double[dimcount];
            for (int i = 0; i < dimcount; i++)
            {
                dim[i] = d[i];
            }

            // заполняем нормальные
            normal = new double[raw.Length];
            for (int i = 0; i < raw.Length; i++)
            {
                if ((raw[i] / sr <= 2) && (raw[i] / sr >= 0.5))
                {
                    normal[i] = raw[i];
                }
                else
                {
                    normal[i] = (raw[i] + normalsr) / 2; 
                }
            }

            // сортируем нормальные
            for (int i = 0; i < raw.Length; i++)
            {
                bool changed = false;
                for (int j = 0; j < raw.Length - 1; j++)
                {
                    if (normal[j] < normal[j + 1])
                    {
                        changed = true;
                        (normal[j], normal[j + 1]) = (normal[j + 1], normal[j]);
                    }
                    
                }
                if (!changed) break;
            }
            // end

            return (bright, normal, dim);
        }
    }
}