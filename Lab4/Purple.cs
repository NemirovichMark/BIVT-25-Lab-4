namespace Lab4
{
    public class Purple
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0, sr = 0, max = -100000;
            int n = array.Length, f = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
                s += array[i];
            }
            sr = s / n;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max && f == 0)
                {
                    f = 1;
                }
                else if (f == 1)
                {
                    array[i] = sr;
                }
            }
            // end

        }
        public (int[] even, int[] odd) Task2(int[] array)
        {
            int[] even = null, odd = null;

            // code here
            int n1, n2;
            if (array.Length % 2 == 0)
            {
                n1 = array.Length / 2;
                n2 = array.Length / 2;
            }
            else
            {
                n1 = (array.Length + 1) / 2;
                n2 = array.Length / 2;
            }
            int[] even1 = new int[n1], odd1 = new int[n2];
            int a1 = 0, a2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                {
                    even1[a1] = array[i];
                    a1++;
                }
                else
                {
                    odd1[a2] = array[i];
                    a2++;
                }
            }
            even = even1;
            odd = odd1;
            // end
            return (even, odd);
        }
        public int[] Task3(int[] array, int P)
        {
            int[] answer = null;

            // code here
            int[] b = new int[array.Length + 1];
            double s = 0, sr = 0;
            int index = 0, indexm = 0;
            for (int i = 0; i < array.Length; i++) //сумма элементов массива
            {
                s += array[i];
            }
            sr = s / array.Length; //ср. значение
            double min = Math.Abs(sr - array[0]); //мин разница между средним и элементом
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(sr - array[i]) < min)
                {
                    min = Math.Abs(sr - array[i]);
                    indexm = index;
                }
                index++;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(sr - array[i]) != min)
                {
                    b[i] = array[i];
                }
                else if (Math.Abs(sr - array[i]) == min)
                {
                    b[i + 1] = P;
                    b[i] = array[i];
                    break;
                }

            }
            for (int i = indexm + 1; i < array.Length; i++)
            {
                b[i + 1] = array[i];
            }
            answer = b;
            // end

            return answer;
        }
        public void Task4(int[] array)
        {
            // code here
            int count = 0; //счетчик отриц. чисел
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    count++;
            }
            if (count != 0 && count != array.Length)
            {
                int[] b = new int[array.Length - count]; // массив для чисел >-1
                int n = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        b[n] = array[i];
                        n++;
                    }
                }
                int p, k = 1, t = 1;
                for (int i = 0; i < array.Length; i++) //перестановка отриц чисел в конец
                {
                    if (array[^k] < 0 && (k == 1))
                    {
                        k++;
                        t++;
                    }
                    else if (array[^k] < 0)
                    {
                        p = array[^t];
                        array[^t] = array[^k];
                        t++;
                        array[^k] = p;
                        k++;
                    }
                    else k++;
                }
                for (int i = 0; i < b.Length; i++) //возвращаем порядок неотриц числам
                {
                    array[i] = b[i];
                }
            }
        }
                // end


        public int[] Task5(int[] A, int[] B, int k)
        {
            int[] answer = null;

            // code here
            k--;
            if (B == null)
            {
                answer = A;
            }
            else if (A == null)
            {
                answer = B;
            }
            else if (k > A.Length)
            {
                answer = A;
            }
            else
            {
                int[] t = new int[A.Length + B.Length];
                int a = 0, f = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (k == -1)
                    {
                        break;
                    }
                    t[i] = A[i];
                    f++;
                    a++;
                    if (i == k)
                    {
                        break;
                    }
                }
                for (int i = 0; i < B.Length; i++)
                {
                    t[f] = B[i];
                    f++;
                }
                for (int i = a; f < t.Length; i++)
                {
                    t[f] = A[i];
                    f++;
                }
                answer = t;
            }
            return answer;
            // end
        }
        public (int[] sum, int[] dif) Task6(int[] A, int[] B)
        {
            int[] sum = null, dif = null;

            // code here
            int[] s = new int[A.Length];
            int[] d = new int[A.Length];
            if (A.Length == B.Length)
            {
                for (int i = 0; i < A.Length; i++)
                {
                    s[i] = A[i] + B[i];
                    d[i] = A[i] - B[i];
                }
                sum = s;
                dif = d;
            }
                // end

                return (sum, dif);
        }
        public double[] Task7(int[] array)
        {
            double[] normalized = null;

            // code here
            int f = 1, a = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] != a)
                {
                    break;
                }
                else f = 0;
            }
            if (f == 1 && array.Length != 1)
            {
                double [] n = new double[array.Length];
                double min = array[0], max = array[0];
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                    }
                    else if (array[i] < min)
                    {
                        min = array[i];
                    }
                }
                for (int i = 0; i < array.Length; i++)
                {
                    n[i] =  2 * (array[i] - min)/(max - min) - 1;
                }
                normalized = n;
            }
            // end
            
            return normalized;
        }
        public int[] Task8(int[] A, int[] B)
        {
            int[] C = null;

            // code here
            int f = 0;
            int[] r = new int[A.Length + B.Length];
            for (int i = 0; i < A.Length; i++)
            {
                r[i] = A[i];
                f++;
            }
            for (int i = 0; i < B.Length; i++)
            {
                r[f] = B[i];
                f++;
            }
            int k = 1, n = r.Length;
            while (k < n)
            {
                if (k == 0 || r[k] <= r[k - 1])
                {
                    k++;
                    
                }
                else
                {
                    (r[k], r[k - 1]) = (r[k - 1], r[k]);
                    k--;
                }
            }
            // end
            C = r;
            return C;
        }
        public void Task9(int[] array)
        {

            // code here
            int indexmax = 0, max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    indexmax = i;
                    break;
                }
            }
            int n = array.Length, shift = indexmax;
            shift = shift % n;
            for (int i = 0; i < shift; i++)
            {
                int temp = array[n - 1];
                for (int j = n - 1; j > 0; j--)
                {
                    array[j] = array[j - 1];
                }
                array[0] = temp;
            }
            // end

        }
        public void Task10(int[] array, int N)
        {

            // code here
            int k = 2;
            for (int i = 0; i < array.Length; i++)
            {
                if (i < (N - 1) && array.Length >= (2 * N - 1))
                {
                    array[2 * N - k] = array[i];
                    k++;
                }
                else if (i < (N - 1) && ((2 * N - i - k)) < array.Length)
                {
                    array[2 * N - k - i] = array[i];
                }
                if (i == (N - 1))
                {
                    break;
                }
            }
            // end

        }
        public (double[], double[]) Task11(double a, double b, int n)
        {
            double[] X = null, Y = null;
            double[] Xext = null, Yext = null;

            // code here
            double h = (b - a) / (n - 1);
            double[] x = new double[n];
            double[] y = new double[n];
            for (int i = 0; i < n; i++)
            {
                x[i] = a + i * h;
                y[i] = Math.Cos(x[i]) + x[i] * Math.Sin(x[i]);
            }
            int t = 0;
            double y1 = 0, y2 = 0, y0 = 0;
            for (int i = 1; i < (n - 1); i++)
            {
                y1 = Math.Cos(x[i]) + x[i] * Math.Sin(x[i]);
                y0 = Math.Cos(x[i - 1]) + x[i - 1] * Math.Sin(x[i - 1]);
                y2 = Math.Cos(x[i + 1]) + x[i + 1] * Math.Sin(x[i + 1]);
                if (x[i] == 0 || Math.Cos(x[i]) == 0)
                {
                    t++;
                }

                else if (y0 < y1 && y2 < y1)
                {
                    t++;
                }
                else if (y0 > y1 && y2 > y1)
                {
                    t++;
                }
            }
            if (t > 0)
            {
                double[] xext = new double[t];
                double[] yext = new double[t];
                int k = 0;
                for (int i = 1; k < t; i++)
                {
                    y1 = Math.Cos(x[i]) + x[i] * Math.Sin(x[i]);
                    y0 = Math.Cos(x[i - 1]) + x[i - 1] * Math.Sin(x[i - 1]);
                    y2 = Math.Cos(x[i + 1]) + x[i + 1] * Math.Sin(x[i + 1]);
                    if (x[i] == 0 || Math.Cos(x[i]) == 0)
                    {
                        xext[k] = x[i];
                        yext[k] = y1;
                        k++;
                    }

                    else if (y0 < y1 && y2 < y1)
                    {
                        xext[k] = x[i];
                        yext[k] = y1;
                        k++;
                    }
                    else if (y0 > y1 && y2 > y1)
                    {
                        xext[k] = x[i];
                        yext[k] = y1;
                        k++;
                    }
                }
                if ((a < b || (a == b && n <= 1)) && t > 0)
                {
                        Xext = xext;
                        Yext = yext;
                }
                // end
            }
            else if ((a < b || (a == b && n <= 1)) && t == 0)
            {
                double[] xext = {};
                double[] yext = {};
                Xext = xext;
                Yext = yext;
            }
                return (Xext, Yext);
        }

        public (double[] bright, double[] normal, double[] dim) Task12(double[] raw)
        {
            double[] bright = null, normal = null, dim = null;

            // code here
            double s = 0, S = 0, SR = 0;
            double sr = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                s += raw[i];
            }
            if (raw.Length != 0)
                sr = s / raw.Length;
            // end
            int nb = 0, nd = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > (2 * sr))
                {
                    nb++;
                }
                else if (raw[i] < (sr / 2))
                {
                    nd++;
                }
            }
            double[] b = new double[nb];
            double[] d = new double[nd];
            int cb = 0, cd = 0;
            for (int i = 0; i < raw.Length; i++)
            {
                if (raw[i] > (2 * sr))
                {
                    b[cb] = raw[i];
                    cb++;
                }
                else if (raw[i] < (sr / 2))
                {
                    d[cd] = raw[i];
                    cd++;
                }
                else S += raw[i]; 
            }

            bright = b;
            dim = d;
            SR = S / (raw.Length - bright.Length - dim.Length);
            for (int i = 0; i < raw.Length; i++)
            {
                if ((raw[i] > (2 * sr)) || (raw[i] < (sr / 2)))
                {
                    raw[i] = (SR + raw[i]) / 2;
                }
            }
            int k = 1, n = raw.Length;
            while (k < n)
            {
                if (k == 0 || raw[k] <= raw[k - 1])
                {
                    k++;
                }
                else
                {
                    (raw[k], raw[k - 1]) = (raw[k - 1], raw[k]);
                    k--;
                }
            }
            normal = raw;
            return (bright, normal, dim);
        }
    }
}
