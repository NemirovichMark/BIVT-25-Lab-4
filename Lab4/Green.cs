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
            if (array == null || array.Length == 0) return 0;
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) break;
                sum += array[i] * array[i];
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

            if (a == b | n <= 1)
                return B;

            A = new double[n];
            int j = 0, meo = 0, meo2 = 0;
            double sum = 0;

            for (double i = Math.Min(a, b); i <= Math.Max(a, b) + 0.0001; i += (Math.Max(a, b) - Math.Min(a, b)) / (n - 1))
            {
                A[j++] = i;
                if (i > 0)
                {
                    meo++;
                    sum += i;
                }
            }

            for (int i = 0; i < n; i++)
                if (A[i] > 0 & A[i] > sum / meo)
                    meo2++;

            B = new double[meo2];
            j = 0;

            for (int i = 0; i < n; i++)
                if (A[i] > 0 & A[i] > sum / meo)
                    B[j++] = A[i];

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            int[] not = new int[dices.Length];
            for (int i = 0; i <= 4 & i < dices.Length; i++)
                not[i] = 6 - i;
            for (int i = 5; i < dices.Length; i++)
                not[i] = 1;
            int meo = 6;
            for (int i = 0; i < dices.Length - 1; i++)
                if (dices[i] == meo)
                {
                    for (int j = i + 1; j < dices.Length; j++)
                        dices[j] = dices[j] - 1;
                    meo--;
                }
            for (int i = 0; i < dices.Length; i++)
                if (dices[i] > not[i])
                    wins++;

            return wins;
        }
    }
}

