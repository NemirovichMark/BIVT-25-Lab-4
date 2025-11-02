namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
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
                double average = sum / count;
                for (int i = 0; i < array.Length; i++)
                {
                    if (array[i] > 0)
                    {
                        array[i] = average;
                    }
                }
            }
            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;

            // code here
             int a = -1;
            for (int i = 0; i < array.Length; i++)
            {
                if ((array[i] < 0) && (a == -1)) a = i;
            }

            for (int i = 0; i < a; i++)
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
            if (array.Length < 3) return new int[0];

            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
                if (array[i] < array[minIndex]) minIndex = i;
            }

            int start = maxIndex;
            int end = minIndex;
            if (minIndex < maxIndex)
            {
                start = minIndex;
                end = maxIndex;
            }

            int count = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0) count++;
            }

            negatives = new int[count];
            int index = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                {
                    negatives[index] = array[i];
                    index++;
                }
            }
            // end

            return negatives;
        }
        public void Task4(int[] array)
        {

            // code here
            int maxIndex = 0;
            int negativeIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
                if (negativeIndex == -1 && array[i] < 0) negativeIndex = i;
            }

            if (negativeIndex != -1)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[negativeIndex];
                array[negativeIndex] = temp;
            }
            // end

        }
        public int[] Task5(int[] array)
        {
            int[] answer = null;

            // code here
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) count++;
            }

            answer = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[index] = i;
                    index++;
                }
            }
            // end

            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
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
            // end

        }
        public void Task7(int[] array)
        {

            // code here
            if (array.Length == 0) return;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            int[] sums = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    sums[i] = 0;
                    for (int j = 0; j < i; j++)
                    {
                        sums[i] += array[j];
                    }
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = sums[i];
                }
            }
            // end

        }
        public int Task8(int[] array)
        {
            int length = 0;

            // code here
            if (array.Length == 0) return 0;

            int current = 1;
            length = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    current++;
                    if (current > length) length = current;
                }
                else
                {
                    current = 1;
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
            // end

        }
        public int[] Task10(int[] array)
        {
            int[] cleared = null;

            // code here
            if (array.Length == 0) return new int[0];

            // Временный массив для уникальных элементов (максимальная длина = array.Length)
            int[] temp = new int[array.Length];
            int uniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < uniqueCount; j++)
                {
                    if (temp[j] == array[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    temp[uniqueCount] = array[i];
                    uniqueCount++;
                }
            }

            cleared = new int[uniqueCount];
            for (int i = 0; i < uniqueCount; i++)
            {
                cleared[i] = temp[i];
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
            int[] shuller = new int[dices.Length];
            for (int i = 0; i <= 4 & i < dices.Length; i++)
            {
                shuller[i] = 6 - i;
            }
            for (int i = 5; i < dices.Length; i++)
            {
                shuller[i] = 1;
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
                if (dices[i] > shuller[i])
                    wins++;
            }
            // end

            return wins;

        }
    }
}
