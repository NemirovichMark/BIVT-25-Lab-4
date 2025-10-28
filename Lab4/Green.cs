namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int n = 0;
            double s = 0;
            foreach (double a in array)
            {
                if (a > 0)
                {
                    s += a;
                    n++;
                }
            }
            if (n>0)
            {
                double m = s / n;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                        array[i] = m;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int iotr = -1;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] <0)
                {
                    iotr = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (i<iotr)
                {
                    sum += array[i] * array[i];
                }
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int imax = -1;
            int chmax = -10000;
            int imin = -1;
            int chmin = 10000;
            int il = -1;
            int ip = -1;
            for (int i = 0; i<array.Length;i++)
            {
                if (array[i] > chmax)
                {
                    chmax=array[i];
                    imax = i;
                }
                if (array[i] < chmin)
                {
                    chmin=array[i];
                    imin = i;
                }
            }
            if (imax < imin)
            {
                il = imax;
                ip = imin;
            }
            else
            {
                il = imin;
                ip = imax;
            }
            int k = 0;
            for (int i = il + 1; i < ip; i++)
            {
                if (array[i] < 0) k++;
            }
            negatives = new int[k];
            int count = 0;
            for (int i=il+1; i<ip; i++)
            {
                if (array[i] < 0)
                {
                    negatives[count] = array[i];
                    count++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int chmax = -10000;
            int imax = -1;
            int iotr = -1;
            for (int i=0; i<array.Length; i++)
            {
                if (array[i]>chmax)
                {
                    chmax=array[i];
                    imax = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    iotr = i;
                    break;
                }
            }
            if (iotr != -1)
                (array[iotr], array[imax]) = (array[imax], array[iotr]);
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int chmax = -10000;
            for (int i=0; i<array.Length;i++)
            {
                if (array[i]>chmax)
                    chmax= array[i];
            }
            int k = 0;
            for (int i = 0; i < array.Length;i++)
            {
                if (array[i] == chmax)
                    k++;
            }
            answer = new int[k];
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == chmax)
                {
                    answer[count] = i;
                    count++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int chmax = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > chmax)
                    chmax = array[i];
            }
            int k = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == chmax)
                {
                    array[i] += k;
                    k++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int chmax = -10000;
            int[] array2 = new int[array.Length];
            for (int i=0; i<array.Length; i++)
                array2 [i] = array[i];
            for (int i=0; i<array.Length; i++)
            {
                if (array[i] > chmax)
                    chmax = array[i];
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == chmax)
                {
                    int s = 0;
                    for (int k=0; k<i; k++)
                    {
                        s += array2[k];
                    }
                    array[i] = s;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int k = 1;
            for (int i=0; i<array.Length-1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    k++;
                    if (k > length)
                        length = k;
                }
                else
                    k = 1;
            }
            if (length == 0)
                length = 1;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i=0; i<array.Length; i += 2)
            {
                for (int j=0; j < array.Length-i-2; j+=2)
                {
                    if (array[j] > array[j+2])
                        (array[j], array[j+2])=(array[j+2], array[j]);
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool a = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                        a = true;
                }
                if (!a)
                    k++;
            }
            cleared = new int[k];
            int ind = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool b = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                        b = true;
                }
                if (!b)
                {
                    cleared[ind] = array[i];
                    ind++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (a == b || n<=1)
                return null;
            A = new double[n];
            double st = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
                A[i] = a + i * st;
            double S = 0;
            int k = 0;
            foreach (double ch in A)
            {
                if (ch > 0)
                {
                    S += ch;
                    k++;
                }
            }
            double average = S/k;
            int kB = 0;
            foreach (double ch in A)
            {
                if (ch > 0 && ch > average)
                    kB++;
            }
            B=new double[kB];
            int indB = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    B[indB] = A[i];
                    indB++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int pr = 6;
            int c = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                int my = 0;
                if (c >= 5) my = 1;
                else my = dices[i] - c;
                if (my > pr) wins++;
                if (dices[i] == 6) c++;
                if (pr <= 1) pr = 1;
                else pr -= 1;
            }
            // end

            return wins;

        }
    }
}