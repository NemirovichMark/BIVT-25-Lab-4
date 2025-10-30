namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int k = 0;
            double s = 0, sr;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    k++;
                    s += array[i];
                }
            }
            sr = s / k;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sr;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int ind = 0;
            if (array[0] >= 0)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] < 0)
                    {
                        ind = i;
                        break;
                    }
                }
                for (int i = 0; i < ind; i++)
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
            int max = -1000000, min = 100000;
            int ind1 = 0, ind2 = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    ind1 = i;
                }
                if (array[i] < min)
                {
                    min = array[i];
                    ind2 = i;
                }
            }
            int nach = Math.Min(ind1, ind2);
            int con = Math.Max(ind1, ind2);
            int L = 0;
            for (int i = nach + 1; i < con; i++)
            {
                if (array[i] < 0)
                    L++;
            }
            negatives = new int[L];
            int j = 0;
            for (int i = nach + 1; i < con; i++)
            {
               if (array[i] < 0)
               {
                    negatives[j++] = array[i];
               }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int max = -100000, indo = 0, indm = 0;
            bool pr = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    indm = i;
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    indo = i;
                    pr = true;
                    break;
                }
            }
            if (pr)
            {
                (array[indm], array[indo]) = (array[indo], array[indm]);
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    k++;
            }
            answer = new int[k];
            int j = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    answer[j++] = i;
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -10000;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            int j = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += j;
                    j++;
                }
            }
            
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = -100000;
            for (int i = 0; i<array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                s+= array[i];
                if (array[i] == max)
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
            int a = 1;
            int b = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i-1] > array[i])
                    a++;
                else
                    a = 1;
                if (a > b)
                    b = a;
            }
            length = b;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 == 0)
                    k++;
            }
            int[] ci = new int[k];
            int q = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((i % 2) == 0)
                {
                    ci[q++] = array[i];
                }
            }
            bool op = false;
            for (int i = 0; i < k-1; i++)
            {
                for (int j = 0; j < k-i-1; j++)
                {
                    if (ci[j] > ci[j+1])
                    {
                        (ci[j], ci[j + 1]) = (ci[j + 1], ci[j]);
                        op = true;
                    }
                }
                if (!op) break;
            }
            int w = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (i % 2 ==0)
                {
                    array[i] = ci[w++];
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int p = 1, k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                p = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                        p = 1;
                }
                if (p == 0) k++;
            }
            cleared = new int[k];
            int q = 0;
            for (int i = 0; i < array.Length; i++)
            {
                p = 0;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                        p = 1;
                }
                if (p == 0) cleared[q++] = array[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (a == b | n <= 1)
                return B;
            A = new double[n];
            double nach = Math.Min(b, a);
            double kon = Math.Max(b, a);
            double shag = (kon - nach) / (n - 1);
            double s = 0;
            int k = 0;
            int j = 0;
            for (double i = nach; i < kon + 0.00001; i += shag)
            {
                A[j++] = i;
                if (i > 0)
                {
                    s += i;
                    k++;
                }
            }
            double sr = s / k;
            int pr = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > sr)
                    pr++;
            }
            B = new double[pr];
            j = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > sr)
                    B[j++] = A[i];
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int[] shul = new int[dices.Length];
            for (int i = 0; i <= 4 & i < dices.Length; i++)
            {
                shul[i] = 6 - i;
            }
            for (int i = 5; i < dices.Length; i++)
            {
                shul[i] = 1;
            }
            int k = 6;
            for (int i = 0; i < dices.Length - 1; i++)
            {
                if (dices[i] == k)
                {
                    for (int j = i + 1; j < dices.Length; j++)
                    {
                        dices[j] = dices[j] - 1;
                    }
                    k--;
                }
            }
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i] > shul[i])
                    wins++;
            }
            // end

            return wins;

        }
    }
}
