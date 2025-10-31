using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices.ObjectiveC;

namespace Lab4
{
    public class Green
    {
        public void Task1(double[] array)
        {

            // code here
            double s = 0;
            double count = 0;
            double srzn = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0)
                {
                    s += array[i];
                    count++;
                }
               
            }
            srzn = s / count;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] > 0)
                {
                    array[i] = srzn;
                }
            }

            // end

        }
        public int Task2(int[] array)
        {
            int sum = 0;
            int otr = 0;
            // code here
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0)
                {
                    otr = i;
                    break;
                }

    
               
                
            }
            for (int i = 0; i < otr; i++)
            {
                sum += array[i] * array[i];

            }
                // end

            return sum;
        }
        public int[] Task3(int[] array)
        {

            // code here
            if (array == null || array.Length < 2)
                return new int[0];

            int minIndex = 0;
            int maxIndex = 0;
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < array[minIndex])
                    minIndex = i;
                if (array[i] > array[maxIndex])
                    maxIndex = i;
            }

            int start = Math.Min(minIndex, maxIndex);
            int end = Math.Max(minIndex, maxIndex);

            if (end - start <= 1)
                return new int[0];
            int count = 0;
            for (int i = start + 1; i < end; i++)
            {
                if (array[i] < 0)
                    count++;
            }

            int[] negatives = new int[count];
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
            if (array == null || array.Length == 0)
                return;

            int otr = -1, max = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > array[max]) max = i;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) { otr = i; break; }
            }
            if (otr != -1)
                (array[max], array[otr]) = (array[otr], array[max]);
            // code end
        }

        public int[] Task5(int[] array)
        {

            if (array == null || array.Length == 0)
                return new int[0];

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                    count++;
            }

            int[] answer = new int[count];
            int index = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    answer[index++] = i;
                }
                
            }
            return answer;
        }
        public void Task6(int[] array)
        {

            // code here
            if (array == null || array.Length == 0)
                return;

            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            int counter = 1;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == max)
                {
                    array[i] += counter;
                    counter++;
                }
            }
            // end
        }
        public void Task7(int[] array)
    {
            if (array == null || array.Length == 0)
                return;
            // code here
            int max = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > max)
                    max = array[i];
            }
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                int current = array[i]; 
                if (current == max)
                {
                    array[i] = sum;
                }
                sum += current;
            }
            // code end
        }
        public int Task8(int[] array)
    {
            if (array == null || array.Length == 0)
                return 0;

            // code here
            int Length = 1;
            int c = 1;

            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] > array[i + 1])
                {
                    c++;
                    if (c > Length)
                        Length = c;
                }
                else
                    c = 1;
            }

            return Length;
            // code end
        }
        public void Task9(int[] array)
        {
            if (array == null || array.Length < 2)
                return;
            // code here
            int even = array.Length+1/2;
            for (int i = 0; i < even - 1; i++)
            {
                for (int j = 0; j < even - i - 1; j++)
                {
                    int index1 = j * 2;
                    int index2 = (j + 1) * 2;

                    if (index2 < array.Length && array[index1] > array[index2])
                    {
                        int temp = array[index1];
                        array[index1] = array[index2];
                        array[index2] = temp;
                    }
                }
            }
            // end

        }
        public int[] Task10(int[] array)
    {
            if (array == null || array.Length == 0)
                return new int[0];

            int uniqueCount = 0;

            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                    uniqueCount++;
            }

            int[] cleared = new int[uniqueCount];
            int r = 0;
            for (int i = 0; i < array.Length; i++)
            {
                bool isUnique = true;
                for (int j = 0; j < i; j++)
                {
                    if (array[i] == array[j])
                    {
                        isUnique = false;
                        break;
                    }
                }
                if (isUnique)
                {
                    cleared[r++] = array[i];
                }
            }

            return cleared;
        }
        public double[] Task11(double a, double b, int n)
    {
            if (n < 2)
            {
                return null;
            }

            double[] A = new double[n];
            double step = (b - a) / (n - 1);
            for (int i = 0; i < n; i++)
            {
                A[i] = a + i * step;
            }

            double sumPositive = 0;
            int countPositive = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0)
                {
                    sumPositive += A[i];
                    countPositive++;
                }
            }

            if (countPositive == 0)
            {
                return new double[0];
            }

            double averagePositive = sumPositive / countPositive;

            int countB = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > averagePositive)
                {
                    countB++;
                }
            }

            if (countB == 0)
            {
                if (countPositive > 1)
                {
                    return null;
                }
                else
                {
                    return new double[0];
                }
            }

            double[] B = new double[countB];
            int indexB = 0;
            for (int i = 0; i < n; i++)
            {
                if (A[i] > 0 && A[i] > averagePositive)
                {
                    B[indexB] = A[i];
                    indexB++;
                }
            }

            return B;
        }

        public int Task12(int[] dices)
        {
            int n = dices.Length;
            int[] p = new int[n];
            int r = 0;

            for (int i = 0; i < n; i++)
            {
                int currentValue = dices[i] - r;
                if (currentValue < 1)
                {
                    currentValue = 1;
                }
                p[i] = currentValue;

                if (dices[i] == 6)
                {
                    r++;
                }
            }
            int[] cheaterDices = new int[n];
            int cheaterReduction = 0;

            for (int i = 0; i < n; i++)
            {
                int cheaterValue = 6 - cheaterReduction;
                if (cheaterValue < 1)
                {
                    cheaterValue = 1;
                }
                cheaterDices[i] = cheaterValue;
                cheaterReduction++;
            }
            int wins = 0;
            for (int i = 0; i < n; i++)
            {
                if (p[i] > cheaterDices[i])
                {
                    wins++;
                }
            }

            return wins;
        }
    }
}