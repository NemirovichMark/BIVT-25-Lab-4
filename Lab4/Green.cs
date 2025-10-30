namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            int count = 0;
            foreach (double i in array)
            {
                if (i > 0)
                {
                    s += i;
                    count++;
                }
            }

            if (count > 0)
            {
                s = s / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = s;
                    }
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
            sum = 0;

            double o = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    o = 1;

            }
            if (o == 0)
            {
                return 0;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                    break;
                sum += array[i] * array[i];
            }
            // end

            return sum;
        }
        public int[] Task3(int[] array)
        {
            int[] negatives = null;

            // code here
            if (array.Length == 0)
            {
                negatives = new int[0];
            }
            else
            {
                // находим первые вхождения max и min
                int maxVal = array[0], minVal = array[0];
                int idxMax = 0, idxMin = 0;
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > maxVal) { maxVal = array[i]; idxMax = i; }
                    if (array[i] < minVal) { minVal = array[i]; idxMin = i; }
                }

                int left = idxMax < idxMin ? idxMax + 1 : idxMin + 1;
                int right = idxMax < idxMin ? idxMin - 1 : idxMax - 1;

                if (left > right)
                {
                    negatives = new int[0];
                }
                else
                {
                    int count = 0;
                    for (int i = left; i <= right; i++)
                    {
                        if (array[i] < 0) count++;
                    }
                    negatives = new int[count];
                    int k = 0;
                    for (int i = left; i <= right; i++)
                    {
                        if (array[i] < 0)
                        {
                            negatives[k++] = array[i];
                        }
                    }
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            if (array.Length == 0) return;

            int maxVal = array[0];
            int idxMax = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                {
                    maxVal = array[i];
                    idxMax = i;
                }
            }

            int idxFirstNeg = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    idxFirstNeg = i;
                    break;
                }
            }

            if (idxFirstNeg != -1)
            {
                int tmp = array[idxMax];
                array[idxMax] = array[idxFirstNeg];
                array[idxFirstNeg] = tmp;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            if (array.Length == 0)
            {
                answer = new int[0];
            }
            else
            {
                int maxVal = array[0];
                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i] > maxVal) maxVal = array[i];
                }

                int count = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == maxVal) count++;
                }

                answer = new int[count];
                int k = 0;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] == maxVal)
                    {
                        answer[k++] = i;
                    }
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array.Length == 0) return;

            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal) maxVal = array[i];
            }

            int ordinal = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == maxVal)
                {
                    array[i] = array[i] + ordinal;
                    ordinal++;
                }
            }
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            if (array.Length == 0) return;

            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxVal) maxVal = array[i];
            }

            int prefixSum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int original = array[i];
                if (original == maxVal)
                {
                    array[i] = prefixSum;
                }
                
                prefixSum += original;
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array.Length == 0) return 0;

            int best = 1;
            int cur = 1;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i - 1] > array[i])
                {
                    cur++;
                }
                else
                {
                    if (cur > best) best = cur;
                    cur = 1;
                }
            }
            if (cur > best) best = cur;
            length = best;
            // end

            return length;
        }
        public void Task9(int[] array)
        {

            // code here
            // Сортируем по возрастанию элементы на чётных индексах простой выборкой
            for (int i = 0; i < array.Length; i += 2)
            {
                int minIdx = i;
                for (int j = i + 2; j < array.Length; j += 2)
                {
                    if (array[j] < array[minIdx]) minIdx = j;
                }
                if (minIdx != i)
                {
                    int tmp = array[i];
                    array[i] = array[minIdx];
                    array[minIdx] = tmp;
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
                bool seenBefore = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        seenBefore = true;
                        break;
                    }
                }
                if (!seenBefore) count++;
            }

            cleared = new int[count];
            int k = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool seenBefore = false;
                for (int j = 0; j < i; j++)
                {
                    if (array[j] == array[i])
                    {
                        seenBefore = true;
                        break;
                    }
                }
                if (!seenBefore)
                {
                    cleared[k++] = array[i];
                }
            }
            // end

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
        {
            double[] A = null, B = null;

            // code here


            A = new double[n];
            double step = (b - a) / (n - 1);

            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }
            double ss = 0;
            int n2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] >= 0)
                {
                    ss += A[i];
                    n2++;
                }
            }
            ss = ss / n2;
            n2 = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > ss)
                {
                    n2++;
                }
            }
            B = new double[n2];
            int g = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > ss)
                {
                    B[g++] = A[i];
                }
            }
            if ((n <= 1) || (a == b))
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
            
            int penaltyMe = 0;
            
            int penaltyOpp = 0;

            for (int i = 0; i < dices.Length; i++)
            {
                int myVal = dices[i] - penaltyMe;
                if (myVal < 1) myVal = 1;

                int oppBase = 6;
                int oppVal = oppBase - penaltyOpp;
                if (oppVal < 1) oppVal = 1;

                if (myVal > oppVal) wins++;

                
                if (dices[i] == 6) penaltyMe++;
                
                penaltyOpp++;
            }
            // end

            return wins;

        }
    }
}
