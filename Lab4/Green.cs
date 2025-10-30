namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {
            // code here
            if (array != null && array.Length > 0)
            {
                double sum = 0;
                int count = 0;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        sum += array[i];
                        count++;
                    }
                }

                if (count > 0)
                {
                    double avg = sum / count;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (array[i] > 0)
                            array[i] = avg;
                    }
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            if (array != null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] >= 0)
                    {
                        sum += array[i] * array[i];
                    }
                    else
                    {
                        break;
                    }
                }
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array != null && array.Length > 0)
            {
                int maxIndex = 0, minIndex = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex]) maxIndex = i;
                    if (array[i] < array[minIndex]) minIndex = i;
                }

                int start = Math.Min(maxIndex, minIndex) + 1;
                int end = Math.Max(maxIndex, minIndex) - 1;

                if (start <= end)
                {
                    int count = 0;
                    for (int i = start; i <= end; i++)
                    {
                        if (array[i] < 0) count++;
                    }

                    negatives = new int[count];
                    int index = 0;
                    for (int i = start; i <= end; i++)
                    {
                        if (array[i] < 0)
                            negatives[index++] = array[i];
                    }
                }
                else
                {
                    negatives = new int[0];
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array != null && array.Length > 0)
            {
                int maxIndex = 0;
                int firstNegativeIndex = -1;

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > array[maxIndex]) maxIndex = i;
                    if (firstNegativeIndex == -1 && array[i] < 0) firstNegativeIndex = i;
                }

                if (firstNegativeIndex != -1)
                {
                    int temp = array[maxIndex];
                    array[maxIndex] = array[firstNegativeIndex];
                    array[firstNegativeIndex] = temp;
                }
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            if (array != null && array.Length > 0)
            {
                int max = array[0];
                int count = 1;

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max)
                    {
                        max = array[i];
                        count = 1;
                    }
                    else if (array[i] == max)
                    {
                        count++;
                    }
                }

                answer = new int[count];
                int index = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max)
                        answer[index++] = i;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array != null && array.Length > 0)
            {
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max) max = array[i];
                }

                int order = 1;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max)
                    {
                        array[i] += order;
                        order++;
                    }
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            if (array != null && array.Length > 0)
            {
                int[] cloned = (int[])array.Clone();
                int max = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > max) max = array[i];
                }

                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == max)
                    {
                        int sum = 0;
                        for (int j = 0; j < i; j++)
                        {
                            sum += cloned[j];
                        }
                        array[i] = sum;
                    }
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array != null && array.Length > 0)
            {
                length = 1;
                int currentLength = 1;

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        currentLength++;
                        if (currentLength > length) length = currentLength;
                    }
                    else
                    {
                        currentLength = 1;
                    }
                }
            }
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            if (array != null && array.Length > 1)
            {
                for (int i = 0; i < array.Length - 2; i += 2)
                {
                    for (int j = i + 2; j < array.Length; j += 2)
                    {
                        if (array[j] < array[i])
                        {
                            int temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array != null)
            {
                if (array.Length == 0)
                {
                    cleared = new int[0];
                }
                else
                {
                    bool[] seen = new bool[1001];
                    int count = 0;

                    for (int i = 0; i < array.Length; i++)
                    {
                        if (!seen[array[i] + 500])
                        {
                            seen[array[i] + 500] = true;
                            count++;
                        }
                    }

                    cleared = new int[count];
                    int index = 0;
                    for (int i = 0; i < array.Length; i++)
                    {
                        if (seen[array[i] + 500])
                        {
                            cleared[index++] = array[i];
                            seen[array[i] + 500] = false;
                        }
                    }
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here
            if (n <= 0) return null ;

            A = new double[n];
            if (n == 1)
            {
                A[0] = a;
            }
            else
            {
                double step = (b - a) / (n - 1);
                for (int i = 0; i < n; i++)
                {
                    A[i] = a + i * step;
                }
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

            if (count == 0) return null;

            double avg = sum / count;

            int bCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg) bCount++;
            }

            if (bCount == 0) return null;

            B = new double[bCount];
            int index = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg)
                {
                    B[index] = A[i];
                    index++;
                }
            }
            // end

            return B;
        }
        public int Task12(int[] dices)
        {
            int wins = 0;

            // code here
            if (dices != null && dices.Length > 0)
            {
                int[] modified = new int[dices.Length];
                Array.Copy(dices, modified, dices.Length);

                for (int i = 0; i < modified.Length; i++)
                {
                    if (modified[i] == 6)
                    {
                        for (int j = i + 1; j < modified.Length; j++)
                        {
                            modified[j]--;
                            if (modified[j] < 1) modified[j] = 1;
                        }
                    }
                }

                int[] sixes = new int[dices.Length];
                for (int i = 0; i < sixes.Length; i++)
                {
                    sixes[i] = 6;
                }

                for (int i = 0; i < sixes.Length; i++)
                {
                    if (sixes[i] == 6)
                    {
                        for (int j = i + 1; j < sixes.Length; j++)
                        {
                            sixes[j]--;
                            if (sixes[j] < 1) sixes[j] = 1;
                        }
                    }
                }

                for (int i = 0; i < modified.Length; i++)
                {
                    if (modified[i] > sixes[i])
                        wins++;
                }
            }
            // end
            return wins;

        }
    }
}
