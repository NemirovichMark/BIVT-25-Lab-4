namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            int n = array.Length;
            double summ = 0;
            int num = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    summ += array[i];
                    num += 1;
                }
            }

            double sr_s = (double) summ / num;
            for (int i = 0; i < n; i++)
            {
                if (array[i] > 0)
                {
                    array[i] = sr_s;
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            int n = array.Length;
            int count = 0;
            for (int i = 0; i < n; i++)
            {
                if (array[i] < 0)
                {
                    count++;
                    break;
                }
                sum += array[i] * array[i];
            }

            if (count == 0) sum = 0;
            // end

            return sum;
        }

        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            int max = -1000;
            int min = 1000;
            int maxIndex = 0;
            int minIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }

                if (array[i] < min)
                {
                    min = array[i];
                    minIndex = i;
                }
            }
            
            int count = 0;
            if (maxIndex < minIndex)
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    if (array[i] < 0) count++;
                }
            }
            else
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    if (array[i] < 0) count++;
                }
            }

            negatives = new int[count];
            count = 0;
            if (maxIndex < minIndex)
            {
                for (int i = maxIndex + 1; i < minIndex; i++)
                {
                    if (array[i] < 0) negatives[count++] = array[i];
                }
            }
            else
            {
                for (int i = minIndex + 1; i < maxIndex; i++)
                {
                    if (array[i] < 0) negatives[count++] = array[i];
                }
            }
        // end

        return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            bool f1 = false;
            int max = -100000;
            int maxIndex = 0;
            int first = 0;
            int firstIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    first = array[i];
                    firstIndex = i;
                    f1 = true;
                    break;
                }
            }
            if (f1) (array[maxIndex], array[firstIndex]) = (first, max);
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = -100000;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) count++;
            }
            answer = new int[count];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[count++] = i;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            int max = -100000;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    count++;
                    array[i] = array[i] + count;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            int max = -100000;
            int maxIndex = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                    maxIndex = i;
                }
            }

            int[] a = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                a[i] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    int sum = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sum += a[j];
                    }
                    array[i] = sum;
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            Console.WriteLine(string.Join(" ", array));
            int count = 1;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    count++;
                    if (count > length) length = count;
                }
                else
                {
                    count = 1;
                }
            }
            if (length == 0) length = 1;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            int length = array.Length;
            int n = length / 2;
            if (length % 2 == 1) n++;
            int[] a = new int[n];
            n = 0;
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0) a[n++] =  array[i];
            }
            
            for (int i = 0; i < n; i++)
            {
                bool f = false;
                for (int j = 1; j < n - i; j++)
                {
                    if (a[j - 1] > a[j])
                    {
                        (a[j - 1], a[j]) = (a[j], a[j - 1]);
                        f = true;
                    }
                }
                if (!f) break;
            }

            n = 0;
            for (int i = 0; i < length; i++)
            {
                if (i % 2 == 0) array[i] = a[n++];
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            int n = array.Length;
            for (int i = 0; i < n; i++)
            {
                int elem = array[i];
                for (int j = i + 1; j < n; j++)
                {
                    if (elem == array[j]) array[j] = 1000;
                }
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 1000) count++;
            }

            cleared = new int[count];
            count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != 1000) cleared[count++] = array[i];
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            double step = 0;
            if (n - 1 > 0 && a != b)
            {
                step = Math.Abs(b - a) / (n - 1);
                A = new double[n];
                if (a < b)
                {
                    for (int i = 0; i < n; i++)
                    {
                        A[i] = a + i * step;
                    } 
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        A[i] = b + i * step;
                    }
                }

                int count = 0;
                double sum = 0;
                for (int i = 0; i < n; i++)
                {
                    if (A[i] > 0)
                    {
                        count++;
                        sum += A[i];
                    }
                }
                if (count > 0)
                {
                    double sr = sum / (double)count;
                    count = 0;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (A[i] > sr) count++;
                    }
                    B = new double[count];
                    count = 0;
                    for (int i = 0; i < A.Length; i++)
                    {
                        if (A[i] > sr) B[count++] = A[i];
                    }
                }
                else
                {
                    B = new double[0];
                }
            }
            else
            {
                return null;
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            int count = 0;
            int[] A = new int[dices.Length];
            for (int i = 0; i < dices.Length; i++)
            {
                A[i] = dices[i];
            }
            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i] - count >= 1)
                {
                    dices[i] = dices[i] - count;
                }
                else
                {
                    dices[i] = 1;
                }
                if (A[i] == 6)
                {
                    count++;
                }
                
            }
            int[] Shuler = new int[dices.Length];
            int[] Shuler1 = new int[dices.Length];
            count = 0;
            for (int i = 0; i < dices.Length; i++)
            {
                Shuler[i] = 6;
                Shuler1[i] = 6;
            }
            for (int i = 0; i < dices.Length; i++)
            {
                if (Shuler[i] - count >= 1)
                {
                    Shuler[i] = Shuler[i] - count;
                }
                else
                {
                    Shuler[i] = 1;
                }
                if (Shuler1[i] == 6)
                {
                    count++;
                }
            }

            for (int i = 0; i < dices.Length; i++)
            {
                if (dices[i] > Shuler[i]) wins++;
            }
            // end

            return wins;

        }
    }
}