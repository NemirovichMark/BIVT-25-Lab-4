namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int k = 0;
            double s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    k++;
                }
            }
            s /= k;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = s;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int k = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    k = i;
                    break;
                }
            }
            for (int i = 0; i < k; i++)
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
            int max = -999999999, maxin = array.Length, min = 999999999, minin = array.Length;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxin = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    minin = i;
                }
            }
            int len = 0, j = 0;
            if (minin > maxin)
            {
                for (int i = maxin + 1; i < minin; i++)
                {
                    if (array[i] < 0)
                    {
                        len++;
                    }
                }
                negatives = new int[len];
                for (int i = maxin + 1; i < minin; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[j++] = array[i];
                    }
                }
            }
            else if (maxin > minin)
            {
                for (int i = minin + 1; i < maxin; i++)
                {
                    if (array[i] < 0)
                    {
                        len++;
                    }
                }
                negatives = new int[len];
                for (int i = minin + 1; i < maxin; i++)
                {
                    if (array[i] < 0)
                    {
                        negatives[j++] = array[i];
                    }
                }
            }

            else negatives = new int[len];
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -999999999, negin = -1, maxin = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    negin = i;
                    break;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxin = i;
                }
            }
            if (negin != -1 && maxin != -1 && negin != maxin)
            {
                (array[maxin], array[negin]) = (array[negin], array[maxin]);
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = -999999999, count = 0;
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
                    count++;
                }
            }
            answer = new int[count];
            int intmax = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[intmax] = i;
                    intmax++;
                }
            }

            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -999999999;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int k = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += k;
                    k += 1;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = -999999999;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int k = 1;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
                if (array[i] == max)
                {
                    array[i] = sum - max;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 1;

            // code here
            int cnt = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    cnt++;
                }
                if (cnt > length)
                {
                    length = cnt;
                }
                if (array[i] >= array[i - 1])
                {
                    cnt = 1;
                }
                    
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            for (int i = 0; i < array.Length; i += 2)
            {
                for (int j = 0; j < array.Length - i - 2; j += 2)
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
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool a = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        a = true;
                    }
                }
                if (!a)
                {
                    count++;
                }
            }
            cleared = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool b = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        b = true;
                    }
                }
                if (!b)
                {
                    cleared[index] = array[i];
                    index++;
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (a == b | n <= 1)
            {
                return B;
            }

            A = new double[n];
            int j = 0, count = 0, count2 = 0;
            double S = 0;

            for (double i = Math.Min(a, b); i <= Math.Max(a, b) + 0.0001; i += (Math.Max(a, b) - Math.Min(a, b)) / (n - 1))
            {
                A[j++] = i;
                if (i > 0)
                {
                    count++;
                    S += i;
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 & A[i] > S / count)
                {
                    count2++;
                }
            }

            B = new double[count2];
            j = 0;

            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 & A[i] > S / count)
                {
                    B[j++] = A[i];
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int point = 6, curse = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int ppoint = Math.Max(1, dices[i] - curse);
                if (ppoint > point)
                {
                    wins++;
                }
                if (dices[i] == 6)
                {
                    curse++;
                }

                point = Math.Max(1, point - 1);
            }

            // end

            return wins;

        }
    }
}