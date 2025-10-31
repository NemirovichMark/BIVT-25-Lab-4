namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            if (array == null || array.Length == 0) return;
            double sum = 0;
            int count = 0;
            foreach (double x in array)
                if (x > 0) { sum += x; count++; }
            if (count == 0) return;
            double avg = sum / count;
            for (int i = 0; i < array.Length; i++)
                if (array[i] > 0) array[i] = avg;
        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int f = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] >= 0) && (f == 0))
                {
                    sum += array[i] * array[i];
                }
                if (array[i] < 0)
                {
                    f = -1;
                }
            }
            if (f == 0)
            {
                sum = 0;
            }
            return sum;
        }

        public int[] Task3(int[] array)
        {
            int maxIdx = 0, minIdx = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIdx]) maxIdx = i;
                if (array[i] < array[minIdx]) minIdx = i;
            }
            int start = Math.Min(minIdx, maxIdx) + 1;
            int end = Math.Max(minIdx, maxIdx);
            if (end - start <= 0) return new int[0];
            List<int> res = new List<int>();
            for (int i = start; i < end; i++)
                if (array[i] < 0) res.Add(array[i]);
            return res.ToArray();
        }

        public void Task4(int[] array)
        {
            int maxIdx = 0;
            for (int i = 1; i < array.Length; i++)
                if (array[i] > array[maxIdx]) maxIdx = i;
            int firstNeg = -1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] < 0) { firstNeg = i; break; }
            if (firstNeg == -1) return;
            (array[maxIdx], array[firstNeg]) = (array[firstNeg], array[maxIdx]);
        }

        public int[] Task5(int[] array)
        {
            int max = array.Max();
            List<int> idx = new List<int>();
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) idx.Add(i);
            return idx.ToArray();
        }

        public void Task6(int[] array)
        {
            int max = array.Max();
            int count = 1;
            for (int i = 0; i < array.Length; i++)
                if (array[i] == max) array[i] += count++;
        }

        public void Task7(int[] array)
        {
            int max = array.Max();
            int[] copy = (int[])array.Clone();
            for (int i = 0; i < array.Length; i++)
            {
                if (copy[i] == max)
                {
                    int sum = 0;
                    for (int j = 0; j < i; j++)
                        sum += copy[j];
                    array[i] = sum;
                }
            }
        }

        public int Task8(int[] array)
        {
            int maxLen = 1, curr = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1]) curr++;
                else { maxLen = Math.Max(maxLen, curr); curr = 1; }
            }
            return Math.Max(maxLen, curr);
        }

        public void Task9(int[] array)
        {
            int n = array.Length;
            List<int> evens = new List<int>();
            for (int i = 0; i < n; i += 2) evens.Add(array[i]);
            evens.Sort();
            for (int i = 0, j = 0; i < n; i += 2, j++) array[i] = evens[j];
        }

        public int[] Task10(int[] array)
        {
            List<int> res = new List<int>();
            foreach (int x in array)
                if (!res.Contains(x)) res.Add(x);
            return res.ToArray();
        }

        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            double r = (b - a) / (n - 1);
            A = new double[n];
            double c = 0;
            double s = 0;
            for (int i = 0; i < n; i++)
            {
                A[i] = a + r * i;
                if (A[i] > 0)
                {
                    s += A[i];
                    c++;
                }

            }
            s = s / c;
            int f = 0;
            for (int j = 0; j < n; j++)
            {
                if (A[j] > s)
                {
                    f++;
                }
            }
            int e = 0;
            B = new double[f];
            int g = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > s)
                {
                    B[g] = A[i];
                    g++;
                }
            }
            if ((n <= 1) || (a == b))
            {
                return null;
            }

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            int[] s = new int[dices.Length];
            for (int i = 0; i <= 4 & i < dices.Length; i++)
            {
                s[i] = 6 - i;
            }
            for (int i = 5; i < dices.Length; i++)
            {
                s[i] = 1;
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
                if (dices[i] > s[i])
                    wins++;
            }

            return wins;
        }
    }
}

