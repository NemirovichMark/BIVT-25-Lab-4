namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
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
            
            if (count == 0) return;
            
            double avg = sum / count;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) array[i] = avg;
            }
        }

        public int Task2(int[] array)
        {
            int sum = 0;
            
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) return sum;
                sum += array[i] * array[i];
            }
            
            return 0;
        }

        public int[] Task3(int[] array)
        {
            if (array.Length < 2) return new int[0];

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
            
            if (end - start <= 1) return new int[0];

            int count = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0) count++;
            }

            int[] result = new int[count];
            int index = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0) 
                {
                    result[index] = array[i];
                    index++;
                }
            }

            return result;
        }

        public void Task4(int[] array)
        {
            int maxIndex = 0;
            int negIndex = -1;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[maxIndex]) maxIndex = i;
                if (negIndex == -1 && array[i] < 0) negIndex = i;
            }

            if (negIndex != -1)
            {
                int temp = array[maxIndex];
                array[maxIndex] = array[negIndex];
                array[negIndex] = temp;
            }
        }

        public int[] Task5(int[] array)
        {
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

            int[] result = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max) 
                {
                    result[index] = i;
                    index++;
                }
            }

            return result;
        }

        public void Task6(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            int number = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] = max + number;
                    number++;
                }
            }
        }

        public void Task7(int[] array)
        {
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max) max = array[i];
            }

            int[] copy = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                copy[i] = array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (copy[i] == max)
                {
                    int sum = 0;
                    for (int j = 0; j < i; j++) 
                    {
                        sum += copy[j];
                    }
                    array[i] = sum;
                }
            }
        }

        public int Task8(int[] array)
        {
            int maxLen = 1;
            int curLen = 1;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[i - 1])
                {
                    curLen++;
                    if (curLen > maxLen) maxLen = curLen;
                }
                else 
                {
                    curLen = 1;
                }
            }

            return maxLen;
        }

        public void Task9(int[] array)
        {
            if (array.Length < 2) return;

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
        }

        public int[] Task10(int[] array)
        {
            int[] temp = new int[array.Length];
            int size = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool found = false;
                for (int j = 0; j < size; j++)
                {
                    if (temp[j] == array[i])
                    {
                        found = true;
                        break;
                    }
                }
                if (!found)
                {
                    temp[size] = array[i];
                    size++;
                }
            }

            int[] result = new int[size];
            for (int i = 0; i < size; i++)
            {
                result[i] = temp[i];
            }

            return result;
        }

        public double[] Task11(double a, double b, int n)
        {
            if (n <= 1 || a == b) return null;

            double[] A = new double[n];
            double step = (b - a) / (n - 1);
            
            for (int i = 0; i < n; i++)
            {
                A[i] = a + step * i;
            }

            double sumPos = 0;
            int countPos = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sumPos += A[i];
                    countPos++;
                }
            }

            if (countPos == 0) return new double[0];

            double avg = sumPos / countPos;

            int countBig = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg) countBig++;
            }

            double[] B = new double[countBig];
            int idx = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > avg) 
                {
                    B[idx] = A[i];
                    idx++;
                }
            }

            return B;
        }

        public int Task12(int[] dices)
        {
            int wins = 0;
            int curse = 0;
            int enemy = 6;

            for (int i = 0; i < dices.Length; i++)
            {
                int current = dices[i] - curse;
                if (current < 1) current = 1;
                
                if (current > enemy) wins++;

                if (dices[i] == 6) curse++;

                enemy--;
                if (enemy < 1) enemy = 1;
            }

            return wins;
        }
    }
}