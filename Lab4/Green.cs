namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0, avg = 0; int m = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s = s + array[i];
                    m++;
                }
            }
            if (m > 0) avg = s / m;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = avg;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int n = 0;  
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    n = i;
                    break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                sum += array[i] * array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here

            //int v = 0;
            //int c = 0;
            //Double min = array[0];
            //Double max = array[0];
            //for (int i = 0; i <= array.Length; i++)
            //{
            //    if(array[i] <= min)
            //    {
            //        min = array[i];
            //        v = i;
            //    }
            //    if(array[i] >= max)
            //    {
            //        max = array[i];
            //        c = i;
            //    }
            //}

            //int p = 0;
            //if(c >= v)
            //{
            //    int n = c - v;
            //    for (int i = v + 1; i < c; i++)
            //    {
            //        negatives[p++] = array[i];
            //    }
            //}
            //else
            //{
            //    int n = v - c;
            //    for (int i = c + 1; i < v; i++)
            //    {
            //        negatives[p++] = array[i];
            //    }
            //}


            int min = 1000; int max = -1000;
            int imax = 0; int imin = 0;
            for (int i = 0; i < array.Length; i++)
            {

                if (array[i] > max)
                {
                    max = array[i];
                    imax = i;
                }

                if (array[i] < min)
                {
                    min = array[i];
                    imin = i;
                }
            }
            int n = 0;
            int st = Math.Min(imin, imax);
            int fn = Math.Max(imin, imax);
            for (int i = st + 1; i < fn; i++)
            {
                if (array[i] < 0)
                {
                    n++;
                }
            }
            negatives = new int[n];
            n = 0;
            for (int i = st + 1; i < fn; i++)
            {
                if (array[i] < 0)
                {
                    negatives[n++] = array[i];
                }
            }

            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array == null || array.Length == 0) return;

            int b = 0;     
            int c = -1;    

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[b]) b = i;
                if (array[i] < 0 && c == -1) c = i;
            }

            if (c == -1) return;

            int d = array[b];
            array[b] = array[c];
            array[c] = d;

            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int m = array[0]; 
            for (int i = 1; i < array.Length; i++)
                if (array[i] > m) m = array[i];
            int c = 0; 
            for (int i = 0; i < array.Length; i++)
                if (array[i] == m) c++;
            answer = new int[c];
            int j = 0; 
            for (int i = 0; i < array.Length; i++)
                if (array[i] == m) answer[j++] = i;
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int k = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                k = Math.Max(k, array[i]);
            }
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == k)
                {
                    array[i] += ++n;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                max = Math.Max(max, array[i]);
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] == max)
                {
                    array[i] = sum - array[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int c = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                    c++;
                else
                {
                    if (c > length) length = c;
                    c = 1;
                }
            }

            if (c > length) length = c;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int n = (array.Length + 1) / 2;
            int[] e = new int[n];

            for (int i = 0; i < n; i++)
                e[i] = array[i * 2];

            Array.Sort(e);

            for (int i = 0; i < n; i++)
                array[i * 2] = e[i];
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                c = array[i];
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] == c)
                    {
                        array[j] = -10000;
                    }
                }
            }
            int n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != -10000)
                {
                    n++;
                }
            }
            cleared = new int[n];
            n = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != -10000)
                {
                    cleared[n++] = array[i];
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 1 || a == b)
            {
                return B;
            }
            A = new double[n];
            double hd = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * hd;
            }
            double sum = 0;
            int m = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    m++;
                }
            }
            double avg = sum / m;
            m = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > avg))
                {
                    m++;
                }
            }
            B = new double[m];
            m = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if ((A[i] > 0) && (A[i] > avg))
                {
                    B[m++] = A[i];
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int n = dices.Length;
            int s = 0;
            int[] mine = new int[n];
            for (int i = 0; i < n; i++)
            {
                int a = dices[i] - s;
                if (a < 1) a = 1;
                mine[i] = a;

                if (dices[i] == 6) s++;
            }
            for (int i = 0; i < n; i++)
            {
                int e = 6 - i;
                if (e < 1) e = 1;
                if (mine[i] > e) wins++;
            }
            // end

            return wins;

        }
    }
}
