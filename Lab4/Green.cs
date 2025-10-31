namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            int c = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    c++;
                }
            }

            double avg = s / c;
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
            int stop = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    stop = i;
                    break;
                }
            }
            for (int i = 0; i < stop; i++)
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
            int imax = -1;
            int max = -10000;
            int imin = -1;
            int min = 10000;
            int ilev = -1;
            int iprav = -1;
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
            if (imax < imin)
            {
                ilev = imax;
                iprav = imin;
            }
            else
            {
                ilev = imin;
                iprav = imax;
            }
            int j = 0;
            for (int i = ilev + 1; i < iprav; i++)
            {
                if (array[i] < 0) j++;
            }
            negatives = new int[j];
            int count = 0;
            for (int i = ilev + 1; i < iprav; i++)
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
            int chm = -10000;
            int im = -1;
            int io = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > chm)
                {
                    chm = array[i];
                    im = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    io = i;
                    break;
                }
            }
            if (io != -1)
            {
                (array[io], array[im]) = (array[im], array[io]);
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int chm = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > chm)
                    chm = array[i];
            }
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == chm)
                    k++;
            }
            answer = new int[k];
            int c = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == chm)
                {
                    answer[c] = i;
                    c++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int chm = -1000000000;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > chm)
                    chm = array[i];
            }

            int k = 1;
            for (int i = 0; i < array.Length; i++)

            {
                if (array[i] == chm)
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
            int mEl = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > mEl)
                {
                    mEl = array[i];
                }
            }
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s += array[i];
                if (array[i] == mEl)
                {
                    array[i] = s - array[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            int c = 1;
            int mc = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    c++;
                    if (c > mc)
                    {
                        mc = c;
                    }
                }
                else
                    c = 1;
            }
            length = mc;

            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length - 2; i += 2)
            {
                for (int j = 0; j < array.Length - 2; j += 2)
                {
                    if (array[j] > array[j + 2])
                    {
                        (array[j], array[j + 2]) = (array[j + 2], array[j]);
                    }
                        
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
                if (!a) k++;
            }
            cleared = new int[k];
            int I = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool b = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i]) b = true;
                }
                if (!b)
                {
                    cleared[I] = array[i];
                    I++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (b == a)
                return null;
            if (n <= 1)
                return null;

            A = new double[n];

            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }


            double sum = 0;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sum += A[i];
                    count++;
                }
            }

            if (count == 0)
                return new double[0];

            double average = sum / count;

            int elementsCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    elementsCount++;
                }
            }

            B = new double[elementsCount];
            int indexB = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > average)
                {
                    B[indexB] = A[i];
                    indexB++;
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
